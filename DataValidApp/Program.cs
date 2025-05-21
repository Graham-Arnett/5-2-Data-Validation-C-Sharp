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
                Console.Write("\nEnter Width");

                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo =Console.ReadKey().KeyChar;
                if (redo != 'y' && redo != 'Y' && redo != 'N' && redo != 'n')
                {
                    Console.WriteLine("That is not a valid input, try again.");
                } 
            } while (redo == 'y' || redo == 'Y');
            Console.WriteLine("Goodbye!");
        }
    }
}
