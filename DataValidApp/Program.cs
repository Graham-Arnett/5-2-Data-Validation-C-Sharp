namespace DataValidApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Validation App");
            char redo;
            //there isn't a straight up data validation project in the book, so I'm making a version of the perimeter calc with it
            do
            {
                Console.Write("\nEnter Length: ");
                double length = double.Parse(Console.ReadLine());
                redo =Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
            Console.WriteLine("Goodbye!");
        }
    }
}
