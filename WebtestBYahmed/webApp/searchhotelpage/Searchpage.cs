using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebtestBYahmed
{
    class selectpage : corepage
    {

        #region Locators
        By locationDropDown = By.Id("location");
        By HotelsDropDown = By.Id("hotels");
        By RoomTypeDropDown = By.Id("room_type");
        By NumberofRoomsDropDown = By.Id("room_nos");
        By CheckInDateTXT = By.Id("datepick_in");
        By CheckOUTDateTXT = By.Id("datepick_out");
        By AdultsperRoomDROPdown = By.Id("adult_room");
        By ChildrenperRoomDropDown = By.Id("child_room");
        By Searchbtn= By.Id("Submit");
        By Resetbtn = By.Id("Reset");
        #endregion 

            




        public void searchhotel()
        {
            driver.FindElement(Resetbtn).Click();
            driver.FindElement(locationDropDown).SendKeys("London");
            driver.FindElement(HotelsDropDown).SendKeys("Hotel Sunshine");
            driver.FindElement(RoomTypeDropDown).SendKeys("Double");
            driver.FindElement(NumberofRoomsDropDown).SendKeys("4 - Four");
            driver.FindElement(CheckInDateTXT).SendKeys("13/06/2023");
            driver.FindElement(CheckOUTDateTXT).SendKeys("14/06/2023");
            driver.FindElement(AdultsperRoomDROPdown).SendKeys("1 - One");
            driver.FindElement(ChildrenperRoomDropDown).SendKeys("3 - Three");
            driver.FindElement(Searchbtn).Click();
           // driver.FindElement(Resetbtn).Click();
        }
    }
}
