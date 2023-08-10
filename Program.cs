namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 16;
            double width = 5.1;
            Console.WriteLine(length * width);
            int area = width * length;
            //hvis man prøver at gange 16 med 5.1 så giver det et kommatal hvilket ikke kan ligge i en int
            double d = width * length;
            //her ganger man 16 med 5.1 igen, men ligger det ind i en double i stedet hvilket godt kan lade sig gøre
        }
    }
}