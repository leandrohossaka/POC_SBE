/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using Org.SbeTool.Sbe.Dll;
using System;

namespace SbeFIX
{
    public sealed partial class BusinessMessageReject
    {
        public const ushort BlockLength = (ushort)21;
        public const ushort TemplateId = (ushort)206;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly BusinessMessageReject _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public BusinessMessageReject()
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
                return MessageType.BusinessMessageReject;
            }
        }


        public const int BusinessRejectReasonId = 380;
        public const int BusinessRejectReasonSinceVersion = 0;
        public const int BusinessRejectReasonDeprecated = 0;
        public bool BusinessRejectReasonInActingVersion()
        {
            return _actingVersion >= BusinessRejectReasonSinceVersion;
        }

        public static string BusinessRejectReasonMetaAttribute(MetaAttribute metaAttribute)
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

        public const uint BusinessRejectReasonNullValue = 4294967295U;
        public const uint BusinessRejectReasonMinValue = 0U;
        public const uint BusinessRejectReasonMaxValue = 4294967294U;

        public uint BusinessRejectReason
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


        public const int RefSeqNumId = 45;
        public const int RefSeqNumSinceVersion = 0;
        public const int RefSeqNumDeprecated = 0;
        public bool RefSeqNumInActingVersion()
        {
            return _actingVersion >= RefSeqNumSinceVersion;
        }

        public static string RefSeqNumMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong RefSeqNumNullValue = 0xffffffffffffffffUL;
        public const ulong RefSeqNumMinValue = 0x0UL;
        public const ulong RefSeqNumMaxValue = 0xfffffffffffffffeUL;

        public ulong RefSeqNum
        {
            get
            {
                return _buffer.Uint64GetLittleEndian(_offset + 4);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 4, value);
            }
        }


        public const int RefMsgTypeId = 372;
        public const int RefMsgTypeSinceVersion = 0;
        public const int RefMsgTypeDeprecated = 0;
        public bool RefMsgTypeInActingVersion()
        {
            return _actingVersion >= RefMsgTypeSinceVersion;
        }

        public static string RefMsgTypeMetaAttribute(MetaAttribute metaAttribute)
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

        public MessageType RefMsgType
        {
            get
            {
                return (MessageType)_buffer.Uint8Get(_offset + 12);
            }
            set
            {
                _buffer.Uint8Put(_offset + 12, (byte)value);
            }
        }


        public const int BusinessRejectRefIDId = 379;
        public const int BusinessRejectRefIDSinceVersion = 0;
        public const int BusinessRejectRefIDDeprecated = 0;
        public bool BusinessRejectRefIDInActingVersion()
        {
            return _actingVersion >= BusinessRejectRefIDSinceVersion;
        }

        public static string BusinessRejectRefIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong BusinessRejectRefIDNullValue = 0xffffffffffffffffUL;
        public const ulong BusinessRejectRefIDMinValue = 0x0UL;
        public const ulong BusinessRejectRefIDMaxValue = 0xfffffffffffffffeUL;

        public ulong BusinessRejectRefID
        {
            get
            {
                return _buffer.Uint64GetLittleEndian(_offset + 13);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 13, value);
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
