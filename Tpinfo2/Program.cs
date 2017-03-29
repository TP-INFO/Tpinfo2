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
			string phraseCode = "Ssfksdwsxjgflgfsvsmfslwehdwssflaimw";
			//string phraseCode = "zzzzzzzzzzzzzzzzzzzzzzzzzzz";
			int i = 0;
			char[] tabDecod = new char[phraseCode.Length];
			 
			int cle = 8;


			foreach (char c in phraseCode)
			{
				int nChiffre = phraseCode[i];
				Console.WriteLine(nChiffre);
				int enChiffre = nChiffre + cle;

				if (enChiffre > 122)
				{
					enChiffre = (enChiffre + (cle - (26+cle)));
				}

				i++;
				Console.WriteLine($"lettre originale :{phraseCode[i - 1]}");
				Console.WriteLine($" :{enChiffre}");
				char newLettre = Convert.ToChar(enChiffre);
				tabDecod[i-1] = newLettre;
				Console.WriteLine($"Nouvelle lettre :{newLettre}");
			}

			

			foreach (var item in tabDecod)
			{
			Console.Write($"{item}");
			}
			Console.WriteLine(" ");

			

		}
	}
}
