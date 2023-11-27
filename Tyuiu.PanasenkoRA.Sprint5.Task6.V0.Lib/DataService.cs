﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PanasenkoRA.Sprint5.Task6.V0.Lib
{
    public class DataService : ISprint5Task6V1
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                foreach (char c in path)
                {
                    if (char.IsDigit(c))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
