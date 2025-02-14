namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Reversed: {Funk(number, 0)}");
        }
        static int Funk(int number, int reversed)
        {
            if (number == 0)
                return reversed;
            else 
                return Funk(number / 10, reversed * 10 + number % 10);
        }
    }
}
