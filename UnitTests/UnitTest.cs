using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactoryDesignPattern.Factory;
using AbstractFactoryDesignPattern.ColorUtility;
using AbstractFactoryDesignPattern.ShapeUtility;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ColorFactory_GetColor_ShouldReturnRed_WhenGivenRed()
        {
            AbstractFactory colorFactory = FactoryProducer.getFactory("color");

            IColor color = colorFactory.getColor("red");

            Assert.IsInstanceOfType(color, typeof(Red));
        }

        [TestMethod]
        public void ColorFactory_GetColor_ShouldReturnGreen_WhenGivenGreen()
        {
            AbstractFactory colorFactory = FactoryProducer.getFactory("color");

            IColor color = colorFactory.getColor("green");

            Assert.IsInstanceOfType(color, typeof(Green));
        }

        [TestMethod]
        public void ColorFactory_GetColor_ShouldReturnBlue_WhenGivenBlue()
        {
            AbstractFactory colorFactory = FactoryProducer.getFactory("color");

            IColor color = colorFactory.getColor("blue");

            Assert.IsInstanceOfType(color, typeof(Blue));
        }

        [TestMethod]
        public void ShapeFactory_GetShape_ShouldReturnCircle_WhenGivenCircle()
        {
            AbstractFactory shapeFactory = FactoryProducer.getFactory("shape");

            IShape shape = shapeFactory.getShape("circle");

            Assert.IsInstanceOfType(shape, typeof(Circle));
        }

        [TestMethod]
        public void ShapeFactory_GetShape_ShouldReturnSquare_WhenGivenSquare()
        {
            AbstractFactory shapeFactory = FactoryProducer.getFactory("shape");

            IShape shape = shapeFactory.getShape("square");

            Assert.IsInstanceOfType(shape, typeof(Square));
        }

        [TestMethod]
        public void ShapeFactory_GetShape_ShouldReturnRectangle_WhenGivenRectangle()
        {
            AbstractFactory shapeFactory = FactoryProducer.getFactory("shape");

            IShape shape = shapeFactory.getShape("rectangle");

            Assert.IsInstanceOfType(shape, typeof(Rectangle));
        }

        [TestMethod]
        public void FactoryProducer_GetFactory_ShouldReturnColorFactory_WhenGivenColor()
        {
            AbstractFactory factory = FactoryProducer.getFactory("color");

            Assert.IsInstanceOfType(factory, typeof(ColorFactory));
        }

        [TestMethod]
        public void FactoryProducer_GetFactory_ShouldReturnShapeFactory_WhenGivenShape()
        {
            AbstractFactory factory = FactoryProducer.getFactory("shape");

            Assert.IsInstanceOfType(factory, typeof(ShapeFactory));
        }

        [TestMethod]
        public void FactoryProducer_GetFactory_ShouldReturnNull_WhenGivenInvalidChoice()
        {
            AbstractFactory factory = FactoryProducer.getFactory("invalid");

            Assert.IsNull(factory);
        }
    }
}