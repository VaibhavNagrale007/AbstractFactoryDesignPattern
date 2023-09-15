using AbstractFactoryDesignPattern.ColorUtility;
using AbstractFactoryDesignPattern.ShapeUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IColor getColor(string color);
        public abstract IShape getShape(string shape);
    }
}
