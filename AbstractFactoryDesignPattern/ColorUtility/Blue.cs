/******************************************************************************
 * Filename    = Blue.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Concrete implementation of the IColor interface for Blue color.
 *****************************************************************************/

namespace AbstractFactoryDesignPattern.ColorUtility
{
    /// <summary>
    /// Concrete implementation of the IColor interface for Blue color.
    /// </summary>
    public class Blue : IColor
    {
        /// <summary>
        /// Prints when Blue Fill Methond is called.
        /// </summary>
        public void Fill()
        {
            Console.WriteLine("Inside Blue Fill Method.");
        }
    }
}
