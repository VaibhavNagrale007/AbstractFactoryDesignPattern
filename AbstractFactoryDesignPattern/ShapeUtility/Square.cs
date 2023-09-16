/******************************************************************************
 * Filename    = Square.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Concrete implementation of the IShape interface for Square shape.
 *****************************************************************************/

namespace AbstractFactoryDesignPattern.ShapeUtility
{

    /// <summary>
    /// Concrete implementation of the IShape interface for Square shape.
    /// </summary>
    public class Square : IShape
    {
        /// <summary>
        /// Prints when Square Draw Method is called.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Inside Square Draw Method.");
        }
    }
}
