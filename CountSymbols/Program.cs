namespace CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку:");
            string symbols = Console.ReadLine();
            Count.Count count = new Count.Count(symbols);
            Console.WriteLine($"Количество различных символов в строке: {count.Symbols().ToString()}");
            Console.WriteLine($"Количество различных букв в строке: {count.Letters().ToString()}");
            Console.WriteLine($"Количество различных цифр в строке: {count.Numbers().ToString()}");
        }
    }
}