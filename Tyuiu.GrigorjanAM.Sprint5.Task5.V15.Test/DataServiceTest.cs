using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint5.Task5.V15.Lib;
using System.IO;

namespace Tyuiu.GrigorjanAM.Sprint5.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLFDF()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V15.txt";
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
