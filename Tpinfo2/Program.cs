using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message
{
    class Program
    {
        static void Main(string[] args)
        {
            Decode();
            //    if (args.Length != 1)
            //    {
            //        Console.WriteLine("Quitting ...");
            //        System.Environment.Exit(0);
            //    }

            //    string helpMessage = "Utilisation : \n" +
            //                         "- message.exe decode [ pour decoder un message ]\n" + 
            //                         "- message.exe encode [ pour encoder un message ]";

            //    switch (args[0])
            //    {
            //        case "decode":
            //            Decode();
            //            break;
            //        case "encode":
            //            Encode();
            //            break;
            //        default:
            //            DisplayHelp(helpMessage);
            //            break;
            //    }







            //}
            ////public void Cryptage(char texte)
            ////{


            ////}

            //public static void DisplayHelp(string message)
            //{
            //    Console.WriteLine(message);
            //}
        }
        public static void Decode()
        {
            char[] myAlpha = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Entrer la phrase à décrypter:");
            string phraseCryptee2 = Console.ReadLine();
            char[] myPhrase = phraseCryptee2.ToCharArray(); // convertit directement en tableau de chara

            int c = myAlpha[23];
            int decalage = 5;

            foreach (char item in myPhrase)
            {
                Console.Write(item);
            }

            //for (int i = 0; i < myPhrase.Length; i++)
            //{
            //    if ('a' <= c && c <= 'z')
            //    {
            //        c = 'a' + ((myPhrase[i] - 'a') + decalage) % 26;
            //    }
            //    else if ('A' <= c && c <= 'Z')
            //    {
            //        c = 'A' + ((myPhrase[i] - 'A') + decalage) % 26;
            //    }
            //    else if ('0' <= c && c <= '9')
            //    {
            //        c = '0' + ((myPhrase[i] - '9') + decalage) % 26;
            //    }

            //    Console.Write(myPhrase[i]);
        }



        public static void Encode()
        {

            Console.WriteLine("Entrer la phrase à encrypter:");
            //string phraseCryptee2 = Console.ReadLine();
            //char[] myPhrase = phraseCryptee2.ToCharArray(); // convertit directement en tableau de char

            //int c = myPhrase[23];
            //int decalage = 5;

            //for (int i = 0; i < myPhrase.Length; i++)
            //{
            //    if ('a' <= c && c <= 'z')
            //    {
            //        c = 'a' + ((myPhrase[i] - 'a') + decalage) % 26;
            //    }dfml
            //    else if ('A' <= c && c <= 'Z')
            //    {
            //        c = 'A' + ((myPhrase[i] - 'A') + decalage) % 26;
            //    }
            //    else if ('0' <= c && c <= '9')
            //    {
            //        c = '0' + ((myPhrase[i] - '9') + decalage) % 26;
            //    }

            //    Console.WriteLine(myPhrase);
        }

    }
}

