namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a row width");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a row quantinty");
            int quantity = int.Parse(Console.ReadLine());
            string ast = "*";
            for (int countRowHeight = 0; countRowHeight < row; countRowHeight++)
            {
                Console.WriteLine(ast);
                for (int countRowWidth = 1; countRowWidth < row; countRowWidth++)
                { 
                    Console.Write(ast);
                }
            }
        }
    }
}