using System;
using System.IO;
using System.Text;
using System.Linq;

namespace LocalFIleEditor
{
    class  Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#############");
            Console.ReadKey();
        }

        private static string[] READ_FILE(string pathToFile)
        {
            try
            {
                string[] fileContent;
                return fileContent = File.ReadAllLines(pathToFile, Encoding.UTF8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
    }
}