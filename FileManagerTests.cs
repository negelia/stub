using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1
{
    [TestClass]
    class FileManagerTests
    {
        [TestMethod]
        public void FileManager_FindFileLogByName_1() {
            Program fileManager = new Program();
            string fileName = "mail.log";

            bool exists = fileManager.FindLogFile(fileName);

            Assert.IsTrue(exists);
        }
    }
}
