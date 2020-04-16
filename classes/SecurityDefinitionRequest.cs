/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public sealed partial class SecurityDefinitionRequest
    {
        public const ushort BlockLength = (ushort)27;
        public const ushort TemplateId = (ushort)300;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly SecurityDefinitionRequest _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public SecurityDefinitionRequest()
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
                return MessageType.SecurityDefinitionRequest;
            }
        }


        public const int SecurityReqIDId = 320;
        public const int SecurityReqIDSinceVersion = 0;
        public const int SecurityReqIDDeprecated = 0;
        public bool SecurityReqIDInActingVersion()
        {
            return _actingVersion >= SecurityReqIDSinceVersion;
        }

        public static string SecurityReqIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong SecurityReqIDNullValue = 0xffffffffffffffffUL;
        public const ulong SecurityReqIDMinValue = 0x0UL;
        public const ulong SecurityReqIDMaxValue = 0xfffffffffffffffeUL;

        public ulong SecurityReqID
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

            return _buffer.CharGet(_offset + 8 + (index * 1));
        }

        public void SetEnteringTrader(int index, byte value)
        {
            if ((uint) index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 8 + (index * 1), value);
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

            _buffer.GetBytes(_offset + 8, dst);
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

            _buffer.SetBytes(_offset + 8, src);
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
                return _buffer.Uint8Get(_offset + 26);
            }
            set
            {
                _buffer.Uint8Put(_offset + 26, value);
            }
        }


        private readonly NoLegsGroup _noLegs = new NoLegsGroup();

        public const long NoLegsId = 552;
        public const int NoLegsSinceVersion = 0;
        public const int NoLegsDeprecated = 0;
        public bool NoLegsInActingVersion()
        {
            return _actingVersion >= NoLegsSinceVersion;
        }

        public NoLegsGroup NoLegs
        {
            get
            {
                _noLegs.WrapForDecode(_parentMessage, _buffer, _actingVersion);
                return _noLegs;
            }
        }

        public NoLegsGroup NoLegsCount(int count)
        {
            _noLegs.WrapForEncode(_parentMessage, _buffer, count);
            return _noLegs;
        }

        public sealed partial class NoLegsGroup
        {
            private readonly GroupSizeEncoding _dimensions = new GroupSizeEncoding();
            private SecurityDefinitionRequest _parentMessage;
            private DirectBuffer _buffer;
            private int _blockLength;
            private int _actingVersion;
            private int _count;
            private int _index;
            private int _offset;

            public void WrapForDecode(SecurityDefinitionRequest parentMessage, DirectBuffer buffer, int actingVersion)
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

            public void WrapForEncode(SecurityDefinitionRequest parentMessage, DirectBuffer buffer, int count)
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

            public const int SbeBlockLength = 17;
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

            public NoLegsGroup Next()
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

            public const int LegSecurityIDId = 602;
            public const int LegSecurityIDSinceVersion = 0;
            public const int LegSecurityIDDeprecated = 0;
            public bool LegSecurityIDInActingVersion()
            {
                return _actingVersion >= LegSecurityIDSinceVersion;
            }

            public static string LegSecurityIDMetaAttribute(MetaAttribute metaAttribute)
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

            public const ulong LegSecurityIDNullValue = 0xffffffffffffffffUL;
            public const ulong LegSecurityIDMinValue = 0x0UL;
            public const ulong LegSecurityIDMaxValue = 0xfffffffffffffffeUL;

            public ulong LegSecurityID
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


            public const int LegSecurityIDSourceId = 603;
            public const int LegSecurityIDSourceSinceVersion = 0;
            public const int LegSecurityIDSourceDeprecated = 0;
            public bool LegSecurityIDSourceInActingVersion()
            {
                return _actingVersion >= LegSecurityIDSourceSinceVersion;
            }

            public static string LegSecurityIDSourceMetaAttribute(MetaAttribute metaAttribute)
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

            public const byte LegSecurityIDSourceNullValue = (byte)0;
            public const byte LegSecurityIDSourceMinValue = (byte)32;
            public const byte LegSecurityIDSourceMaxValue = (byte)126;

            private static readonly byte[] _legSecurityIDSourceValue = { 56 };

            public const int LegSecurityIDSourceLength = 1;
            public byte LegSecurityIDSource(int index)
            {
                return _legSecurityIDSourceValue[index];
            }

            public int GetLegSecurityIDSource(byte[] dst, int offset, int length)
            {
                int bytesCopied = Math.Min(length, 1);
                Array.Copy(_legSecurityIDSourceValue, 0, dst, offset, bytesCopied);
                return bytesCopied;
            }

            public const int LegSecurityExchangeId = 616;
            public const int LegSecurityExchangeSinceVersion = 0;
            public const int LegSecurityExchangeDeprecated = 0;
            public bool LegSecurityExchangeInActingVersion()
            {
                return _actingVersion >= LegSecurityExchangeSinceVersion;
            }

            public static string LegSecurityExchangeMetaAttribute(MetaAttribute metaAttribute)
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

            public const byte LegSecurityExchangeNullValue = (byte)0;
            public const byte LegSecurityExchangeMinValue = (byte)32;
            public const byte LegSecurityExchangeMaxValue = (byte)126;

            private static readonly byte[] _legSecurityExchangeValue = { 66, 86, 77, 70 };

            public const int LegSecurityExchangeLength = 4;
            public byte LegSecurityExchange(int index)
            {
                return _legSecurityExchangeValue[index];
            }

            public int GetLegSecurityExchange(byte[] dst, int offset, int length)
            {
                int bytesCopied = Math.Min(length, 4);
                Array.Copy(_legSecurityExchangeValue, 0, dst, offset, bytesCopied);
                return bytesCopied;
            }

            public const int LegRatioQtyId = 623;
            public const int LegRatioQtySinceVersion = 0;
            public const int LegRatioQtyDeprecated = 0;
            public bool LegRatioQtyInActingVersion()
            {
                return _actingVersion >= LegRatioQtySinceVersion;
            }

            public static string LegRatioQtyMetaAttribute(MetaAttribute metaAttribute)
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

            private readonly RatioQty _legRatioQty = new RatioQty();

            public RatioQty LegRatioQty
            {
                get
                {
                    _legRatioQty.Wrap(_buffer, _offset + 8, _actingVersion);
                    return _legRatioQty;
                }
            }

            public const int LegSideId = 624;
            public const int LegSideSinceVersion = 0;
            public const int LegSideDeprecated = 0;
            public bool LegSideInActingVersion()
            {
                return _actingVersion >= LegSideSinceVersion;
            }

            public static string LegSideMetaAttribute(MetaAttribute metaAttribute)
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

            public Side LegSide
            {
                get
                {
                    return (Side)_buffer.CharGet(_offset + 16);
                }
                set
                {
                    _buffer.CharPut(_offset + 16, (byte)value);
                }
            }

        }
    }
}
