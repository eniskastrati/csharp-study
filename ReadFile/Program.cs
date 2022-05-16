using System;
using System.Text;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }

        public static string [] READ_FILE(sting pathToFile)
        {
            string[] fileContent;
            return fileContent = File.ReadAllLines(pathToFile, Encoding.UTF8);
        }
    }
    
}