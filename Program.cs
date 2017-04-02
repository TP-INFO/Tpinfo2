using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication64
{
    class Program
    {
        

        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {

                switch (args[0])
                {
                    case "help":

                        // afficher un text de help
                        Lesmethodes.Afficherhelpe(Lesmethodes.messageduHelp);
                        
                        break;

                    case "version":
                        // afficher la version du programme

                        Lesmethodes.Messagedeversion(Lesmethodes.lemessagedeversion);
                        break;

                    case "messageencode":

                      Lesmethodes.Codé() ;

                        // lancer e decodage du systeme 
                        break;
                    case "messagedecode":

                        Lesmethodes.décrypter();

                        break;
                }
            }
            else

            {

                Console.WriteLine("ce programme fonctionne en monde invite de commande ");
            }
        }
    }
}


