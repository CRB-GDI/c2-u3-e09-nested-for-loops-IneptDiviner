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
            Console.WriteLine(" | ");
            Console.WriteLine(" V ");
            Console.WriteLine(" ");
            for (int col = 1; col <= columns; col++)
            {
                Console.Write("{0, 3}*");

            }

            
        }
    }
}