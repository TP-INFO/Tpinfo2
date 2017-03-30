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
            if (args.Length >= 1)
            {
                switch (args[0])
                {
                    case "encode":
                        AfficherMesEncode();
                        break;
                    case "decode":
                        AfficherMesDecode();
                        break;
                    case "help":
                        AfficherAide();
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// Méthode affichant l'aide
        /// </summary>
        public static void AfficherAide()
        {
            Console.WriteLine(" 'encode' : permet de coder en message avec une clé type de César");
            Console.WriteLine(" 'decode' : permet de décoder un message et d'afficher sa clé");
        }
        /// <summary>
        /// Méthode permettant de coder en décalant (clé de codage) une des 26 lettres de l'alphabet.
        /// </summary>
        public static void AfficherMesEncode()
        {
            do
            {
                Console.WriteLine("Veuillez entrer la phrase à encoder :");
                string phrase = Console.ReadLine();
                Console.WriteLine("Choisissez la clé de condage, un nombre entre 1 et 26 : ");
                int decal = Convert.ToInt16(Console.ReadLine());
                char[] ph = new char[phrase.Length];
                char let;
                for (int i = 0; i < phrase.Length; i++)
                {
                    let = phrase[i];
                    ph[i] = (char)(let + decal);
                    if (ph[i] > 'z')
                    {
                        ph[i] = (char)(ph[i] - 26);
                    }
                }
                Console.WriteLine(phrase);
                Console.WriteLine(ph);
                Console.WriteLine("Appuyez sur <Enter> si vous souhaitez recommencer ou n'importe quelle autre touche pour sortir");
            }
            while (Console.ReadKey().Key == ConsoleKey.Enter);
        }



        /// <summary>
        /// Méthode permettant    de trouver une phrase codée par décalage des lettres de l'alaphabet.
        /// Affiche 26 propositions de décodage et sa clé de codage correspondant au lettres de l'alphabet.
        /// </summary>
        public static void AfficherMesDecode()
        {
            do
            {
                Console.WriteLine("Saisissez la phrase codée : ");
                string phraseCodee = Console.ReadLine();
                char[] ph = new char[phraseCodee.Length];
                char let;
                int decalage;
                for (int i = 1; i <= 26; i++)
                {
                    for (int j = 0; j < phraseCodee.Length; j++)
                    {
                        let = phraseCodee[j];
                        ph[j] = (char)(let + i);
                        if (ph[j] > 'z')
                        {
                            ph[j] = (char)(ph[j] - 26);
                        }
                    }
                    decalage = i;
                    Console.Write(ph);
                    Console.WriteLine($" //  clé de décodage de : {decalage}");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Appuyez sur <Enter> si vous souhaitez recommencer ou n'importe quelle autre touche pour sortir ?");
            }
            while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

    }
}
