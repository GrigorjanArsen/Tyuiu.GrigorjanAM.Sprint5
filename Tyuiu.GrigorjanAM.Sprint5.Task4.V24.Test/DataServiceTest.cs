using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint5.Task4.V24.Lib;
using System.IO;

namespace Tyuiu.GrigorjanAM.Sprint5.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLFDF()
        {
            string path = @"D:\Users\djura\source\repos\Tyuiu.GrigorjanAM.Sprint5\Tyuiu.GrigorjanAM.Sprint5.Task4.V24\bin\Debug\InPutDataFileTask4V24.txt";
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
