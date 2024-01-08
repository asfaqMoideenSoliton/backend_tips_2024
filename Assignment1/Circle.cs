namespace Assignments
{ 
    /// <summary>
    /// Derived Class as Circle with the base class Circle
    /// </summary>
    public class Circle : Shape
    {
        private string _colour; 
        /// <summary>
       /// This is Radius of the circle as double datatypre
       /// </summary>
        private double _radius;
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="colour">Red</param>
        /// <param name="radius">2</param>
        public Circle(string colour, double radius)
            : base(colour)
        {
            _colour = colour;
            _radius = radius;
        }
        /// <summary>
        /// This method calculates the area of the circle
        /// </summary>
        /// <returns>sd</returns>
        public override double CalculateArea()
        {
            return _radius * _radius * 3.14;
        }

        /// <summary>
        ///  This Method calls the CalculateArea() functions and print the Colour and Area
        /// </summary>
        public override void PrintDetails()
        {   
            Console.WriteLine(this._colour + ":" + CalculateArea());
        }
    }
}