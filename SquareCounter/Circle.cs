using SquareCounter.Abstractions;
using System;

namespace SquareCounter
{
    public class Circle : IFigure
    {
        //поля могут быть свойствами при необходимости
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
