using System;
using System.IO;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		string path = "logs.csv";
		string[] text = null;
		try
		{	
			StreamReader reader = new StreamReader(path);
			while(!reader.EndOfStream)
			{
				text = reader.ReadLine().Split(',');
				Console.WriteLine("\nLogged In time: \t{0}", text[0]);	
				Console.WriteLine("Logged In date: \t{0}", text[1]);	
				Console.WriteLine("Logged Out time: \t{0}", text[2]);	
				Console.WriteLine("Logged Out date: \t{0}", text[3]);	
				Console.WriteLine("Username: \t\t{0}\n", text[4]);	
			}
			
		}
		catch(Exception e)
		{
			Console.WriteLine(e.Message);
		}



		Console.ReadKey();
	}
}
