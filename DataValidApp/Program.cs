namespace DataValidApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Validation App");
            char redo;

            do
            {
                redo =Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
            Console.WriteLine("Goodbye!");
        }
    }
}
