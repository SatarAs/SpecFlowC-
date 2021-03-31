using System;
using TechTalk.SpecFlow;

namespace Banque
{
    [Binding]
    public class SpecFlowFeatureNegatifSteps
    {
        [Given(@"client suivant")]
        public void GivenClientSuivant(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"client retire (.*)")]
        public void WhenClientRetire(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"la transaction est refusee")]
        public void ThenLaTransactionEstRefusee()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
