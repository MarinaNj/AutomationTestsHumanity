using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Diagnostics;
using ProjekatMarina2.Page.Objects;

namespace ProjekatMarina2.Page.Test
{
    class TestLogin
    {
        public static void TeostGoToLogin()
        {

            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Drive Initialized!");

            HumanityHome.NavigateTo(wd);
            HumanityHome.ClickCookies(wd);
            HumanityHome.ClickLogIn(wd);


            if (wd.Url.Contains(HuamnityLogin.URL))
            {
                Console.WriteLine("Login Pass");
            }
            else
            {
                Console.WriteLine("Login Fail");
            }
            wd.Quit();


        }
        public static void TestFillForm()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Drive Initialized!");

            wd.Navigate().GoToUrl(HuamnityLogin.URL1);
            FillForm(wd, "xeyiro8556@mailer9.net", "Mikica345");
            HuamnityLogin.ClickButtonLogIn(wd);
        }

        public static void FillForm(IWebDriver wd, string UName, string Pass)
        {
            HuamnityLogin.SendUName(wd, UName);
            HuamnityLogin.SendPass(wd, Pass);

        }
    }
}
