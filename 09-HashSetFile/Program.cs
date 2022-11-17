using _09_HashSetFile.Entities;

namespace _09_HashSetFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            HashSet<LogRecords> records = new HashSet<LogRecords>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                       string username = line[0];
                        DateTime instant =DateTime.Parse( line[1]);
                        records.Add(new LogRecords(username, instant));
                   
                    }


                    Console.WriteLine("Total Users: "+records.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}