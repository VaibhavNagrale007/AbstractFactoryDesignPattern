using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactoryDesignPattern.Factory;
using AbstractFactoryDesignPattern.ColorUtility;
using AbstractFactoryDesignPattern.ShapeUtility;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for Abstract Factory Pattern.
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Test ColorFactory_GetColor_ShouldReturnRed_WhenGivenRed
        /// </summary>
        [TestMethod]
        public void ColorFactory_GetColor_ShouldReturnRed_WhenGivenRed()
        {
            AbstractFactory colorFactory = FactoryProducer.getFactory("color");

            IColor color = colorFactory.GetColor("red");

            Assert.IsInstanceOfType(color, typeof(Red));
        }

        /// <summary>
        /// Test ColorFactory_GetColor_ShouldReturnGreen_WhenGivenGreen
        /// </summary>
        [TestMethod]
        public void ColorFactory_GetColor_ShouldReturnGreen_WhenGivenGreen()
        {
            AbstractFactory colorFactory = FactoryProducer.getFactory("color");

            IColor color = colorFactory.GetColor("green");

            Assert.IsInstanceOfType(color, typeof(Green));
        }

        /// <summary>
        /// Test ColorFactory_GetColor_ShouldReturnBlue_WhenGivenBlue
        /// </summary>
        [TestMethod]
        public void ColorFactory_GetColor_ShouldReturnBlue_WhenGivenBlue()
        {
            AbstractFactory colorFactory = FactoryProducer.getFactory("color");

            IColor color = colorFactory.GetColor("blue");

            Assert.IsInstanceOfType(color, typeof(Blue));
        }

        /// <summary>
        /// Test ShapeFactory_GetShape_ShouldReturnCircle_WhenGivenCircle
        /// </summary>
        [TestMethod]
        public void ShapeFactory_GetShape_ShouldReturnCircle_WhenGivenCircle()
        {
            AbstractFactory shapeFactory = FactoryProducer.getFactory("shape");

            IShape shape = shapeFactory.GetShape("circle");

            Assert.IsInstanceOfType(shape, typeof(Circle));
        }

        /// <summary>
        /// Test ShapeFactory_GetShape_ShouldReturnSquare_WhenGivenSquare
        /// </summary>
        [TestMethod]
        public void ShapeFactory_GetShape_ShouldReturnSquare_WhenGivenSquare()
        {
            AbstractFactory shapeFactory = FactoryProducer.getFactory("shape");

            IShape shape = shapeFactory.GetShape("square");

            Assert.IsInstanceOfType(shape, typeof(Square));
        }

        /// <summary>
        /// Test ShapeFactory_GetShape_ShouldReturnRectangle_WhenGivenRectangle
        /// </summary>
        [TestMethod]
        public void ShapeFactory_GetShape_ShouldReturnRectangle_WhenGivenRectangle()
        {
            AbstractFactory shapeFactory = FactoryProducer.getFactory("shape");

            IShape shape = shapeFactory.GetShape("rectangle");

            Assert.IsInstanceOfType(shape, typeof(Rectangle));
        }

        /// <summary>
        /// Test FactoryProducer_GetFactory_ShouldReturnColorFactory_WhenGivenColor
        /// </summary>
        [TestMethod]
        public void FactoryProducer_GetFactory_ShouldReturnColorFactory_WhenGivenColor()
        {
            AbstractFactory factory = FactoryProducer.getFactory("color");

            Assert.IsInstanceOfType(factory, typeof(ColorFactory));
        }

        /// <summary>
        /// Test FactoryProducer_GetFactory_ShouldReturnShapeFactory_WhenGivenShape
        /// </summary>
        [TestMethod]
        public void FactoryProducer_GetFactory_ShouldReturnShapeFactory_WhenGivenShape()
        {
            AbstractFactory factory = FactoryProducer.getFactory("shape");

            Assert.IsInstanceOfType(factory, typeof(ShapeFactory));
        }

        /// <summary>
        /// Test FactoryProducer_GetFactory_ShouldReturnNull_WhenGivenInvalidChoice
        /// </summary>
        [TestMethod]
        public void FactoryProducer_GetFactory_ShouldReturnNull_WhenGivenInvalidChoice()
        {
            AbstractFactory factory = FactoryProducer.getFactory("invalid");

            Assert.IsNull(factory);
        }
    }
}