using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo2
{
	class Program
	{
		
		static void Main(string[] args)
		{
			/// évaluation des arguments
			foreach (string arg in args)
			{
				if (args.Length >=1)
				{
					switch (arg)
					{
						case "encode":
						Dechiffrer();
							break;

						case "decode":
							Chiffrer();
							break;
						default:
							break;
					}
				}
			}

		}


			/// METHODE CHIFFRER
			/// 
		public static void Chiffrer()
		{
			// initialisation de la valeur clé de chiffrement
			int cle = 0;


			int count = 0;

			Console.Write("Veuillez rentrer la phrase à encoder:");
			string phraseCode = Console.ReadLine();

			// boucle do/while pour basé sur le nbre de clés à tester
			do
			{
				//string phraseCode = "Wtfltdxtykgfmgftwtnftmxehdxttfmbinx";
				//string phraseCode = "Ssfksdwsxjgflgfsvsmfslwehdwssflaimw";
				//string phraseCode = "kvmvyzvgzioznvhzovhjmkcjnzn";
				//Console.WriteLine(phraseCode);

				int i = 0;
				char[] tabDecod = new char[phraseCode.Length];

				foreach (char c in phraseCode)
				{
					int nChiffre = phraseCode[i];  //  i = nbre de char de la phrase
												   //Console.WriteLine(nChiffre);
					int enChiffre = nChiffre + cle;

					if (enChiffre > 122)
					{
						enChiffre = (enChiffre - 26);
					}

					i++;
					//Console.WriteLine($"lettre originale :{phraseCode[i - 1]}");
					//Console.WriteLine($" :{enChiffre}");
					char newLettre = Convert.ToChar(enChiffre);
					tabDecod[i - 1] = newLettre;
					//Console.WriteLine($"Nouvelle lettre :{newLettre}");
				}

				Console.Write("Voici le résultat: ");

				foreach (var item in tabDecod)
				{
					Console.Write($"{item}");
				}
				Console.WriteLine($" / (clé: +{count++})");

				cle++;

			} while (cle <= 25);
		}


		public static void Dechiffrer()
		{
			/// POUR CREER METHODE DECHIFFRER
			/// 
			// initialisation de la valeur clé de chiffrement
			int cle = 0;


			int count = 0;

			Console.Write("Veuillez rentrer la phrase codée:");
			string phraseCode = Console.ReadLine();

			// boucle do/while pour basé sur le nbre de clés à tester
			do
			{
				//string phraseCode = "Wtfltdxtykgfmgftwtnftmxehdxttfmbinx";
				//string phraseCode = "Ssfksdwsxjgflgfsvsmfslwehdwssflaimw";
				//string phraseCode = "kvmvyzvgzioznvhzovhjmkcjnzn";
				//Console.WriteLine(phraseCode);

				int i = 0;
				char[] tabDecod = new char[phraseCode.Length];

				foreach (char c in phraseCode)
				{
					int nChiffre = phraseCode[i];  //  i = nbre de char de la phrase
												   //Console.WriteLine(nChiffre);
					int enChiffre = nChiffre + cle;

					if (enChiffre > 122)
					{
						enChiffre = (enChiffre - 26);
					}

					i++;
					//Console.WriteLine($"lettre originale :{phraseCode[i - 1]}");
					//Console.WriteLine($" :{enChiffre}");
					char newLettre = Convert.ToChar(enChiffre);
					tabDecod[i - 1] = newLettre;
					//Console.WriteLine($"Nouvelle lettre :{newLettre}");
				}

				Console.Write("Le message est: ");

				foreach (var item in tabDecod)
				{
					Console.Write($"{item}");
				}
				Console.WriteLine($" / (clé: +{count++})");

				cle++;

			} while (cle <= 25);
		}

		// Source\Repos\Tpinfo2\Tpinfo2\bin\Debug\Tpinfo2.exe
		/// " Dans le fronton d'un temple antique,
		/// Sur le fond bleu du ciel attique,
		/// Par de lentes métamorphoses "

	}
}
