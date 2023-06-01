using System;

namespace Calculator.AdvanceOperations {
    internal class SquareRoot {
        public double Execute(double num) {
            if (num < 0) {
                throw new ArgumentOutOfRangeException("Error: Cannot calculate square root of a negative number.");
            }
            return Math.Sqrt(num);
        }
    }
}
