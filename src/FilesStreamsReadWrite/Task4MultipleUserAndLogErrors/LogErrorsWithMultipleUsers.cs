using System.Text;

namespace FilesStreamsReadWrite
{
    /// <summary>
    /// Log errors created due to multiple user
    /// </summary>
    public class LogErrorsWithMultipleUsers
    {
        private static string _logFilePath = "log.txt";

        /// <summary>
        /// Log Error Method
        /// </summary>
        /// <param name="erorMessage">Error message</param>
        public static void LogError(string erorMessage)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] errorBytes = Encoding.UTF8.GetBytes(erorMessage);
                memoryStream.Write(errorBytes, 0, errorBytes.Length);

                using (FileStream fileStream = new FileStream(_logFilePath, FileMode.Append))
                {
                    memoryStream.WriteTo(fileStream);
                }
            }
        }
    }
}
