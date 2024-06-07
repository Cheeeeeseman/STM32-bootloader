/**
 * @file CRC32
 * @brief Класс служит для рассчета контрольной суммы
 */

using System.Buffers.Binary;

namespace swBootloader
{
    public static class CRC32
    {
        public static uint CalculateCrc32(ReadOnlySpan<byte> data, int? bound = null)
        {
            uint crc = 0xffffffff;
            int bytes = bound ?? data.Length;
            int p = 0;
            while (true)
            {
                uint dw = BinaryPrimitives.ReadUInt32LittleEndian(
                    data.Slice(p * sizeof(uint), sizeof(uint)));
                crc ^= dw;
                p++;
                for (int i = 0; i < 32; ++i)
                {
                    if ((crc & 0x80000000) != 0)
                    {
                        crc = (crc << 1) ^ 0x04C11DB7;
                    }
                    else
                    {
                        crc <<= 1;
                    }
                }
                if (bytes <= sizeof(uint)) return crc;
                bytes -= sizeof(uint);
            }
        }
    }
}
