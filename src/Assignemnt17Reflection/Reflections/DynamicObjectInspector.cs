using System.Reflection;

namespace Reflections
{
    /// <summary>
    /// Inspects the objects with relevant methods
    /// </summary>
    public class DynamicObjectInspector
    {
        /// <summary>
        /// Gets the type of the object and property
        /// </summary>
        /// <param name="obj">object</param>
        public void GetTypeof(object obj)
        {
            Type type = obj.GetType();
            var property = type.GetProperties();
            foreach (var propertyInfo in property)
            {
                Console.WriteLine($"{propertyInfo.Name} - {propertyInfo.GetValue(obj)}");
            }
        }

        /// <summary>
        /// Edits the property info
        /// </summary>
        /// <param name="obj">object of</param>
        /// <param name="propertyName">Property name to be set</param>
        /// <param name="newValue">obj1</param>
        public void EditPropertyDetails(object obj, string propertyName, object newValue)
        {
            Type type = obj.GetType();
            var isPropertyValid = type.GetProperties().
                Any(p => p.Name == propertyName);
            if (!isPropertyValid)
            {
                throw new Exception("Property is Not Defined");
            }
            else
            {
                PropertyInfo property = type.GetProperty(propertyName) !;
                property.SetValue(obj, newValue);
            }

            this.GetTypeof(obj);
        }
    }   
}
