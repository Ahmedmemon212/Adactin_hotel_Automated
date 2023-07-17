using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebtestBYahmed
{
    class selecthotelpage : corepage
    {

        By selecthotelRidoButton = By.Id("radiobutton_0");

        By ClickContinueBtn = By.Id("continue");


      //  By clickcancelBtn = By.Id("cancel");





        public void selecthotel()
        {


            driver.FindElement(selecthotelRidoButton).Click();

            driver.FindElement(ClickContinueBtn).Click();

           // driver.FindElement(clickcancelBtn).Click(); 

        }
    }
}
