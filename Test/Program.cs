using System;

namespace Test
{
    class Program
    {
      
        static void Main(string[] args)
        {
            try
            {
                double[] numbers = new double[2];
            double[] getNumbers()
            {
                
                    Console.WriteLine("Please enter two numbers to use:");
                    //Get number 1
                    Console.WriteLine("Number 1: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    //Get number 2
                    Console.WriteLine("Number 2: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    numbers[0] = num1;
                    numbers[1] = num2;

                    return numbers;
            }

            string operation = "";
            string[] validOperations = { "add", "subtract", "multiply", "divide" };
            int[] validNumbers = { 1, 2, 3, 4 };
            string getOperation()
            {
                bool valid = false;
                Console.WriteLine("What operation do you want to use?\nValid operations are:\n1. Add\n2. Subtract\n3. Multiply\n4. Divide");

                while (!valid)
                {
                    operation = Console.ReadLine();

                    if (Array.Exists(validOperations, x => x == operation.ToLower()) || Array.Exists(validNumbers, x => x == Convert.ToInt32(operation)))
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Please choose a valid operation!");
                    }
                }

                return operation;
            }

            getNumbers();
            getOperation();

            void doMath(double num1, double num2)
            {
                if (operation.ToLower() == validOperations[0] || Convert.ToInt32(operation) == 1)
                {
                  Console.WriteLine($"The result is: {Add(numbers[0], numbers[1])}");
                }
                else if (operation.ToLower() == validOperations[1] || Convert.ToInt32(operation) == 2)
                {
                   Console.WriteLine($"The result is: {Sub(numbers[0], numbers[1])}");
                }
                else if (operation.ToLower() == validOperations[2] || Convert.ToInt32(operation) == 3)
                {
                   Console.WriteLine($"The result is: {Multiply(numbers[0], numbers[1])}");
                }
                else
                {
                   Console.WriteLine($"The result is: {Divide(numbers[0], numbers[1])}");
                }
            }

            doMath(numbers[0], numbers[1]);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }



        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}