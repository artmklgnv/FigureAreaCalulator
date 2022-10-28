using FigureAreaCalulator;
using FigureAreaCalulator.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorTest
{
    public class AreaCalcuatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GIVEN_AreaCalculator_WHEN_Calculate_method_is_invoked_WITH_correct_triangle_THEN_correct_value_is_returned()
        {
            Triangle triangle = new Triangle(2, 3, 4);
            double actual = Math.Round(AreaCalculator.Calculate(triangle), 2);
            Assert.That(actual, Is.EqualTo(2.90));
        }

        [Test]
        public void GIVEN_AreaCalculator_WHEN_Calculate_method_is_invoked_WITH_correct_triangle_THEN_incorrect_value_is_returned()
        {
            Triangle triangle = new Triangle(2, 3, 4);
            double actual = Math.Round(AreaCalculator.Calculate(triangle), 2);
            Assert.That(actual, Is.Not.EqualTo(12345));
        }

        [Test]
        public void GIVEN_AreaCalculator_WHEN_Calculate_method_is_invoked_WITH_incorrect_triangle_THEN_exeption_returned()
        {
            Triangle triangle = new Triangle(1, 2, 3);
            var ex = Assert.Throws<Exception>(() => AreaCalculator.Calculate(triangle));
            Assert.That(ex.Message, Is.EqualTo("The sum of the two sides of the triangle must be greater than the third."));
        }


        [Test]
        public void GIVEN_AreaCalculator_WHEN_Calculate_method_is_invoked_WITH_correct_circle_THEN_correct_value_is_returned()
        {
            Circle circle = new Circle(2);
            double actual = Math.Round(AreaCalculator.Calculate(circle), 2);
            Assert.That(actual, Is.EqualTo(12.57));
        }

        [Test]
        public void GIVEN_AreaCalculator_WHEN_Calculate_method_is_invoked_WITH_correct_circle_THEN_incorrect_value_is_returned()
        {
            Circle circle = new Circle(2);
            double actual = Math.Round(AreaCalculator.Calculate(circle), 2);
            Assert.That(actual, Is.Not.EqualTo(12345));
        }

        [Test]
        public void GIVEN_AreaCalculator_WHEN_Calculate_method_is_invoked_WITH_incorrect_circle_THEN_exeption_returned()
        {
            Circle circle = new Circle(0);
            var ex = Assert.Throws<Exception>(() => AreaCalculator.Calculate(circle));
            Assert.That(ex.Message, Is.EqualTo("Radius must be greater than 0"));
        }
    }
}
