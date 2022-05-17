using System;
using System.IO;
using System.Text;

class Progam
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enis Kastrati - Linux Mint");
        string[] allText = File.ReadAllLines("text.txt");
        foreach (string Line in allText)
        {
            Console.WriteLine(Line);
        }
    }
}
