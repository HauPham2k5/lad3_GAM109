using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lap3bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string username = "1";

            string password = "123";
            string time ="1/2/2001";
            var sw = new StringWriter();
            sw.WriteLine("Username: " + username);
            sw.WriteLine("Password: " + password);
            var content = sw.ToString();
            Console.WriteLine(content);

            // "Username: 1\nPassword: 123\n";
            var sr = new StringReader(content);
            string line1 = sr.ReadLine();
            Console.WriteLine("Line1:" + line1);
            string line2 = sr.ReadLine();
            Console.WriteLine("Line2:" + line2);


            /*string line = sr.ReadLine();
            while (line!= null)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine(sr.ReadToEnd());*/

            Console.ReadLine();
        }
    }
}
