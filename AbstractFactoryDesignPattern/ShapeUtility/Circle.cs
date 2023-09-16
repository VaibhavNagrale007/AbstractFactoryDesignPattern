using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.ShapeUtility
{
    /// <summary>
    /// Concrete implementation of the IShape interface for Circle shape.
    /// </summary>
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle Draw Method.");
        }
    }
}
