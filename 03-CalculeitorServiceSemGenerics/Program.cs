namespace _03_CalculeitorServiceSemGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {List<int> list = new List<int>();  
            Console.Write("How many values? ");
            int N=int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Digite Valor {i+1}: ");
                int x=int.Parse(Console.ReadLine());
                list.Add(x);
            }
            CalculationService calculationService = new CalculationService();
           // calculationService.Max(list);
            Console.WriteLine("Max:");
            Console.Write(calculationService.Max(list));
        }
    }
}