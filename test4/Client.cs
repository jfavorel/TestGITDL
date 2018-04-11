using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Client
    {
        private string nom;
        private string prenom;
        private int numero;
        
        public Client(string Nom, string Prenom, int Numero)
        {
            nom = Nom;
            prenom = Prenom;
            numero = Numero;
        }

        public string Decrire()
        {
            string description = "Je m'appelle : " + nom + " " + prenom + " J'ai le numéro: " + numero;
            return description;
        }
    }
}
