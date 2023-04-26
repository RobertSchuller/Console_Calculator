using System;

namespace ConsoleCalculator
{
    class Program
    {
        
        #region Display
        static void Display1()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║      Console Calculator      ║");
            Console.WriteLine("╠══════════════════════════════╣");
            Console.WriteLine("╠══════════════════════════════╣");
            Console.WriteLine("║      Select an operation     ║");
            Console.WriteLine("╠══════════════════════════════╣");
            Console.WriteLine("║ 1. Addition(+)               ║");
            Console.WriteLine("║ 2. Subtraction(-)            ║");
            Console.WriteLine("║ 3. Multiplication(*)         ║");
            Console.WriteLine("║ 4. Division(/)               ║");
            Console.WriteLine("║ 5. Exponentiation(^)         ║");
            Console.WriteLine("║ 6. Modulus(%)                ║");
            Console.WriteLine("║ 7. Factorial(!)              ║");
            Console.WriteLine("║ 8. Quit(Q)                   ║");
            Console.WriteLine("╚══════════════════════════════╝");


        }

        static void Display()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║      Console Calculator      ║");
            Console.WriteLine("╠══════════════════════════════╣");
            Console.WriteLine("╠══════════════════════════════╣");
            Console.WriteLine("║     Select an operation      ║");
            Console.WriteLine("╠══════════════════════════════╣");
            Console.WriteLine("║ 1. Addition(+)               ║");
            Console.WriteLine("║ 2. Subtraction(-)            ║");
            Console.WriteLine("║ 3. Multiplication(*)         ║");
            Console.WriteLine("║ 4. Division(/)               ║");
            Console.WriteLine("║ 5. Exponentiation(^)         ║");
            Console.WriteLine("║ 6. Modulus(%)                ║");
            Console.WriteLine("║ 7. Factorial(!)              ║");
            Console.WriteLine("║ 8. Use the last result       ║");
            Console.WriteLine("║ 9. Quit(Q)                   ║");
            Console.WriteLine("╚══════════════════════════════╝");


        }
        #endregion
        static double lastResult = 0.0;
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Display();
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                Console.Clear(); //clear pentru aspect mai frumos
                Display();
                double num1, num2, result;
                switch (choice)
                {
                    case "1": //Adunare
                        Console.WriteLine("You choose Addition!");
                        num1 = GetNumberInput("\nEnter the first number: ");
                        num2 = GetNumberInput("Enter the second number: ");
                        result = Add(num1, num2);
                        DisplayResult(num1, num2, "+", result);
                        lastResult = result;
                        break;
                    case "2": // Scadere
                        Console.WriteLine("You choose Subtraction!");
                        num1 = GetNumberInput("\nEnter the first number: ");
                        num2 = GetNumberInput("Enter the second number: ");
                        result = Subtract(num1, num2);
                        DisplayResult(num1, num2, "-", result);
                        lastResult = result;
                        break;
                    case "3": // Inmultire
                        Console.WriteLine("You choose Multiplication!");
                        num1 = GetNumberInput("\nEnter the first number: ");
                        num2 = GetNumberInput("Enter the second number: ");
                        result = Multiply(num1, num2);
                        DisplayResult(num1, num2, "*", result);
                        lastResult = result;
                        break;
                    case "4": // div
                        Console.WriteLine("You choose Division!");
                        num1 = GetNumberInput("\nEnter the first number: ");
                        num2 = GetNumberInput("Enter the second number: ");
                        result = Divide(num1, num2);
                        if(result == 0)
                            Console.WriteLine("\nDivision by 0 is not allowed!");
                        else
                        {
                            DisplayResult(num1, num2, "/", result);
                            lastResult= result;
                        }
                        break;
                    case "5": //putere
                        Console.WriteLine("You choose Exponentiation!");
                        num1 = GetNumberInput("\nEnter the base number: ");
                        num2 = GetNumberInput("Enter the exponent: ");
                        result = Power(num1, num2);
                        DisplayResult(num1, num2, "^", result);
                        lastResult = result;
                        break;
                    case "6": //modulo
                        Console.WriteLine("You choose Modulus!");
                        num1 = GetNumberInput("\nEnter the first number: ");
                        num2 = GetNumberInput("Enter the second number: ");
                        result = Modulus(num1, num2);
                        DisplayResult(num1, num2, "%", result);
                        lastResult = result;
                        break;
                    case "7": //factorial
                        Console.WriteLine("You choose Factorial!");
                        num1 = GetNumberInput("\nEnter a number: ");
                        result = Factorial(num1);
                        if(result == 0)
                            Console.WriteLine("\nError: Factorial of negative numbers is not defined.");
                        else
                            DisplayResult(num1, result);
                        lastResult = result;
                        break;
                    #region last_result_case
                    case "8":
                        
                        UseLastResult(ref lastResult);
                        Console.Write("\nEnter your choice: ");
                        string choice1 = Console.ReadLine();
                        switch (choice1) // switch pt case 8 ca sa se efectueze fiecare operatie cu lastresult salvand iar rezultatul final
                        {
                            case "1":
                                Console.WriteLine("You choose Addition!");
                                num1 = lastResult;
                                num2 = GetNumberInput("\nEnter the second number: ");
                                result = Add(num1, num2);
                                DisplayResult(num1, num2, "+", result);
                                lastResult = result;
                                break;
                            case "2":
                                Console.WriteLine("You choose Subtraction!");
                                num1 = lastResult;
                                num2 = GetNumberInput("\nEnter the second number: ");
                                result = Subtract(num1, num2);
                                DisplayResult(num1, num2, "-", result);
                                lastResult = result;
                                break;
                            case "3":
                                Console.WriteLine("You choose Multiplication!");
                                num1 = lastResult;
                                num2 = GetNumberInput("\nEnter the second number: ");
                                result = Multiply(num1, num2);
                                DisplayResult(num1, num2, "*", result);
                                lastResult = result;
                                break;
                            case "4":
                                Console.WriteLine("You choose Division!!");
                                num1 = lastResult;
                                num2 = GetNumberInput("\nEnter the second number: ");
                                result = Divide(num1, num2);
                                if (result == 0)
                                    Console.WriteLine("\nDivision by 0 is not allowed!");
                                else
                                {
                                    DisplayResult(num1, num2, "/", result);
                                    lastResult= result;
                                }
                                break;
                            case "5":
                                Console.WriteLine("You choose Exponentiation!");
                                num1 = lastResult; 
                                num2 = GetNumberInput("\nEnter the exponent: ");
                                result = Power(num1, num2);
                                DisplayResult(num1, num2, "^", result);
                                lastResult = result;
                                break;
                            case "6":
                                Console.WriteLine("You choose Modulus!");
                                num1 = lastResult;
                                num2 = GetNumberInput("\nEnter the second number: ");
                                result = Modulus(num1, num2);
                                DisplayResult(num1, num2, "%", result);
                                lastResult = result;
                                break;
                            case "7":
                                Console.WriteLine("You choose Factorial!");
                                num1 = lastResult;
                                result = Factorial(num1);
                                if (result == 0)
                                    Console.WriteLine("\nError: Factorial of negative numbers is not defined.");
                                else
                                    DisplayResult(num1, result);
                                lastResult = result;
                                break;
                            case "8":
                                Console.WriteLine("You closed the calculator!");
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid input! Please enter a valid choice.");
                                break;
                        }
                        break;
                    #endregion
                    case "9": //quit
                        Console.WriteLine("You closed the calculator!");
                        Environment.Exit(0);
                        break;
                    default: // daca se adauga un nr mai mare de 9 sau o litera
                        Console.WriteLine("Invalid input! Please enter a valid choice.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
        static double UseLastResult(ref double lastResult)
        {
            Console.WriteLine($"Last Result: {lastResult}");
            Console.Write("Press ENTER to use the last result or type a new number: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) // daca input e gol last result ramane neschimbat - sau se schimba cu input
            {
                Console.Clear();
                Display1();
                if (double.TryParse(input, out double num1))
                {
                    lastResult = num1;
                    Console.WriteLine($"The first number is: {lastResult}");
                    return lastResult;
                }
                else
                {
                    Console.WriteLine($"Invalid input! Using last result: {lastResult}.");
                    return lastResult;
                }
            }
            else
            {
                Console.Clear();
                Display1();
                Console.WriteLine($"Last Result: {lastResult}");
                return lastResult;
            }
        }

        static double GetNumberInput(string message)
        {
            double number;
            bool isValid = false;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                isValid = double.TryParse(input, out number);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            } while (!isValid);

            return number;
        }
        #region display result
        static void DisplayResult(double num1, double num2, string operation, double result) //afiseaza rezultatul unei operatii matematice 
        {
            Console.WriteLine($"\n{num1} {operation} {num2} = {result}");
        }
        static void DisplayResult(double num, double result) //afiseaza rezultatul calculului factorial
        {
            Console.WriteLine($"\nFactorial of {num} = {result}"); 
        }
        #endregion
        #region Operations
        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Divide(double num1, double num2)
        {
            if(num2 == 0)
                return 0;
            else
                return num1 / num2;
        }
        static double Power(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
        static double Modulus(double num1, double num2)
        {
            return num1 % num2;
        }
        static double Factorial(double num)
        {
            if (num < 0)
                return 0;
            if (num == 0)
                return 1;
            else
                return num * Factorial(num - 1);
        }
        #endregion 
    }
}