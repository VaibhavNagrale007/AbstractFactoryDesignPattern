/******************************************************************************
 * Filename    = Circle.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Concrete implementation of the IShape interface for Circle shape.
 *****************************************************************************/

namespace AbstractFactoryDesignPattern.ShapeUtility
{
    /// <summary>
    /// Concrete implementation of the IShape interface for Circle shape.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Prints when Circle Draw Method is called.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Inside Circle Draw Method.");
        }
    }
}
