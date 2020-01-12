using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace ProjekatMarina2.Page.Objects
{
    class HumanityMenu
    {
        public static readonly string URLMenu = "https://miki2.humanity.com/app/dashboard/";
        public static readonly string Dashboard_XPath = "//a[@id='sn_dashboard']//span[@class='primNavQtip__inner']";
        public static readonly string ShiftPlanning_XPath = "///a[@id='sn_schedule']//span[@class='primNavQtip__inner']";
        public static readonly string TimeOClock_XPath = "//a[@id='sn_timeclock']//span[@class='primNavQtip__inner']";
        public static readonly string Leave_XPath = "//a[@id='sn_requests']//span[@class='primNavQtip__inner']";
        public static readonly string Training_XPath = "//a[@id='sn_training']//span[@class='primNavQtip__inner']";
        public static readonly string Staff_XPath = "//p[contains(text(),'Staff')]";                   // "//a[@id='sn_staff']//span[@class='primNavQtip__inner']";
        public static readonly string Payroll_XPath = "//a[@id='sn_payroll']//span[@class='primNavQtip__inner']";
        public static readonly string Report_XPath = "//a[@id='sn_reports']//span[@class='primNavQtip__inner']";
        public static readonly string SettingsButton_XPath = "//a[@id='sn_admin']";

        #region Click Dashboard  
        public static IWebElement GetDashboard(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Dashboard_XPath));
        }
        public static void ClickDashboard(IWebDriver wd)
        {
            GetDashboard(wd).Click();
        }
        #endregion
        #region Click Shift Planing
        public static IWebElement GetShiftPlanning(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(ShiftPlanning_XPath));
        }
        public static void ClickShiftPlanning(IWebDriver wd)
        {
            GetShiftPlanning(wd).Click();
        }
        #endregion
        #region Click Time O' Clock
        public static IWebElement GetTimeOClock(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(TimeOClock_XPath));
        }
        public static void ClickTimeOClock(IWebDriver wd)
        {
            GetTimeOClock(wd).Click();
        }
        #endregion
        #region Click Get Leave
        public static IWebElement GetLeave(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Leave_XPath));
        }
        public static void ClickLeave(IWebDriver wd)
        {
            GetLeave(wd).Click();

        }
        #endregion
        #region Click Training
        public static IWebElement GetTraining(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Training_XPath));
        }
        public static void ClickTraining(IWebDriver wd)
        {
            GetTraining(wd).Click();
        }
        #endregion
        #region Click Settings
        public static IWebElement GetSettingsButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SettingsButton_XPath));
        }
        public static void ClickSettingsButton(IWebDriver wd)
        {
            GetSettingsButton(wd).Click();
            #endregion
        }
        public static IWebElement GetPayroll(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Payroll_XPath));
        }
        public static void ClickPayroll(IWebDriver wd)
        {
            GetPayroll(wd).Click();
        }
        public static IWebElement GetReport(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Report_XPath));
        }
        public static void ClickReport(IWebDriver wd)
        {
            GetReport(wd).Click();
        }
        public static IWebElement GetStaff(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Staff_XPath));
        }
        public static void ClickStaff(IWebDriver wd)
        {
            GetStaff(wd).Click();
        }

    }
}
