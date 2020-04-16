/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using Org.SbeTool.Sbe.Dll;

namespace SbeFIX
{
    public sealed partial class NotApplied
    {
        public const ushort BlockLength = (ushort)12;
        public const ushort TemplateId = (ushort)8;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly NotApplied _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public NotApplied()
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
                return MessageType.NotApplied;
            }
        }


        public const int FromSeqNoId = 35529;
        public const int FromSeqNoSinceVersion = 0;
        public const int FromSeqNoDeprecated = 0;
        public bool FromSeqNoInActingVersion()
        {
            return _actingVersion >= FromSeqNoSinceVersion;
        }

        public static string FromSeqNoMetaAttribute(MetaAttribute metaAttribute)
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

        public const ulong FromSeqNoNullValue = 0xffffffffffffffffUL;
        public const ulong FromSeqNoMinValue = 0x0UL;
        public const ulong FromSeqNoMaxValue = 0xfffffffffffffffeUL;

        public ulong FromSeqNo
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


        public const int CountId = 35530;
        public const int CountSinceVersion = 0;
        public const int CountDeprecated = 0;
        public bool CountInActingVersion()
        {
            return _actingVersion >= CountSinceVersion;
        }

        public static string CountMetaAttribute(MetaAttribute metaAttribute)
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

        public const uint CountNullValue = 4294967295U;
        public const uint CountMinValue = 0U;
        public const uint CountMaxValue = 4294967294U;

        public uint Count
        {
            get
            {
                return _buffer.Uint32GetLittleEndian(_offset + 8);
            }
            set
            {
                _buffer.Uint32PutLittleEndian(_offset + 8, value);
            }
        }

    }
}
