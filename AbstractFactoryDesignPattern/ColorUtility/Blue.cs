using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.ColorUtility
{
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Blue Fill Method.");
        }
    }
}
