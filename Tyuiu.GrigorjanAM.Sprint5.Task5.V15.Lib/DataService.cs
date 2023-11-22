using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GrigorjanAM.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            double min = 1000000000;
            using (StreamReader rd = new StreamReader(path))
            {
                string line;
                while ((line = rd.ReadLine())  != null)
                {
                    if (Convert.ToDouble(line) % 5 == 0 && Convert.ToDouble(line) < min)
                    {
                        min = Convert.ToDouble(line);
                    }
 
                }
                return Math.Round(min,3);
            }

        }
    }
}
