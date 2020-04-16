/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public sealed partial class NewOrderCross
    {
        public const ushort BlockLength = (ushort)34;
        public const ushort TemplateId = (ushort)106;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly NewOrderCross _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public NewOrderCross()
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


        public const int MessageTypeId = 35;
        public const int MessageTypeSinceVersion = 0;
        public const int MessageTypeDeprecated = 0;
        public bool MessageTypeInActingVersion()
        {
            return _actingVersion >= MessageTypeSinceVersion;
        }

        public static string MessageTypeMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "constant";
            }

            return "";
        }

        public MessageType MessageType
        {
            get
            {
                return MessageType.NewOrderCross;
            }
        }


        public const int CrossIDId = 548;
        public const int CrossIDSinceVersion = 0;
        public const int CrossIDDeprecated = 0;
        public bool CrossIDInActingVersion()
        {
            return _actingVersion >= CrossIDSinceVersion;
        }

        public static string CrossIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong CrossIDNullValue = 0xffffffffffffffffUL;
        public const ulong CrossIDMinValue = 0x0UL;
        public const ulong CrossIDMaxValue = 0xfffffffffffffffeUL;

        public ulong CrossID
        {
            get
            {
                return _buffer.Uint64GetLittleEndian(_offset + 0);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 0, value);
            }
        }


        public const int SecurityIDId = 48;
        public const int SecurityIDSinceVersion = 0;
        public const int SecurityIDDeprecated = 0;
        public bool SecurityIDInActingVersion()
        {
            return _actingVersion >= SecurityIDSinceVersion;
        }

        public static string SecurityIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong SecurityIDNullValue = 0xffffffffffffffffUL;
        public const ulong SecurityIDMinValue = 0x0UL;
        public const ulong SecurityIDMaxValue = 0xfffffffffffffffeUL;

        public ulong SecurityID
        {
            get
            {
                return _buffer.Uint64GetLittleEndian(_offset + 8);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 8, value);
            }
        }


        public const int SecurityIDSourceId = 22;
        public const int SecurityIDSourceSinceVersion = 0;
        public const int SecurityIDSourceDeprecated = 0;
        public bool SecurityIDSourceInActingVersion()
        {
            return _actingVersion >= SecurityIDSourceSinceVersion;
        }

        public static string SecurityIDSourceMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "constant";
            }

            return "";
        }

        public const byte SecurityIDSourceNullValue = (byte)0;
        public const byte SecurityIDSourceMinValue = (byte)32;
        public const byte SecurityIDSourceMaxValue = (byte)126;

        private static readonly byte[] _securityIDSourceValue = { 56 };

        public const int SecurityIDSourceLength = 1;
        public byte SecurityIDSource(int index)
        {
            return _securityIDSourceValue[index];
        }

        public int GetSecurityIDSource(byte[] dst, int offset, int length)
        {
            int bytesCopied = Math.Min(length, 1);
            Array.Copy(_securityIDSourceValue, 0, dst, offset, bytesCopied);
            return bytesCopied;
        }

        public const int SecurityExchangeId = 207;
        public const int SecurityExchangeSinceVersion = 0;
        public const int SecurityExchangeDeprecated = 0;
        public bool SecurityExchangeInActingVersion()
        {
            return _actingVersion >= SecurityExchangeSinceVersion;
        }

        public static string SecurityExchangeMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "constant";
            }

            return "";
        }

        public const byte SecurityExchangeNullValue = (byte)0;
        public const byte SecurityExchangeMinValue = (byte)32;
        public const byte SecurityExchangeMaxValue = (byte)126;

        private static readonly byte[] _securityExchangeValue = { 66, 86, 77, 70 };

        public const int SecurityExchangeLength = 4;
        public byte SecurityExchange(int index)
        {
            return _securityExchangeValue[index];
        }

        public int GetSecurityExchange(byte[] dst, int offset, int length)
        {
            int bytesCopied = Math.Min(length, 4);
            Array.Copy(_securityExchangeValue, 0, dst, offset, bytesCopied);
            return bytesCopied;
        }

        public const int PriceId = 44;
        public const int PriceSinceVersion = 0;
        public const int PriceDeprecated = 0;
        public bool PriceInActingVersion()
        {
            return _actingVersion >= PriceSinceVersion;
        }

        public static string PriceMetaAttribute(MetaAttribute metaAttribute)
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

        private readonly Price _price = new Price();

        public Price Price
        {
            get
            {
                _price.Wrap(_buffer, _offset + 16, _actingVersion);
                return _price;
            }
        }

        public const int OrderQtyId = 38;
        public const int OrderQtySinceVersion = 0;
        public const int OrderQtyDeprecated = 0;
        public bool OrderQtyInActingVersion()
        {
            return _actingVersion >= OrderQtySinceVersion;
        }

        public static string OrderQtyMetaAttribute(MetaAttribute metaAttribute)
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

        public const uint OrderQtyNullValue = 4294967295U;
        public const uint OrderQtyMinValue = 0U;
        public const uint OrderQtyMaxValue = 4294967294U;

        public uint OrderQty
        {
            get
            {
                return _buffer.Uint32GetLittleEndian(_offset + 24);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 24, value);
            }
        }


        public const int EnteringTraderId = 35502;
        public const int EnteringTraderSinceVersion = 0;
        public const int EnteringTraderDeprecated = 0;
        public bool EnteringTraderInActingVersion()
        {
            return _actingVersion >= EnteringTraderSinceVersion;
        }

        public static string EnteringTraderMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte EnteringTraderNullValue = (byte)0;
        public const byte EnteringTraderMinValue = (byte)32;
        public const byte EnteringTraderMaxValue = (byte)126;

        public const int EnteringTraderLength = 5;

        public byte GetEnteringTrader(int index)
        {
            if ((uint) index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 28 + (index * 1));
        }

        public void SetEnteringTrader(int index, byte value)
        {
            if ((uint) index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 28 + (index * 1), value);
        }

        public const string EnteringTraderCharacterEncoding = "ASCII";


        public int GetEnteringTrader(byte[] dst, int dstOffset)
        {
            const int length = 5;
            return GetEnteringTrader(new Span<byte>(dst, dstOffset, length));
        }

        public int GetEnteringTrader(Span<byte> dst)
        {
            const int length = 5;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 28, dst);
            return length;
        }

        public void SetEnteringTrader(byte[] src, int srcOffset)
        {
            SetEnteringTrader(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetEnteringTrader(ReadOnlySpan<byte> src)
        {
            const int length = 5;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 28, src);
        }

        public const int MarketSegmentIDId = 1300;
        public const int MarketSegmentIDSinceVersion = 0;
        public const int MarketSegmentIDDeprecated = 0;
        public bool MarketSegmentIDInActingVersion()
        {
            return _actingVersion >= MarketSegmentIDSinceVersion;
        }

        public static string MarketSegmentIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte MarketSegmentIDNullValue = (byte)255;
        public const byte MarketSegmentIDMinValue = (byte)0;
        public const byte MarketSegmentIDMaxValue = (byte)254;

        public byte MarketSegmentID
        {
            get
            {
                return _buffer.Uint8Get(_offset + 33);
            }
            set
            {
                _buffer.Uint8Put(_offset + 33, value);
            }
        }


        private readonly NoSidesGroup _noSides = new NoSidesGroup();

        public const long NoSidesId = 552;
        public const int NoSidesSinceVersion = 0;
        public const int NoSidesDeprecated = 0;
        public bool NoSidesInActingVersion()
        {
            return _actingVersion >= NoSidesSinceVersion;
        }

        public NoSidesGroup NoSides
        {
            get
            {
                _noSides.WrapForDecode(_parentMessage, _buffer, _actingVersion);
                return _noSides;
            }
        }

        public NoSidesGroup NoSidesCount(int count)
        {
            _noSides.WrapForEncode(_parentMessage, _buffer, count);
            return _noSides;
        }

        public sealed partial class NoSidesGroup
        {
            private readonly GroupSizeEncoding _dimensions = new GroupSizeEncoding();
            private NewOrderCross _parentMessage;
            private DirectBuffer _buffer;
            private int _blockLength;
            private int _actingVersion;
            private int _count;
            private int _index;
            private int _offset;

            public void WrapForDecode(NewOrderCross parentMessage, DirectBuffer buffer, int actingVersion)
            {
                _parentMessage = parentMessage;
                _buffer = buffer;
                _dimensions.Wrap(buffer, parentMessage.Limit, actingVersion);
                _blockLength = _dimensions.BlockLength;
                _count = (int) _dimensions.NumInGroup;
                _actingVersion = actingVersion;
                _index = 0;
                _parentMessage.Limit = parentMessage.Limit + SbeHeaderSize;
            }

            public void WrapForEncode(NewOrderCross parentMessage, DirectBuffer buffer, int count)
            {
                if ((uint) count > 254)
                {
                    ThrowHelper.ThrowCountOutOfRangeException(count);
                }

                _parentMessage = parentMessage;
                _buffer = buffer;
                _dimensions.Wrap(buffer, parentMessage.Limit, _actingVersion);
                _dimensions.BlockLength = SbeBlockLength;
                _dimensions.NumInGroup = (byte) count;
                _index = 0;
                _count = count;
                _blockLength = SbeBlockLength;
                _actingVersion = SchemaVersion;
                parentMessage.Limit = parentMessage.Limit + SbeHeaderSize;
            }

            public const int SbeBlockLength = 13;
            public const int SbeHeaderSize = 3;
            public int ActingBlockLength { get { return _blockLength; } }

            public int Count { get { return _count; } }

            public bool HasNext { get { return _index < _count; } }

            public int ResetCountToIndex()
            {
                _count = _index;
                _dimensions.NumInGroup = (byte) _count;

                return _count;
            }

            public NoSidesGroup Next()
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

            public const int SideId = 54;
            public const int SideSinceVersion = 0;
            public const int SideDeprecated = 0;
            public bool SideInActingVersion()
            {
                return _actingVersion >= SideSinceVersion;
            }

            public static string SideMetaAttribute(MetaAttribute metaAttribute)
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

            public Side Side
            {
                get
                {
                    return (Side)_buffer.CharGet(_offset + 0);
                }
                set
                {
                    _buffer.CharPut(_offset + 0, (byte)value);
                }
            }


            public const int ClOrdIDId = 11;
            public const int ClOrdIDSinceVersion = 0;
            public const int ClOrdIDDeprecated = 0;
            public bool ClOrdIDInActingVersion()
            {
                return _actingVersion >= ClOrdIDSinceVersion;
            }

            public static string ClOrdIDMetaAttribute(MetaAttribute metaAttribute)
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

            public const ulong ClOrdIDNullValue = 0xffffffffffffffffUL;
            public const ulong ClOrdIDMinValue = 0x0UL;
            public const ulong ClOrdIDMaxValue = 0xfffffffffffffffeUL;

            public ulong ClOrdID
            {
                get
                {
                    return _buffer.Uint64GetLittleEndian(_offset + 1);
                }
                set
                {
                    _buffer.Uint64PutLittleEndian(_offset + 1, value);
                }
            }


            public const int AccountId = 1;
            public const int AccountSinceVersion = 0;
            public const int AccountDeprecated = 0;
            public bool AccountInActingVersion()
            {
                return _actingVersion >= AccountSinceVersion;
            }

            public static string AccountMetaAttribute(MetaAttribute metaAttribute)
            {
                switch (metaAttribute)
                {
                    case MetaAttribute.Epoch: return "";
                    case MetaAttribute.TimeUnit: return "";
                    case MetaAttribute.SemanticType: return "";
                    case MetaAttribute.Presence: return "optional";
                }

                return "";
            }

            public const uint AccountNullValue = 4294967295U;
            public const uint AccountMinValue = 0U;
            public const uint AccountMaxValue = 4294967294U;

            public uint Account
            {
                get
                {
                    return _buffer.Uint32GetLittleEndian(_offset + 9);
                }
                set
                {
                    _buffer.Uint32PutLittleEndian(_offset + 9, value);
                }
            }

        }
    }
}
