using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PanasenkoRA.Sprint5.Task4.V0.Lib
{
    public class DataService : ISprint5Task4V30
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX);
            double res = Math.Round(((Math.Pow(x, 3) - Math.Tan(x)) + 2.03 * x), 3);
            return res;
        }
    }
}
