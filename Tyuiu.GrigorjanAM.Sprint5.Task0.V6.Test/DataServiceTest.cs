using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint5.Task0.V6.Lib;
using System.IO;

namespace Tyuiu.GrigorjanAM.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"D:\Users\djura\source\repos\Tyuiu.GrigorjanAM.Sprint5\Tyuiu.GrigorjanAM.Sprint5.Task0.V6\bin\Debug\OutPutFileTask0.txt";
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists; 
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
