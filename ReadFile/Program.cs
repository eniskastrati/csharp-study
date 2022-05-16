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

        public static string [] READ_FILE(string pathToFile)
        {
            try
            {
                string[] fileContent;
                return fileContent = File.ReadAllLines(pathToFile, Encoding.UTF8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
    
}