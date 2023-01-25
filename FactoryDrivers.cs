using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
     class FactoryDrivers
    {
        public IWebDriver GetDriver(string driverType)
        {
            switch (driverType)
            {
                case "Firefox":
                    return new FirefoxDriver("C:\\Drivers\\FirefoxDriver");
                case "Chrome":
                    return new ChromeDriver("C:\\Drivers\\chromeDriver");
                case "Edge":
                    return new EdgeDriver("C:\\Drivers\\IEdriver");
                default:
                    return new ChromeDriver("C:\\Drivers\\chromeDriver");
            }
        }
    }
}
