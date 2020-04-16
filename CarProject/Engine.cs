/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using Org.SbeTool.Sbe.Dll;
using System;

namespace Sbe
{
    public sealed partial class Engine
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

        public const int Size = 6;

        public const ushort CapacityNullValue = (ushort)65535;
        public const ushort CapacityMinValue = (ushort)0;
        public const ushort CapacityMaxValue = (ushort)65534;

        public ushort Capacity
        {
            get
            {
                return _buffer.Uint16GetLittleEndian(_offset + 0);
            }
            set
            {
                _buffer.Uint16PutLittleEndian(_offset + 0, value);
            }
        }


        public const byte NumCylindersNullValue = (byte)255;
        public const byte NumCylindersMinValue = (byte)0;
        public const byte NumCylindersMaxValue = (byte)254;

        public byte NumCylinders
        {
            get
            {
                return _buffer.Uint8Get(_offset + 2);
            }
            set
            {
                _buffer.Uint8Put(_offset + 2, value);
            }
        }


        public const ushort MaxRpmNullValue = (ushort)65535;
        public const ushort MaxRpmMinValue = (ushort)0;
        public const ushort MaxRpmMaxValue = (ushort)65534;

        public ushort MaxRpm { get { return (ushort)9000; } }

        public const byte ManufacturerCodeNullValue = (byte)0;
        public const byte ManufacturerCodeMinValue = (byte)32;
        public const byte ManufacturerCodeMaxValue = (byte)126;

        public const int ManufacturerCodeLength = 3;

        public byte GetManufacturerCode(int index)
        {
            if ((uint)index >= 3)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 3 + (index * 1));
        }

        public void SetManufacturerCode(int index, byte value)
        {
            if ((uint)index >= 3)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 3 + (index * 1), value);
        }

        public const string ManufacturerCodeCharacterEncoding = "US-ASCII";


        public int GetManufacturerCode(byte[] dst, int dstOffset)
        {
            const int length = 3;
            return GetManufacturerCode(new Span<byte>(dst, dstOffset, length));
        }

        public int GetManufacturerCode(Span<byte> dst)
        {
            const int length = 3;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 3, dst);
            return length;
        }

        public void SetManufacturerCode(byte[] src, int srcOffset)
        {
            SetManufacturerCode(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetManufacturerCode(ReadOnlySpan<byte> src)
        {
            const int length = 3;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 3, src);
        }

        public const byte FuelNullValue = (byte)0;
        public const byte FuelMinValue = (byte)32;
        public const byte FuelMaxValue = (byte)126;

        private static readonly byte[] _FuelValue = { 80, 101, 116, 114, 111, 108 };

        public const int FuelLength = 6;
        public byte Fuel(int index)
        {
            return _FuelValue[index];
        }

        public int GetFuel(byte[] dst, int offset, int length)
        {
            int bytesCopied = Math.Min(length, 6);
            Array.Copy(_FuelValue, 0, dst, offset, bytesCopied);
            return bytesCopied;
        }
    }
}
