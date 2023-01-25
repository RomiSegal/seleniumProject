using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    class Amazon
    {
        private Pages pages;
        private IWebDriver driver;

        public Amazon(IWebDriver driver)
        {
            this.driver = driver;  
            this.driver.Url = "https://www.amazon.com/?language=en_US&currency=USD";
        }

        public Pages Pages { 
            get
            {
                    if(this.pages == null)
                    {
                        this.pages = new Pages(this.driver);
                    }
                    return this.pages;
            }
        }

    }
}

