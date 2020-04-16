/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public sealed partial class ExecutionReport_Cancel
    {
        public const ushort BlockLength = (ushort)61;
        public const ushort TemplateId = (ushort)202;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly ExecutionReport_Cancel _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public ExecutionReport_Cancel()
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
                return MessageType.ExecutionReport_Cancel;
            }
        }


        public const int ExecIDId = 17;
        public const int ExecIDSinceVersion = 0;
        public const int ExecIDDeprecated = 0;
        public bool ExecIDInActingVersion()
        {
            return _actingVersion >= ExecIDSinceVersion;
        }

        public static string ExecIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong ExecIDNullValue = 0xffffffffffffffffUL;
        public const ulong ExecIDMinValue = 0x0UL;
        public const ulong ExecIDMaxValue = 0xfffffffffffffffeUL;

        public ulong ExecID
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
                return _buffer.Uint64GetLittleEndian(_offset + 8);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 8, value);
            }
        }


        public const int OrderIDId = 37;
        public const int OrderIDSinceVersion = 0;
        public const int OrderIDDeprecated = 0;
        public bool OrderIDInActingVersion()
        {
            return _actingVersion >= OrderIDSinceVersion;
        }

        public static string OrderIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong OrderIDNullValue = 0xffffffffffffffffUL;
        public const ulong OrderIDMinValue = 0x0UL;
        public const ulong OrderIDMaxValue = 0xfffffffffffffffeUL;

        public ulong OrderID
        {
            get
            {
                return _buffer.Uint64GetLittleEndian(_offset + 16);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 16, value);
            }
        }


        public const int TransactTimeId = 60;
        public const int TransactTimeSinceVersion = 0;
        public const int TransactTimeDeprecated = 0;
        public bool TransactTimeInActingVersion()
        {
            return _actingVersion >= TransactTimeSinceVersion;
        }

        public static string TransactTimeMetaAttribute(MetaAttribute metaAttribute)
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

        private readonly UTCTimestampNanos _transactTime = new UTCTimestampNanos();

        public UTCTimestampNanos TransactTime
        {
            get
            {
                _transactTime.Wrap(_buffer, _offset + 24, _actingVersion);
                return _transactTime;
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

            return _buffer.CharGet(_offset + 32 + (index * 1));
        }

        public void SetEnteringTrader(int index, byte value)
        {
            if ((uint) index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 32 + (index * 1), value);
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

            _buffer.GetBytes(_offset + 32, dst);
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

            _buffer.SetBytes(_offset + 32, src);
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
                return _buffer.Uint64GetLittleEndian(_offset + 37);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 37, value);
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

        public const int ExecTypeId = 150;
        public const int ExecTypeSinceVersion = 0;
        public const int ExecTypeDeprecated = 0;
        public bool ExecTypeInActingVersion()
        {
            return _actingVersion >= ExecTypeSinceVersion;
        }

        public static string ExecTypeMetaAttribute(MetaAttribute metaAttribute)
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

        public ExecType ExecType
        {
            get
            {
                return (ExecType)_buffer.CharGet(_offset + 45);
            }
            set
            {
                _buffer.CharPut(_offset + 45, (byte)value);
            }
        }


        public const int OrdStatusId = 39;
        public const int OrdStatusSinceVersion = 0;
        public const int OrdStatusDeprecated = 0;
        public bool OrdStatusInActingVersion()
        {
            return _actingVersion >= OrdStatusSinceVersion;
        }

        public static string OrdStatusMetaAttribute(MetaAttribute metaAttribute)
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

        public OrdStatus OrdStatus
        {
            get
            {
                return (OrdStatus)_buffer.CharGet(_offset + 46);
            }
            set
            {
                _buffer.CharPut(_offset + 46, (byte)value);
            }
        }


        public const int SecondaryOrderIDId = 198;
        public const int SecondaryOrderIDSinceVersion = 0;
        public const int SecondaryOrderIDDeprecated = 0;
        public bool SecondaryOrderIDInActingVersion()
        {
            return _actingVersion >= SecondaryOrderIDSinceVersion;
        }

        public static string SecondaryOrderIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong SecondaryOrderIDNullValue = 0xffffffffffffffffUL;
        public const ulong SecondaryOrderIDMinValue = 0x0UL;
        public const ulong SecondaryOrderIDMaxValue = 0xfffffffffffffffeUL;

        public ulong SecondaryOrderID
        {
            get
            {
                return _buffer.Uint64GetLittleEndian(_offset + 47);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 47, value);
            }
        }


        public const int ExecutingTraderId = 35506;
        public const int ExecutingTraderSinceVersion = 0;
        public const int ExecutingTraderDeprecated = 0;
        public bool ExecutingTraderInActingVersion()
        {
            return _actingVersion >= ExecutingTraderSinceVersion;
        }

        public static string ExecutingTraderMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte ExecutingTraderNullValue = (byte)0;
        public const byte ExecutingTraderMinValue = (byte)32;
        public const byte ExecutingTraderMaxValue = (byte)126;

        public const int ExecutingTraderLength = 5;

        public byte GetExecutingTrader(int index)
        {
            if ((uint) index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 55 + (index * 1));
        }

        public void SetExecutingTrader(int index, byte value)
        {
            if ((uint) index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 55 + (index * 1), value);
        }

        public const string ExecutingTraderCharacterEncoding = "ASCII";


        public int GetExecutingTrader(byte[] dst, int dstOffset)
        {
            const int length = 5;
            return GetExecutingTrader(new Span<byte>(dst, dstOffset, length));
        }

        public int GetExecutingTrader(Span<byte> dst)
        {
            const int length = 5;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 55, dst);
            return length;
        }

        public void SetExecutingTrader(byte[] src, int srcOffset)
        {
            SetExecutingTrader(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetExecutingTrader(ReadOnlySpan<byte> src)
        {
            const int length = 5;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 55, src);
        }

        public const int ExecRestatementReasonId = 378;
        public const int ExecRestatementReasonSinceVersion = 0;
        public const int ExecRestatementReasonDeprecated = 0;
        public bool ExecRestatementReasonInActingVersion()
        {
            return _actingVersion >= ExecRestatementReasonSinceVersion;
        }

        public static string ExecRestatementReasonMetaAttribute(MetaAttribute metaAttribute)
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

        public ExecRestatementReason ExecRestatementReason
        {
            get
            {
                return (ExecRestatementReason)_buffer.Uint8Get(_offset + 60);
            }
            set
            {
                _buffer.Uint8Put(_offset + 60, (byte)value);
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
