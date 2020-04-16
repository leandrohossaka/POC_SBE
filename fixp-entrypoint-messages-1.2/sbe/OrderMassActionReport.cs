/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using Org.SbeTool.Sbe.Dll;
using System;

namespace SbeFIX
{
    public sealed partial class OrderMassActionReport
    {
        public const ushort BlockLength = (ushort)29;
        public const ushort TemplateId = (ushort)303;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly OrderMassActionReport _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public OrderMassActionReport()
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
                return MessageType.OrderMassActionReport;
            }
        }


        public const int MassActionReportIDId = 1369;
        public const int MassActionReportIDSinceVersion = 0;
        public const int MassActionReportIDDeprecated = 0;
        public bool MassActionReportIDInActingVersion()
        {
            return _actingVersion >= MassActionReportIDSinceVersion;
        }

        public static string MassActionReportIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong MassActionReportIDNullValue = 0xffffffffffffffffUL;
        public const ulong MassActionReportIDMinValue = 0x0UL;
        public const ulong MassActionReportIDMaxValue = 0xfffffffffffffffeUL;

        public ulong MassActionReportID
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
                _transactTime.Wrap(_buffer, _offset + 16, _actingVersion);
                return _transactTime;
            }
        }

        public const int MassActionResponseId = 1375;
        public const int MassActionResponseSinceVersion = 0;
        public const int MassActionResponseDeprecated = 0;
        public bool MassActionResponseInActingVersion()
        {
            return _actingVersion >= MassActionResponseSinceVersion;
        }

        public static string MassActionResponseMetaAttribute(MetaAttribute metaAttribute)
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

        public MassActionResponse MassActionResponse
        {
            get
            {
                return (MassActionResponse)_buffer.Uint8Get(_offset + 24);
            }
            set
            {
                _buffer.Uint8Put(_offset + 24, (byte)value);
            }
        }


        public const int MassActionScopeId = 1374;
        public const int MassActionScopeSinceVersion = 0;
        public const int MassActionScopeDeprecated = 0;
        public bool MassActionScopeInActingVersion()
        {
            return _actingVersion >= MassActionScopeSinceVersion;
        }

        public static string MassActionScopeMetaAttribute(MetaAttribute metaAttribute)
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

        public MassActionScope MassActionScope
        {
            get
            {
                return (MassActionScope)_buffer.Uint8Get(_offset + 25);
            }
            set
            {
                _buffer.Uint8Put(_offset + 25, (byte)value);
            }
        }


        public const int MassActionTypeId = 1373;
        public const int MassActionTypeSinceVersion = 0;
        public const int MassActionTypeDeprecated = 0;
        public bool MassActionTypeInActingVersion()
        {
            return _actingVersion >= MassActionTypeSinceVersion;
        }

        public static string MassActionTypeMetaAttribute(MetaAttribute metaAttribute)
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

        public MassActionType MassActionType
        {
            get
            {
                return MassActionType.CANCEL_ORDERS;
            }
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
                return (ExecRestatementReason)_buffer.Uint8Get(_offset + 26);
            }
            set
            {
                _buffer.Uint8Put(_offset + 26, (byte)value);
            }
        }


        public const int MassActionRejectReasonId = 1376;
        public const int MassActionRejectReasonSinceVersion = 0;
        public const int MassActionRejectReasonDeprecated = 0;
        public bool MassActionRejectReasonInActingVersion()
        {
            return _actingVersion >= MassActionRejectReasonSinceVersion;
        }

        public static string MassActionRejectReasonMetaAttribute(MetaAttribute metaAttribute)
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

        public MassActionRejectReason MassActionRejectReason
        {
            get
            {
                return (MassActionRejectReason)_buffer.Uint8Get(_offset + 27);
            }
            set
            {
                _buffer.Uint8Put(_offset + 27, (byte)value);
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
                return _buffer.Uint8Get(_offset + 28);
            }
            set
            {
                _buffer.Uint8Put(_offset + 28, value);
            }
        }


        public const int TextId = 58;
        public const int TextSinceVersion = 0;
        public const int TextDeprecated = 0;
        public bool TextInActingVersion()
        {
            return _actingVersion >= TextSinceVersion;
        }

        public const string TextCharacterEncoding = "UTF-8";


        public static string TextMetaAttribute(MetaAttribute metaAttribute)
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

        public const int TextHeaderSize = 1;

        public int TextLength()
        {
            _buffer.CheckLimit(_parentMessage.Limit + 1);
            return (int)_buffer.Uint8Get(_parentMessage.Limit);
        }

        public int GetText(byte[] dst, int dstOffset, int length) =>
            GetText(new Span<byte>(dst, dstOffset, length));

        public int GetText(Span<byte> dst)
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
        public byte[] GetTextBytes()
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

        public int SetText(byte[] src, int srcOffset, int length) =>
            SetText(new ReadOnlySpan<byte>(src, srcOffset, length));

        public int SetText(ReadOnlySpan<byte> src)
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
