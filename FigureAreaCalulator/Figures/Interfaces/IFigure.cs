using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaCalulator.Figures.Interfaces
{
    public interface IFigure
    {
        double GetArea();
        bool IsCorrect();
        void CheckIsCorrect();
    }
}
