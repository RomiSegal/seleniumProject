using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V107.CSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
     class SearchBar
     {
        private IWebDriver driver;

        public SearchBar(IWebDriver driver)
        {  
            this.driver = driver;          
        }

        public void Click()
        {   
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
        }

        public string Text
        {
            get 
            {
                var searchTextBox = this.driver.FindElement(By.Id("twotabsearchtextbox"));
                return searchTextBox.Text;
            }
            set
            {
                this.driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys(value); 
            }
        }
     }
}
