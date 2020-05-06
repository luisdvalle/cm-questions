using System;

namespace CMSolution.Question3
{
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException(string message) : base(message)
        {
        }
    }
}
