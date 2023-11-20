using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PanasenkoRA.Sprint5.Task0.V0.Lib
{
    public class DataService : ISprint5Task0V18

    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            x = 3;
            
            double z = Math.Round((x / (Math.Sqrt(Math.Pow(x, 2) + x))), 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path; 
        }
    }
}
