using System;
using System.IO;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		string path = "file.txt";
		string text = null;
		try
		{	
			StreamReader reader = new StreamReader(path);
			while(!reader.EndOfStream)
			{
				text = reader.ReadLine();
				Console.WriteLine(text);	
			}
			
		}
		catch(Exception e)
		{
			Console.WriteLine(e.Message);
		}



		Console.ReadKey();
	}
}
