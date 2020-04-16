/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Adaptive.SimpleBinaryEncoding;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public sealed partial class Negotiate
    {
        public const ushort BlockLength = (ushort)44;
        public const ushort TemplateId = (ushort)1;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly Negotiate _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public Negotiate()
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
                return MessageType.Negotiate;
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
            if ((uint) index >= 10)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 0 + (index * 1));
        }

        public void SetSessionID(int index, byte value)
        {
            if ((uint) index >= 10)
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


        public const int TimestampId = 35520;
        public const int TimestampSinceVersion = 0;
        public const int TimestampDeprecated = 0;
        public bool TimestampInActingVersion()
        {
            return _actingVersion >= TimestampSinceVersion;
        }

        public static string TimestampMetaAttribute(MetaAttribute metaAttribute)
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

        private readonly UTCTimestampNanos _timestamp = new UTCTimestampNanos();

        public UTCTimestampNanos Timestamp
        {
            get
            {
                _timestamp.Wrap(_buffer, _offset + 18, _actingVersion);
                return _timestamp;
            }
        }

        public const int ClientFlowId = 35516;
        public const int ClientFlowSinceVersion = 0;
        public const int ClientFlowDeprecated = 0;
        public bool ClientFlowInActingVersion()
        {
            return _actingVersion >= ClientFlowSinceVersion;
        }

        public static string ClientFlowMetaAttribute(MetaAttribute metaAttribute)
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

        public FlowType ClientFlow
        {
            get
            {
                return FlowType.IDEMPOTENT;
            }
        }


        public const int EnteringFirmId = 35501;
        public const int EnteringFirmSinceVersion = 0;
        public const int EnteringFirmDeprecated = 0;
        public bool EnteringFirmInActingVersion()
        {
            return _actingVersion >= EnteringFirmSinceVersion;
        }

        public static string EnteringFirmMetaAttribute(MetaAttribute metaAttribute)
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

        public const uint EnteringFirmNullValue = 4294967295U;
        public const uint EnteringFirmMinValue = 0U;
        public const uint EnteringFirmMaxValue = 4294967294U;

        public uint EnteringFirm
        {
            get
            {
                return _buffer.Uint32GetLittleEndian(_offset + 26);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 26, value);
            }
        }


        public const int OnbehalfFirmId = 35517;
        public const int OnbehalfFirmSinceVersion = 0;
        public const int OnbehalfFirmDeprecated = 0;
        public bool OnbehalfFirmInActingVersion()
        {
            return _actingVersion >= OnbehalfFirmSinceVersion;
        }

        public static string OnbehalfFirmMetaAttribute(MetaAttribute metaAttribute)
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

        public const uint OnbehalfFirmNullValue = 4294967295U;
        public const uint OnbehalfFirmMinValue = 0U;
        public const uint OnbehalfFirmMaxValue = 4294967294U;

        public uint OnbehalfFirm
        {
            get
            {
                return _buffer.Uint32GetLittleEndian(_offset + 30);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 30, value);
            }
        }


        public const int SenderLocationId = 35503;
        public const int SenderLocationSinceVersion = 0;
        public const int SenderLocationDeprecated = 0;
        public bool SenderLocationInActingVersion()
        {
            return _actingVersion >= SenderLocationSinceVersion;
        }

        public static string SenderLocationMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte SenderLocationNullValue = (byte)0;
        public const byte SenderLocationMinValue = (byte)32;
        public const byte SenderLocationMaxValue = (byte)126;

        public const int SenderLocationLength = 10;

        public byte GetSenderLocation(int index)
        {
            if ((uint) index >= 10)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 34 + (index * 1));
        }

        public void SetSenderLocation(int index, byte value)
        {
            if ((uint) index >= 10)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 34 + (index * 1), value);
        }

        public const string SenderLocationCharacterEncoding = "ASCII";


        public int GetSenderLocation(byte[] dst, int dstOffset)
        {
            const int length = 10;
            return GetSenderLocation(new Span<byte>(dst, dstOffset, length));
        }

        public int GetSenderLocation(Span<byte> dst)
        {
            const int length = 10;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 34, dst);
            return length;
        }

        public void SetSenderLocation(byte[] src, int srcOffset)
        {
            SetSenderLocation(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetSenderLocation(ReadOnlySpan<byte> src)
        {
            const int length = 10;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 34, src);
        }

        public const int CredentialsId = 35512;
        public const int CredentialsSinceVersion = 0;
        public const int CredentialsDeprecated = 0;
        public bool CredentialsInActingVersion()
        {
            return _actingVersion >= CredentialsSinceVersion;
        }

        public const string CredentialsCharacterEncoding = "UTF-8";


        public static string CredentialsMetaAttribute(MetaAttribute metaAttribute)
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

        public const int CredentialsHeaderSize = 1;
        
        public int CredentialsLength()
        {
            _buffer.CheckLimit(_parentMessage.Limit + 1);
            return (int)_buffer.Uint8Get(_parentMessage.Limit);
        }

        public int GetCredentials(byte[] dst, int dstOffset, int length) =>
            GetCredentials(new Span<byte>(dst, dstOffset, length));

        public int GetCredentials(Span<byte> dst)
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
        public byte[] GetCredentialsBytes()
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

        public int SetCredentials(byte[] src, int srcOffset, int length) =>
            SetCredentials(new ReadOnlySpan<byte>(src, srcOffset, length));

        public int SetCredentials(ReadOnlySpan<byte> src)
        {
            const int sizeOfLengthField = 1;
            int limit = _parentMessage.Limit;
            _parentMessage.Limit = limit + sizeOfLengthField + src.Length;
            _buffer.Uint8Put(limit, (byte)src.Length);
            _buffer.SetBytes(limit + sizeOfLengthField, src);

            return src.Length;
        }

        public const int ClientIPId = 35513;
        public const int ClientIPSinceVersion = 0;
        public const int ClientIPDeprecated = 0;
        public bool ClientIPInActingVersion()
        {
            return _actingVersion >= ClientIPSinceVersion;
        }

        public const string ClientIPCharacterEncoding = "UTF-8";


        public static string ClientIPMetaAttribute(MetaAttribute metaAttribute)
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

        public const int ClientIPHeaderSize = 1;
        
        public int ClientIPLength()
        {
            _buffer.CheckLimit(_parentMessage.Limit + 1);
            return (int)_buffer.Uint8Get(_parentMessage.Limit);
        }

        public int GetClientIP(byte[] dst, int dstOffset, int length) =>
            GetClientIP(new Span<byte>(dst, dstOffset, length));

        public int GetClientIP(Span<byte> dst)
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
        public byte[] GetClientIPBytes()
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

        public int SetClientIP(byte[] src, int srcOffset, int length) =>
            SetClientIP(new ReadOnlySpan<byte>(src, srcOffset, length));

        public int SetClientIP(ReadOnlySpan<byte> src)
        {
            const int sizeOfLengthField = 1;
            int limit = _parentMessage.Limit;
            _parentMessage.Limit = limit + sizeOfLengthField + src.Length;
            _buffer.Uint8Put(limit, (byte)src.Length);
            _buffer.SetBytes(limit + sizeOfLengthField, src);

            return src.Length;
        }

        public const int ClientAppNameId = 35514;
        public const int ClientAppNameSinceVersion = 0;
        public const int ClientAppNameDeprecated = 0;
        public bool ClientAppNameInActingVersion()
        {
            return _actingVersion >= ClientAppNameSinceVersion;
        }

        public const string ClientAppNameCharacterEncoding = "UTF-8";


        public static string ClientAppNameMetaAttribute(MetaAttribute metaAttribute)
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

        public const int ClientAppNameHeaderSize = 1;
        
        public int ClientAppNameLength()
        {
            _buffer.CheckLimit(_parentMessage.Limit + 1);
            return (int)_buffer.Uint8Get(_parentMessage.Limit);
        }

        public int GetClientAppName(byte[] dst, int dstOffset, int length) =>
            GetClientAppName(new Span<byte>(dst, dstOffset, length));

        public int GetClientAppName(Span<byte> dst)
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
        public byte[] GetClientAppNameBytes()
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

        public int SetClientAppName(byte[] src, int srcOffset, int length) =>
            SetClientAppName(new ReadOnlySpan<byte>(src, srcOffset, length));

        public int SetClientAppName(ReadOnlySpan<byte> src)
        {
            const int sizeOfLengthField = 1;
            int limit = _parentMessage.Limit;
            _parentMessage.Limit = limit + sizeOfLengthField + src.Length;
            _buffer.Uint8Put(limit, (byte)src.Length);
            _buffer.SetBytes(limit + sizeOfLengthField, src);

            return src.Length;
        }

        public const int ClientAppVersionId = 35515;
        public const int ClientAppVersionSinceVersion = 0;
        public const int ClientAppVersionDeprecated = 0;
        public bool ClientAppVersionInActingVersion()
        {
            return _actingVersion >= ClientAppVersionSinceVersion;
        }

        public const string ClientAppVersionCharacterEncoding = "UTF-8";


        public static string ClientAppVersionMetaAttribute(MetaAttribute metaAttribute)
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

        public const int ClientAppVersionHeaderSize = 1;
        
        public int ClientAppVersionLength()
        {
            _buffer.CheckLimit(_parentMessage.Limit + 1);
            return (int)_buffer.Uint8Get(_parentMessage.Limit);
        }

        public int GetClientAppVersion(byte[] dst, int dstOffset, int length) =>
            GetClientAppVersion(new Span<byte>(dst, dstOffset, length));

        public int GetClientAppVersion(Span<byte> dst)
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
        public byte[] GetClientAppVersionBytes()
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

        public int SetClientAppVersion(byte[] src, int srcOffset, int length) =>
            SetClientAppVersion(new ReadOnlySpan<byte>(src, srcOffset, length));

        public int SetClientAppVersion(ReadOnlySpan<byte> src)
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
