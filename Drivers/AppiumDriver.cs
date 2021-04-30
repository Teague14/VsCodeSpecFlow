using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;

namespace VsCodeSpecFlow.Drivers
{
    public class AppiumDriver
    {
        private AppiumDriver<AppiumWebElement> Driver { get; set; }

        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName,"Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.Udid,"192.168.1.226:5555");
            //driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName,"Pixel_3a_API_30_x86");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App,"/Users/allanteague/Downloads/ApiDemos-debug.apk");
            var AppiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingPort(4723).Build();
            AppiumService.Start();
            return new AndroidDriver<AppiumWebElement>(AppiumService, driverOptions);
        }

    }
}
