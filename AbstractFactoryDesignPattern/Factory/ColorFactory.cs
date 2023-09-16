/******************************************************************************
 * Filename    = ColorFactory.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Concrete factory class for creating color objects.
 *****************************************************************************/

using AbstractFactoryDesignPattern.ColorUtility;
using AbstractFactoryDesignPattern.ShapeUtility;

namespace AbstractFactoryDesignPattern.Factory
{
    /// <summary>
    /// Concrete factory class for creating color objects.
    /// </summary>
    public class ColorFactory : AbstractFactory
    {
        /// <summary>
        /// Override GetShape
        /// </summary>
        /// <param name="shape">The type of shape to create.</param>
        /// <returns>Null as we are inside ColorFactory.</returns>
        public override IShape GetShape(string shapeType)
        {
            return null;
        }

        /// <summary>
        /// Override GetColor
        /// </summary>
        /// <param name="shape">The type of shape to create.</param>
        /// <returns>A concrete color object.</returns>
        public override IColor GetColor(string color)
        {
            IColor obj = null;

            if (color.ToLower().Equals("red"))
            {
                obj = new Red();
            }
            else if (color.ToLower().Equals("green"))
            {
                obj = new Green();
            }
            else if (color.ToLower().Equals("blue"))
            {
                obj = new Blue();
            }
            else
            {
                Console.WriteLine("Type not found.");
            }

            return obj;
        }
    }
}
