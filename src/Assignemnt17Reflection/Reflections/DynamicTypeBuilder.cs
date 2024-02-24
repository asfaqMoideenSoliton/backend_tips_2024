using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Reflections
{
    /// <summary>
    /// Dynamically type builder
    /// </summary>
    public class DynamicTypeBuilder
    {
        /// <summary>
        /// //Build class, methods, fields and properties
        /// </summary>
        public void TypeBuilder()
        {
            Console.WriteLine("Create a new Assembly");
            string assemblyNameFromUser = ConsoleInterfaceController.GetStringFromTheUser(
                "to create a new Assembly");
            var assemblyName = new AssemblyName(assemblyNameFromUser);
            AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(
                assemblyName,
                AssemblyBuilderAccess.Run);

            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(
                assemblyName.Name ?? assemblyNameFromUser);

            TypeBuilder typeBuilder = moduleBuilder.DefineType(
                "MyDynamicType",
                TypeAttributes.Public);

            string fieldName = ConsoleInterfaceController.GetStringFromTheUser(
                "to create feild name");
            FieldBuilder fieldBuilder = typeBuilder.DefineField(
                fieldName,
                typeof(int),
                FieldAttributes.Private);

            Type[] parameterTypes = { typeof(int) };

            ConstructorBuilder constructor = typeBuilder.DefineConstructor(
                MethodAttributes.Public,
                CallingConventions.Standard,
                null);

            ILGenerator constructorIl = constructor.GetILGenerator();
            constructorIl.EmitWriteLine("Constructor Created");
            constructorIl.Emit(OpCodes.Ret);

            string propertyName = ConsoleInterfaceController.GetStringFromTheUser(
                "to create a new property");

            PropertyBuilder propertyBuilder = typeBuilder.DefineProperty(
                propertyName,
                PropertyAttributes.HasDefault,
                typeof(int),
                null);

            string methodName = ConsoleInterfaceController.GetStringFromTheUser(
                "to create a new Method");
            MethodBuilder methodBuilder = typeBuilder.DefineMethod(
                methodName,
                MethodAttributes.Public,
                typeof(void),
                null);

            ILGenerator methodOne = methodBuilder.GetILGenerator();
            methodOne.EmitWriteLine("Method created");
            methodOne.Emit(OpCodes.Ret);

            Type type = typeBuilder.CreateType() !;
            var instanceType = Activator.CreateInstance(type);

            MethodInfo methodInfo = type.GetMethod(methodName) !;
            methodInfo.Invoke(instanceType, null);

            foreach (var methodNames in type.GetMethods())
            {
                Console.WriteLine(methodNames);
            }
        }
    }
}
