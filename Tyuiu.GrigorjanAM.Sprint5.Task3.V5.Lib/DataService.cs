using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.GrigorjanAM.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
            double f = 2 * Math.Pow(x, 3) + (Math.Pow(x,2) / 2) - 3.5 * x + 2;
            f = Math.Round(f, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(f));

            }
            return path; ;
        }
    }
}
