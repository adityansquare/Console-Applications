using Calculator.AdvanceOperations;
using System;

namespace Calculator.TypesOfCalculators {
    internal class AdvanceCalculator {
        public bool Execute() {
            double result, num1=0;
            bool continueCalculating = true;
            while (continueCalculating) {

                Console.WriteLine("\nSelect the operation:");
                Console.WriteLine("1. Square (x^2)");
                Console.WriteLine("2. Cube (x^3)");
                Console.WriteLine("3. Square Root (√)");
                Console.WriteLine("4. Cube Root (3√)");
                Console.WriteLine("5. Factorial (x!)");
                Console.WriteLine("6. PowerOfTen (10^x)");
                Console.WriteLine("7. Go Back");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice (1-8): ");
                string choice = Console.ReadLine();

                if (choice == "7" || choice == "8") {
                    continueCalculating = false;
                }
                else {
                    Console.WriteLine("Enter the number: ");
                    num1 = GetNumberInput();
                }

                switch (choice) {
                    case "1":
                        Square square = new Square();
                        result = square.Execute(num1);
                        Console.WriteLine($"\nResult: Square of {num1} = {result}\n");
                        break;
                    case "2":
                        Cube cube = new Cube();
                        result = cube.Execute(num1);
                        Console.WriteLine($"\nResult: Cube of {num1} = {result}\n");
                        break;
                    case "3":
                        SquareRoot sqrt = new SquareRoot();
                        try {
                            result = sqrt.Execute(num1);
                            Console.WriteLine($"\nResult: Square root of {num1} = {result}\n");
                        }
                        catch (ArgumentOutOfRangeException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "4":
                        CubeRoot cubeRoot = new CubeRoot();
                        result = cubeRoot.Execute(num1);
                        Console.WriteLine($"\nResult: Cube root of {num1} = {result}\n");
                        break;
                    case "5":
                        Factorial factorial = new Factorial();
                        try {
                            result = factorial.Execute((int)num1); // Assuming num1 is a non-negative integer
                            Console.WriteLine($"\nResult: Factorial of {num1} = {result}\n");
                        }
                        catch (ArgumentOutOfRangeException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "6":
                        PowerOfTen powerOfTen = new PowerOfTen();
                        result = powerOfTen.Execute(num1);
                        Console.WriteLine($"\nResult: 10^{num1} = {result}\n");
                        break;
                    case "7":
                        return true; // Go back to Main Menu
                    case "8":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.\n");
                        break;
                }
            }
            return false; // Exit the program
        }

        static double GetNumberInput() {
            double number;
            while (true) {
                string input = Console.ReadLine();
                if (double.TryParse(input, out number)) {
                    return number;
                }
                else {
                    Console.WriteLine("Invalid input. Please enter a valid number: ");
                }
            }
        }
    }
}