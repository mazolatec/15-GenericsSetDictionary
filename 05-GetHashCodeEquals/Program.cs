using _05_GetHashCodeEquals.Entities;

namespace _05_GetHashCodeEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client { Name="Emilio", Email="mazolatec@gmail.com" };
            Client client1 = new Client { Name = "Mazola", Email ="mazolatec@gmail.com" };

            Console.WriteLine(client.Equals(client1));

            Console.WriteLine(client.GetHashCode());
            Console.WriteLine(client1.GetHashCode());
        }
    }
}