using System;

namespace SquareCounter.Exceptions
{
    public class ImpossibleTriangleException : Exception
    {
        public ImpossibleTriangleException(string message) : base("Невозможный треугольник: " + message)
        {

        }
    }
}
