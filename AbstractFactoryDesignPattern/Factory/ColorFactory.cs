using AbstractFactoryDesignPattern.ColorUtility;
using AbstractFactoryDesignPattern.ShapeUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Factory
{
    /// <summary>
    /// Concrete factory class for creating color objects.
    /// </summary>
    public class ColorFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            return null;
        }
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
