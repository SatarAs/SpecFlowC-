using System;
using TechTalk.SpecFlow;

namespace Banque
{
    [Binding]
    public class SpecFlowFeatureClientSteps
    {
        [Given(@"sclient suivant")]
        public void GivenSclientSuivant(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"ce client est sélectionné")]
        public void WhenCeClientEstSelectionne()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"solde du compte est de (.*)")]
        public void ThenSoldeDuCompteEstDe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
