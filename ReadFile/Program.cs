using System;
using System.Text;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //the path to our file
            string path = "data.txt";

            //save all text in this array
            string[] fileContent;
            fileContent = READ_FILE(path);
            
            //Print the array to console
            foreach (var VARIABLE in fileContent)
            {
                Console.WriteLine(VARIABLE);
            }
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
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
    
}