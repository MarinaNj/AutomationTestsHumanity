using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProjekatMarina2.Page.Objects
{
    class HumanitySettings
    {
        public static readonly string Country_XPath = "//select[@id='country']";
        public static readonly string Language_XPath = "//td[@class='nowrap']//select[@name='language']";
        public static readonly string TimeFormat_XPath = "//select[@name='pref_24hr']";
       
        #region Select Country
        public static IWebElement GetCountry(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Country_XPath));
        }
        public static void SelectCountry(IWebDriver wd, string data)
        {
            SelectElement country = new SelectElement(GetCountry(wd));
           
            country.SelectByText(data);
        }
        #endregion
        #region Select Language
        public static IWebElement GetLanguage(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Language_XPath));
        }
        public static void SelectLanguage(IWebDriver wd, string data)
        {
            SelectElement language = new SelectElement(GetLanguage(wd));

            language.SelectByText(data);
        }
        #endregion
        #region Select Time Format
        public static IWebElement GetTimeFormat(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(TimeFormat_XPath));
        }
        public static void SelectTimeFormat(IWebDriver wd, string data)
        {
            SelectElement time_format = new SelectElement(GetTimeFormat(wd));

            time_format.SelectByText(data);
        }
        #endregion

    }
}
