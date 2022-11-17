namespace _02_ComGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printservice = new PrintService<int>();
            Console.Write("How many values? ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int values = int.Parse(Console.ReadLine());
                printservice.AddValue(values);
            }
            printservice.Print();
            Console.WriteLine("First: " + printservice.Fisth());
        }
    }
}