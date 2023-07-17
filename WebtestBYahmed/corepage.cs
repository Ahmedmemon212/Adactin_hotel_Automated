using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebtestBYahmed
{
   public class corepage
    {
        public static IWebDriver driver;
        public static void SeleniumInit(string Browser)
        {

            if (Browser == "Chrome")
            {

                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("--start-maximized");
                chromeOptions.AddArguments("--incognito");
                IWebDriver chromeDriver = new ChromeDriver(chromeOptions);
                driver = chromeDriver;

            }
            else if (Browser == "Firefox")
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddArguments("");
                driver = new FirefoxDriver(options);




               

            }
            
            


        }
    }
}
