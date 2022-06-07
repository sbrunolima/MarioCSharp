using System;

namespace mario
{
    class MainClass
    {
        //Validate the number
        public static int isNumber(String userInput)
        {
            int number;

            try
            {
                number = int.Parse(userInput);
            }
            catch
            {
                number = -1;
            }
            return number;
        }


        public static void Main(string[] args)
        {
            int height;
            string userInput;


            do
            {
                Console.Write("Height: ");
                userInput = Console.ReadLine();
                height = isNumber(userInput);
            } while (height < 1 || height > 8); 

            for (int i = 0; i < height; i++)
            {
                for (int j = height - 1; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int y = -1; y < i; y++)
                {
                    Console.Write("#");
                }

                Console.Write("  ");

                for (int x = -1; x < i; x++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
