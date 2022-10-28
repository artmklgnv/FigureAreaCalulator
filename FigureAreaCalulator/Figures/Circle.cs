using System;
using System.Collections.Generic;
using System.Text;
using FigureAreaCalulator.Figures.Interfaces;

namespace FigureAreaCalulator.Figures
{
    public class Circle : IFigure
    {
        private double radius;

        /// <summary>
        /// Create circle by radius
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Calcuate circle area
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public double GetArea()
        {
            CheckIsCorrect();
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Сheck if the circle is correct
        /// </summary>
        /// <returns></returns>
        public bool IsCorrect()
        {
            return radius > 0;
        }

        /// <summary>
        /// Сheck if the circle is correct and throw an exception if it is not
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void CheckIsCorrect()
        {
            if (!IsCorrect())
            {
                throw new Exception("Radius must be greater than 0");
            }
        }
    }
}
