/******************************************************************************
 * Filename    = IShape.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Interface for defining shape-related operations.
 *****************************************************************************/

namespace AbstractFactoryDesignPattern.ShapeUtility
{
    /// <summary>
    /// Interface for defining shape-related operations.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Draws the shape.
        /// </summary>
        void Draw();
    }
}
