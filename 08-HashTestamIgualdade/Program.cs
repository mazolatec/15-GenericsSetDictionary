using _08_HashTestamIgualdade.Entities;

namespace _08_HashTestamIgualdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> set = new HashSet<Product>();

            set.Add(new Product("Tv", 9950.00));
            set.Add(new Product("HD-7200", 10999.00));
            set.Add(new Product("Mouse-ouro", 9950.00));
            set.Add(new Product("Processador", 10999.00));
            set.Add(new Product("Font atx", 9950.00));
            set.Add(new Product("DDR4", 10999.00));



            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(5, 5));
            points.Add(new Point(2, 3));

            Product product = new Product("DDR4", 10999.00);
            Point point = new Point(5, 5);
            Console.WriteLine("Conten Point: "+points.Contains(point));
            Console.WriteLine();
            Console.WriteLine("Conten Product: "+set.Contains(product));
            Console.WriteLine();
           
            foreach (Product p in set)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}