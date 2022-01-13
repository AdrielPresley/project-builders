using System;
using ExampleBuilders.Models;

namespace ExampleBuilders
{
	class Program
	{
		static void Main(string[] args)
		{
			Data data = new Data();
			data.SetMes(5);

			data.ApresentarMes();

			//Log log = Log.GetInstance();

			//log.PropriedadeLog = "Teste instancia";

			//Log log2 = Log.GetInstance();
			//System.Console.WriteLine(log2.PropriedadeLog);

			//Aluno p1 = new Aluno("Pedro", "Oliveira", ".NET");
			//p1.Apresentar();
		}
	}
}

