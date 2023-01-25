using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    class Home
    {
        private IWebDriver driver;
        private SearchBar search;
       
        public Home(IWebDriver driver)
        {
            this.driver = driver;  
        }

        public SearchBar SearchBar {
            get
            {
                if (this.search == null)
                {
                    this.search = new SearchBar(this.driver);
                }
                return this.search;
            }
        }

    }
}
