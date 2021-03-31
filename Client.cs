using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    public class Client
    {
        private string nom { get; set; }
        private string prenom { get; set; }
        private int age { get; set; }
        private int numClient { get; set; }
        private int telephone { get; set; }

        public Client(string nom, string prenom, int age, int numClient, int telephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.numClient = numClient;
            this.telephone = telephone;
        }
    }
}
