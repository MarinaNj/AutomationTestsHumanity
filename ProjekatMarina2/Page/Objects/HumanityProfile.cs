using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ProjekatMarina2.Page.Objects
{
    public class HumanityProfile
    {
        public static readonly string ProfileMenu_XPath = "//img[@id='tr_avatar']";
        public static readonly string Profile_XPath = @"//a[contains(text(),'Profile')]";
        public static readonly string Settings_XPath = @"//div[@class='userm userm-mainPage']//a[contains(text(),'Settings')]";
        public static readonly string Availability_XPath = @"//div[@class='userm userm-mainPage']//a[contains(text(),'Availability')]";
        public static readonly string Version_XPath = @"//b[contains(text(),'9.13.4')]";
        public static readonly string SignOut_XPath = @"//a[contains(text(),'Sign Out')]";

        #region Click on Profile Menu
        public static IWebElement GetProfileMenu(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(ProfileMenu_XPath));
        }
        public static void ClickProfileMenu(IWebDriver wd)
        {
            GetProfileMenu(wd).Click();
        }
        #endregion

        #region Profile
        public static IWebElement GetProfile(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Profile_XPath));
        }
        public static void ClickProfile(IWebDriver wd)
        {
            GetProfile(wd).Click();
            #endregion
            #region Settings
        }
        public static IWebElement GetSettings(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Settings_XPath));
        }
        public static void ClickSettings(IWebDriver wd)
        {
            GetSettings(wd).Click();
        }
        #endregion
        #region Availability
        public static IWebElement GetAvailability(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Availability_XPath));
        }
        public static void ClickAvailability(IWebDriver wd)
        {
            GetAvailability(wd).Click();
        }
        #endregion
        #region Get Version
        public static IWebElement GetVersion(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Version_XPath));
        }
        public static void ClickVersion(IWebDriver wd)
        {
            GetVersion(wd).Click();
        }
        #endregion
        #region SignOut
        public static IWebElement GetSignOut(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SignOut_XPath));
        }
        public static void ClickSignOut(IWebDriver wd)
        {
            GetSignOut(wd).Click();
        }
        #endregion
    }
}



    
