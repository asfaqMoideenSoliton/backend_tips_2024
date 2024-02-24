using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Reflections
{
    /// <summary>
    /// Serializes the given content to serializedformat.
    /// </summary>
    public class SerializationAPI
    {
        /// <summary>
        /// Serializes the given data to serializedforma
        /// </summary>
        /// <param name="objToSerialize">object to serialise</param>
        public void SerializeData(object objToSerialize)
        {
            StringBuilder objcetProperties = new StringBuilder();
            Type type = objToSerialize.GetType();
            var properties = type.GetProperties();
            foreach ( var property in properties )
            {
                var propertyValue = property.GetValue(objToSerialize, null);
                objcetProperties.Append($"{property.Name} : {propertyValue}");
            }

            Console.WriteLine(objcetProperties.ToString());
        }

        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <param name="objectToSerialize">object to serialize</param>
        public void SerializeToStringUsingReflection(object objectToSerialize)
        {
            var objectToSerializeType = objectToSerialize.GetType();
            var serializerAssembly = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("SerializerAssembly"), AssemblyBuilderAccess.Run);
            var serializerModule = serializerAssembly.DefineDynamicModule("SerializerModule");
            var serializerType = serializerModule.DefineType("Serializer", TypeAttributes.Public);
            var serializerMethod = serializerType.DefineMethod("Serialize", MethodAttributes.Public, typeof(string), new Type[] { typeof(object) });
            var appendMethod = typeof(StringBuilder).GetMethod("Append", new Type[] { typeof(string) });
            var toStringMethod = typeof(StringBuilder).GetMethod("ToString", Type.EmptyTypes);
            var stringBuilderConstructor = typeof(StringBuilder).GetConstructor(Type.EmptyTypes);
            if (appendMethod is not null && toStringMethod is not null && stringBuilderConstructor is not null)
            {
                var serializerMethodIL = serializerMethod.GetILGenerator();
                serializerMethodIL.DeclareLocal(typeof(StringBuilder));
                serializerMethodIL.Emit(OpCodes.Newobj, stringBuilderConstructor);
                serializerMethodIL.Emit(OpCodes.Ldstr, "{ Type: ");
                serializerMethodIL.Emit(OpCodes.Callvirt, appendMethod);
                serializerMethodIL.Emit(OpCodes.Ldstr, objectToSerializeType.Name);
                serializerMethodIL.Emit(OpCodes.Callvirt, appendMethod);
                var properties = objectToSerializeType.GetProperties();
                foreach (var property in properties)
                {
                    serializerMethodIL.Emit(OpCodes.Ldstr, $", {property.Name} : ");
                    serializerMethodIL.Emit(OpCodes.Callvirt, appendMethod);
                    serializerMethodIL.Emit(OpCodes.Ldstr, $" {property.GetValue(objectToSerialize)}");
                    serializerMethodIL.Emit(OpCodes.Callvirt, appendMethod);
                }

                serializerMethodIL.Emit(OpCodes.Ldstr, " }");
                serializerMethodIL.Emit(OpCodes.Callvirt, appendMethod);
                serializerMethodIL.Emit(OpCodes.Callvirt, toStringMethod);
                serializerMethodIL.Emit(OpCodes.Ret);
                var dynamicSerializerType = serializerType.CreateType();
                if (dynamicSerializerType is not null)
                {
                    var dynamicSerializerInstance = Activator.CreateInstance(dynamicSerializerType);
                    var dynamicSerializerMethod = dynamicSerializerType.GetMethod("Serialize");
                    if (dynamicSerializerMethod is not null)
                    {
                        var serializerResult = dynamicSerializerMethod.Invoke(dynamicSerializerInstance, new object[] { objectToSerialize }) as string;
                        if (serializerResult is not null)
                        {
                            Console.WriteLine(serializerResult);
                        }
                    }
                }
            }
        }
    }
}
