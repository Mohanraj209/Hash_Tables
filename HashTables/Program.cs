using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class Program
    {
       public static void Main()
        {
            Console.WriteLine("-------** Hash Tables **-------");
            Console.WriteLine("Hash table demo"); //() []
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To be");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "Not to be");
            hash.Add("5", "be");
            hash.Add("5", "be 2");

            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value: " + hash5);
            string hash0 = hash.Get("0");
            Console.WriteLine("2th index value: " + hash0);
            Console.ReadKey();
        }
    }
}
