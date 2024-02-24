using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    /// <summary>
    /// Executes the API Controller
    /// </summary>
    public class APIController
    {
        /// <summary>
        /// Execute the Serializer
        /// /// </summary>
        public void ExecuteSerilizer()
        {
            Student student = new ("asfaq", "Tenth", "12");

            SerializationAPI serializationAPI = new SerializationAPI();

            serializationAPI.SerializeData(student);

            serializationAPI.SerializeToStringUsingReflection(student);
        }
    }
}
