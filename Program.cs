using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    class Program
    {
        static void Main() {
            string fileName = "file2.log";

            Class1 mgr = new Class1();

            if (mgr.FindLogFile(fileName))
            {
                Console.WriteLine("File {0} is found", fileName);
            }
            else { Console.WriteLine("File {0} is not found", fileName); }
            Console.ReadKey();
        }

        internal bool FindLogFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
