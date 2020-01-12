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
    class TestLoginExcell
    {
        #region logovanje vise korisnika
        public static Boolean TestLoginUsers()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Drive Initialized!");
            Thread.Sleep(3000);




            ExcelExecute.OpenFile(Constants.EXCEL_PATH);
            ExcelExecute.LoadWorkSheet(0);

            string UName = ExcelExecute.GetDataAt(100, 3);
            string Pass = ExcelExecute.GetDataAt(100, 10);
            Boolean successful = false;
            try
            {
                wd.Navigate().GoToUrl(HumanityHome.URL);
                wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                wd.Manage().Window.Maximize();
                HumanityHome.ClickLogIn(wd);
                Thread.Sleep(2000);
                HuamnityLogin.SendUName(wd, UName);
                HuamnityLogin.SendPass(wd, Pass);
                HuamnityLogin.ClickButtonLogIn(wd);

                Thread.Sleep(2000);

              //  string lokacija = wd.Url;
                

                if (!wd.Url.Contains(HuamnityLogin.URL1))   //    lokacija != HuamnityLogin.URL1
                {
                    successful = true;
                }
                else
                {
                    successful = false;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            if (successful == true)
            {
                Console.WriteLine("Login Test PASSED");
            }
            else
            {
                Console.WriteLine("Login Test FAILED");
            }
            return successful;
        }
        #endregion
    }
}

            

            
      
        

    

