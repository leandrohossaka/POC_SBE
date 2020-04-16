/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using Org.SbeTool.Sbe.Dll;

namespace SbeFIX
{
    public sealed partial class UTCTimestampNanos
    {
        private DirectBuffer _buffer;
        private int _offset;
        private int _actingVersion;

        public void Wrap(DirectBuffer buffer, int offset, int actingVersion)
        {
            _offset = offset;
            _actingVersion = actingVersion;
            _buffer = buffer;
        }

        public const int Size = 8;

        public const ulong TimeNullValue = 0xffffffffffffffffUL;
        public const ulong TimeMinValue = 0x0UL;
        public const ulong TimeMaxValue = 0xfffffffffffffffeUL;

        public ulong Time
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


        public const byte UnitNullValue = (byte)255;
        public const byte UnitMinValue = (byte)0;
        public const byte UnitMaxValue = (byte)254;

        public byte Unit { get { return (byte)9; } }
    }
}
