﻿using System.IO;
using System.IO.Compression;

/// <summary>
/// Восстановление из архива.
/// DeflateStream
/// </summary>
namespace _030_DEFLATE_DeCompression
{
    class Program
    {
        static void Main()
        {
            FileStream source = File.OpenRead(@"D:\archive.dfl");
            FileStream destination = File.Create(@"D:\text_deflate.txt");

            //Распаковывает основной поток.
            DeflateStream deCompressor = new DeflateStream(source, CompressionMode.Decompress);

            int theByte = deCompressor.ReadByte();
            while (theByte != -1)
            {
                destination.WriteByte((byte)theByte);
                theByte = deCompressor.ReadByte();
            }

            deCompressor.Close();
        }
    }
}
