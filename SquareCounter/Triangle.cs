using SquareCounter.Abstractions;
using SquareCounter.Exceptions;
using System;

namespace SquareCounter
{
    public class Triangle : IFigure
    {
        //поля могут быть свойствами при необходимости
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        private readonly bool _isRight;

        public Triangle(double sideA, double sideB, double sideC)
        {
            //Здесь можно бы было обрабатывать исключение
            if (IsPossible(sideA, sideB, sideC))
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
                _isRight = IsRight(sideA, sideB, sideC);
            }
        }

        public double Square()
        { 
            //можно было бы добавить расчет площади прямоугольного треугольника по 2 сторонам
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        private bool IsPossible(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new ImpossibleTriangleException("длина сторон(ы) меньше 0");
            }

            if (sideA > (sideB + sideC) || sideB > (sideA + sideC) || sideC > (sideA + sideB))
            {
                throw new ImpossibleTriangleException("сторона больше суммы двух других сторон");
            }

            return true;
        }

        private bool IsRight(double sideA, double sideB, double sideC)
        {
            if (sideA == Math.Sqrt(Math.Pow(sideB, 2) + Math.Pow(sideC, 2)) ||
                sideB == Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideC, 2)) ||
                sideC == Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)))
            {
                return true;
            }

            return false;
        }
    }
}
