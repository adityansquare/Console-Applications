using System;

namespace Calculator.AdvanceOperations {
    internal class Factorial {
        public double Execute(int num) {
            if (num < 0) {
                throw new ArgumentOutOfRangeException("Error: Factorial is defined only for non-negative integers.");
            }

            double result = 1;
            for (int i = 1; i <= num; i++) {
                result *= i;
            }
            return result;
        }
    }
}
