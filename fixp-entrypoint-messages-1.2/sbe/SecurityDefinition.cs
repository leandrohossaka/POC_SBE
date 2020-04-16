/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using Org.SbeTool.Sbe.Dll;
using System;

namespace SbeFIX
{
    public sealed partial class SecurityDefinition
    {
        public const ushort BlockLength = (ushort)53;
        public const ushort TemplateId = (ushort)301;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly SecurityDefinition _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public SecurityDefinition()
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
                return MessageType.SecurityDefinition;
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


        public const int SecurityResponseIDId = 322;
        public const int SecurityResponseIDSinceVersion = 0;
        public const int SecurityResponseIDDeprecated = 0;
        public bool SecurityResponseIDInActingVersion()
        {
            return _actingVersion >= SecurityResponseIDSinceVersion;
        }

        public static string SecurityResponseIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong SecurityResponseIDNullValue = 0xffffffffffffffffUL;
        public const ulong SecurityResponseIDMinValue = 0x0UL;
        public const ulong SecurityResponseIDMaxValue = 0xfffffffffffffffeUL;

        public ulong SecurityResponseID
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


        public const int SecurityResponseTypeId = 323;
        public const int SecurityResponseTypeSinceVersion = 0;
        public const int SecurityResponseTypeDeprecated = 0;
        public bool SecurityResponseTypeInActingVersion()
        {
            return _actingVersion >= SecurityResponseTypeSinceVersion;
        }

        public static string SecurityResponseTypeMetaAttribute(MetaAttribute metaAttribute)
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

        public SecurityResponseType SecurityResponseType
        {
            get
            {
                return (SecurityResponseType)_buffer.Uint8Get(_offset + 16);
            }
            set
            {
                _buffer.Uint8Put(_offset + 16, (byte)value);
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

            return _buffer.CharGet(_offset + 17 + (index * 1));
        }

        public void SetEnteringTrader(int index, byte value)
        {
            if ((uint)index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 17 + (index * 1), value);
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

            _buffer.GetBytes(_offset + 17, dst);
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

            _buffer.SetBytes(_offset + 17, src);
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
                return _buffer.Uint64GetLittleEndian(_offset + 22);
            }
            set
            {
                _buffer.Uint64PutLittleEndian(_offset + 22, value);
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

        public const int SymbolId = 55;
        public const int SymbolSinceVersion = 0;
        public const int SymbolDeprecated = 0;
        public bool SymbolInActingVersion()
        {
            return _actingVersion >= SymbolSinceVersion;
        }

        public static string SymbolMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte SymbolNullValue = (byte)0;
        public const byte SymbolMinValue = (byte)32;
        public const byte SymbolMaxValue = (byte)126;

        public const int SymbolLength = 20;

        public byte GetSymbol(int index)
        {
            if ((uint)index >= 20)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 30 + (index * 1));
        }

        public void SetSymbol(int index, byte value)
        {
            if ((uint)index >= 20)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 30 + (index * 1), value);
        }

        public const string SymbolCharacterEncoding = "ASCII";


        public int GetSymbol(byte[] dst, int dstOffset)
        {
            const int length = 20;
            return GetSymbol(new Span<byte>(dst, dstOffset, length));
        }

        public int GetSymbol(Span<byte> dst)
        {
            const int length = 20;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 30, dst);
            return length;
        }

        public void SetSymbol(byte[] src, int srcOffset)
        {
            SetSymbol(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetSymbol(ReadOnlySpan<byte> src)
        {
            const int length = 20;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 30, src);
        }

        public const int SecurityStrategyTypeId = 7534;
        public const int SecurityStrategyTypeSinceVersion = 0;
        public const int SecurityStrategyTypeDeprecated = 0;
        public bool SecurityStrategyTypeInActingVersion()
        {
            return _actingVersion >= SecurityStrategyTypeSinceVersion;
        }

        public static string SecurityStrategyTypeMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte SecurityStrategyTypeNullValue = (byte)0;
        public const byte SecurityStrategyTypeMinValue = (byte)32;
        public const byte SecurityStrategyTypeMaxValue = (byte)126;

        public const int SecurityStrategyTypeLength = 3;

        public byte GetSecurityStrategyType(int index)
        {
            if ((uint)index >= 3)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 50 + (index * 1));
        }

        public void SetSecurityStrategyType(int index, byte value)
        {
            if ((uint)index >= 3)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 50 + (index * 1), value);
        }

        public const string SecurityStrategyTypeCharacterEncoding = "ASCII";


        public int GetSecurityStrategyType(byte[] dst, int dstOffset)
        {
            const int length = 3;
            return GetSecurityStrategyType(new Span<byte>(dst, dstOffset, length));
        }

        public int GetSecurityStrategyType(Span<byte> dst)
        {
            const int length = 3;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 50, dst);
            return length;
        }

        public void SetSecurityStrategyType(byte[] src, int srcOffset)
        {
            SetSecurityStrategyType(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetSecurityStrategyType(ReadOnlySpan<byte> src)
        {
            const int length = 3;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 50, src);
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
