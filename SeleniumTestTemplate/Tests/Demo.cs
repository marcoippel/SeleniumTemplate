using System;
using FluentAssertions;
using NUnit.Framework;
using SeleniumTestTemplate.Business;
using SeleniumTestTemplate.Enums;
using SeleniumTestTemplate.Helpers;
using SeleniumTestTemplate.Models;

namespace SeleniumTestTemplate.Tests
{
    [TestFixture(Devices.Ipad)]
    [TestFixture(Devices.Iphone6)]
    public class Demo : SeleniumBase
    {
        private Devices _device;
        public Demo(Devices device)
        {
            this._device = device;
        }

        private const string Url = "/";

        [SetUp]
        public void Initialize()
        {
            SetupDriver();
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.Quit();
        }

        [Test]
        public void SearchOnGoogle()
        {
            DeviceModel model = Device.Get(_device);
            Driver.Manage().Window.Size = model.ScreenSize;
            SetupMobileDriver(model.UserAgent);

            Goto(Url);
            Driver.GetElementByAttribute(ElementType.Input, AttributeType.Class, "gsfi").SendKeys("Selenium tests");
            Driver.GetElementByAttribute(ElementType.Button, AttributeType.Class, "lsb").Click();

            const int expectedResult = 5;
            int actualResult = Driver.GetElementsByAttribute(ElementType.Li, AttributeType.Class, "g").Count;

            actualResult.Should().BeGreaterOrEqualTo(expectedResult);
        }
    }
}
