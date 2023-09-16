using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.ShapeUtility
{

    /// <summary>
    /// Concrete implementation of the IShape interface for Square shape.
    /// </summary>
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square Draw Method.");
        }
    }
}
