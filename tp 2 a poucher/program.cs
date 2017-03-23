using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication174
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie sale = new Salarie("salah ", 300, 10014, 34000, 10);
            sale.Calculesalire();
            sale.nom = "xxxx";
            sale.matricule = "222222";
            sale.Calculesalire();

        }
    }
}
