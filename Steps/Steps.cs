using TechTalk.SpecFlow;
using VsCodeSpecFlow.Drivers;

namespace VsCodeSpecFlow.StepDefinitions
{
    [Binding]
    public class Steps
    {
        private readonly AppiumDriver _driver;

        public Steps(AppiumDriver driver)
        {
            _driver = driver;
        }

        [Given(@"Put your Background here")]
        public void GivenPutYourBackgroundHere()
        {
            
        }

        [When(@"Put your Action here")]
        public void WhenPutYourActionHere()
        {
           
        }

        [Then(@"Put your Condition here")]
        public void ThenPutYourConditionHere()
        {
            
        }
    }
}
