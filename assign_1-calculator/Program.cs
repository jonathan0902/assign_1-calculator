using System;

namespace assign_1_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float result;

                Console.WriteLine("Pick number:");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("----------------------------\n");

                Console.Write("Enter Number: ");

                string number = Console.ReadLine();

                switch (number)
                {
                    case "1":

                        Console.WriteLine("\n----------------------------");
                        Console.WriteLine("\nEnter Addition\n");
                        Console.WriteLine("----------------------------\n");

                        result = Addition();

                        Console.WriteLine("\n----------------------------\n");
                        Console.Write("Result: ");
                        Console.Write(result);
                        Console.WriteLine("\n----------------------------\n");

                        break;
                    case "2":
                        Console.WriteLine("\n----------------------------");
                        Console.WriteLine("\nEnter Subtraction\n");
                        Console.WriteLine("----------------------------\n");

                        result = Subtraction();

                        Console.WriteLine("\n----------------------------\n");
                        Console.Write("Result: ");
                        Console.Write(result);
                        Console.WriteLine("\n----------------------------\n");
                        break;
                    case "3":
                        Console.WriteLine("\n----------------------------");
                        Console.WriteLine("\nEnter Multiplication\n");
                        Console.WriteLine("----------------------------\n");

                        result = Multiplication();

                        Console.WriteLine("\n----------------------------\n");
                        Console.Write("Result: ");
                        Console.Write(result);
                        Console.WriteLine("\n----------------------------\n");
                        break;
                    case "4":
                        Console.WriteLine("\n----------------------------");
                        Console.WriteLine("\nEnter Division\n");
                        Console.WriteLine("----------------------------\n");

                        result = Division();

                        Console.WriteLine("\n----------------------------\n");
                        Console.Write("Result: ");
                        Console.Write(result);
                        Console.WriteLine("\n----------------------------\n");
                        break;
                    case "5":
                        Console.WriteLine("\n----------------------------");
                        Console.WriteLine("\nExit program\n");
                        Console.WriteLine("----------------------------\n");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nDid not understand, repat that!\n");
                        break;
                }
            }
        }

        public static float Addition()
        {
            float result;

            float[] values = new float[2];

            values = getValues(false);

            result = values[0] + values[1];

            return result;

        }

        public static float Subtraction()
        {
            float result;

            float[] values = new float[2];

            values = getValues(false);

            result = values[0] - values[1];

            return result;
        }

        public static float Multiplication()
        {
            float result;

            float[] values = new float[2];

            values = getValues(false);

            result = values[0] * values[1];

            return result;
        }

        public static float Division()
        {
            float result;

            float[] values = new float[2];

            values = getValues(true);

            result = values[0] / values[1];

            return result;
        }

        public static float[] getValues(Boolean Division)
        {
            Boolean firstNumberAcceptans = true;
            Boolean secundNumberAcceptans = true;

            float[] result = new float[2];

            do
            {
                Console.Write("Enter First Number: ");
                string line = Console.ReadLine();
                float value;

                if (float.TryParse(line, out value))
                {
                    if(!Division)
                    {
                        firstNumberAcceptans = false;
                        result[0] = value;
                    }
                    else
                    {
                        if (value != 0)
                        {
                            firstNumberAcceptans = false;
                            result[0] = value;
                        }
                        else
                        {
                            Console.WriteLine("\n----------------------------");
                            Console.WriteLine("\nCan't Divid by value 0\n");
                            Console.WriteLine("----------------------------\n");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("\n----------------------------");
                    Console.WriteLine("\nPlz, Enter a valid number\n");
                    Console.WriteLine("----------------------------\n");
                }

            } while (firstNumberAcceptans);

            Console.Write("\n");

            do
            {
                Console.Write("Enter Second Number: ");
                string line = Console.ReadLine();
                float value;

                if (float.TryParse(line, out value))
                {
                    if (!Division)
                    {
                        secundNumberAcceptans = false;
                        result[1] = value;
                    }
                    else
                    {
                        if (value != 0)
                        {
                            secundNumberAcceptans = false;
                            result[1] = value;
                        }
                        else
                        {
                            Console.WriteLine("\n----------------------------");
                            Console.WriteLine("\nCan't Divid by value 0\n");
                            Console.WriteLine("----------------------------\n");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("\n----------------------------");
                    Console.WriteLine("\nPlz, Enter a valid number\n");
                    Console.WriteLine("----------------------------\n");
                }

            } while (secundNumberAcceptans);

            return result;
        }
    }
}
