/******************************************************************************
 * Filename    = FactoryProducer.cs
 *
 * Author      = Vaibhav Nagrale
 *
 * Product     = AbstractFactoryDesignPattern
 * 
 * Project     = AbstractFactoryDesignPattern
 *
 * Description = Factory class for producing shape and color factories.
 *****************************************************************************/

namespace AbstractFactoryDesignPattern.Factory
{
    /// <summary>
    /// Factory class for producing shape and color factories.
    /// </summary>
    public class FactoryProducer
    {
        /// <summary>
        /// Gets a factory instance based on the provided choice.
        /// </summary>
        /// <param name="choice">The choice of factory to create.</param>
        /// <returns>An abstract factory instance.</returns>
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
