/*
    Credits goes to Twitter.com/iMCSx
    I used this script to save time and people already familiar with the structure
    - BISOON
 
 */
using System;
using System.Linq;
using System.Text;

namespace PS4Lib
{
    public class Extension
    {
        private readonly PS4API PS4;
        public Extension(PS4API ps4Api)
        {
            PS4 = ps4Api;
        }
        private void SetMem(ulong offset, byte[] buffer)
        {
            PS4.SetMemory(offset, buffer, buffer.Length);
        }

        private void GetMem(ulong offset, ref byte[] buffer)
        {
            PS4.GetMemory(offset, ref buffer);
        }

        private byte[] GetBytes(ulong offset, uint length)
        {
            byte[] buffer = new byte[length];
            GetMem(offset, ref buffer);
            return buffer;
        }

        /// <summary>Read a signed byte.</summary>
        public sbyte ReadSByte(ulong offset)
        {
            byte[] buffer = new byte[1];
            GetMem(offset, ref buffer);
            return (sbyte)buffer[0];
        }

        /// <summary>Read a byte a check if his value. This return a bool according the byte detected.</summary>
        public bool ReadBool(ulong offset)
        {
            byte[] buffer = new byte[1];
            GetMem(offset, ref buffer);
            return buffer[0] != 0;
        }

        /// <summary>Read and return an integer 16 bits.</summary>
        public short ReadInt16(ulong offset)
        {
            byte[] buffer = GetBytes(offset, 2);
            return BitConverter.ToInt16(buffer, 0);
        }

        /// <summary>Read and return an integer 32 bits.</summary>
        public int ReadInt32(ulong offset)
        {
            byte[] buffer = GetBytes(offset, 4);
            return BitConverter.ToInt32(buffer, 0);
        }

        /// <summary>Read and return an integer 64 bits.</summary>
        public long ReadInt64(ulong offset)
        {
            byte[] buffer = GetBytes(offset, 8);
            return BitConverter.ToInt64(buffer, 0);
        }

        /// <summary>Read and return a byte.</summary>
        public byte ReadByte(ulong offset)
        {
            byte[] buffer = GetBytes(offset, 1);
            return buffer[0];
        }

        /// <summary>Read a string with a length to the first byte equal to an value null (0x00).</summary>
        public byte[] ReadBytes(ulong offset, int length)
        {
            byte[] buffer = GetBytes(offset, (uint)length);
            return buffer;
        }

        /// <summary>Read and return an unsigned integer 16 bits.</summary>
        public ushort ReadUInt16(ulong offset)
        {
            byte[] buffer = GetBytes(offset, 2);
            return BitConverter.ToUInt16(buffer, 0);
        }

        /// <summary>Read and return an unsigned integer 32 bits.</summary>
        public uint ReadUInt32(ulong offset)
        {
            byte[] buffer = GetBytes(offset, 4);
            return BitConverter.ToUInt32(buffer, 0);
        }

        /// <summary>Read and return an unsigned integer 64 bits.</summary>
        public ulong ReadUInt64(ulong offset)
        {
            byte[] buffer = GetBytes(offset, 8);
            return BitConverter.ToUInt64(buffer, 0);
        }

        /// <summary>Read and return a Float.</summary>
        public float ReadFloat(ulong offset)
        {
            byte[] buffer = GetBytes(offset, 4);
            return BitConverter.ToSingle(buffer, 0);
        }

        /// <summary>Read and return an array of Floats.</summary>
        public float[] ReadFloats(ulong offset, int arrayLength = 3)
        {
            float[] vec = new float[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                vec[i] = ReadFloat(offset + ((ulong) i * 4));
            }
            return vec;
        }

        /// <summary>Read and return a Double.</summary>
        public double ReadDouble(ulong offset)
        {
            byte[] buffer = GetBytes(offset, 8);
            return BitConverter.ToDouble(buffer, 0);
        }

        /// <summary>Read a string very fast by buffer and stop only when a byte null is detected (0x00).</summary>
        public string ReadString(ulong offset)
        {
            int blocksize = 40;
            int scalesize = 0;
            string str = string.Empty;

            while (!str.Contains('\0'))
            {
                byte[] buffer = ReadBytes(offset + (uint)scalesize, blocksize);
                str += Encoding.UTF8.GetString(buffer);
                scalesize += blocksize;
            }

            return str.Substring(0, str.IndexOf('\0'));
        }

        /// <summary>Write a signed byte.</summary>
        public void WriteSByte(ulong offset, sbyte input)
        {
            byte[] buff = new byte[1];
            buff[0] = (byte)input;
            SetMem(offset, buff);
        }

        /// <summary>Write a boolean.</summary>
        public void WriteBool(ulong offset, bool input)
        {
            byte[] buff = new byte[1];
            buff[0] = input ? (byte)1 : (byte)0;
            SetMem(offset, buff);
        }

        /// <summary>Write an interger 16 bits.</summary>
        public void WriteInt16(ulong offset, short input)
        {
            byte[] buff = new byte[2];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            SetMem(offset, buff);
        }

        /// <summary>Write an integer 32 bits.</summary>
        public void WriteInt32(ulong offset, int input)
        {
            byte[] buff = new byte[4];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            SetMem(offset, buff);
        }

        /// <summary>Write an integer 64 bits.</summary>
        public void WriteInt64(ulong offset, long input)
        {
            byte[] buff = new byte[8];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            SetMem(offset, buff);
        }

        /// <summary>Write a byte.</summary>
        public void WriteByte(ulong offset, byte input)
        {
            byte[] buff = new byte[1];
            buff[0] = input;
            SetMem(offset, buff);
        }

        /// <summary>Write a byte array.</summary>
        public void WriteBytes(ulong offset, byte[] input)
        {
            byte[] buff = input;
            SetMem(offset, buff);
        }

        /// <summary>Write a string.</summary>
        public void WriteString(ulong offset, string input)
        {
            byte[] buff = Encoding.UTF8.GetBytes(input);
            Array.Resize(ref buff, buff.Length + 1);
            SetMem(offset, buff);
        }

        /// <summary>Write an unsigned integer 16 bits.</summary>
        public void WriteUInt16(ulong offset, ushort input)
        {
            byte[] buff = new byte[2];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            
            SetMem(offset, buff);
        }

        /// <summary>Write an unsigned integer 32 bits.</summary>
        public void WriteUInt32(ulong offset, uint input)
        {
            byte[] buff = new byte[4];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            SetMem(offset, buff);
        }

        /// <summary>Write an unsigned integer 64 bits.</summary>
        public void WriteUInt64(ulong offset, ulong input)
        {
            byte[] buff = new byte[8];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            SetMem(offset, buff);
        }

        /// <summary>Write a Float.</summary>
        public void WriteFloat(ulong offset, float input)
        {
            byte[] buff = new byte[4];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            SetMem(offset, buff);
        }

        /// <summary>Write an array of Floats.</summary>
        public void WriteFloats(ulong offset, float[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                WriteFloat(offset + ((uint)i * 4), input[i]);
            }
        }

        /// <summary>Write a double.</summary>
        public void WriteDouble(ulong offset, double input)
        {
            byte[] buff = new byte[8];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            SetMem(offset, buff);
        }
    }
}