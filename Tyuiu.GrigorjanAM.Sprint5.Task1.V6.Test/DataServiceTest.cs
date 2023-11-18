using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint5.Task1.V6.Lib;
using System.IO;

namespace Tyuiu.GrigorjanAM.Sprint5.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSTFTD()
        {
            string path = @"D:\Users\djura\source\repos\Tyuiu.GrigorjanAM.Sprint5\Tyuiu.GrigorjanAM.Sprint5.Task1.V6\bin\Debug\OutPutFileTask1.txt";
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
