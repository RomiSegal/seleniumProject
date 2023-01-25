using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver driver;
        public Dictionary<string, string> filters = new Dictionary<string, string>()
        {
            {"Price_Lower_Then","100"},
            {"Price_Hiegher_OR_Equal_Then","50"},
            {"Free_Shipping","true"}
        };    

        [SetUp]
        public void Setup()
        {  
            FactoryDrivers factory= new FactoryDrivers();
            this.driver=factory.GetDriver("Chrome");
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void Test1()
        {
            Amazon amazon= new Amazon(this.driver);
            amazon.Pages.Home.SearchBar.Text = "mouse";
            amazon.Pages.Home.SearchBar.Click();
            amazon.Pages.Results.GetResultsBy(this.filters);
            Assert.Pass();
        }
    }
}
