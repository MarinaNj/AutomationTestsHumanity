using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ProjekatMarina2.Page.Objects
{
    class HuamnityLogin
    {
        public static readonly string URL = "humanity.com/app/";
        public static readonly string URL1 = "https://www.humanity.com/app/";
        public static readonly string UName_XPath = "//input[@id='email']";
        public static readonly string Pass_XPath = "//input[@id='password']";
        public static readonly string ButtonLogIn_XPath = "//button[@name='login'][contains(text(),'Log in')]";

        public static IWebElement GetUName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(UName_XPath));
        }
        public static void SendUName(IWebDriver wd, string data)
        {
            GetUName(wd).SendKeys(data);
        }
        public static IWebElement GetPass(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Pass_XPath));
        }
        public static void SendPass(IWebDriver wd, string data)
        {
            GetPass(wd).SendKeys(data);
        }
        public static IWebElement GetButtonLogIn(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(ButtonLogIn_XPath));
        }
        public static void ClickButtonLogIn(IWebDriver wd)
        {
            GetButtonLogIn(wd).Click();
        }

    }
}
