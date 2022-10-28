using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FigureAreaCalulator.Figures.Interfaces;

namespace FigureAreaCalulator.Figures
{
    public class Triangle : ITriangle
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double sideC { get; set; }

        List<double> AllSides { get 
            {
                return new List<double>() { SideA, SideB, sideC }.OrderByDescending(s => s).ToList();
            } 
        }

        /// <summary>
        /// Triangle by three sides
        /// </summary>
        /// <param name="sideLengthA">Lengths of the A side</param>
        /// <param name="sideLengthB">Lengths of the B side</param>
        /// <param name="sideLengthC">Lengths of the C side</param>
        public Triangle(double sideLengthA, double sideLengthB, double sideLengthC)
        {
            SideA = sideLengthA;
            SideB = sideLengthB;
            sideC = sideLengthC;
        }

        /// <summary>
        /// Calculate area by three sides
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            CheckIsCorrect();
            double semiPerimeter = (SideA + SideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - sideC));
            return area;
        }

        /// <summary>
        /// Determine if the triangle is a right triangle
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            CheckIsCorrect();
            List<double> allSidesInSquare = AllSides.Select(s => s * s).ToList();
            bool result = allSidesInSquare[0] == allSidesInSquare[1] + allSidesInSquare[2];
            return result;
        }

        /// <summary>
        /// Сheck if the triangle is correct 
        /// </summary>
        /// <returns></returns>
        public bool IsCorrect()
        {
            return AllSides[0] < AllSides[1] + AllSides[2];
        }

        /// <summary>
        /// Сheck if the triangle is correct and throw an exception if it is not
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CheckIsCorrect()
        {
            if (!IsCorrect())
            {
                throw new Exception("The sum of the two sides of the triangle must be greater than the third.");
            }
        }
    }
}
