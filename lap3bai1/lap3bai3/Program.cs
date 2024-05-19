using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap3bai3
{
    public class Program
    {

        static void create(string path)
        {
            
            Directory.CreateDirectory(path);
            string filePath = Path.Combine(path, "data.txt");

            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("Mssv: 180085");
            streamWriter.WriteLine("Ho va ten:Pham Huu Hau");
            streamWriter.Dispose();    
        }
        static void copy(string sourcePath,string destinationPath)
        {
            if (Directory.Exists(destinationPath)==false)
            {
                Directory.CreateDirectory(destinationPath);
                string[]fileLith = Directory.GetFiles(sourcePath);
                foreach(string file in fileLith)
                {

                }
            }
           
        }
        static void Main(string[] args)
        {
            string path1 = "data";
            string path2 = "data2";
            create(path1);
            copy(path1, path2);
        }
    }
}
