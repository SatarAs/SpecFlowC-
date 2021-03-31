using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    public class Account
    {
        public Client Client { get; set; }
        public int NumAccount { get; set; }
        public double Solde { get; set; }

        public void Deposer(double montant)
        {
            this.Solde = this.Solde + montant;
        }

        public void Retirer(double montant)
        {
            if(this.Solde - montant >= -100) {
                this.Solde = this.Solde - montant;
            }
            else
            {
                throw new Exception("Ta plus de sous gros con");
            }
        }
    }
}
