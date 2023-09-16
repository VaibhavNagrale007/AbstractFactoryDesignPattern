/******************************************************************************
 * Filename    = Green.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Concrete implementation of the IColor interface for Green color.
 *****************************************************************************/

namespace AbstractFactoryDesignPattern.ColorUtility
{
    /// <summary>
    /// Concrete implementation of the IColor interface for Green color.
    /// </summary>
    public class Green : IColor
    {
        /// <summary>
        /// Prints when Green Fill Methond is called.
        /// </summary>
        public void Fill()
        {
            Console.WriteLine("Inside Green Fill Method.");
        }
    }
}
