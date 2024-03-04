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

        }
    }
}