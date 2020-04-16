/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public sealed partial class OrderMassActionRequest
    {
        public const ushort BlockLength = (ushort)11;
        public const ushort TemplateId = (ushort)302;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly OrderMassActionRequest _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public OrderMassActionRequest()
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
                return MessageType.OrderMassActionRequest;
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
                return _buffer.Uint8Get(_offset + 8);
            }
            set
            {
                _buffer.Uint8Put(_offset + 8, value);
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
                return (MassActionScope)_buffer.Uint8Get(_offset + 9);
            }
            set
            {
                _buffer.Uint8Put(_offset + 9, (byte)value);
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
                case MetaAttribute.Presence: return "constant";
            }

            return "";
        }

        public ExecRestatementReason ExecRestatementReason
        {
            get
            {
                return ExecRestatementReason.ORDER_MASS_ACTION_FROM_CLIENT_REQUEST;
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
                return _buffer.Uint8Get(_offset + 10);
            }
            set
            {
                _buffer.Uint8Put(_offset + 10, value);
            }
        }

    }
}
