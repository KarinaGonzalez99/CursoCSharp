using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._3.ClassesEMetodos
{
	internal class Membros
	{
		public static void Executar()
		{
            Pessoa nomeVariavel = new Pessoa();
			nomeVariavel.Nome = "Karina";
			nomeVariavel.Idade = 25;

			//Console.WriteLine($"{nomeVariavel.Nome} tem {nomeVariavel.Idade} anos!");

			nomeVariavel.ApresentarNoConsole();
        }
	}
}
