﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PanasenkoRA.Sprint5.Task7.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint5.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.PanasenkoRA.Sprint5\Tyuiu.PanasenkoRA.Sprint5.Task7.V0\bin\Debug\InPutDataFileTask7V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
