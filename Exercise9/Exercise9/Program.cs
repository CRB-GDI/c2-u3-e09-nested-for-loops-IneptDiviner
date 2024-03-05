namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number of rows");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number of ");
            int columns = int.Parse(Console.ReadLine());
            string ast = "*";
            Console.WriteLine(" | ");
            Console.WriteLine(" V ");
            Console.WriteLine(" ");

            for (int col = 0; columns > col; col++)
            {
            
                for (int row = 0; rows > row; row++)
                {
                    Console.Write(ast);
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("Now onto a triangle.");
            Console.WriteLine("Please enter a height for the right triangle.");
            int height = int.Parse(Console.ReadLine());
            for (int heightTwo = 0; heightTwo < height; heightTwo++)
            {
                Console.Write("*");
                for (int heightThree = 0; heightThree < heightTwo; heightThree++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}