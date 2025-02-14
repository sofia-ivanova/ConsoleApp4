namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Funk(number)}");
        }
        static bool Funk(int number)
        {
            if (number == 1)
                return true;
            else if (number % 2 == 0)
                return Funk(number / 2);
            else
                return false;
        }

    }
}
