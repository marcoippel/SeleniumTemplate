Seleniumtest template
==============

## What is Seleniumtest template?

Selenium test template is a visualstudio template to get started with Selenium testing.

## How to get started?

* Download the [zipfile](https://github.com/marcoippel/SeleniumTemplate/tree/master/Template).
* Copy the zipfile to "%userprofile%\Documents\Visual Studio 2013\Templates\ProjectTemplates\Visual C#\Selenium".
* Add a new project to your solution based on the seleniumtest template.
* Restore the missing nuget packages.

## What is in the template
* Nunit
* FluentAssertions
* Selenium.WebDriver
* Selenium.Support
* Different devices to simulate different screen resolutions and useragents
  * Iphone4
  * Iphone5
  * Iphone6
  * Ipad
  * Nexus5
  * GalaxyS4
  * GalaxyTab
  * Desktop
* Helpers to help you to write your tests

### Version 1.0.1
* [Extra property added for device type](https://github.com/marcoippel/SeleniumTemplate/commit/e1b2d527826403eae8a6253e6175ea372ed67521)
* [Wait for ajax method added. In case of an jquery ajax call it waits till the ajax call is finished](https://github.com/marcoippel/SeleniumTemplate/commit/ee51aa7a375371d929c758250d0df2599007d0dc)

## Examples

    namespace SeleniumTestTemplate.Tests
    {
        [TestFixture(Devices.Ipad)]
        [TestFixture(Devices.Nexus5)]
        [TestFixture]
        public class Demo : SeleniumBase
        {
            private const string Url = "/";
            private Devices _device;
    
            public Demo()
            {
                this._device = Devices.Desktop;
            }
    
            public Demo(Devices device)
            {
                this._device = device;
            }
            
            [SetUp]
            public void Initialize()
            {
                SetupDriver(_device);
            }
    
            [TearDown]
            public void Cleanup()
            {
                Driver.Quit();
            }
    
            [Test]
            public void SearchOnGoogle()
            {
                Goto(Url);
                Driver.GetElementByAttribute(ElementType.Input, AttributeType.Class, "gsfi").SendKeys("Selenium tests");
                Driver.GetElementByAttribute(ElementType.Button, AttributeType.Class, "lsb").Click();
    
                const int expectedResult = 5;
                int actualResult = Driver.GetElementsByAttribute(ElementType.Li, AttributeType.Class, "g").Count;
    
                actualResult.Should().BeGreaterOrEqualTo(expectedResult);
            }
        }
    }
