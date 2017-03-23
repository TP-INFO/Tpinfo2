using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication174
{
    class Salarie
    {/// <summary>
     ///  declarer les attribut 
     /// </summary>
        protected int matricule;
        protected int categorie;
        protected int service;
        protected string nom;
        protected double salaire;

        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }

        }
        public int Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        public int Service
        {
            get { return service; }
            set { service = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }





        public Salarie(string lenom, double lesalire, int lamatricule, int leservice, int lacategorie)
        {
            Categorie = lacategorie;
            Matricule = matricule;
            Service = leservice;
            Nom = lenom;
            Salaire = lesalire;
        }
        public string  Calculesalire()
        {
            return $" le salaire de {nom} est de {salaire}";

        }
       
        

    }
}