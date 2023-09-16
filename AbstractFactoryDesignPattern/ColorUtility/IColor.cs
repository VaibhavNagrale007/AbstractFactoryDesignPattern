/******************************************************************************
 * Filename    = IColor.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Interface for defining color-related operations.
 *****************************************************************************/

namespace AbstractFactoryDesignPattern.ColorUtility
{
    /// <summary>
    /// Interface for defining color-related operations.
    /// </summary>
    public interface IColor
    {
        /// <summary>
        /// Fills an object with the color.
        /// </summary>
        void Fill();
    }
}
