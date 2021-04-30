using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using VsCodeSpecFlow.Drivers;

namespace VsCodeSpecFlow.StepDefinitions
{
    [Binding]
    public class AppiumSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public AppiumSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I Click On The Media Item")]
        public void GivenIClickOnTheMediaItem()
        {
            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementByXPath("//android.widget.TextView[@content-desc='Media']").Click();
        }

        [When(@"I Click On The MediaPlayer Item")]
        public void WhenIClickOnTheMediaPlayerItem()
        {
           _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementByAccessibilityId("MediaPlayer").Click();
        }

        [Then(@"results are displayed")]
        public void ThenResultsAreDisplayed()
        {
            bool t = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementById("io.appium.android.apis:id/localvideo").Displayed;
            Assert.That(t==true);
        }
    }
}
