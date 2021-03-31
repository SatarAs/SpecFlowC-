using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Banque
{
    [Binding]
    public class SpecFlowFeatureDeposerSteps
    {
      
        private Account account;

        [Given(@"le client suivant")]
        public void GivenLeClientSuivant(Table table)
        {
            account = new Account();
            account.NumAccount = Int32.Parse(table.Rows[0]["numAccount"]);
            account.Solde = Double.Parse(table.Rows[0]["solde"]);
        }
        
        [When(@"ce client depose (.*)")]
        public void WhenCeClientDepose(int montant)
        {
            this.account.Deposer(montant);
        }
        
        [Then(@"tasoeurlesolde du compte est de (.*)")]
        public void ThenTasoeurlesoldeDuCompteEstDe(Decimal montant)
        {
            Assert.AreEqual(montant, this.account.Solde);
        }
    }
}
