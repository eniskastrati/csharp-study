using System;
using System.IO;
using System.Text;

class Progam
{
    static void Main(string[] args)
    {
        string path = "text.txt";
        Console.WriteLine("Enis Kastrati - Linux Mint");
        string[] allText = File.ReadAllLines(path);
        foreach(string Line in allText)
        {
            Console.WriteLine(Line);
        }

        // Console.Write("Please type in a number: ");
        // decimal number = Convert.ToDecimal(Console.ReadLine());

        // Console.WriteLine("You number type is : {0}", number.GetType());

        Console.ReadKey();
    }
}
