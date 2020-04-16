/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using Org.SbeTool.Sbe.Dll;
using System;

namespace Sbe
{
    public sealed partial class Car
    {
        public const ushort BlockLength = (ushort)41;
        public const ushort TemplateId = (ushort)1;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)1;
        public const string SemanticType = "";

        private readonly Car _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public Car()
        {
            _parentMessage = this;
        }

        public void WrapForEncode(DirectBuffer buffer, int offset)
        {
            _buffer = buffer;
            _offset = offset;
            _actingBlockLength = BlockLength;
            _actingVersion = SchemaVersion;
            Limit = offset + _actingBlockLength;
        }

        public void WrapForDecode(DirectBuffer buffer, int offset, int actingBlockLength, int actingVersion)
        {
            _buffer = buffer;
            _offset = offset;
            _actingBlockLength = actingBlockLength;
            _actingVersion = actingVersion;
            Limit = offset + _actingBlockLength;
        }

        public int Size
        {
            get
            {
                return _limit - _offset;
            }
        }

        public int Limit
        {
            get
            {
                return _limit;
            }
            set
            {
                _buffer.CheckLimit(value);
                _limit = value;
            }
        }


        public const int SerialNumberId = 1;
        public const int SerialNumberSinceVersion = 0;
        public const int SerialNumberDeprecated = 0;
        public bool SerialNumberInActingVersion()
        {
            return _actingVersion >= SerialNumberSinceVersion;
        }

        public static string SerialNumberMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public const uint SerialNumberNullValue = 4294967295U;
        public const uint SerialNumberMinValue = 0U;
        public const uint SerialNumberMaxValue = 4294967294U;

        public uint SerialNumber
        {
            get
            {
                return _buffer.Uint32GetLittleEndian(_offset + 0);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 0, value);
            }
        }


        public const int ModelYearId = 2;
        public const int ModelYearSinceVersion = 0;
        public const int ModelYearDeprecated = 0;
        public bool ModelYearInActingVersion()
        {
            return _actingVersion >= ModelYearSinceVersion;
        }

        public static string ModelYearMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public const ushort ModelYearNullValue = (ushort)65535;
        public const ushort ModelYearMinValue = (ushort)0;
        public const ushort ModelYearMaxValue = (ushort)65534;

        public ushort ModelYear
        {
            get
            {
                return _buffer.Uint16GetLittleEndian(_offset + 4);
            }
            set
            {
                _buffer.Uint16PutLittleEndian(_offset + 4, value);
            }
        }


        public const int AvailableId = 3;
        public const int AvailableSinceVersion = 0;
        public const int AvailableDeprecated = 0;
        public bool AvailableInActingVersion()
        {
            return _actingVersion >= AvailableSinceVersion;
        }

        public static string AvailableMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public BooleanType Available
        {
            get
            {
                return (BooleanType)_buffer.Uint8Get(_offset + 6);
            }
            set
            {
                _buffer.Uint8Put(_offset + 6, (byte)value);
            }
        }


        public const int CodeId = 4;
        public const int CodeSinceVersion = 0;
        public const int CodeDeprecated = 0;
        public bool CodeInActingVersion()
        {
            return _actingVersion >= CodeSinceVersion;
        }

        public static string CodeMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public Model Code
        {
            get
            {
                return (Model)_buffer.CharGet(_offset + 7);
            }
            set
            {
                _buffer.CharPut(_offset + 7, (byte)value);
            }
        }


        public const int SomeNumbersId = 5;
        public const int SomeNumbersSinceVersion = 0;
        public const int SomeNumbersDeprecated = 0;
        public bool SomeNumbersInActingVersion()
        {
            return _actingVersion >= SomeNumbersSinceVersion;
        }

        public static string SomeNumbersMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public const int SomeNumbersNullValue = -2147483648;
        public const int SomeNumbersMinValue = -2147483647;
        public const int SomeNumbersMaxValue = 2147483647;

        public const int SomeNumbersLength = 5;

        public int GetSomeNumbers(int index)
        {
            if ((uint)index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.Int32GetLittleEndian(_offset + 8 + (index * 4));
        }

        public void SetSomeNumbers(int index, int value)
        {
            if ((uint)index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.Int32PutLittleEndian(_offset + 8 + (index * 4), value);
        }

        public const int VehicleCodeId = 6;
        public const int VehicleCodeSinceVersion = 0;
        public const int VehicleCodeDeprecated = 0;
        public bool VehicleCodeInActingVersion()
        {
            return _actingVersion >= VehicleCodeSinceVersion;
        }

        public static string VehicleCodeMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public const byte VehicleCodeNullValue = (byte)0;
        public const byte VehicleCodeMinValue = (byte)32;
        public const byte VehicleCodeMaxValue = (byte)126;

        public const int VehicleCodeLength = 6;

        public byte GetVehicleCode(int index)
        {
            if ((uint)index >= 6)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 28 + (index * 1));
        }

        public void SetVehicleCode(int index, byte value)
        {
            if ((uint)index >= 6)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 28 + (index * 1), value);
        }

        public const string VehicleCodeCharacterEncoding = "US-ASCII";


        public int GetVehicleCode(byte[] dst, int dstOffset)
        {
            const int length = 6;
            return GetVehicleCode(new Span<byte>(dst, dstOffset, length));
        }

        public int GetVehicleCode(Span<byte> dst)
        {
            const int length = 6;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 28, dst);
            return length;
        }

        public void SetVehicleCode(byte[] src, int srcOffset)
        {
            SetVehicleCode(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetVehicleCode(ReadOnlySpan<byte> src)
        {
            const int length = 6;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 28, src);
        }

        public const int ExtrasId = 7;
        public const int ExtrasSinceVersion = 0;
        public const int ExtrasDeprecated = 0;
        public bool ExtrasInActingVersion()
        {
            return _actingVersion >= ExtrasSinceVersion;
        }

        public static string ExtrasMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public OptionalExtras Extras
        {
            get
            {
                return (OptionalExtras)_buffer.Uint8Get(_offset + 34);
            }
            set
            {
                _buffer.Uint8Put(_offset + 34, (byte)value);
            }
        }

        public const int EngineId = 8;
        public const int EngineSinceVersion = 0;
        public const int EngineDeprecated = 0;
        public bool EngineInActingVersion()
        {
            return _actingVersion >= EngineSinceVersion;
        }

        public static string EngineMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        private readonly Engine _engine = new Engine();

        public Engine Engine
        {
            get
            {
                _engine.Wrap(_buffer, _offset + 35, _actingVersion);
                return _engine;
            }
        }

        private readonly FuelFiguresGroup _fuelFigures = new FuelFiguresGroup();

        public const long FuelFiguresId = 9;
        public const int FuelFiguresSinceVersion = 0;
        public const int FuelFiguresDeprecated = 0;
        public bool FuelFiguresInActingVersion()
        {
            return _actingVersion >= FuelFiguresSinceVersion;
        }

        public FuelFiguresGroup FuelFigures
        {
            get
            {
                _fuelFigures.WrapForDecode(_parentMessage, _buffer, _actingVersion);
                return _fuelFigures;
            }
        }

        public FuelFiguresGroup FuelFiguresCount(int count)
        {
            _fuelFigures.WrapForEncode(_parentMessage, _buffer, count);
            return _fuelFigures;
        }

        public sealed partial class FuelFiguresGroup
        {
            private readonly GroupSizeEncoding _dimensions = new GroupSizeEncoding();
            private Car _parentMessage;
            private DirectBuffer _buffer;
            private int _blockLength;
            private int _actingVersion;
            private int _count;
            private int _index;
            private int _offset;

            public void WrapForDecode(Car parentMessage, DirectBuffer buffer, int actingVersion)
            {
                _parentMessage = parentMessage;
                _buffer = buffer;
                _dimensions.Wrap(buffer, parentMessage.Limit, actingVersion);
                _blockLength = _dimensions.BlockLength;
                _count = (int)_dimensions.NumInGroup;
                _actingVersion = actingVersion;
                _index = 0;
                _parentMessage.Limit = parentMessage.Limit + SbeHeaderSize;
            }

            public void WrapForEncode(Car parentMessage, DirectBuffer buffer, int count)
            {
                if ((uint)count > 65534)
                {
                    ThrowHelper.ThrowCountOutOfRangeException(count);
                }

                _parentMessage = parentMessage;
                _buffer = buffer;
                _dimensions.Wrap(buffer, parentMessage.Limit, _actingVersion);
                _dimensions.BlockLength = SbeBlockLength;
                _dimensions.NumInGroup = (ushort)count;
                _index = 0;
                _count = count;
                _blockLength = SbeBlockLength;
                _actingVersion = SchemaVersion;
                parentMessage.Limit = parentMessage.Limit + SbeHeaderSize;
            }

            public const int SbeBlockLength = 6;
            public const int SbeHeaderSize = 4;
            public int ActingBlockLength { get { return _blockLength; } }

            public int Count { get { return _count; } }

            public bool HasNext { get { return _index < _count; } }

            public int ResetCountToIndex()
            {
                _count = _index;
                _dimensions.NumInGroup = (ushort)_count;

                return _count;
            }

            public FuelFiguresGroup Next()
            {
                if (_index >= _count)
                {
                    ThrowHelper.ThrowInvalidOperationException();
                }

                _offset = _parentMessage.Limit;
                _parentMessage.Limit = _offset + _blockLength;
                ++_index;

                return this;
            }

            public System.Collections.IEnumerator GetEnumerator()
            {
                while (this.HasNext)
                {
                    yield return this.Next();
                }
            }

            public const int SpeedId = 10;
            public const int SpeedSinceVersion = 0;
            public const int SpeedDeprecated = 0;
            public bool SpeedInActingVersion()
            {
                return _actingVersion >= SpeedSinceVersion;
            }

            public static string SpeedMetaAttribute(MetaAttribute metaAttribute)
            {
                switch (metaAttribute)
                {
                    case MetaAttribute.Epoch: return "";
                    case MetaAttribute.TimeUnit: return "";
                    case MetaAttribute.SemanticType: return "";
                    case MetaAttribute.Presence: return "required";
                }

                return "";
            }

            public const ushort SpeedNullValue = (ushort)65535;
            public const ushort SpeedMinValue = (ushort)0;
            public const ushort SpeedMaxValue = (ushort)65534;

            public ushort Speed
            {
                get
                {
                    return _buffer.Uint16GetLittleEndian(_offset + 0);
                }
                set
                {
                    _buffer.Uint16PutLittleEndian(_offset + 0, value);
                }
            }


            public const int MpgId = 11;
            public const int MpgSinceVersion = 0;
            public const int MpgDeprecated = 0;
            public bool MpgInActingVersion()
            {
                return _actingVersion >= MpgSinceVersion;
            }

            public static string MpgMetaAttribute(MetaAttribute metaAttribute)
            {
                switch (metaAttribute)
                {
                    case MetaAttribute.Epoch: return "";
                    case MetaAttribute.TimeUnit: return "";
                    case MetaAttribute.SemanticType: return "";
                    case MetaAttribute.Presence: return "required";
                }

                return "";
            }

            public const float MpgNullValue = float.NaN;
            public const float MpgMinValue = 1.401298464324817E-45f;
            public const float MpgMaxValue = 3.4028234663852886E38f;

            public float Mpg
            {
                get
                {
                    return _buffer.FloatGetLittleEndian(_offset + 2);
                }
                set
                {
                    _buffer.FloatPutLittleEndian(_offset + 2, value);
                }
            }

        }

        private readonly PerformanceFiguresGroup _performanceFigures = new PerformanceFiguresGroup();

        public const long PerformanceFiguresId = 12;
        public const int PerformanceFiguresSinceVersion = 0;
        public const int PerformanceFiguresDeprecated = 0;
        public bool PerformanceFiguresInActingVersion()
        {
            return _actingVersion >= PerformanceFiguresSinceVersion;
        }

        public PerformanceFiguresGroup PerformanceFigures
        {
            get
            {
                _performanceFigures.WrapForDecode(_parentMessage, _buffer, _actingVersion);
                return _performanceFigures;
            }
        }

        public PerformanceFiguresGroup PerformanceFiguresCount(int count)
        {
            _performanceFigures.WrapForEncode(_parentMessage, _buffer, count);
            return _performanceFigures;
        }

        public sealed partial class PerformanceFiguresGroup
        {
            private readonly GroupSizeEncoding _dimensions = new GroupSizeEncoding();
            private Car _parentMessage;
            private DirectBuffer _buffer;
            private int _blockLength;
            private int _actingVersion;
            private int _count;
            private int _index;
            private int _offset;

            public void WrapForDecode(Car parentMessage, DirectBuffer buffer, int actingVersion)
            {
                _parentMessage = parentMessage;
                _buffer = buffer;
                _dimensions.Wrap(buffer, parentMessage.Limit, actingVersion);
                _blockLength = _dimensions.BlockLength;
                _count = (int)_dimensions.NumInGroup;
                _actingVersion = actingVersion;
                _index = 0;
                _parentMessage.Limit = parentMessage.Limit + SbeHeaderSize;
            }

            public void WrapForEncode(Car parentMessage, DirectBuffer buffer, int count)
            {
                if ((uint)count > 65534)
                {
                    ThrowHelper.ThrowCountOutOfRangeException(count);
                }

                _parentMessage = parentMessage;
                _buffer = buffer;
                _dimensions.Wrap(buffer, parentMessage.Limit, _actingVersion);
                _dimensions.BlockLength = SbeBlockLength;
                _dimensions.NumInGroup = (ushort)count;
                _index = 0;
                _count = count;
                _blockLength = SbeBlockLength;
                _actingVersion = SchemaVersion;
                parentMessage.Limit = parentMessage.Limit + SbeHeaderSize;
            }

            public const int SbeBlockLength = 1;
            public const int SbeHeaderSize = 4;
            public int ActingBlockLength { get { return _blockLength; } }

            public int Count { get { return _count; } }

            public bool HasNext { get { return _index < _count; } }

            public int ResetCountToIndex()
            {
                _count = _index;
                _dimensions.NumInGroup = (ushort)_count;

                return _count;
            }

            public PerformanceFiguresGroup Next()
            {
                if (_index >= _count)
                {
                    ThrowHelper.ThrowInvalidOperationException();
                }

                _offset = _parentMessage.Limit;
                _parentMessage.Limit = _offset + _blockLength;
                ++_index;

                return this;
            }

            public System.Collections.IEnumerator GetEnumerator()
            {
                while (this.HasNext)
                {
                    yield return this.Next();
                }
            }

            public const int OctaneRatingId = 13;
            public const int OctaneRatingSinceVersion = 0;
            public const int OctaneRatingDeprecated = 0;
            public bool OctaneRatingInActingVersion()
            {
                return _actingVersion >= OctaneRatingSinceVersion;
            }

            public static string OctaneRatingMetaAttribute(MetaAttribute metaAttribute)
            {
                switch (metaAttribute)
                {
                    case MetaAttribute.Epoch: return "";
                    case MetaAttribute.TimeUnit: return "";
                    case MetaAttribute.SemanticType: return "";
                    case MetaAttribute.Presence: return "required";
                }

                return "";
            }

            public const byte OctaneRatingNullValue = (byte)255;
            public const byte OctaneRatingMinValue = (byte)0;
            public const byte OctaneRatingMaxValue = (byte)254;

            public byte OctaneRating
            {
                get
                {
                    return _buffer.Uint8Get(_offset + 0);
                }
                set
                {
                    _buffer.Uint8Put(_offset + 0, value);
                }
            }


            private readonly AccelerationGroup _acceleration = new AccelerationGroup();

            public const long AccelerationId = 14;
            public const int AccelerationSinceVersion = 0;
            public const int AccelerationDeprecated = 0;
            public bool AccelerationInActingVersion()
            {
                return _actingVersion >= AccelerationSinceVersion;
            }

            public AccelerationGroup Acceleration
            {
                get
                {
                    _acceleration.WrapForDecode(_parentMessage, _buffer, _actingVersion);
                    return _acceleration;
                }
            }

            public AccelerationGroup AccelerationCount(int count)
            {
                _acceleration.WrapForEncode(_parentMessage, _buffer, count);
                return _acceleration;
            }

            public sealed partial class AccelerationGroup
            {
                private readonly GroupSizeEncoding _dimensions = new GroupSizeEncoding();
                private Car _parentMessage;
                private DirectBuffer _buffer;
                private int _blockLength;
                private int _actingVersion;
                private int _count;
                private int _index;
                private int _offset;

                public void WrapForDecode(Car parentMessage, DirectBuffer buffer, int actingVersion)
                {
                    _parentMessage = parentMessage;
                    _buffer = buffer;
                    _dimensions.Wrap(buffer, parentMessage.Limit, actingVersion);
                    _blockLength = _dimensions.BlockLength;
                    _count = (int)_dimensions.NumInGroup;
                    _actingVersion = actingVersion;
                    _index = 0;
                    _parentMessage.Limit = parentMessage.Limit + SbeHeaderSize;
                }

                public void WrapForEncode(Car parentMessage, DirectBuffer buffer, int count)
                {
                    if ((uint)count > 65534)
                    {
                        ThrowHelper.ThrowCountOutOfRangeException(count);
                    }

                    _parentMessage = parentMessage;
                    _buffer = buffer;
                    _dimensions.Wrap(buffer, parentMessage.Limit, _actingVersion);
                    _dimensions.BlockLength = SbeBlockLength;
                    _dimensions.NumInGroup = (ushort)count;
                    _index = 0;
                    _count = count;
                    _blockLength = SbeBlockLength;
                    _actingVersion = SchemaVersion;
                    parentMessage.Limit = parentMessage.Limit + SbeHeaderSize;
                }

                public const int SbeBlockLength = 6;
                public const int SbeHeaderSize = 4;
                public int ActingBlockLength { get { return _blockLength; } }

                public int Count { get { return _count; } }

                public bool HasNext { get { return _index < _count; } }

                public int ResetCountToIndex()
                {
                    _count = _index;
                    _dimensions.NumInGroup = (ushort)_count;

                    return _count;
                }

                public AccelerationGroup Next()
                {
                    if (_index >= _count)
                    {
                        ThrowHelper.ThrowInvalidOperationException();
                    }

                    _offset = _parentMessage.Limit;
                    _parentMessage.Limit = _offset + _blockLength;
                    ++_index;

                    return this;
                }

                public System.Collections.IEnumerator GetEnumerator()
                {
                    while (this.HasNext)
                    {
                        yield return this.Next();
                    }
                }

                public const int MphId = 15;
                public const int MphSinceVersion = 0;
                public const int MphDeprecated = 0;
                public bool MphInActingVersion()
                {
                    return _actingVersion >= MphSinceVersion;
                }

                public static string MphMetaAttribute(MetaAttribute metaAttribute)
                {
                    switch (metaAttribute)
                    {
                        case MetaAttribute.Epoch: return "";
                        case MetaAttribute.TimeUnit: return "";
                        case MetaAttribute.SemanticType: return "";
                        case MetaAttribute.Presence: return "required";
                    }

                    return "";
                }

                public const ushort MphNullValue = (ushort)65535;
                public const ushort MphMinValue = (ushort)0;
                public const ushort MphMaxValue = (ushort)65534;

                public ushort Mph
                {
                    get
                    {
                        return _buffer.Uint16GetLittleEndian(_offset + 0);
                    }
                    set
                    {
                        _buffer.Uint16PutLittleEndian(_offset + 0, value);
                    }
                }


                public const int SecondsId = 16;
                public const int SecondsSinceVersion = 0;
                public const int SecondsDeprecated = 0;
                public bool SecondsInActingVersion()
                {
                    return _actingVersion >= SecondsSinceVersion;
                }

                public static string SecondsMetaAttribute(MetaAttribute metaAttribute)
                {
                    switch (metaAttribute)
                    {
                        case MetaAttribute.Epoch: return "";
                        case MetaAttribute.TimeUnit: return "";
                        case MetaAttribute.SemanticType: return "";
                        case MetaAttribute.Presence: return "required";
                    }

                    return "";
                }

                public const float SecondsNullValue = float.NaN;
                public const float SecondsMinValue = 1.401298464324817E-45f;
                public const float SecondsMaxValue = 3.4028234663852886E38f;

                public float Seconds
                {
                    get
                    {
                        return _buffer.FloatGetLittleEndian(_offset + 2);
                    }
                    set
                    {
                        _buffer.FloatPutLittleEndian(_offset + 2, value);
                    }
                }

            }
        }

        public const int ManufacturerId = 17;
        public const int ManufacturerSinceVersion = 0;
        public const int ManufacturerDeprecated = 0;
        public bool ManufacturerInActingVersion()
        {
            return _actingVersion >= ManufacturerSinceVersion;
        }

        public const string ManufacturerCharacterEncoding = "ISO-8859-1";


        public static string ManufacturerMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public const int ManufacturerHeaderSize = 4;

        public int ManufacturerLength()
        {
            _buffer.CheckLimit(_parentMessage.Limit + 4);
            return (int)_buffer.Uint32GetLittleEndian(_parentMessage.Limit);
        }

        public int GetManufacturer(byte[] dst, int dstOffset, int length) =>
            GetManufacturer(new Span<byte>(dst, dstOffset, length));

        public int GetManufacturer(Span<byte> dst)
        {
            const int sizeOfLengthField = 4;
            int limit = _parentMessage.Limit;
            _buffer.CheckLimit(limit + sizeOfLengthField);
            int dataLength = (int)_buffer.Uint32GetLittleEndian(limit);
            int bytesCopied = Math.Min(dst.Length, dataLength);
            _parentMessage.Limit = limit + sizeOfLengthField + dataLength;
            _buffer.GetBytes(limit + sizeOfLengthField, dst.Slice(0, bytesCopied));

            return bytesCopied;
        }

        // Allocates and returns a new byte array
        public byte[] GetManufacturerBytes()
        {
            const int sizeOfLengthField = 4;
            int limit = _parentMessage.Limit;
            _buffer.CheckLimit(limit + sizeOfLengthField);
            int dataLength = (int)_buffer.Uint32GetLittleEndian(limit);
            byte[] data = new byte[dataLength];
            _parentMessage.Limit = limit + sizeOfLengthField + dataLength;
            _buffer.GetBytes(limit + sizeOfLengthField, data);

            return data;
        }

        public int SetManufacturer(byte[] src, int srcOffset, int length) =>
            SetManufacturer(new ReadOnlySpan<byte>(src, srcOffset, length));

        public int SetManufacturer(ReadOnlySpan<byte> src)
        {
            const int sizeOfLengthField = 4;
            int limit = _parentMessage.Limit;
            _parentMessage.Limit = limit + sizeOfLengthField + src.Length;
            _buffer.Uint32PutLittleEndian(limit, (uint)src.Length);
            _buffer.SetBytes(limit + sizeOfLengthField, src);

            return src.Length;
        }

        public const int ModelId = 18;
        public const int ModelSinceVersion = 0;
        public const int ModelDeprecated = 0;
        public bool ModelInActingVersion()
        {
            return _actingVersion >= ModelSinceVersion;
        }

        public const string ModelCharacterEncoding = "ISO-8859-1";


        public static string ModelMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public const int ModelHeaderSize = 4;

        public int ModelLength()
        {
            _buffer.CheckLimit(_parentMessage.Limit + 4);
            return (int)_buffer.Uint32GetLittleEndian(_parentMessage.Limit);
        }

        public int GetModel(byte[] dst, int dstOffset, int length) =>
            GetModel(new Span<byte>(dst, dstOffset, length));

        public int GetModel(Span<byte> dst)
        {
            const int sizeOfLengthField = 4;
            int limit = _parentMessage.Limit;
            _buffer.CheckLimit(limit + sizeOfLengthField);
            int dataLength = (int)_buffer.Uint32GetLittleEndian(limit);
            int bytesCopied = Math.Min(dst.Length, dataLength);
            _parentMessage.Limit = limit + sizeOfLengthField + dataLength;
            _buffer.GetBytes(limit + sizeOfLengthField, dst.Slice(0, bytesCopied));

            return bytesCopied;
        }

        // Allocates and returns a new byte array
        public byte[] GetModelBytes()
        {
            const int sizeOfLengthField = 4;
            int limit = _parentMessage.Limit;
            _buffer.CheckLimit(limit + sizeOfLengthField);
            int dataLength = (int)_buffer.Uint32GetLittleEndian(limit);
            byte[] data = new byte[dataLength];
            _parentMessage.Limit = limit + sizeOfLengthField + dataLength;
            _buffer.GetBytes(limit + sizeOfLengthField, data);

            return data;
        }

        public int SetModel(byte[] src, int srcOffset, int length) =>
            SetModel(new ReadOnlySpan<byte>(src, srcOffset, length));

        public int SetModel(ReadOnlySpan<byte> src)
        {
            const int sizeOfLengthField = 4;
            int limit = _parentMessage.Limit;
            _parentMessage.Limit = limit + sizeOfLengthField + src.Length;
            _buffer.Uint32PutLittleEndian(limit, (uint)src.Length);
            _buffer.SetBytes(limit + sizeOfLengthField, src);

            return src.Length;
        }
    }
}
