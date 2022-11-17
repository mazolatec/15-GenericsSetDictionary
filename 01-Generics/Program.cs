using _01_Generics.Services;

namespace _01_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService printservice = new PrintService();
            Console.Write("How many values? ");
            int N=int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int values=int.Parse(Console.ReadLine());
                printservice.AddValue(values);
            }
            printservice.Print();
            Console.WriteLine("First: "+printservice.ValueFirst());
        }
    }
}