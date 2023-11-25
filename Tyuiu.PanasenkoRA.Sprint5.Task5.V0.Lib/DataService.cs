using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PanasenkoRA.Sprint5.Task5.V0.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 2;i< Convert.ToDouble(line); i++)
                    {
                        if (((Convert.ToDouble(line) % Convert.ToDouble(line) == 0) && (Convert.ToDouble(line) % i != 0)) && (Convert.ToDouble(line) > i))
                        {
                            res = res + Convert.ToDouble(line);
                        }
                    }
                }
            }
            return res; 
        }
    }
}
