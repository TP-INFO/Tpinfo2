using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo2
{
    public class Encodage
    {
        /// <summary>
        /// Initialise le programme d'encodage
        /// </summary>
        public void Initial()
        {
            Console.Write("Veuillez saisir une phrase : ");
            string ph = Console.ReadLine();
            ph.ToLower();

            Console.WriteLine("\nVoulez-vous encoder cette phrase ou la décoder ? (-E- Encode / -D- Decode)\n");

            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "E":

                    string messageToEncode = null;
                    foreach (var caract in ph)
                    {
                        messageToEncode += _encode(caract);
                    }
                    Console.WriteLine("");
                    Console.WriteLine(messageToEncode);
                    Initial();
                    break;

                case "e":

                    messageToEncode = null;
                    foreach (var caract in ph)
                    {
                        messageToEncode += _encode(caract);
                    }
                    Console.WriteLine("");
                    Console.WriteLine(messageToEncode);
                    Initial();
                    break;

                case "D":

                    string messageToDecode = null;
                    foreach (var caract in ph)
                    {
                        messageToDecode += _decode(caract);
                    }
                    Console.WriteLine("");
                    Console.WriteLine(messageToDecode);
                    Initial();
                    break;

                case "d":

                    messageToDecode = null;
                    foreach (var caract in ph)
                    {
                        messageToDecode += _decode(caract);
                    }
                    Console.WriteLine("");
                    Console.WriteLine(messageToDecode);
                    Initial();
                    break;

                default:

                    Console.WriteLine("Une erreur de saisie est survenue, veuillez recommencer");
                    Initial();
                    break;
            }
        } 

        /// <summary>
        /// Methode qui décode le message entrée
        /// </summary>
        /// <remarks>Utilisant la table ASCII</remarks>
        /// <param name="ph"></param>
        /// <returns></returns>
        private static char _decode (char caract)
        {
            int asciiChar = Convert.ToInt32(caract) + 5; //8 pour phrase n°2
            if (asciiChar > 122)
            {
                asciiChar -= 26;
            }
            caract = Convert.ToChar(asciiChar);

            return caract;
        }

        /// <summary>
        /// Méthode qui encode le message entré
        /// </summary>
        /// <remarks>Utilisant la table ASCII</remarks>
        /// <param name="ph"></param>
        /// <returns></returns>
        private static char _encode (char caract)
        {
           
            int asciiChar = Convert.ToInt32(caract) - 5;
            if (asciiChar < 97)
            {
                asciiChar += 26;
            }
            caract = Convert.ToChar(asciiChar);

            return caract;
        }


    }
}
