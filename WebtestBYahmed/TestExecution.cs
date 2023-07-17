using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;

namespace WebtestBYahmed
{
    [TestClass]
    public class TestExecution

    {
        #region setups and cleanups 

        public TestContext instance;

        public TestContext TestContext 
       {

            set { instance = value; }
            get { return instance; }
           
        }

        [ClassInitialize()]

        public static void classint(TestContext context)
        {

        }

        [ClassCleanup()]
        public static void classcleanup()
        {

        }

        [TestInitialize()]
        public void Testint()
        {
            corepage.SeleniumInit("Chrome");
        }

        [TestCleanup()]
        public void Testcleanup()
        {
           corepage.driver.Close();
        }

        #endregion

        loginPAge loginP = new loginPAge();
        selectpage searchPage = new selectpage();
        selecthotelpage selectPagehotel = new selecthotelpage();
        bookedhotelpage bookedPage = new bookedhotelpage();
        Cnfirm bookingConfirm = new Cnfirm();


        [TestMethod]
        [TestCategory("Bookhotel")]
        public void loginpageworkwithVAliddata__TC1()
        {
            
            loginP.login("https://adactinhotelapp.com/", "AhmedMemonTester", "AhmedMemonTester");
            string actultext = corepage.driver.FindElement(By.ClassName("welcome_menu")).Text;
            Assert.AreEqual("Welcome to Adactin Group of Hotels", actultext);
            
        }
        
        [TestMethod]
        [TestCategory("Bookhotel")]

        public void Loginpageworkwithinvaliddata__TC2()
        {
            
            loginP.login("https://adactinhotelapp.com/", "AhmedtMemonTester", "AhmedtMemonester12321");
            string actultext = corepage.driver.FindElement(By.ClassName("auth_error")).Text;
            Assert.AreEqual("Invalid Login details or Your Password might have expired. Click here to reset your password", actultext);
            
    
        }
        [TestMethod]
        [TestCategory("Bookhotel")]
        public void searchHotel__TC001()
        {
            
            loginP.login("https://adactinhotelapp.com/", "AhmedMemonTester23", "AhmedMemonTester");
            searchPage.searchhotel();
            

        }
        [TestMethod]
        [TestCategory("Bookhotel")]
        public void selecthotel__TC001()
        {
           
            loginP.login("https://adactinhotelapp.com/", "AhmedMemonTester", "AhmedMemonTester");
            searchPage.searchhotel();
            selectPagehotel.selecthotel();
            

        }
        [TestMethod]
        [TestCategory("Bookhotel")]
        public void ConfrimPage__TC001()
        {

            loginP.login("https://adactinhotelapp.com/", "AhmedMemonTester", "AhmedMemonTester");
            searchPage.searchhotel();
            selectPagehotel.selecthotel();
            bookedPage.bookedhotel();
            bookingConfirm.COnfrimBOOKing();


        }
        [TestMethod]
        [TestCategory("Bookhotel")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML","data.xml", "MainTest__Case", DataAccessMethod.Sequential)]
        public void MainTest__Case()
        {
            
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            loginP.login(url,user, pass);
            searchPage.searchhotel();
            selectPagehotel.selecthotel();
            bookedPage.bookedhotel();
            bookingConfirm.COnfrimBOOKing();
            Thread.Sleep(3000);

        }

    }
}
