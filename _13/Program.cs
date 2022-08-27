using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilding bilding = new Bilding("jhf", "vhjjv", "klnn", "kbiio");
            Console.WriteLine(bilding.Print());
            MultiBuilding multiBuilding = new MultiBuilding("qfqf", "fqqfq", "adaa", "aafaf", "acac");
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
