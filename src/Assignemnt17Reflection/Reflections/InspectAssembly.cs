using System.Reflection;

namespace Reflections
{
    /// <summary>
    /// Inspects the assembly
    /// </summary>
    public class InspectAssembly
    {
        private string _filePath = "C:\\New\\backend_tips_2024\\src\\Reflections\\bin\\Debug\\net6.0\\Reflections.dll";

        /// <summary>
        /// Executes the Assemble Info.
        /// </summary>
        public void ExecuteAssemblyInspector()
        {
            Assembly assembly = Assembly.LoadFile(this._filePath);
            Type type = assembly.GetType();

            var methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method);
            }

            var properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property);
            }

            var feilds = type.GetFields();
            foreach (FieldInfo field in feilds)
            {
                Console.WriteLine(field);
            }

            var events = type.GetEvents();
            foreach (EventInfo eventInfo in events)
            {
                Console.WriteLine(eventInfo);
            }
        }
    }
}
