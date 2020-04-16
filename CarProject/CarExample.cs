using Org.SbeTool.Sbe.Dll;
using Sbe;
using System;
using System.Text;

namespace TCPSender
{
    public static class CarExample
    {
        private static readonly byte[] VehicleCode;
        private static readonly byte[] ManufacturerCode;
        private static readonly byte[] Manufacturer;
        private static readonly byte[] Model;

        static CarExample()
        {
            try
            {
                // convert some sample strings to the correct encoding for this sample
                VehicleCode = Encoding.GetEncoding(Car.VehicleCodeCharacterEncoding).GetBytes("abcdef");
                ManufacturerCode = Encoding.GetEncoding(Engine.ManufacturerCodeCharacterEncoding).GetBytes("123");
                Manufacturer = Encoding.GetEncoding(Car.ManufacturerCharacterEncoding).GetBytes("Honda");
                Model = Encoding.GetEncoding(Car.ModelCharacterEncoding).GetBytes("Civic VTi");
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while reading encodings", ex);
            }
        }



        public static int Encode(Car car, DirectBuffer directBuffer, int bufferOffset)
        {
            const int srcOffset = 0;

            // we position the car encoder on the direct buffer, at the correct offset (ie. just after the header)
            car.WrapForEncode(directBuffer, bufferOffset);
            car.SerialNumber = 1234; // we set the different fields, just as normal properties and they get written straight to the underlying byte buffer
            car.ModelYear = 2013;
            car.Available = BooleanType.T; // enums are directly supported
            car.Code = Sbe.Model.A;
            car.SetVehicleCode(VehicleCode, srcOffset); // we set a constant string

            for (int i = 0, size = Car.SomeNumbersLength; i < size; i++)
            {
                car.SetSomeNumbers(i, (int)i); // this property is defined as a constant length array of integers
            }

            car.Extras = OptionalExtras.CruiseControl | OptionalExtras.SportsPack; // bit set (flag enums in C#) are supported

            car.Engine.Capacity = 2000;
            car.Engine.NumCylinders = 4;
            car.Engine.SetManufacturerCode(ManufacturerCode, srcOffset);

            // we have written all the constant length fields, now we can write the repeatable groups

            var fuelFigures = car.FuelFiguresCount(3); // we specify that we are going to write 3 FueldFigures (the API is not very .NET friendly yet, we will address that)
            fuelFigures.Next(); // move to the first element
            fuelFigures.Speed = 30;
            fuelFigures.Mpg = 35.9f;

            fuelFigures.Next(); // second
            fuelFigures.Speed = 55;
            fuelFigures.Mpg = 49.0f;

            fuelFigures.Next();
            fuelFigures.Speed = 75;
            fuelFigures.Mpg = 40.0f;

            Car.PerformanceFiguresGroup perfFigures = car.PerformanceFiguresCount(2); // demonstrates how to create a nested group
            perfFigures.Next();
            perfFigures.OctaneRating = 95;

            Car.PerformanceFiguresGroup.AccelerationGroup acceleration = perfFigures.AccelerationCount(3).Next(); // this group is going to be nested in the first element of the previous group
            acceleration.Mph = 30;
            acceleration.Seconds = 4.0f;

            acceleration.Next();
            acceleration.Mph = 60;
            acceleration.Seconds = 7.5f;

            acceleration.Next();
            acceleration.Mph = 100;
            acceleration.Seconds = 12.2f;

            perfFigures.Next();
            perfFigures.OctaneRating = 99;
            acceleration = perfFigures.AccelerationCount(3).Next();

            acceleration.Mph = 30;
            acceleration.Seconds = 3.8f;

            acceleration.Next();
            acceleration.Mph = 60;
            acceleration.Seconds = 7.1f;

            acceleration.Next();
            acceleration.Mph = 100;
            acceleration.Seconds = 11.8f;

            // once we have written all the repeatable groups we can write the variable length properties (you would use that for strings, byte[], etc)

            car.SetManufacturer(Manufacturer, srcOffset, Manufacturer.Length);
            car.SetModel(Model, srcOffset, Model.Length);

            return car.Size;
        }

        public static void Decode(Car car,
            DirectBuffer directBuffer,
            int bufferOffset,
            int actingBlockLength,
            int actingVersion)
        {
            var buffer = new byte[128];
            var sb = new StringBuilder();

            // position the car flyweight just after the header on the DirectBuffer
            car.WrapForDecode(directBuffer, bufferOffset, actingBlockLength, actingVersion);

            // decode the car properties on by one, directly from the buffer
            sb.Append("\ncar.templateId=").Append(Car.TemplateId);
            sb.Append("\ncar.schemaVersion=").Append(Car.SchemaVersion);
            sb.Append("\ncar.serialNumber=").Append(car.SerialNumber);
            sb.Append("\ncar.modelYear=").Append(car.ModelYear);
            sb.Append("\ncar.available=").Append(car.Available);
            sb.Append("\ncar.code=").Append(car.Code);
            sb.Append("\ncar.code=").Append(car.GetVehicleCode(0));

            sb.Append("\ncar.someNumbers=");
            for (int i = 0, size = Car.SomeNumbersLength; i < size; i++)
            {
                sb.Append(car.GetSomeNumbers(i)).Append(", ");
            }

            sb.Append("\ncar.vehicleCode=");
            var vehicleCode = new byte[Car.VehicleCodeLength];
            car.GetVehicleCode(vehicleCode, 0);
            sb.Append(Encoding.GetEncoding(Car.VehicleCodeCharacterEncoding).GetString(vehicleCode, 0, Car.VehicleCodeLength));

            OptionalExtras extras = car.Extras;
            sb.Append("\ncar.extras.cruiseControl=").Append((extras & OptionalExtras.CruiseControl) == OptionalExtras.CruiseControl); // this is how you can find out if a specific flag is set in a flag enum
            sb.Append("\ncar.extras.sportsPack=").Append((extras & OptionalExtras.SportsPack) == OptionalExtras.SportsPack);
            sb.Append("\ncar.extras.sunRoof=").Append((extras & OptionalExtras.SunRoof) == OptionalExtras.SunRoof);

            Engine engine = car.Engine;
            sb.Append("\ncar.engine.capacity=").Append(engine.Capacity);
            sb.Append("\ncar.engine.numCylinders=").Append(engine.NumCylinders);
            sb.Append("\ncar.engine.maxRpm=").Append(engine.MaxRpm);
            sb.Append("\ncar.engine.manufacturerCode=");
            for (int i = 0, size = Engine.ManufacturerCodeLength; i < size; i++)
            {
                sb.Append((char)engine.GetManufacturerCode(i));
            }

            int length = engine.GetFuel(buffer, 0, buffer.Length);

            sb.Append("\ncar.engine.fuel=").Append(Encoding.ASCII.GetString(buffer, 0, length)); // string requires a bit of work to decode

            // The first way to access a repeating group is by using Next()
            var fuelFiguresGroup = car.FuelFigures;
            while (fuelFiguresGroup.HasNext)
            {
                var fuelFigures = fuelFiguresGroup.Next();
                sb.Append("\ncar.fuelFigures.speed=").Append(fuelFigures.Speed);
                sb.Append("\ncar.fuelFigures.mpg=").Append(fuelFigures.Mpg);
            }

            // The second way to access a repeating group is to use an iterator
            foreach (Car.PerformanceFiguresGroup performanceFigures in car.PerformanceFigures)
            {
                sb.Append("\ncar.performanceFigures.octaneRating=").Append(performanceFigures.OctaneRating);

                // The third way to access a repeating group is loop over the count of elements
                var accelerationGroup = performanceFigures.Acceleration;
                for (int i = 0; i < accelerationGroup.Count; i++)
                {
                    var acceleration = accelerationGroup.Next();
                    sb.Append("\ncar.performanceFigures.acceleration.mph=").Append(acceleration.Mph);
                    sb.Append("\ncar.performanceFigures.acceleration.seconds=").Append(acceleration.Seconds);
                }
            }

            // variable length fields
            sb.Append("\ncar.manufacturer.semanticType=").Append(Car.ManufacturerMetaAttribute(MetaAttribute.SemanticType));
            length = car.GetManufacturer(buffer, 0, buffer.Length);
            sb.Append("\ncar.manufacturer=").Append(Encoding.GetEncoding(Car.ManufacturerCharacterEncoding).GetString(buffer, 0, length));

            length = car.GetModel(buffer, 0, buffer.Length);
            sb.Append("\ncar.model=").Append(Encoding.GetEncoding(Car.ModelCharacterEncoding).GetString(buffer, 0, length));
            sb.Append("\ncar.size=").Append(car.Size);

            Console.WriteLine(sb.ToString());
        }
    }
}
