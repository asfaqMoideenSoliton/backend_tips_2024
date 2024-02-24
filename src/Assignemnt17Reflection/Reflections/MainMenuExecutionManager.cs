namespace Reflections
{
    /// <summary>
    /// Executes the main menu operations
    /// </summary>
    public class MainMenuExecutionManager
    {
        private enum ReflectionOperations
        {
            Quit,
            InspectAssemblyMetaData,
            DynamicObjectInspector,
            DynamicMethodInvoker,
            DynamicTypeBuilder,
            PluginSystem,
            MockingFramework,
            SerializationAPI,
        }

        /// <summary>
        /// Execute the user operations
        /// </summary>
        /// <returns>true if user press quit</returns>
        public bool ExecuteMainMenu()
        {
            ShowMainMenu();
            int userOption = ConsoleInterfaceController.GetOptionFromTheUser();
            Student student = new Student("asfaq", "pass", "12");

            ReflectionOperations operationToPerform = (ReflectionOperations)userOption;

            switch (operationToPerform)
            {
                case ReflectionOperations.InspectAssemblyMetaData:
                    InspectAssembly assembly = new InspectAssembly();
                    assembly.ExecuteAssemblyInspector();
                    break;
                case ReflectionOperations.DynamicObjectInspector:
                    ExecuteDynamicObjectInspector(student);
                    break;
                case ReflectionOperations.DynamicMethodInvoker:
                    ExecuteDynamicMethodInvoker();
                    break;
                case ReflectionOperations.DynamicTypeBuilder:
                    DynamicTypeBuilder builder = new DynamicTypeBuilder();
                    builder.TypeBuilder();
                    break;
                case ReflectionOperations.PluginSystem:
                    PluginManager pluginManager = new PluginManager();
                    pluginManager.ExecutePluginManager();
                    break;
                case ReflectionOperations.SerializationAPI:
                    APIController aPIController = new APIController();
                    aPIController.ExecuteSerilizer();
                    break;
                case ReflectionOperations.Quit:
                    return true;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

            return false;
        }

        private static void ExecuteDynamicMethodInvoker()
        {
            DynamicMethodInvoker methodInvoker = new ();
            PrintDetails printDetails = new PrintDetails();
            string methodName = ConsoleInterfaceController.GetStringFromTheUser("to search property name");
            methodInvoker.GetMethodInfo(printDetails, methodName);
        }

        private static void ExecuteDynamicObjectInspector(Student student)
        {
            DynamicObjectInspector dynamicObjectInspector = new ();
            dynamicObjectInspector.GetTypeof(student);
            string propertyName = ConsoleInterfaceController.GetStringFromTheUser("to Search the Property Name");
            string newValue = ConsoleInterfaceController.GetStringFromTheUser("new value of the property to change");
            dynamicObjectInspector.EditPropertyDetails(student, propertyName, newValue);
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine("Choose a Option to proceed");
            Console.WriteLine("1." + ReflectionOperations.InspectAssemblyMetaData);
            Console.WriteLine("2." + ReflectionOperations.DynamicObjectInspector);
            Console.WriteLine("3." + ReflectionOperations.DynamicMethodInvoker);
            Console.WriteLine("4." + ReflectionOperations.DynamicTypeBuilder);
            Console.WriteLine("5." + ReflectionOperations.PluginSystem);
            Console.WriteLine("6." + ReflectionOperations.MockingFramework);
            Console.WriteLine("7." + ReflectionOperations.SerializationAPI);
        }
    }
}
