using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace ProjekatMarina2.Page.Objects
{
    class HumanityStaff
    {
        public static readonly string URL2 = "https://miki2.humanity.com/app/staff/add/";
        public static readonly string URL3 = "https://chemschool.humanity.com/app/dashboard/";
        public static readonly string URL4 = "https://chemschool.humanity.com/app/staff/list/load/true/";
        public static readonly string URL5 = "https://chemschool.humanity.com/app/staff/assign/";
        public static readonly string NameStaff_XPath = "//a[@class='staff-employee']";
        public static readonly string AddEmployees_XPath = "//button[@id='act_primary']";
        public static readonly string FirstName_XPath = "//input[@id='_asf1']";  
        public static readonly string LastName_XPath = "//input[@id='_asl1']";
        public static readonly string EMailEmployee_XPath = "//input[@id='_ase1']";
        public static readonly string SaveButton_XPath = "//button[@id='_as_save_multiple']";
        
        public static IWebElement GetNameStaff(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(NameStaff_XPath));
        }
        public static void ClickNamestaff(IWebDriver wd)
        {
            GetNameStaff(wd).Click();

        }
        public static IWebElement GetAddEmployees(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(AddEmployees_XPath));
        }
        public static void ClickAddEmployees(IWebDriver wd)
        {
            GetAddEmployees(wd).Click();
        }
        public static IWebElement GetFirstName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(FirstName_XPath));
        }
        public static void SendFirstName(IWebDriver wd, string data)
        {
            GetFirstName(wd).SendKeys(data);
        }
        public static IWebElement GetLastName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(LastName_XPath));
        }
        public static void SendLastName(IWebDriver wd, string data)
        {
            GetLastName(wd).SendKeys(data);
        }
        public static IWebElement GetEMailEmployee(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(EMailEmployee_XPath));
        }
        public static void SendEMailEmployee(IWebDriver wd, string data)
        {
            GetEMailEmployee(wd).SendKeys(data);
        }

        public static IWebElement GetSaveButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SaveButton_XPath));
        }
        public static void ClickSaveButton(IWebDriver wd)
        {
            GetSaveButton(wd).Click();

        }
    }
}
