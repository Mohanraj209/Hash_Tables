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
            Console.WriteLine("\n Hash table demo"); //() []
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "Paranoids");
            hash.Add("1", "are not");
            hash.Add("2", "paranoid");
            hash.Add("3", "because they");
            hash.Add("4", "are");
            hash.Add("5", "but");
            hash.Add("6", "keep putting");
            hash.Add("7", "themselves");
            hash.Add("8", "deliberately");
            hash.Add("9", "into");
            hash.Add("10", "situations");

            Console.WriteLine( );
            string hash0 = hash.Get("0");
            Console.Write( hash0 + " ");
            string hash1 = hash.Get("1");
            Console.Write( hash1 + " ");
            string hash2 = hash.Get("2");
            Console.Write(hash2 + " ");
            string hash3 = hash.Get("3");
            Console.Write(hash3 + " ");
            Console.Write(hash2 + " ");
            string hash5 = hash.Get("5");
            Console.Write(hash5 + " ");
            Console.Write(hash3 + " ");
            string hash6 = hash.Get("6");
            Console.Write(hash6 + " ");
            string hash7 = hash.Get("7");
            Console.Write(hash7 + " ");
            string hash8 = hash.Get("8");
            Console.Write(hash8 + " ");
            string hash9 = hash.Get("9");
            Console.Write(hash9 + " ");
            Console.Write(hash2 + " ");
            string hash10 = hash.Get("10");
            Console.Write(hash10);
            Console.ReadKey();
        }
    }
}
