using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 13, 73, 72, 68, 82, 0, 0,5, 176
            string data = "this is the text to be written to the file";
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filePath = Path.Combine(desktop, "text", "passwords.txt");

            string passwordToSearch = "yny";
            var passwords = File.ReadAllText(filePath);
            int index = 0;  
            foreach ( var passphrase in passwords)
            {
                index++;
                if(passwords == passwordToSearch)
                {
                    Console.WriteLine("Password found at indx:" + index);
                        break;
                }
            }
        }
    }
}
