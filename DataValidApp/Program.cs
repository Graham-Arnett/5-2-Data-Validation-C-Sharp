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
            char[] acceptChars = {'y','Y','n','N'};
            bool validChar = false;
            do
            {
                Console.Write("\nEnter Length: ");
    
                while(!double.TryParse(Console.ReadLine(), out length))
                {
                    Console.WriteLine("Invalid format, please enter a number!");
                    Console.Write("\nEnter Length: ");
                }
                
                Console.Write("\nEnter Width: ");
                while (!double.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Invalid format, please enter a number!");
                    Console.Write("\nEnter Width: ");
                }


                double perimeter = (width * 2) + (length * 2);
                double area = width * length;

                Console.WriteLine($"\nThe perimeter of your rectangle is: {perimeter}" +
                    $"\nThe area of your rectangle is: {area}");

                
                do
                {
                    Console.Write("\nWould you like to go again? (y/n): ");
                    redo = Console.ReadKey().KeyChar;
                    if (acceptChars.Contains(redo))
                    {
                        validChar = true;
                    }
                    else
                    {
                        Console.WriteLine("\nThat was not a valid input, please try again.");
                        validChar =false ;
                    }
                } while (!validChar);

            } while (redo == 'y' || redo == 'Y');
            Console.WriteLine("\n\nGoodbye!");
        }
    }
}
