using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Diagnostics;
using ProjekatMarina2.Page.Objects;
using System.Windows.Forms;

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
                Thread.Sleep(3000);
                HumanityHome.ClickCookies(wd);
                HumanityHome.ClickLogIn(wd);
                Thread.Sleep(3000);


            

        }
        public static void TestFillForm()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Drive Initialized!");

            //wd.Navigate().GoToUrl(HuamnityLogin.URL1);
            try { 
            HumanityHome.NavigateTo(wd);
            Thread.Sleep(3000);
            HumanityHome.ClickCookies(wd);
            HumanityHome.ClickLogIn(wd);
            Thread.Sleep(3000);
            FillForm(wd, "xeyiro8556@mailer9.net", "Mikica345");
            HuamnityLogin.ClickButtonLogIn(wd);

                if (wd.Url.Contains(HuamnityLogin.URL1))
                {
                    Console.WriteLine("Login Pass");
                    MessageBox.Show("Successfully login");
                }
                else
                {
                    Console.WriteLine("Login Fail");
                    MessageBox.Show("Login Fail");
                }
            }
            catch (Exception izuzetak)
            {
                Console.WriteLine(izuzetak.ToString());
            }
        }

        public static void FillForm(IWebDriver wd, string UName, string Pass)
        {
            HuamnityLogin.SendUName(wd, UName);
            HuamnityLogin.SendPass(wd, Pass);

        }
    
    }
}
