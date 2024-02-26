namespace BoilerControllerConsoleApplication
{
    /// <summary>
    /// Holds and manipulates the log file
    /// </summary>
    public class LogFileService
    {
        private string _logFilePath = "Boiler Log.txt";

        /// <summary>
        /// Writes to the file with time stamp
        /// </summary>
        /// <param name="stringtoPrintInLogFile">data to be written in the File</param>
        public void WriteToFile(string stringtoPrintInLogFile)
        {
            using (StreamWriter writer = new StreamWriter(this._logFilePath, true))
            {
                writer.Write(stringtoPrintInLogFile);
                writer.WriteLine("," + DateTime.Now);
                writer.Flush();
            }
        }

        /// <summary>
        /// Reads from the File
        /// </summary>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public void ReadFromFile()
        {
            if (File.Exists(this._logFilePath))
            {
                using (StreamReader reader = File.OpenText(this._logFilePath))
                {
                    string readString;
                    while ((readString = reader.ReadLine() !) != null)
                    {
                        Console.WriteLine(readString);
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Log File Not Found");
            }
        }
    }
}
