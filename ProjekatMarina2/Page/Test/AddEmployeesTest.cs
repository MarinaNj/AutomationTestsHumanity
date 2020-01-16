using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ProjekatMarina2.Page.Objects;
using ProjekatMarina2.Page.Test;

namespace ProjekatMarina2.Page.Test
{
    class AddEmployeesTest
    {

        public static void TestAddEmployees()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Drive Initialized!");

            wd.Navigate().GoToUrl(HuamnityLogin.URL1);
            FillForm(wd, "xeyiro8556@mailer9.net", "Mikica345");
            HuamnityLogin.ClickButtonLogIn(wd);
            HumanityMenu.ClickStaff(wd);
            HumanityStaff.ClickAddEmployees(wd);

            AddEmployeesTest.AddNewEmployee(wd, "Petar", "Pejovic", "ppk2345@mail.net");
            HumanityStaff.ClickSaveButton(wd);
        }

        #region konstruktor za logovanje
        public static void FillForm(IWebDriver wd, string Email, string Pass)
        {
            HuamnityLogin.SendUName(wd, Email);
            HuamnityLogin.SendPass(wd, Pass);

        }
        #endregion region 

        #region konstruktor dodavanje novog zaposlempg
        public static void AddNewEmployee(IWebDriver wd, string FirstName, string LastName, string EmailEmployee)
        {
            HumanityStaff.SendFirstName(wd, FirstName);
            HumanityStaff.SendLastName(wd, LastName);
            HumanityStaff.SendEMailEmployee(wd, EmailEmployee);
        }
        #endregion

        #region automatsko testiranje vise podataka

        public static Boolean TestFillFormAutomatic()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Drive Initialized!");

            try
            {
                wd.Navigate().GoToUrl(HuamnityLogin.URL1);
                FillForm(wd, "xeyiro8556@mailer9.net", "Mikica345");
                HuamnityLogin.ClickButtonLogIn(wd);        // click LOGIN button
                Thread.Sleep(3000);

                if (!wd.Url.Contains(HumanityStaff.URL3))  // check whether user LOGIN successfully or not
                {
                    Console.WriteLine("Login Fail");
                    return false;
                }
                else
                {
                    Console.WriteLine("Login Pass");

                    HumanityMenu.ClickStaff(wd);
                    HumanityStaff.ClickAddEmployees(wd);
                    Thread.Sleep(5000);

                    // adding Employees


                    ExcelExecute.OpenFile(Constants.EXCEL_PATH);
                    ExcelExecute.LoadWorkSheet(0);

                    for (int i = 1; i < ExcelExecute.GetRowCount(); i++)
                    {

                        string FirstName = ExcelExecute.GetDataAt(i, 0);
                        string LastName = ExcelExecute.GetDataAt(i, 1);
                        string EMailEmployee = ExcelExecute.GetDataAt(i, 3);

                        wd.Navigate().GoToUrl(HumanityStaff.URL2);

                        AddEmployeesTest.AddNewEmployee(wd, FirstName, LastName, EMailEmployee);
                    }
                    HumanityStaff.ClickSaveButton(wd);

                }
                

            }
     
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // provera uspesnosti dodavanja
            wd.Navigate().GoToUrl(HumanityStaff.URL4);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Thread.Sleep(3000);

            if (wd.Url.Contains(HumanityStaff.URL5)) 
            {
                Console.WriteLine("Successfully added Employee");
                return false;
            }
            else
            {
                Console.WriteLine("Unsuccessfully added Employee");
                wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                wd.Close();
                return true;
            }
            #endregion
        }
    }
}











        

   