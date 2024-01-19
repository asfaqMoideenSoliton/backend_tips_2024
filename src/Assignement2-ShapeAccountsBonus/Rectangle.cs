namespace Assignments
{ /// <summary>
/// This is a derived class rectangle from the Base class
/// </summary>
    public class Rectangle : Shape
    {
        private string _colour;

        /// <summary>
        /// This is the height of the rectangle
        /// </summary>
        private double _height;

        /// <summary>
        /// This is the width of the width
        /// </summary>
        private double _width;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="colour">df</param>
        /// <param name="height">fdfsd</param>
        /// <param name="width">ds</param>
        public Rectangle(string colour, double height, double width) 
            : base(colour)
        {
            this._colour = colour;
            this._height = height;
            this._width = width;
        }

        /// <summary>
        /// This is the Method for calculating Area
        /// </summary>
        /// <returns> Area of the Rectangle</returns>
        public override double CalculateArea()
        {
            return _height * _width;
        }

        /// <summary>
        /// This is the Methos to print the details 
        /// </summary>
        public override void PrintDetails()
        {
            Console.WriteLine(this._colour + ": " + CalculateArea());
        }
    }
}