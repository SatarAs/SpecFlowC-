using System;
using TechTalk.SpecFlow;

namespace Banque
{
    [Binding]
    public class SpecFlowFeatureRetirerSteps
    {
        [Given(@"leclient suivant")]
        public void GivenLeclientSuivant(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"client retirer (.*)")]
        public void WhenClientRetirer(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"ta soeurlesolde du compte est de (.*)")]
        public void ThenTaSoeurlesoldeDuCompteEstDe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
