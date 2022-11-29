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
        private IWebElement _status => _driver.FindElement(By.Id("dcep-tab-control-overlay11-статусРейса-toggle"));
        private IWebElement _airline => _driver.FindElement(By.CssSelector("#dcep-a4a628f31-d438-4cc1-8523-5a6040309ec6-flightstatus-flightStatusByFlightNumberRequest\\.airline"));
        private IWebElement _targetAirline => _driver.FindElement(By.CssSelector("#dcep-a4a628f31-d438-4cc1-8523-5a6040309ec6-flightstatus-flightStatusByFlightNumberRequest\\.airline-item-7"));
        private IWebElement _filghtNumber => _driver.FindElement(By.CssSelector("#dcep-a4a628f31-d438-4cc1-8523-5a6040309ec6-flightstatus-flightStatusByFlightNumberRequest\\.flightNumber"));
        private IWebElement _flightDate => _driver.FindElement(By.Id("dcep-a4a628f31-d438-4cc1-8523-5a6040309ec6-flightstatus-flightStatusByFlightNumberRequest.date"));
        private IWebElement _targetFlightDate => _driver.FindElement(By.CssSelector("#dcep-a4a628f31-d438-4cc1-8523-5a6040309ec6-flightstatus-flightStatusByFlightNumberRequest\\.date-item-4"));
        private IWebElement _findButton => _driver.FindElement(By.CssSelector("#dcep-tab-control-overlay11-статусРейса-section > div > div > form > div.d-flex.button-flex > button"));
        private IWebElement _hotelButton => _driver.FindElement(By.CssSelector("#dcep-tab-control-standalone9-отель-toggle"));
        private IWebElement _pointOfВestination => _driver.FindElement(By.CssSelector("#dcep-a10c1dd30-2a78-487a-9682-0065526a9424-flm-hotel-hotelQuery\\.cityName"));
        private IWebElement _calendar => _driver.FindElement(By.CssSelector("#dcep-tab-control-standalone9-отель-section > div > form > div:nth-child(1) > div:nth-child(2) > div > div.input-wrapper.only-child"));
        private IWebElement _firstDay => _driver.FindElement(By.CssSelector("body > div.modal.react-modal.modal-datepicker.modal-size-datepicker.react-modal-opened > div > div > div.modal-body > div.DayPicker.DayPicker_1.DayPicker__horizontal.DayPicker__horizontal_2 > div > div > div.DayPicker_focusRegion.DayPicker_focusRegion_1 > div.DayPicker_transitionContainer.DayPicker_transitionContainer_1.DayPicker_transitionContainer__horizontal.DayPicker_transitionContainer__horizontal_2 > div > div:nth-child(3) > div > table > tbody > tr:nth-child(1) > td:nth-child(5)"));
        private IWebElement _lastDay => _driver.FindElement(By.CssSelector("body > div.modal.react-modal.modal-datepicker.modal-size-datepicker.react-modal-opened > div > div > div.modal-body > div.DayPicker.DayPicker_1.DayPicker__horizontal.DayPicker__horizontal_2 > div > div > div.DayPicker_focusRegion.DayPicker_focusRegion_1 > div.DayPicker_transitionContainer.DayPicker_transitionContainer_1.DayPicker_transitionContainer__horizontal.DayPicker_transitionContainer__horizontal_2 > div > div:nth-child(3) > div > table > tbody > tr:nth-child(2) > td:nth-child(3)"));
        private IWebElement _searchButton => _driver.FindElement(By.CssSelector("#dcep-tab-control-standalone9-отель-section > div > form > div:nth-child(2) > div.col-md-4.text-right > button"));
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

        public LufthansaPageObject AvailableHotelsCheck(string city)
        {
            _acceptCookiesButton.Click();
            _hotelButton.Click();
            _pointOfВestination.Click();
            _pointOfВestination.SendKeys(city);
            _calendar.Click();
            _firstDay.Click();
            _lastDay.Click();
            _searchButton.Click();
            return new LufthansaPageObject(_driver);
        }
    }
}