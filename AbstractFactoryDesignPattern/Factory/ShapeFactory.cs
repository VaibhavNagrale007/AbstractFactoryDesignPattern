using AbstractFactoryDesignPattern.ShapeUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.ColorUtility;

namespace AbstractFactoryDesignPattern.Factory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape getShape(string shapeType)
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
        public override IColor getColor(string color)
        {
            return null;
        }
    }
}
