using OpenQA.Selenium;

namespace TestLab10
{
    public class LufthansaPageObject
    {
        private IWebDriver _driver;
        public LufthansaPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement _acceptCookiesButton => _driver.FindElement(By.CssSelector("#cm-acceptAll"));
        private IWebElement _status => _driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div/div[3]/div/div/div/div/div[2]"));
        private IWebElement _airline => _driver.FindElement(By.CssSelector("#dcep-a526d12dd-0e23-40d2-bc10-0e0f1e94b80b-flightstatus-flightStatusByFlightNumberRequest\\.airline"));
        private IWebElement _targetAirline => _driver.FindElement(By.CssSelector("#dcep-a526d12dd-0e23-40d2-bc10-0e0f1e94b80b-flightstatus-flightStatusByFlightNumberRequest\\.airline-item-7"));
        private IWebElement _filghtNumber => _driver.FindElement(By.CssSelector("#dcep-a526d12dd-0e23-40d2-bc10-0e0f1e94b80b-flightstatus-flightStatusByFlightNumberRequest\\.flightNumber"));
        private IWebElement _flightDate => _driver.FindElement(By.CssSelector("#dcep-a526d12dd-0e23-40d2-bc10-0e0f1e94b80b-flightstatus-flightStatusByFlightNumberRequest\\.date"));
        private IWebElement _targetFlightDate => _driver.FindElement(By.CssSelector("#dcep-a526d12dd-0e23-40d2-bc10-0e0f1e94b80b-flightstatus-flightStatusByFlightNumberRequest\\.date-item-1"));
        private IWebElement _findButton => _driver.FindElement(By.CssSelector("#dcep-tab-control-overlay14-статусРейса-section > div > div > form > div.d-flex.button-flex > button"));
        public LufthansaPageObject FlightStatusCheck(string flightNumber)
        {
            _acceptCookiesButton.Click();
            _status.Click();
            _airline.Click();
            _targetAirline.Click();
            _filghtNumber.SendKeys(flightNumber);
            _flightDate.Click();
            _targetFlightDate.Click();
            _findButton.Click();
            return new LufthansaPageObject(_driver);
        }

    }
}
