namespace _1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int? age = null;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {name}, your age is {age}");

            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
        }
    }
}