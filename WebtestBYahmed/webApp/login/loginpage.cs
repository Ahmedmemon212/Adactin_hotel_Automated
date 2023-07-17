using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebtestBYahmed
{
    class loginPAge : corepage
    {
        public void login(string url, string username, string password)
        {

            
            driver.Url = url;
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("login")).Click();


        }
    }
}
