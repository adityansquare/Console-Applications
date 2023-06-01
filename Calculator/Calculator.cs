using Calculator.TypesOfCalculators;
using System;

namespace Calculator {
    public class Calculator {
        public static void Main(string[] args) {
            Console.WriteLine("\n********* Calculator *********");
            Console.WriteLine("-------------------------------");

            bool continueCalculating = true;
            bool isBack = false;

            while (continueCalculating) {
                Console.WriteLine("\nSelect the operation:");
                Console.WriteLine("  1. Perform Basic Operations such as Addition, Subtraction, Multiplication, Division & Modulus");
                Console.WriteLine("  2. Perform Advance Operations such as Square, Cube, Square Root, Cube Root, Factorial, 10^x of a Number");
                Console.WriteLine("  3. Exit");

                Console.Write("  Enter your choice (1-3): ");
                string choice = Console.ReadLine();

                switch (choice) {
                    case "1":
                        SimpleCalculator simpleCalc = new SimpleCalculator();
                        isBack = simpleCalc.Execute();
                        break;
                    case "2":
                        AdvanceCalculator advanceCalc = new AdvanceCalculator();
                        isBack = advanceCalc.Execute();
                        break;
                    case "3":
                        Console.WriteLine("\nGoodbye!");
                        continueCalculating = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.\n");
                        break;
                }

                if (continueCalculating && !isBack) {
                    Console.WriteLine("  Do you want to continue? (Y/N)");
                    string continueChoice = Console.ReadLine();
                    continueCalculating = (continueChoice.ToLower() == "y");
                    Console.WriteLine();
                }
                else if (isBack) {
                    isBack = false;
                }
            }
        }
    }
}
