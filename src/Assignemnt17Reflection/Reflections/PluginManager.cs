using System.Reflection;

namespace Reflections
{
    /// <summary>
    /// Manages the plugin
    /// </summary>
   public class PluginManager
    {
        private const string Plugin1FilePath = @"C:\New\backend_tips_2024\src\Assignemnt17 Reflection\Plugin1\bin\Debug\net6.0\plugin1.dll";
        private const string Plugin2FilePath = @"C:\New\backend_tips_2024\src\Assignemnt17 Reflection\Plugin2\bin\Debug\net6.0\plugin2.dll";

        /// <summary>
        /// Executes the Plugin Manager
        /// </summary>
        public void ExecutePluginManager()
        {
            Assembly pluginAssembly1 = Assembly.LoadFile(Plugin1FilePath);
            Assembly pluginAssembly2 = Assembly.LoadFile(Plugin2FilePath);

            var plugin1Types = pluginAssembly1.GetTypes()
                .Where(t => typeof(IPlugins).IsAssignableFrom(t)).ToArray();

            var plugin2Types = pluginAssembly2.GetTypes()
                .Where(t => typeof(IPlugins).IsAssignableFrom(t)).ToArray();

            foreach (var pluginType in plugin1Types)
            {
                IPlugins plugin = (IPlugins)Activator.CreateInstance(pluginType) !;
                plugin.PrintGreetings();
            }

            foreach (var pluginType in plugin2Types)
            {
                IPlugins plugins = (IPlugins)(Activator.CreateInstance(pluginType) !);
                plugins.PrintGreetings();
            }
        }
    }
}
