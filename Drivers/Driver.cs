using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;

namespace VsCodeSpecFlow.Drivers
{
    public class Driver
    {
        public readonly string apkFile = @"/Users/allanteague/Downloads";

        public void CreateBackground() 
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName,"Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName,"Pixel_3a_API_30_x86");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App,"/Users/allanteague/Downloads/com.afwsamples.testdpc_7.0.2-7002_minAPI21(nodpi)_apkmirror.com.apk");
        }

        public void ExecuteAction() 
        {
            
        }

        public void CheckCondition() 
        {
            
        }

    }
}
