using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint5.Task6.V0.Lib;
using System.IO;

namespace Tyuiu.PanasenkoRA.Sprint5.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.PanasenkoRA.Sprint5\Tyuiu.PanasenkoRA.Sprint5.Task6.V0\bin\Debug\InPutDataFileTask6V1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\user\source\repos\Tyuiu.PanasenkoRA.Sprint5\Tyuiu.PanasenkoRA.Sprint5.Task6.V0\bin\Debug\InPutDataFileTask6V1.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    
    }
}
