/******************************************************************************
 * Filename    = ShapeFactory.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Concrete factory class for creating shape objects.
 *****************************************************************************/

using AbstractFactoryDesignPattern.ShapeUtility;
using AbstractFactoryDesignPattern.ColorUtility;

namespace AbstractFactoryDesignPattern.Factory
{
    /// <summary>
    /// Concrete factory class for creating shape objects.
    /// </summary>
    public class ShapeFactory : AbstractFactory
    {
        /// <summary>
        /// Override GetShape
        /// </summary>
        /// <param name="shape">The type of shape to create.</param>
        /// <returns>A concrete shape object.</returns>
        public override IShape GetShape(string shapeType)
        {
            IShape obj = null;

            if (shapeType.ToLower().Equals("square"))
            {
                obj = new Square();
            }
            else if (shapeType.ToLower().Equals("rectangle"))
            {
                obj = new Rectangle();
            }
            else if (shapeType.ToLower().Equals("circle"))
            {
                obj = new Circle();
            }
            else
            {
                Console.WriteLine("Type not found.");
            }

            return obj;
        }

        /// <summary>
        /// Override GetColor
        /// </summary>
        /// <param name="shape">The type of shape to create.</param>
        /// <returns>Null as we are inside ShapeFactory..</returns>
        public override IColor GetColor(string color)
        {
            return null;
        }
    }
}
