using System;
using ExampleBuilders.Models;

namespace ExampleBuilders
{
	class Program
	{
		static void Main(string[] args)
		{
			Log log = Log.GetInstance();

			log.PropriedadeLog = "Teste instancia";

			Log log2 = Log.GetInstance();
			System.Console.WriteLine(log2.PropriedadeLog);



			//Pessoa p1 = new Pessoa("Paulo", "Santos");
			//p1.Apresentar();
		}
	}
}

