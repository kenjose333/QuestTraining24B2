using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\user\Documents\TestDirectory";
            var fileName = "data.txt";
            var filePath = path.Combine(path, fileName);
            // Directory.CreateDirectory(path);
            // File.WriteAllText(fitePath,"New text from code");
            // File.AppendAllText(fitepath,"new text from code");
            // File.AppendAllText(filePath,"new text from code");
            // File.AppendAllText(fitePath,"new text from code");
            // Directory.Delete(path);
            // Directory.Delete(path. true);
            var content = File.ReadAttText(fitePath);
            string[] contentLines = File.ReadAllLines(filePath);
            Console.WriteLine(content);
        }
    }
}
