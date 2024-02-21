using System.IO;
using System.Text;

namespace FilesStreamsReadWrite
{
    /// <summary>
    /// Efficients methods to read write files
    /// </summary>
    public class EfficiectStreamProcessor
    {
        /// <summary>
        /// Modified stream writer
        /// </summary>
        public void StreamWriter()
        {
            string path = "newFilePath";
            string data = "newDataPath";

            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                memoryStream.Write(buffer, 0, buffer.Length);
                memoryStream.Position = 0;

                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    memoryStream.WriteTo(fileStream);
                }
            }
        }

        /// <summary>
        /// Modified stream reader
        /// </summary>
        public void StreamReader()
        {
            string path = "newFilePath";
            using (StreamReader streamReader = new (path, true))
            {
                char[] buffer = new char[1024];
                int bytesRead;
                while ((bytesRead = streamReader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    // Reading the file
                }
            }
        }
    }
}
