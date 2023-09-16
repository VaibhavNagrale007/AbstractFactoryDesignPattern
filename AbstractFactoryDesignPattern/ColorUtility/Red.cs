/******************************************************************************
 * Filename    = Red.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Concrete implementation of the IColor interface for Red color.
 *****************************************************************************/

namespace AbstractFactoryDesignPattern.ColorUtility
{
    /// <summary>
    /// Concrete implementation of the IColor interface for Red color.
    /// </summary>
    public class Red : IColor
    {
        /// <summary>
        /// Prints when Red Fill Methond is called.
        /// </summary>
        public void Fill()
        {
            Console.WriteLine("Inside Red Fill Method.");
        }
    }
}
