using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_22_TP_Encoder_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rentrer votre phrase!");
            string phrase = Console.ReadLine();
            Console.WriteLine("La phrase est-elle à encoder ou à decoder?");
            string transfo = Console.ReadLine();
            if (transfo == "encoder")
            {
                string messageEncode = null;
                foreach (var lettre in phrase)
                {
                    messageEncode += lettreEncodee(lettre);
                }
                Console.WriteLine(messageEncode);
            }
            else if(transfo =="decoder")
            {
                string messageDecode = null;
                foreach (var lettre in phrase)
                {
                    messageDecode += lettreDecodee(lettre);
                }
                Console.WriteLine(messageDecode);
            }
        }

        static char lettreDecodee (char lettre)
        {
            int asciiLettre = Convert.ToInt32(lettre) + 5;
            if (asciiLettre>122)
            {
                asciiLettre -= 26;
            }
            lettre = Convert.ToChar(asciiLettre);
            return lettre;
        }

        static char lettreEncodee(char lettre)
        {
            int asciiLettre = Convert.ToInt32(lettre) - 5;
            if (asciiLettre <97)
            {
                asciiLettre += 26;
            }
            lettre = Convert.ToChar(asciiLettre);
            return lettre;
        }
    }
}
