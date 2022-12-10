using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashh = new Hashtable();
            hashh.Add("1", "bara-bara-bara");
            hashh.Add("2", "beri-beri-beri");

            Console.WriteLine("Ключ присутсвует в таблице со значением");
            Console.WriteLine(hashh.ContainsKey("1"));
            Console.WriteLine(hashh.ContainsValue("bara-bara-bara"));
            Console.WriteLine();

            Console.WriteLine("Ключ присутсвует в таблице без значения");
            Console.WriteLine(hashh.ContainsKey("2"));
            Console.WriteLine(hashh.ContainsValue(" "));
            Console.WriteLine();

            Console.WriteLine("Ключ отсутствует, но значение присутсвует");
            Console.WriteLine(hashh.ContainsKey("4"));
            Console.WriteLine(hashh.ContainsValue("beri-beri-beri"));
            Console.ReadKey();
        }
    }
}
