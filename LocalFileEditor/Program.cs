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
            string path = @"./bin/Debug/net6.0/dhcp.txt";
            string[] dhcpText = CHANGE_FILE(path);
            string[] macAdresses = GET_MAC_ADRESSES("dhcp.cfg", dhcpText);

            for (int i = 0; i < dhcpText.Length; i++)
            {
                Console.WriteLine(dhcpText[i]);
				Console.WriteLine(macAdresses[i]);
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

        private static string[] GET_MAC_ADRESSES(string path, string [] configFile)
        {
            string[] dhcpAdresses = new string [configFile.Length];
            string[] ram = null;
            try
            {
                for (int i = 0; i < configFile.Length; i++)
                {
                    ram = configFile[i].Split(';');
                    dhcpAdresses[i] = ram[1];

                }
                File.WriteAllLines("macAdresses.txt", dhcpAdresses, Encoding.UTF8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return dhcpAdresses;
        }
        
    }
}
