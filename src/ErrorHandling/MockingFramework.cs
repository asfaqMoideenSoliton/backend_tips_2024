namespace Reflections
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Dynamically creates method and tested with mocking framework
    /// </summary>
    public class MockingFramework
    {
        /// <summary>
        /// Dynamically creates methods, types and assemblies
        /// </summary>
        /// <returns>Type of the object </returns>
        public Type TypeBuilder()
        {
            var assemblyName = new AssemblyName("UserInputValidator");
            AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(
                assemblyName,
                AssemblyBuilderAccess.Run);

            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(
                assemblyName.Name ?? "UserInputValidator");

            TypeBuilder typeBuilder = moduleBuilder.DefineType(
                "MyDynamicType",
                TypeAttributes.Public);

            Type[] parameterTypes = { typeof(int) };

            MethodBuilder methodBuilderUserName = typeBuilder.DefineMethod(
                "GetUserName",
                MethodAttributes.Public,
                typeof(string),
                null);

            MethodBuilder methodBuilderUserId = typeBuilder.DefineMethod(
                "GetUserId",
                MethodAttributes.Public,
                typeof(int),
                null);

            ILGenerator methodOne = methodBuilderUserName.GetILGenerator();
            methodOne.Emit(OpCodes.Ldstr, string.Empty);
            methodOne.Emit(OpCodes.Ret);

            ILGenerator methodTwo = methodBuilderUserId.GetILGenerator();
            methodTwo.Emit(OpCodes.Ldc_I4, default(int));
            methodTwo.Emit(OpCodes.Ret);

            Type type = typeBuilder.CreateType() !;

            return type;
        }
    }
}
