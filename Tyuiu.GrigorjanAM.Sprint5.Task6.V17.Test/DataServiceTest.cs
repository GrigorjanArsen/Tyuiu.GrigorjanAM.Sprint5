using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GrigorjanAM.Sprint5.Task6.V17.Lib;

namespace Tyuiu.GrigorjanAM.Sprint5.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"D:\Users\djura\source\repos\Tyuiu.GrigorjanAM.Sprint5\Tyuiu.GrigorjanAM.Sprint5.Task6.V17\bin\Debug\InPutDataFileTask6V17.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"D:\Users\djura\source\repos\Tyuiu.GrigorjanAM.Sprint5\Tyuiu.GrigorjanAM.Sprint5.Task6.V17\bin\Debug\InPutDataFileTask6V17.txt";
            
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
