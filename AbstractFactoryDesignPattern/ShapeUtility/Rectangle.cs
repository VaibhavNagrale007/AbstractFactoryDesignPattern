﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.ShapeUtility
{
    /// <summary>
    /// Concrete implementation of the IShape interface for Rectangle shape.
    /// </summary>
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle Draw Method.");
        }
    }
}
