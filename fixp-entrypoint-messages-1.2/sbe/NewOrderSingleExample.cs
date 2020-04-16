using Org.SbeTool.Sbe.Dll;
using System;
using System.Text;

namespace SbeFIX
{
    public class NewOrderSingleExample
    {

        public static int Encode(SimpleNewOrder sno, DirectBuffer directBuffer, int bufferOffset)
        {
            // we position the car encoder on the direct buffer, at the correct offset (ie. just after the header)
            sno.WrapForEncode(directBuffer, bufferOffset);
            sno.ClOrdID = 1234567890;
            sno.Account = 111;
            sno.SecurityID = 48;
            sno.OrderQty = 100;
            sno.MarketSegmentID = 70;
            sno.Side = Side.BUY;
            sno.OrdType = OrdType.LIMIT;
            sno.TimeInForce = TimeInForce.DAY;
            sno.InvestorID = 1;
            sno.Price.Mantissa = 11;

            byte[] trder = Encoding.GetEncoding(SimpleNewOrder.EnteringTraderCharacterEncoding).GetBytes("12345");
            sno.SetEnteringTrader(trder, 0);
            return sno.Size;
        }

        public static int Encode(Negotiate sno, DirectBuffer directBuffer, int bufferOffset)
        {
            // we position the car encoder on the direct buffer, at the correct offset (ie. just after the header)
            sno.WrapForEncode(directBuffer, bufferOffset);
            //car.SetManufacturer(Manufacturer, srcOffset, Manufacturer.Length);
            // Manufacturer = Encoding.GetEncoding(Car.ManufacturerCharacterEncoding).GetBytes("Honda");

            byte[] Cred = Encoding.GetEncoding(Negotiate.CredentialsCharacterEncoding).GetBytes("teste");
            sno.SetCredentials(Cred, 0, Cred.Length);
            return sno.Size;
        }

        public static int Encode(NewOrderCross sno, DirectBuffer directBuffer, int bufferOffset)
        {
            // we position the car encoder on the direct buffer, at the correct offset (ie. just after the header)
            sno.WrapForEncode(directBuffer, bufferOffset);
            sno.SecurityID = 48;
            sno.OrderQty = 100;
            sno.MarketSegmentID = 70;
            sno.Price.Mantissa = 11;
            NewOrderCross.NoSidesGroup g = sno.NoSidesCount(2);
            g.Next();
            g.Account = 1111;
            g.ClOrdID = 1234;
            g.Side = Side.BUY;
            g.Next();
            g.Account = 2222;
            g.ClOrdID = 5678;
            g.Side = Side.SELL;

            return sno.Size;
        }


        public static void Decode(SimpleNewOrder sno,
            DirectBuffer directBuffer,
            int bufferOffset,
            int actingBlockLength,
            int actingVersion)
        {
            var buffer = new byte[128];
            var sb = new StringBuilder();

            // position the car flyweight just after the header on the DirectBuffer
            sno.WrapForDecode(directBuffer, bufferOffset, actingBlockLength, actingVersion);

            // decode the car properties on by one, directly from the buffer
            sb.Append("\nClOrdID=").Append(sno.ClOrdID);
            sb.Append("\nAccount=").Append(sno.Account);
            sb.Append("\nSecurityID=").Append(sno.SecurityID);
            sb.Append("\nOrderQty=").Append(sno.OrderQty);
            sb.Append("\nMarketSegmentID=").Append(sno.MarketSegmentID);
            sb.Append("\nSide=").Append(sno.Side);
            sb.Append("\nOrdType=").Append(sno.OrdType);
            sb.Append("\nTimeInForce=").Append(sno.TimeInForce);
            sb.Append("\nInvestorID=").Append(sno.InvestorID);
            sb.Append("\nEnteringTrader=").Append(sno.GetEnteringTrader(0));
            sb.Append("\nMantissa=").Append(sno.Price.Mantissa);
            sb.Append("\nSize=").Append(sno.Size);

            Console.WriteLine(sb.ToString());
        }

        public static void Decode(NewOrderCross sno,
           DirectBuffer directBuffer,
           int bufferOffset,
           int actingBlockLength,
           int actingVersion)
        {
            var buffer = new byte[128];
            var sb = new StringBuilder();

            // position the car flyweight just after the header on the DirectBuffer
            sno.WrapForDecode(directBuffer, bufferOffset, actingBlockLength, actingVersion);

            NewOrderCross.NoSidesGroup g = sno.NoSides;
            while (g.HasNext)
            {
                g.Next();
                Console.WriteLine(g.Account);
                Console.WriteLine(g.ClOrdID);
                Console.WriteLine(g.Side);
            }
            Console.WriteLine(sb.ToString());
        }

    }
}
