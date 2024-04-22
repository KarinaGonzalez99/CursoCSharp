using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._3.ClassesEMetodos {
	class Carro {
		public string Modelo;
		public string Fabricante;
		public int Ano;

		public Carro(string modelo, string fabricante, int ano) {
			Modelo = modelo; // se eu quisesse por exemplo dar o como Modelo = Modelo, teria que colocar um this pra referenciar (this.Modelo = Modelo)
			Fabricante = fabricante;
			Ano = ano;
		}

		public Carro() // como definimos em cima um construtor carro, pra não dar conflito com o new Carro() que antes funcionava normal, criamos um construtor padrão sem parametro
		{

		}
	}
	internal class Construtores {
		public static void Executar() {
			var carro1 = new Carro(); // construtor padrão não recebe nenhum parametro
			carro1.Modelo = "325i";
			carro1.Fabricante = "BMW";
			carro1.Ano = 2017;
			Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

			var carro2 = new Carro("Ka", "Ford", 2018);
			Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

			var carro3 = new Carro() {
				Modelo = "Uno",
				Fabricante = "Fiat",
				Ano = 2019
			};
			Console.WriteLine($"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");
		}
	}
}
