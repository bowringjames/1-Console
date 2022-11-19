namespace _1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine($"Hello {name}, your age is {age}");

            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
        }
    }
}