using FluentAssertions;
using Microsoft.Expression.Encoder.ScreenCapture;
using NUnit.Framework;
using SeleniumTestTemplate.Business;
using SeleniumTestTemplate.Enums;
using SeleniumTestTemplate.Helpers;

namespace SeleniumTestTemplate.Tests
{
    [TestFixture(Devices.Ipad)]
    [TestFixture(Devices.Nexus5)]
    [TestFixture(Devices.Desktop)]
    public class Demo : SeleniumBase
    {
        private Devices _device;
        private ScreenCaptureJob scj;
        public Demo()
        {
            this._device = Devices.Desktop;
        }

        public Demo(Devices device)
        {
            this._device = device;
        }

        private const string Url = "/";

        [SetUp]
        public void Initialize()
        {
            SetupDriver(_device);
            scj = new ScreenCaptureJob();
            scj.OutputScreenCaptureFileName = TestContext.CurrentContext.TestDirectory + "\\" + _device + ".wmv";
            scj.Start();
        }

        [TearDown]
        public void Cleanup()
        {
            scj.Stop();
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
