namespace Reflections
{
    /// <summary>
    /// Plugin one contains the print greetings
    /// </summary>
    public class PluginOne: IPlugins
    {
        /// <summary>
        /// says greetings to the world
        /// </summary>
        public void PrintGreetings()
        {
            Console.WriteLine("Hello, World !");
        }
    }
}
