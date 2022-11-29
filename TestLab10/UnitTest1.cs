using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
        private string _flightNumber = "927";
        private string _cityOfDestination = "Берлин";

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

        [Test]
        public void AvailableHotelsCheck()
        {
            var lufthansaPage = new LufthansaPageObject(_webDriver);
            lufthansaPage.AvailableHotelsCheck(_cityOfDestination);
            TearDown();
        }
    }
}