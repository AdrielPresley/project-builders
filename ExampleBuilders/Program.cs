using System;
using ExampleBuilders.Models;

namespace ExampleBuilders
{
	class Program
	{
		static void Main(string[] args)
		{
			Pessoa p1 = new Pessoa("Paulo", "Santos");
			p1.Apresentar();
		}
	}
}

