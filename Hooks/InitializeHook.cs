using System;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;
using VsCodeSpecFlow.Drivers;

namespace VsCodeSpecFlow.Hooks
{
    [Binding]
    public class InitializeHook
    {
        private readonly ScenarioContext _scenarioContext;

        public InitializeHook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Initialize()
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            _scenarioContext.Set(appiumDriver.InitializeAppium());
        }

        [AfterScenario]
        public void TearDown()
        {
            _scenarioContext.Remove("Driver");
        }
    }
}
