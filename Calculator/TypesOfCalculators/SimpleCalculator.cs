using Calculator.SimpleOperations;
using System;

namespace Calculator.TypesOfCalculators {
    internal class SimpleCalculator {
        public bool Execute() {

            double num1 = 0, num2 = 0;
            bool continueCalculating = true;
            while (continueCalculating) {

                Console.WriteLine("\nSelect the operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Modulus (Mod)");
                Console.WriteLine("6. Go Back to Main Menu");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice (1-7): ");
                string choice = Console.ReadLine();

                if (choice == "6" || choice == "7") {
                    continueCalculating = false;
                }
                else {
                    Console.WriteLine("Enter the first number: ");
                    num1 = GetNumberInput();

                    Console.WriteLine("Enter the second number: ");
                    num2 = GetNumberInput();
                }

                switch (choice) {
                    case "1":
                        Addition add = new Addition();
                        double result = add.Execute(num1, num2);
                        Console.WriteLine($"\nResult: {num1} + {num2} = {result}\n");
                        break;
                    case "2":
                        Subtraction subtract = new Subtraction();
                        result = subtract.Execute(num1, num2);
                        Console.WriteLine($"\nResult: {num1} - {num2} = {result}\n");
                        break;
                    case "3":
                        Multiplication multiply = new Multiplication();
                        result = multiply.Execute(num1, num2);
                        Console.WriteLine($"\nResult: {num1} * {num2} = {result}\n");
                        break;
                    case "4":
                        Division divide = new Division();
                        try {
                            result = divide.Execute(num1, num2);
                            Console.WriteLine($"\nResult: {num1} / {num2} = {result}\n");
                        }
                        catch (DivideByZeroException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "5":
                        Modulus modulus = new Modulus();
                        result = modulus.Execute(num1, num2);
                        Console.WriteLine($"\nResult: {num1} % {num2} = {result}\n");
                        break;
                    case "6":
                        return true; // Go back to Main Menu
                    case "7":
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
