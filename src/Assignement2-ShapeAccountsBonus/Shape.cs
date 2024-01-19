namespace Assignments
{
   /// <summary>
   /// This is a class whcih is public and have Shape as its property and Two methods as CalculateArea and PrintDetails
   /// </summary>
    public abstract class Shape
    {
        private string _colour;
        private string _shape_name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// This is a Constructor
        /// </summary>
        /// <param name="name">j</param>
        public Shape(string name)
        {
            this._colour = name;
        }

        /// <summary>
        /// ftghf
        /// </summary>
        /// <returns>kd</returns>
        public abstract double CalculateArea();

        /// <summary>
        /// Funtion to Print the details of the shapes i.e. color and area
        /// </summary>
        public abstract void PrintDetails();
    }
}