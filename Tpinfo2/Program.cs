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
                Console.WriteLine(ph);
                Console.WriteLine(decalage);
                               
            }
            Console.WriteLine();
        }









            //if (args.Length >= 1)
            //{
            //    switch (args[0])
            //    {
            //        case "Message encode":
            //            AfficherMesEncode();
            //            break;
            //        case "Message decode":
            //            AfficherMesDecode();
            //            break;
            //        default:
            //            break;

            //    }
            //}

        
        //public static void AfficherMesEncode()
        //{

        //}

        //public static void AfficherMesDecode()
        //{

        //}

    }
}
