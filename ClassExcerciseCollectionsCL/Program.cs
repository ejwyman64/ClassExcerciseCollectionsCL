using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcerciseCollectionsCL
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileParser parser = new FileParser();

            var dataCatcher = parser.Read("../../../data.txt");

            for (int i = 0; i < dataCatcher.Length; i++)
            {
                Console.WriteLine(dataCatcher[i]);
            }

            Console.ReadKey();

        }
    }
}
