using rot13;
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Введите текст");
            Console.WriteLine();
            string enter = Console.ReadLine();
            ParseInWork13.WordEncryption(enter);
        }
    }
}