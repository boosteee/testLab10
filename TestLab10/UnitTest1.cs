using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestLab10
{
    public class Tests
    {
        private IWebDriver GetChromeDriver()
        {
            return new ChromeDriver(_driverPath, new ChromeOptions());
        }
        private IWebDriver _webDriver { get; set; } = null!;
        private string _driverPath { get; set; } = @"E:\WebDrivers\Chrome";
        private string _flightNumber = "2230";

        [SetUp]
        public void SetUp()
        {
            _webDriver = GetChromeDriver();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl("https://www.lufthansa.com/by/ru/homepage");
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
            
        [Test]
        public void FlightStatusCheck()
        {
            var lufthansaPage = new LufthansaPageObject(_webDriver);
            lufthansaPage.FlightStatusCheck(_flightNumber);
            TearDown();
        }
    }
}