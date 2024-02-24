namespace Reflections
{
    /// <summary>
    /// Plugin two with same contract of plugin manager
    /// </summary>
    public class PluginTwo : IPlugins
    {
        /// <summary>
        /// says greetings to the world
        /// </summary>
        public void PrintGreetings()
        {
            Console.WriteLine("Hello, Soliton !");
        }
    }
}
