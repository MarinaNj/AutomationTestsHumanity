using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;



namespace ProjekatMarina2.Page.Objects
{
    class HumanityHome
    {
        public static readonly string URL = "https://www.humanity.com/";
        public static readonly string FullName_XPath = "//div[@class='input-wrapper']//input[@placeholder='Full Name']";
        public static readonly string WorkMail_XPath = "//div[@class='input-wrapper']//input[@placeholder='Work Email']";
        public static readonly string Start_XPath = "//input[@id='free-trial-link-01']";
        public static readonly string LogIn_XPath = "//p[contains(text(),'LOGIN')]";
        public static readonly string AboutUs_XPath = "//body[@class='home page-template page-template-revamp page-template-homepage-test page-template-revamphomepage-test-php page page-id-3935 mmactive']/div[@class='sm_menu_outer active']/ul[@class='mobile_menu']/li[7]/a[1]";
        public static readonly string Cookies_XPath = "//a[@class='cc-btn cc-dismiss']";



        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(URL);
        }
        public static IWebElement GetCookies(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Cookies_XPath));
        }
        public static void ClickCookies(IWebDriver wd)
        {
            GetCookies(wd).Click();
        }
        public static IWebElement GetFullName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(FullName_XPath));
        }
        public static void SendFullName(IWebDriver wd, string data)
        {
            GetFullName(wd).SendKeys(data);
        }
        public static IWebElement GetWorkMail(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(WorkMail_XPath));
        }
        public static void SendWorkMail(IWebDriver wd, string data)
        {
            GetWorkMail(wd).SendKeys(data);
        }
        public static IWebElement GetStart(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Start_XPath));
        }
        public static void ClickStart(IWebDriver wd)
        {
            GetStart(wd).Click();
        }
        public static IWebElement GetLogIn(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(LogIn_XPath));
        }

        public static void ClickLogIn(IWebDriver wd)
        {
            GetLogIn(wd).Click();
        }
        public static IWebElement GetAboutUs(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(AboutUs_XPath));
        }

        public static void ClickAboutUs(IWebDriver wd)
        {
            GetAboutUs(wd).Click();
        }

    }
}
