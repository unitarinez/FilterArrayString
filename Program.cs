namespace FilterArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строки через пробел:");
            string input = Console.ReadLine();

            string[] originalArray = input.Split(' ');
        }
    }
}