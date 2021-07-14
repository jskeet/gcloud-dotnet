using Google.Cloud.Storage.V1;
using System;
using System.Diagnostics;
using System.IO;

namespace UploadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = StorageClient.Create();
            string bucket = args[0];
            string obj = args[1];
            string file = args[2];

            var stream = File.OpenRead(file);
            var stopwatch = Stopwatch.StartNew();
            var options = new UploadObjectOptions
            {
                ChunkSize = UploadObjectOptions.MinimumChunkSize
            };
            client.UploadObject(bucket, obj, "application/binary", stream, options);
            stopwatch.Stop();
            Console.WriteLine($"Upload completed in {stopwatch.Elapsed.TotalSeconds}s");
        }
    }
}
