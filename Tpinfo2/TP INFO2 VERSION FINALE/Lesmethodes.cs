using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication64
{
    class Lesmethodes
    {
        static public string messageduHelp = "veuillez essayer les  decallage jusqua trouver votre mot de passe ";
        static public string lemessagedeversion = "la nouvelle version est 1.1";

        internal static void décrypter() 
        {
        ee: try
            {
                Console.WriteLine("donner une phrase svp ");// je demande a l'utilisateur d'ecrire une phrase
                string phrase = Console.ReadLine();

                int clédecallage = 0;

                do
                {
                    char[] tableauesdescaracterecodé = new char[phrase.Length];
                    int i = 0;
                    foreach (char caractere in phrase)
                    {
                        int chiffreducaractere = phrase[i];// je converti chaque caractere a une valeur numerique 
                        int newchiffre = chiffreducaractere + clédecallage;//  Chaque chiffre va avoir un decallage pour avoir un nouveau code

                        if (newchiffre > 122) // 122 est le ode asci assoucié a la lettre z 
                        {
                            newchiffre -= 26;// cette condition permet de rentrer a la lettre a si on depasse la lettre z 
                        }
                        i++;
                        char newlettre = Convert.ToChar(newchiffre); // je conerti chaquevaleur nummerique a sont caractere assooucié 


                        tableauesdescaracterecodé[i - 1] = newlettre; // les nouvelle lettre seront classé dans un tableau 
                    }
                    Console.WriteLine(clédecallage);
                    foreach (char newlettre in tableauesdescaracterecodé)
                    {
                        Console.Write(newlettre);
                    }
                    Console.WriteLine("");
                    clédecallage++;
                }
                while (clédecallage <= 26);
            }


            catch (Exception e)
            {
                Console.WriteLine("essaie erroné ...rennové la saisie ");
            }
            finally
            {
                Console.WriteLine("votre mot décrypter exciste dans les 26 proposition ci-dessus ");
                Console.WriteLine("$$$$$$$$ merci d'avoir utiliser ce programme $$$$$$$");
            }


        }
        internal static void Afficherhelpe(string lemessagedehelpe) 
        {
            Console.WriteLine(messageduHelp);
        }
        internal static void Messagedeversion(string lemessagedeversion)
        {
            Console.WriteLine(lemessagedeversion);
        }
        internal static void Codé()
        {
        ee: try
            {
                Console.WriteLine("donner votre mot a codé svp ");// je demande a l'utilisateur d'ecrire une phrase
                string phrase = Console.ReadLine();

                int clédecallage = 0;

                do
                {
                    char[] tableauesdescaracterecodé = new char[phrase.Length];
                    int i = 0;
                    foreach (char caractere in phrase)
                    {
                        int chiffreducaractere = phrase[i];// je converti chaque caractere a une valeur numerique 
                        int newchiffre = chiffreducaractere + clédecallage;//  Chaque chiffre va avoir un decallage pour avoir un nouveau code

                        if (newchiffre > 122) // 122 est le ode asci assoucié a la lettre z 
                        {
                            newchiffre += 26;// cette condition permet de rentrer a la lettre a si on depasse la lettre z 
                        }
                        i++;
                        char newlettre = Convert.ToChar(newchiffre); // je conerti chaquevaleur nummerique a sont caractere assooucié 


                        tableauesdescaracterecodé[i - 1] = newlettre; // les nouvelle lettre seront classé dans un tableau 
                    }
                    Console.WriteLine(clédecallage);
                    foreach (char newlettre in tableauesdescaracterecodé)
                    {
                        Console.Write(newlettre);
                    }
                    Console.WriteLine("");
                    clédecallage++;
                }
                while (clédecallage <= 26);
            }


            catch (Exception e)
            {
                Console.WriteLine("essaie erroné ...rennové la saisie ");
            }
            finally
            {
                Console.WriteLine("votre mot codé exciste dans les 26 proposition ci-dessus ");
                Console.WriteLine("$$$$$$$$ merci d'avoir utiliser ce programme $$$$$$$");
            }
        }


    }

    }


