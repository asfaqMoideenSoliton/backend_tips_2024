using System.Diagnostics;
using System.Text;

namespace FilesStreamsReadWrite
{
    /// <summary>
    /// Procces the Streams in Asynchronous mode
    /// </summary>
    public class AsynchronousStreamProcessor
    {
        /// <summary>
        /// Executes the Asynchronous file streams
        /// </summary>
        /// <returns>Executes the Async stream with multiple files</returns>
        public async Task ExecuteAsyncStreams()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Dictionary<string, string> asyncFilePaths = new Dictionary<string, string>()
                {
                    { @"C:\FileStreams\asyncnewlyWrittenFile.txt", @"C:\FileStreams\asyncprocessesData.txt" },
                    { @"C:\FileStreams\asyncnewlyWrittenFile1.txt", @"C:\FileStreams\asyncprocessesData1.txt" },
                    { @"C:\FileStreams\asyncnewlyWrittenFile2.txt", @"C:\FileStreams\asyncprocessesData2.txt" },
                };

            foreach (KeyValuePair<string, string> pair in asyncFilePaths)
            {
                await this.FileStreamWriter(pair.Key);
                await this.FileStreamReader(pair.Key);
                await this.BufferedStreamReader(pair.Key);
                await this.ReadProccesAndWriteDataToNewFile(pair.Key, pair.Value);
            }

            stopwatch.Stop();
            Console.WriteLine($"The Time for synchronous proccesing is {stopwatch.Elapsed}");
        }

        /// <summary>
        /// Writes into the files
        /// </summary>
        /// <returns>Task</returns>
        /// <param name="filePath">file path of the file to be read</param>
        public async Task FileStreamWriter(string filePath)
        {
            string data = "This is some test data";

            byte[] buffer = Encoding.ASCII.GetBytes(data);

            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                while (fileStream.Length < 1073741824)
                {
                   await fileStream.WriteAsync(buffer, 0, buffer.Length);
                }
            }
        }

        /// <summary>
        /// Read From the file using file stream
        /// </summary>
        /// <returns>Task</returns>
        /// <param name="filePath">file path of the file to be read</param>
        public async Task FileStreamReader(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                while ((bytesRead = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    // Reading using FileStream
                }

                stopwatch.Stop();
                Console.WriteLine($"Time taken to read file using FileStream (Async){stopwatch.Elapsed}");
            }
        }

        /// <summary>
        /// Read From the file using buffered stream
        /// </summary>
        /// <returns>Task</returns>
        /// <param name="filePath">file path of the file to be read</param>
        public async Task BufferedStreamReader(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                Stopwatch stopwatch = new Stopwatch();
                using (BufferedStream buffered = new BufferedStream(fileStream))
                {
                    stopwatch.Start();
                    while ((bytesRead = await buffered.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        // Reading file using buffered stream
                    }

                    stopwatch.Stop();
                }

                Console.WriteLine($"Time taken to read using Buffered Stream (Async): {stopwatch.Elapsed}");
            }
        }

        /// <summary>
        /// Read data from file change to upper case and write to a new file
        /// </summary>
        /// <returns>Task</returns>
        /// <param name="filePath">file path of the file to be read</param>
        /// <param name="newFilePath">file path of the new file to write</param>
        public async Task ReadProccesAndWriteDataToNewFile(string filePath, string newFilePath)
        {
            Stopwatch stopwatch = new Stopwatch();
            using (MemoryStream memoryStream = new ())
            using (FileStream streamReader = new (filePath, FileMode.Open))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                stopwatch.Start();
                while ((bytesRead = await streamReader.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    memoryStream.Write(buffer, 0, buffer.Length);
                }

                using (FileStream streamWriter = new (newFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    memoryStream.Position = 0;
                    memoryStream.CopyTo(streamWriter);
                }

                stopwatch.Stop();
                Console.WriteLine($"Time taken to Read, Procces and write in a new file is (Async){stopwatch.Elapsed}");
            }
        }
    }
}
