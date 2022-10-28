using FigureAreaCalulator.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorTest
{
    public class TriangleTests
    {
        [Test]
        public void GIVEN_Triangle_WHEN_IsRightTriangle_method_is_invoked_WITH_right_triangle_THEN_correct_value_is_returned()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            bool actual = triangle.IsRightTriangle();
            Assert.That(actual, Is.True);
        }

        [Test]
        public void GIVEN_Triangle_WHEN_IsRightTriangle_method_is_invoked_WITH_not_right_triangle_THEN_incorrect_value_is_returned()
        {
            Triangle triangle = new Triangle(5, 8, 10);
            bool actual = triangle.IsRightTriangle();
            Assert.That(actual, Is.False);
        }
    }
}
