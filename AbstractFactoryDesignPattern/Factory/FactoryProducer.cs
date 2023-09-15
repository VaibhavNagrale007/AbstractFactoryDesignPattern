using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Factory
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(string choice)
        {
            AbstractFactory obj = null;

            if (choice.ToLower().Equals("shape"))
            {
                obj = new ShapeFactory();
            }
            else if (choice.ToLower().Equals("color"))
            {
                obj = new ColorFactory();
            }
            else
            {
                Console.WriteLine("Type not found.");
            }

            return obj;
        }
    }
}
