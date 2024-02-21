using System.Text;

namespace FilesStreamsReadWrite
{
    /// <summary>
    /// Holds the methods of optimized log errors with multiple users
    /// </summary>
    public class ModifiedLogError
    {
        private static object _lockTheThread = new object();

        /// <summary>
        /// Modfied logger which locks the thread when multiple users logs at a time.
        /// </summary>
        /// <param name="errorMessage"> Error Message</param>
        /// <param name="userId">user id</param>
        public static void ModifiedLogger(string errorMessage, string userId)
        {
            string logFile = $"log_user{userId}.txt";
            lock (_lockTheThread)
            {
                using (FileStream filewriter = new FileStream(logFile, FileMode.Append))
                {
                    byte[] data = Encoding.Default.GetBytes(errorMessage);
                    filewriter.Write(data, 0, data.Length);
                }
            }
        }
    }
}
