namespace DataValidApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Validation App");
            char redo;
            //there isn't a straight up data validation project in the book, so I'm making a version of the perimeter calc with it
            double length = 0;
            double width = 0;
            do
            {
                Console.Write("\nEnter Length: ");
                //double length = double.Parse(Console.ReadLine());
                while(!double.TryParse(Console.ReadLine(), out length))
                {
                    Console.WriteLine("Invalid format, please enter a number!");
                }
                
                Console.Write("\nEnter Width: ");
                while (!double.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Invalid format, please enter a number!");
                }


                double perimeter = (width * 2) + (length * 2);
                double area = width * length;

                Console.WriteLine($"\nThe perimeter of your rectangle is: {perimeter}" +
                    $"\nThe area of your rectangle is: {area}");

                Console.Write("\n\nWould you like to go again? (y/n): ");
                while (!char.TryParse(Console.ReadLine(), out redo) && redo != 'y' && redo != 'n')
                {
                    Console.WriteLine("That is not a valid input, try again please.");
                }
                //redo =Console.ReadKey().KeyChar;
                //if (redo != 'y' && redo != 'Y' && redo != 'N' && redo != 'n')
                //{
                //    Console.WriteLine("\nThat is not a valid input, try again.");
                    
                //}
                //else
                //{

                //}
            } while (redo == 'y' || redo == 'Y');
            Console.WriteLine("Goodbye!");
        }
    }
}
