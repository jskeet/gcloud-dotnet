using System;
using System.IO;

namespace GenerateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];
            long size = long.Parse(args[1]);

            byte[] buffer = new byte[65536];
            var random = new Random();
            using var stream = File.Create(name);
            while (size > 0)
            {
                int chunk = (int) Math.Min(buffer.Length, size);
                random.NextBytes(buffer);
                stream.Write(buffer, 0, chunk);
                size -= chunk;
            }
        }
    }
}
