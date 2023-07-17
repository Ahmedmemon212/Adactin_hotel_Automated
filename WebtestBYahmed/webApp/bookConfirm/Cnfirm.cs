using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebtestBYahmed
{
     class Cnfirm : corepage
    {
      By confrimtext = By.ClassName("login_title");
        By logOUT = By.XPath("/html/body/table[2]/tbody/tr[1]/td[2]/a[4]");
        By backTOlogin = By.XPath("/html/body/table[2]/tbody/tr/td[1]/table/tbody/tr/td/a");



        public void COnfrimBOOKing()
        {

          System.Threading.Thread.Sleep(6000);
          string actultext = driver.FindElements(confrimtext).ToString();
            // Assert.AreEqual("Booking Confirmation", actultext);
               driver.FindElement(logOUT).Click();
               driver.FindElement(backTOlogin).Click();
        }

    }
}
