using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Class1
    {
        public bool FindLogFile(string fileName) {

            FileDataObject obj = new FileDataObject(); //если раскомментить,
            //то будет вызываться бд
           // TestDataObject obj = new TestDataObject();

            List<string> files = obj.GetFiles();
            foreach (var file in files)
            {
                if (file.Contains(fileName)) { return true; }
            }
            return false;
        }
    }
}
