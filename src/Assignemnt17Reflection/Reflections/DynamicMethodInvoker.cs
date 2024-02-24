using System.Reflection;

namespace Reflections
{
    /// <summary>
    /// Dynamic Method Invoker
    /// </summary>
    public class DynamicMethodInvoker
    {
        /// <summary>
        /// Gets the information of the method
        /// </summary>
        /// <param name="obj1">Object </param>
        /// <param name="methodName"> Method Name</param>
        public void GetMethodInfo(object obj1, string methodName)
        {
            Type type = obj1.GetType();

            var isMethodValid = type.GetMethod(methodName);
            if (isMethodValid != null)
            {
                isMethodValid.Invoke(obj1, null);
                return;
            }

            throw new NotImplementedException("Method not found.");
        }
    }
}
