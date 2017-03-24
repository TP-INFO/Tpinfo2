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

                Console.WriteLine("Souhaitez vous crypter ou décrypter (0/1) ?");
                string edcd = Console.ReadLine();
                Console.WriteLine("Ecrire la phrase en minuscules");
                string phrase = Console.ReadLine();
                Console.WriteLine("Indiquer le nombre pour crypter/décrypter (1-25)");
                int nombre = Convert.ToInt32(Console.ReadLine());

                if (edcd == "1")
                {
                    Console.WriteLine("La phrase décryptée est :");
                    char[] decode = decodex(phrase, nombre);
                    foreach (char item in decode)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine("");
                }

                if (edcd == "0")
                {
                    Console.WriteLine("La phrase cryptée est :");
                    char[] code = codex(phrase, nombre);
                    foreach (char item in code)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine("");
                }

            }
            static char[] decodex(string phrase, int nombre)
            {


                char[] array = phrase.ToCharArray();
                int[] array2 = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    array2[i] = Convert.ToInt32(array[i]);
                }

                for (int i = 0; i < phrase.Length; i++)
                {
                    if (array2[i] + nombre > 122)
                    {
                        array2[i] = array2[i] - 26 + nombre;
                    }
                    else array2[i] += nombre;
                }
                char[] decode = new char[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    decode[i] = Convert.ToChar(array2[i]);
                }

                return decode;
            }

            static char[] codex(string phrase, int nombre)

            {

                char[] array = phrase.ToCharArray();
                int[] array2 = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    array2[i] = Convert.ToInt32(array[i]);
                    if (array2[i] == 32) array2[i] = 97;
                    if (array2[i] - nombre < 97)
                    {
                        array2[i] = array2[i] + 26 - nombre;
                    }
                    else array2[i] -= nombre;

                }
                char[] code = new char[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    code[i] = Convert.ToChar(array2[i]);
                }

                return code;

            }
        }
    }

