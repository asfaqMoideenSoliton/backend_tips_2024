using Moq;
using System.Reflection;

namespace Reflections
{
    public class ReflectionMockingTests
    {
        [Fact]
        public void DynamicMethodReturnValue_GetUserName_ReturnsDeafultString()
        {
            MockingFramework mockingFramework = new MockingFramework();
            Type type = mockingFramework.TypeBuilder();

            object instance = Activator.CreateInstance(type) !;
            MethodInfo methodInfo = type.GetMethod("GetUserName") !;

            string expected = string.Empty;

            object actual = methodInfo.Invoke(instance, null) !;

            Assert.Equal(expected, actual);
        }    
        
        [Fact]
        public void DynamicMethodReturnValue_GetUserId_ReturnsDefaultInt()
        {
            MockingFramework mockingFramework = new MockingFramework();
            Type type = mockingFramework.TypeBuilder();

            object instance = Activator.CreateInstance(type) !;
            MethodInfo methodInfo = type.GetMethod("GetUserId") !;

            int expected = 0;

            object actual = methodInfo.Invoke(instance, null) !;

            Assert.Equal(expected, actual);
        }
    }
}