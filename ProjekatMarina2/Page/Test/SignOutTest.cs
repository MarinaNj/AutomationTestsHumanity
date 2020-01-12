using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;
using ProjekatMarina2.Page.Objects;
using OpenQA.Selenium.Support.UI;


namespace ProjekatMarina2.Page.Test
{
    class SignOutTest
    {
        public static void TestSignOut()
        {

            try { 
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Drive Initialized!");

            HumanityHome.NavigateTo(wd);
            HumanityHome.ClickCookies(wd);
            HumanityHome.ClickLogIn(wd);
            TestLogin.FillForm(wd, "xeyiro8556@mailer9.net", "Mikica345");
            HuamnityLogin.ClickButtonLogIn(wd);
            HumanityProfile.ClickProfileMenu(wd);
            Thread.Sleep(3000);
            HumanityProfile.ClickSignOut(wd);
                Thread.Sleep(2000);

                //Convert to javascript 
                IJavaScriptExecutor js = (IJavaScriptExecutor)wd;

             if (wd.Url.Contains("https://chemschool.humanity.com/app/"))
            {
                    js.ExecuteScript("alert('Successfully logout');");
                     
                    // MessageBox.Show("Successfully logout");
                }
            else
            {
                    js.ExecuteScript("alert('Login Fail');");
             
                    // MessageBox.Show("Login Fail");
                }
            
            }
            catch (Exception izuzetak)
            {
                Console.WriteLine(izuzetak.ToString());
            }
            
        }
    }
}
