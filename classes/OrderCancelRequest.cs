/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public sealed partial class OrderCancelRequest
    {
        public const ushort BlockLength = (ushort)27;
        public const ushort TemplateId = (ushort)105;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly OrderCancelRequest _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public OrderCancelRequest()
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
                return MessageType.OrderCancelRequest;
            }
        }


        public const int OrigClOrdIDId = 41;
        public const int OrigClOrdIDSinceVersion = 0;
        public const int OrigClOrdIDDeprecated = 0;
        public bool OrigClOrdIDInActingVersion()
        {
            return _actingVersion >= OrigClOrdIDSinceVersion;
        }

        public static string OrigClOrdIDMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong OrigClOrdIDNullValue = 0xffffffffffffffffUL;
        public const ulong OrigClOrdIDMinValue = 0x0UL;
        public const ulong OrigClOrdIDMaxValue = 0xfffffffffffffffeUL;

        public ulong OrigClOrdID
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

            return _buffer.CharGet(_offset + 16 + (index * 1));
        }

        public void SetEnteringTrader(int index, byte value)
        {
            if ((uint) index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 16 + (index * 1), value);
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

            _buffer.GetBytes(_offset + 16, dst);
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

            _buffer.SetBytes(_offset + 16, src);
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

            return _buffer.CharGet(_offset + 21 + (index * 1));
        }

        public void SetExecutingTrader(int index, byte value)
        {
            if ((uint) index >= 5)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 21 + (index * 1), value);
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

            _buffer.GetBytes(_offset + 21, dst);
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

            _buffer.SetBytes(_offset + 21, src);
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

    }
}
