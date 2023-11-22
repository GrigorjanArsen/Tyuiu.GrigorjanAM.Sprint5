using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;

namespace Tyuiu.GrigorjanAM.Sprint5.Task4.V24.Lib
{
    public class DataService : ISprint5Task4V24
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            strx = strx.Replace(".", ",");
            double x = double.Parse(strx);
            double res = Math.Round((Math.Pow(x, -2) + 2) * Math.Sin(x), 3);
            return res;



        }
    }
}
