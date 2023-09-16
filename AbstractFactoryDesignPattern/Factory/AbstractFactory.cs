/******************************************************************************
 * Filename    = AbstractFactory.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Abstract factory class defining methods for creating shapes and colors.
 *****************************************************************************/

using AbstractFactoryDesignPattern.ColorUtility;
using AbstractFactoryDesignPattern.ShapeUtility;

namespace AbstractFactoryDesignPattern.Factory
{
    /// <summary>
    /// Abstract factory class defining methods for creating shapes and colors.
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// Creates a color object based on the provided color name.
        /// </summary>
        /// <param name="color">The name of the color to create.</param>
        /// <returns>A concrete color object.</returns>
        public abstract IColor GetColor(string color);

        /// <summary>
        /// Creates a shape object based on the provided shape type.
        /// </summary>
        /// <param name="shape">The type of shape to create.</param>
        /// <returns>A concrete shape object.</returns>
        public abstract IShape GetShape(string shape);
    }
}
