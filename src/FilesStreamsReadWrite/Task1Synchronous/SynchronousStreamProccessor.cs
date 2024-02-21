using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Text;

namespace FilesStreamsReadWrite
{
    /// <summary>
    /// Handle File Stream read write and performance analysis
    /// </summary>
    public class SynchronousStreamProccessor
    {
        /// <summary>
        /// Executes the Sync Streams with multiple files
        /// </summary>
        public void ExecuteSyncStreams()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Dictionary<string, string> syncFilePaths = new Dictionary<string, string>()
                {
                    { @"C:\FileStreams\newlyWrittenFile.txt", @"C:\FileStreams\processedData.txt" },
                    { @"C:\FileStreams\newlyWrittenFile1.txt", @"C:\FileStreams\processedData1.txt" },
                    { @"C:\FileStreams\newlyWrittenFile2.txt", @"C:\FileStreams\processedData2.txt" },
                };

            foreach (KeyValuePair<string, string> pair in syncFilePaths)
            {
                this.FileStreamWriter(pair.Key);
                this.FileStreamReader(pair.Key);
                this.BufferedStreamReader(pair.Key);
                this.ReadProccesAndWriteDataToNewFile(pair.Key, pair.Value);
            }

            stopwatch.Stop();
            Console.WriteLine($"The Time for synchronous proccesing is {stopwatch.Elapsed}");
        }

        /// <summary>
        /// Writes into the files
        /// </summary>
        /// <param name="filePath">file path of the file to be read</param>
        public void FileStreamWriter(string filePath)
        {
            string data = "This is some test data";

            byte[] buffer = Encoding.ASCII.GetBytes(data);

            using (Stream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                while (fileStream.Length < 1073741824)
                {
                    fileStream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        /// <summary>
        /// Read From the file using file stream
        /// </summary>
        /// <param name="filePath">file path of the file to be read</param>
        public void FileStreamReader(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    // Reading using FileStream
                }

                stopwatch.Stop();
                Console.WriteLine($"Time taken to read file using FileStream {stopwatch.Elapsed}");
            }
        }

        /// <summary>
        /// Read From the file using buffered stream
        /// </summary>
        /// <param name="filePath">file path of the file to be read</param>
        public void BufferedStreamReader(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                Stopwatch stopwatch = new Stopwatch();
                using (BufferedStream buffered = new BufferedStream(fileStream))
                {
                    stopwatch.Start();
                    while ((bytesRead = buffered.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        // Reading file using buffered stream
                    }

                    stopwatch.Stop();
                }

                Console.WriteLine($"Time taken to read using Buffered Stream : {stopwatch.Elapsed}");
            }
        }

        /// <summary>
        /// Read data from file change to upper case and write to a new file
        /// </summary>
        /// <param name="filePath">file path of the file to be read</param>
        /// <param name="newFilePath">file path of the new file to write</param>
        public void ReadProccesAndWriteDataToNewFile(string filePath, string newFilePath)
        {
            Stopwatch stopwatch = new Stopwatch();
            using (MemoryStream memoryStream = new ())
            using (FileStream streamReader = new (filePath, FileMode.Open))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                stopwatch.Start();
                while ((bytesRead = streamReader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    memoryStream.Write(buffer, 0, buffer.Length);
                }

                using (FileStream streamWriter = new (newFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    memoryStream.Position = 0;
                    memoryStream.CopyTo(streamWriter);
                }

                stopwatch.Stop();
                Console.WriteLine($"Time taken to Read, Procces and write in a new file is{stopwatch.Elapsed}");
            }
        }
    }
}
