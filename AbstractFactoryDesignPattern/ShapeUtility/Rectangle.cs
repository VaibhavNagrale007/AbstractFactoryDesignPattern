/******************************************************************************
 * Filename    = Rectangle.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Concrete implementation of the IShape interface for Rectangle shape.
 *****************************************************************************/

namespace AbstractFactoryDesignPattern.ShapeUtility
{
    /// <summary>
    /// Concrete implementation of the IShape interface for Rectangle shape.
    /// </summary>
    public class Rectangle : IShape
    {
        /// <summary>
        /// Prints when Rectangle Draw Method is called.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle Draw Method.");
        }
    }
}
