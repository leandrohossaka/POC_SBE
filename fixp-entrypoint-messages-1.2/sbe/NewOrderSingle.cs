/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using Org.SbeTool.Sbe.Dll;
using System;

namespace SbeFIX
{
    public sealed partial class NewOrderSingle
    {
        public const ushort BlockLength = (ushort)66;
        public const ushort TemplateId = (ushort)102;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly NewOrderSingle _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public NewOrderSingle()
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
                return MessageType.NewOrderSingle;
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

        public const int StopPxId = 99;
        public const int StopPxSinceVersion = 0;
        public const int StopPxDeprecated = 0;
        public bool StopPxInActingVersion()
        {
            return _actingVersion >= StopPxSinceVersion;
        }

        public static string StopPxMetaAttribute(MetaAttribute metaAttribute)
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

        private readonly Price _stopPx = new Price();

        public Price StopPx
        {
            get
            {
                _stopPx.Wrap(_buffer, _offset + 24, _actingVersion);
                return _stopPx;
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
                return _buffer.Uint32GetLittleEndian(_offset + 32);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 32, value);
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
            if ((uint)index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 36 + (index * 1));
        }

        public void SetEnteringTrader(int index, byte value)
        {
            if ((uint)index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 36 + (index * 1), value);
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

            _buffer.GetBytes(_offset + 36, dst);
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

            _buffer.SetBytes(_offset + 36, src);
        }

        public const int ExpireDateId = 432;
        public const int ExpireDateSinceVersion = 0;
        public const int ExpireDateDeprecated = 0;
        public bool ExpireDateInActingVersion()
        {
            return _actingVersion >= ExpireDateSinceVersion;
        }

        public static string ExpireDateMetaAttribute(MetaAttribute metaAttribute)
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

        public const ushort ExpireDateNullValue = (ushort)65535;
        public const ushort ExpireDateMinValue = (ushort)0;
        public const ushort ExpireDateMaxValue = (ushort)65534;

        public ushort ExpireDate
        {
            get
            {
                return _buffer.Uint16GetLittleEndian(_offset + 41);
            }
            set
            {
                _buffer.Uint16PutLittleEndian(_offset + 41, value);
            }
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
                return _buffer.Uint32GetLittleEndian(_offset + 43);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 43, value);
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
                return _buffer.Uint32GetLittleEndian(_offset + 47);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 47, value);
            }
        }


        public const int MinQtyId = 110;
        public const int MinQtySinceVersion = 0;
        public const int MinQtyDeprecated = 0;
        public bool MinQtyInActingVersion()
        {
            return _actingVersion >= MinQtySinceVersion;
        }

        public static string MinQtyMetaAttribute(MetaAttribute metaAttribute)
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

        public const uint MinQtyNullValue = 4294967295U;
        public const uint MinQtyMinValue = 0U;
        public const uint MinQtyMaxValue = 4294967294U;

        public uint MinQty
        {
            get
            {
                return _buffer.Uint32GetLittleEndian(_offset + 51);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 51, value);
            }
        }


        public const int MaxFloorId = 111;
        public const int MaxFloorSinceVersion = 0;
        public const int MaxFloorDeprecated = 0;
        public bool MaxFloorInActingVersion()
        {
            return _actingVersion >= MaxFloorSinceVersion;
        }

        public static string MaxFloorMetaAttribute(MetaAttribute metaAttribute)
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

        public const uint MaxFloorNullValue = 4294967295U;
        public const uint MaxFloorMinValue = 0U;
        public const uint MaxFloorMaxValue = 4294967294U;

        public uint MaxFloor
        {
            get
            {
                return _buffer.Uint32GetLittleEndian(_offset + 55);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 55, value);
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
                return _buffer.Uint8Get(_offset + 59);
            }
            set
            {
                _buffer.Uint8Put(_offset + 59, value);
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
                return (Side)_buffer.CharGet(_offset + 60);
            }
            set
            {
                _buffer.CharPut(_offset + 60, (byte)value);
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
                return (OrdType)_buffer.CharGet(_offset + 61);
            }
            set
            {
                _buffer.CharPut(_offset + 61, (byte)value);
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
                return (TimeInForce)_buffer.CharGet(_offset + 62);
            }
            set
            {
                _buffer.CharPut(_offset + 62, (byte)value);
            }
        }


        public const int MmProtectionResetId = 9773;
        public const int MmProtectionResetSinceVersion = 0;
        public const int MmProtectionResetDeprecated = 0;
        public bool MmProtectionResetInActingVersion()
        {
            return _actingVersion >= MmProtectionResetSinceVersion;
        }

        public static string MmProtectionResetMetaAttribute(MetaAttribute metaAttribute)
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

        public Bool MmProtectionReset
        {
            get
            {
                return (Bool)_buffer.Uint8Get(_offset + 63);
            }
            set
            {
                _buffer.Uint8Put(_offset + 63, (byte)value);
            }
        }


        public const int RoutingInstructionId = 35487;
        public const int RoutingInstructionSinceVersion = 0;
        public const int RoutingInstructionDeprecated = 0;
        public bool RoutingInstructionInActingVersion()
        {
            return _actingVersion >= RoutingInstructionSinceVersion;
        }

        public static string RoutingInstructionMetaAttribute(MetaAttribute metaAttribute)
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

        public RoutingInstruction RoutingInstruction
        {
            get
            {
                return (RoutingInstruction)_buffer.Uint8Get(_offset + 64);
            }
            set
            {
                _buffer.Uint8Put(_offset + 64, (byte)value);
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
                return _buffer.Uint8Get(_offset + 65);
            }
            set
            {
                _buffer.Uint8Put(_offset + 65, value);
            }
        }


        public const int DeskIDId = 35510;
        public const int DeskIDSinceVersion = 0;
        public const int DeskIDDeprecated = 0;
        public bool DeskIDInActingVersion()
        {
            return _actingVersion >= DeskIDSinceVersion;
        }

        public const string DeskIDCharacterEncoding = "UTF-8";


        public static string DeskIDMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "String";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public const int DeskIDHeaderSize = 1;

        public int DeskIDLength()
        {
            _buffer.CheckLimit(_parentMessage.Limit + 1);
            return (int)_buffer.Uint8Get(_parentMessage.Limit);
        }

        public int GetDeskID(byte[] dst, int dstOffset, int length) =>
            GetDeskID(new Span<byte>(dst, dstOffset, length));

        public int GetDeskID(Span<byte> dst)
        {
            const int sizeOfLengthField = 1;
            int limit = _parentMessage.Limit;
            _buffer.CheckLimit(limit + sizeOfLengthField);
            int dataLength = (int)_buffer.Uint8Get(limit);
            int bytesCopied = Math.Min(dst.Length, dataLength);
            _parentMessage.Limit = limit + sizeOfLengthField + dataLength;
            _buffer.GetBytes(limit + sizeOfLengthField, dst.Slice(0, bytesCopied));

            return bytesCopied;
        }

        // Allocates and returns a new byte array
        public byte[] GetDeskIDBytes()
        {
            const int sizeOfLengthField = 1;
            int limit = _parentMessage.Limit;
            _buffer.CheckLimit(limit + sizeOfLengthField);
            int dataLength = (int)_buffer.Uint8Get(limit);
            byte[] data = new byte[dataLength];
            _parentMessage.Limit = limit + sizeOfLengthField + dataLength;
            _buffer.GetBytes(limit + sizeOfLengthField, data);

            return data;
        }

        public int SetDeskID(byte[] src, int srcOffset, int length) =>
            SetDeskID(new ReadOnlySpan<byte>(src, srcOffset, length));

        public int SetDeskID(ReadOnlySpan<byte> src)
        {
            const int sizeOfLengthField = 1;
            int limit = _parentMessage.Limit;
            _parentMessage.Limit = limit + sizeOfLengthField + src.Length;
            _buffer.Uint8Put(limit, (byte)src.Length);
            _buffer.SetBytes(limit + sizeOfLengthField, src);

            return src.Length;
        }

        public const int MemoId = 5149;
        public const int MemoSinceVersion = 0;
        public const int MemoDeprecated = 0;
        public bool MemoInActingVersion()
        {
            return _actingVersion >= MemoSinceVersion;
        }

        public const string MemoCharacterEncoding = "UTF-8";


        public static string MemoMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "String";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public const int MemoHeaderSize = 1;

        public int MemoLength()
        {
            _buffer.CheckLimit(_parentMessage.Limit + 1);
            return (int)_buffer.Uint8Get(_parentMessage.Limit);
        }

        public int GetMemo(byte[] dst, int dstOffset, int length) =>
            GetMemo(new Span<byte>(dst, dstOffset, length));

        public int GetMemo(Span<byte> dst)
        {
            const int sizeOfLengthField = 1;
            int limit = _parentMessage.Limit;
            _buffer.CheckLimit(limit + sizeOfLengthField);
            int dataLength = (int)_buffer.Uint8Get(limit);
            int bytesCopied = Math.Min(dst.Length, dataLength);
            _parentMessage.Limit = limit + sizeOfLengthField + dataLength;
            _buffer.GetBytes(limit + sizeOfLengthField, dst.Slice(0, bytesCopied));

            return bytesCopied;
        }

        // Allocates and returns a new byte array
        public byte[] GetMemoBytes()
        {
            const int sizeOfLengthField = 1;
            int limit = _parentMessage.Limit;
            _buffer.CheckLimit(limit + sizeOfLengthField);
            int dataLength = (int)_buffer.Uint8Get(limit);
            byte[] data = new byte[dataLength];
            _parentMessage.Limit = limit + sizeOfLengthField + dataLength;
            _buffer.GetBytes(limit + sizeOfLengthField, data);

            return data;
        }

        public int SetMemo(byte[] src, int srcOffset, int length) =>
            SetMemo(new ReadOnlySpan<byte>(src, srcOffset, length));

        public int SetMemo(ReadOnlySpan<byte> src)
        {
            const int sizeOfLengthField = 1;
            int limit = _parentMessage.Limit;
            _parentMessage.Limit = limit + sizeOfLengthField + src.Length;
            _buffer.Uint8Put(limit, (byte)src.Length);
            _buffer.SetBytes(limit + sizeOfLengthField, src);

            return src.Length;
        }
    }
}
