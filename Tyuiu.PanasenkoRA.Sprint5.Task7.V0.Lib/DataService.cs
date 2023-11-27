using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PanasenkoRA.Sprint5.Task7.V0.Lib
{
    public class DataService : ISprint5Task7V17
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V17.txt";
            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSave);
            }

            string strline = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != 'н') || (((line[i] == 'н') && (line[i + 1] != 'н') && (line[i - 1] != 'н'))))
                        {
                            strline += line[i];
                        }
                    }
                    File.AppendAllText(pathSave, strline + Environment.NewLine);
                    strline = "";
                }
            }
            return pathSave;
        }
    }
}
