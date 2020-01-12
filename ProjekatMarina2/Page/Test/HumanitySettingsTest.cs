using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;
using ProjekatMarina2.Page.Objects;

namespace ProjekatMarina2.Page.Test
{
    class HumanitySettingsTest
    {
        public static void TeostGoToSettings()
        {

            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Drive Initialized!");
            Thread.Sleep(3000);

            wd.Navigate().GoToUrl(HuamnityLogin.URL1);
            
            TestLogin.FillForm(wd, "xeyiro8556@mailer9.net", "Mikica345");
            HuamnityLogin.ClickButtonLogIn(wd);
            HumanityMenu.ClickSettingsButton(wd);
            HumanitySettings.SelectCountry(wd, "Italy");
            HumanitySettings.SelectLanguage(wd, "Italian (machine)");
            HumanitySettings.SelectTimeFormat(wd, "24 hour");
            HumanityMenu.ClickSettingsButton(wd);

        }
    }
}
