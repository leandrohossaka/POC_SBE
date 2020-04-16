/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public sealed partial class SimpleNewOrder
    {
        public const ushort BlockLength = (ushort)46;
        public const ushort TemplateId = (ushort)100;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly SimpleNewOrder _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public SimpleNewOrder()
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
                return MessageType.SimpleNewOrder;
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
                return _buffer.Uint32GetLittleEndian(_offset + 28);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 28, value);
            }
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
                return _buffer.Uint8Get(_offset + 32);
            }
            set
            {
                _buffer.Uint8Put(_offset + 32, value);
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
                return (Side)_buffer.CharGet(_offset + 33);
            }
            set
            {
                _buffer.CharPut(_offset + 33, (byte)value);
            }
        }


        public const int OrdTypeId = 40;
        public const int OrdTypeSinceVersion = 0;
        public const int OrdTypeDeprecated = 0;
        public bool OrdTypeInActingVersion()
        {
            return _actingVersion >= OrdTypeSinceVersion;
        }

        public static string OrdTypeMetaAttribute(MetaAttribute metaAttribute)
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

        public OrdType OrdType
        {
            get
            {
                return (OrdType)_buffer.CharGet(_offset + 34);
            }
            set
            {
                _buffer.CharPut(_offset + 34, (byte)value);
            }
        }


        public const int TimeInForceId = 59;
        public const int TimeInForceSinceVersion = 0;
        public const int TimeInForceDeprecated = 0;
        public bool TimeInForceInActingVersion()
        {
            return _actingVersion >= TimeInForceSinceVersion;
        }

        public static string TimeInForceMetaAttribute(MetaAttribute metaAttribute)
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

        public TimeInForce TimeInForce
        {
            get
            {
                return (TimeInForce)_buffer.CharGet(_offset + 35);
            }
            set
            {
                _buffer.CharPut(_offset + 35, (byte)value);
            }
        }


        public const int OrdTagIDId = 35505;
        public const int OrdTagIDSinceVersion = 0;
        public const int OrdTagIDDeprecated = 0;
        public bool OrdTagIDInActingVersion()
        {
            return _actingVersion >= OrdTagIDSinceVersion;
        }

        public static string OrdTagIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte OrdTagIDNullValue = (byte)255;
        public const byte OrdTagIDMinValue = (byte)0;
        public const byte OrdTagIDMaxValue = (byte)254;

        public byte OrdTagID
        {
            get
            {
                return _buffer.Uint8Get(_offset + 36);
            }
            set
            {
                _buffer.Uint8Put(_offset + 36, value);
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

            return _buffer.CharGet(_offset + 37 + (index * 1));
        }

        public void SetEnteringTrader(int index, byte value)
        {
            if ((uint) index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 37 + (index * 1), value);
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

            _buffer.GetBytes(_offset + 37, dst);
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

            _buffer.SetBytes(_offset + 37, src);
        }

        public const int InvestorIDId = 35504;
        public const int InvestorIDSinceVersion = 0;
        public const int InvestorIDDeprecated = 0;
        public bool InvestorIDInActingVersion()
        {
            return _actingVersion >= InvestorIDSinceVersion;
        }

        public static string InvestorIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const uint InvestorIDNullValue = 4294967295U;
        public const uint InvestorIDMinValue = 0U;
        public const uint InvestorIDMaxValue = 4294967294U;

        public uint InvestorID
        {
            get
            {
                return _buffer.Uint32GetLittleEndian(_offset + 42);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 42, value);
            }
        }

    }
}
