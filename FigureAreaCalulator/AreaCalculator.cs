using System;
using FigureAreaCalulator.Figures.Interfaces;

namespace FigureAreaCalulator
{
    public class AreaCalculator
    {
        public static double Calculate(IFigure figure)
        {
            return figure.GetArea();
        }
    }
}
