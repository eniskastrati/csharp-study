using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace LocalFIleEditor
{
    class  Program
    {
        static void Main(string[] args)
        {
            string path = "dhcp.txt";
            string[] dhcpText = CHANGE_FILE(path);

            foreach (var VARIABLE in dhcpText)
            {
                Console.WriteLine(VARIABLE);
            }
            
            
            Console.ReadKey();
        }

        public static string[] CHANGE_FILE(string pathToFile)
        {
            string[] fileContent = null;
            try
            {
                fileContent = File.ReadAllLines(pathToFile, Encoding.UTF8);
                for (int i = 0; i < fileContent.Length; i++)
                {
                    fileContent[i] = fileContent[i].Replace('-', ':');
                }
                File.WriteAllLines("dhcp.cfg", fileContent, Encoding.UTF8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return fileContent;
        }
        
    }
}