using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebtestBYahmed
{
    class bookedhotelpage : corepage
    {

        By firstname = By.Id("first_name");
        By lastname = By.Id("last_name");
        By addresshotel = By.Id("address");
        By credCardNo = By.Id("cc_num");
        By credCardType = By.Id("cc_type");
        By ExpiryDateCCmonth = By.Id("cc_exp_month");
        By ExpiryDateCCyear = By.Id("cc_exp_year");
        By CvvNO = By.Id("cc_cvv");
        By ClickbtnBOOK = By.Id("book_now");
        public void bookedhotel()
        {

            driver.FindElement(firstname).SendKeys("Ahmed");
            driver.FindElement(lastname).SendKeys("Memon");
            driver.FindElement(addresshotel).SendKeys("A1 phase 2 gulshan e hadeed Bin qasim town karachi");
            driver.FindElement(credCardNo).SendKeys("4884558456456632");
            driver.FindElement(credCardType).SendKeys("VISA");
            driver.FindElement(ExpiryDateCCmonth).SendKeys("June");
            driver.FindElement(ExpiryDateCCyear).SendKeys("2027");
            driver.FindElement(CvvNO).SendKeys("5645");
             driver.FindElement(ClickbtnBOOK).Click();
           // System.Threading.Thread.Sleep(2000);
          //  driver.FindElement(ClickbtnBOOK).Click();
           // driver.FindElement(clickcancelBtn).Click(); 

        }
    }
}
