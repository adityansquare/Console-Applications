using System;

namespace Calculator.SimpleOperations {
    internal class Division {
        public double Execute(double num1, double num2) {
            if (num2 == 0) {
                throw new DivideByZeroException("Error: Division by zero is not allowed.");
            }
            return num1 / num2;
        }
    }
}
