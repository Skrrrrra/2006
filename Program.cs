using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BadenSLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputpath = "D:\\SolutionsForSpaceApp\\2006\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2006\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            int n = Convert.ToInt32(File.ReadAllText(inputpath));


            double tempduim = n / 2;
            double tempft = tempduim / 12;

            double ft = Math.Floor(tempft);
            double duim = tempduim - tempduim % 2;

            string output = ft + " " + duim;

            File.WriteAllText(outputpath, output);

        }
    }
}
