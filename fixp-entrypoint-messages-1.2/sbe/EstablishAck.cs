/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using Org.SbeTool.Sbe.Dll;
using System;

namespace SbeFIX
{
    public sealed partial class EstablishAck
    {
        public const ushort BlockLength = (ushort)50;
        public const ushort TemplateId = (ushort)5;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly EstablishAck _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public EstablishAck()
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
                return MessageType.EstablishAck;
            }
        }


        public const int SessionIDId = 35518;
        public const int SessionIDSinceVersion = 0;
        public const int SessionIDDeprecated = 0;
        public bool SessionIDInActingVersion()
        {
            return _actingVersion >= SessionIDSinceVersion;
        }

        public static string SessionIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte SessionIDNullValue = (byte)0;
        public const byte SessionIDMinValue = (byte)32;
        public const byte SessionIDMaxValue = (byte)126;

        public const int SessionIDLength = 10;

        public byte GetSessionID(int index)
        {
            if ((uint)index >= 10)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 0 + (index * 1));
        }

        public void SetSessionID(int index, byte value)
        {
            if ((uint)index >= 10)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 0 + (index * 1), value);
        }

        public const string SessionIDCharacterEncoding = "ASCII";


        public int GetSessionID(byte[] dst, int dstOffset)
        {
            const int length = 10;
            return GetSessionID(new Span<byte>(dst, dstOffset, length));
        }

        public int GetSessionID(Span<byte> dst)
        {
            const int length = 10;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 0, dst);
            return length;
        }

        public void SetSessionID(byte[] src, int srcOffset)
        {
            SetSessionID(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetSessionID(ReadOnlySpan<byte> src)
        {
            const int length = 10;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 0, src);
        }

        public const int SessionVerIDId = 35519;
        public const int SessionVerIDSinceVersion = 0;
        public const int SessionVerIDDeprecated = 0;
        public bool SessionVerIDInActingVersion()
        {
            return _actingVersion >= SessionVerIDSinceVersion;
        }

        public static string SessionVerIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong SessionVerIDNullValue = 0xffffffffffffffffUL;
        public const ulong SessionVerIDMinValue = 0x0UL;
        public const ulong SessionVerIDMaxValue = 0xfffffffffffffffeUL;

        public ulong SessionVerID
        {
            get
            {
                return _buffer.Uint64GetLittleEndian(_offset + 10);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 10, value);
            }
        }


        public const int RequestTimestampId = 35521;
        public const int RequestTimestampSinceVersion = 0;
        public const int RequestTimestampDeprecated = 0;
        public bool RequestTimestampInActingVersion()
        {
            return _actingVersion >= RequestTimestampSinceVersion;
        }

        public static string RequestTimestampMetaAttribute(MetaAttribute metaAttribute)
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

        private readonly UTCTimestampNanos _requestTimestamp = new UTCTimestampNanos();

        public UTCTimestampNanos RequestTimestamp
        {
            get
            {
                _requestTimestamp.Wrap(_buffer, _offset + 18, _actingVersion);
                return _requestTimestamp;
            }
        }

        public const int KeepAliveIntervalId = 35525;
        public const int KeepAliveIntervalSinceVersion = 0;
        public const int KeepAliveIntervalDeprecated = 0;
        public bool KeepAliveIntervalInActingVersion()
        {
            return _actingVersion >= KeepAliveIntervalSinceVersion;
        }

        public static string KeepAliveIntervalMetaAttribute(MetaAttribute metaAttribute)
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

        private readonly DeltaInMillis _keepAliveInterval = new DeltaInMillis();

        public DeltaInMillis KeepAliveInterval
        {
            get
            {
                _keepAliveInterval.Wrap(_buffer, _offset + 26, _actingVersion);
                return _keepAliveInterval;
            }
        }

        public const int NextSeqNoId = 35526;
        public const int NextSeqNoSinceVersion = 0;
        public const int NextSeqNoDeprecated = 0;
        public bool NextSeqNoInActingVersion()
        {
            return _actingVersion >= NextSeqNoSinceVersion;
        }

        public static string NextSeqNoMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong NextSeqNoNullValue = 0xffffffffffffffffUL;
        public const ulong NextSeqNoMinValue = 0x0UL;
        public const ulong NextSeqNoMaxValue = 0xfffffffffffffffeUL;

        public ulong NextSeqNo
        {
            get
            {
                return _buffer.Uint64GetLittleEndian(_offset + 34);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 34, value);
            }
        }


        public const int LastIncomingSeqNoId = 35527;
        public const int LastIncomingSeqNoSinceVersion = 0;
        public const int LastIncomingSeqNoDeprecated = 0;
        public bool LastIncomingSeqNoInActingVersion()
        {
            return _actingVersion >= LastIncomingSeqNoSinceVersion;
        }

        public static string LastIncomingSeqNoMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong LastIncomingSeqNoNullValue = 0xffffffffffffffffUL;
        public const ulong LastIncomingSeqNoMinValue = 0x0UL;
        public const ulong LastIncomingSeqNoMaxValue = 0xfffffffffffffffeUL;

        public ulong LastIncomingSeqNo
        {
            get
            {
                return _buffer.Uint64GetLittleEndian(_offset + 42);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 42, value);
            }
        }

    }
}
