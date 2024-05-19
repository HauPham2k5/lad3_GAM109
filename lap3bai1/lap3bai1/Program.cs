using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lap3bai1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string path = "../../../example.txt";//đường dẫn
            using(FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Username:myUserName");
                    sw.WriteLine("Password:myPassword");
                }
            }
            using(var fs = new FileStream(path,FileMode.Open,FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            Console.ReadLine();
        }
    }
}
