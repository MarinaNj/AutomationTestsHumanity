using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ProjekatMarina2.Page.Objects
{
    class HumanityEditStaff
    {

        public static readonly string EditDetails_XPath = "//a[contains(text(),'Edit Details')]";
        public static readonly string UploadPicture_XPath = "//input[@id='fileupload']";
        public static readonly string Nickname_XPath = "//input[@id='nick_name']";
        public static readonly string SaveButton_XPath = "//button[@id='act_primary']";



        #region EditDetalis of Employee
        public static IWebElement GetEditDetails(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(EditDetails_XPath));
        }
        public static void ClickEditDetails(IWebDriver wd)
        {
            GetEditDetails(wd).Click();

        }
        #endregion
        #region add Nickname
        public static IWebElement GetNickname(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Nickname_XPath));
        }
        public static void SendNickname(IWebDriver wd, string data)
        {
            GetNickname(wd).Clear();
            GetNickname(wd).SendKeys(data);
        }
        #endregion
        #region upload profile pictutre

        public static IWebElement GetUploadPicture(IWebDriver wd)
            {
                return wd.FindElement(By.XPath(UploadPicture_XPath));  
            }
            public static void ClickUploadPicture(IWebDriver wd)
            {
               
                GetUploadPicture(wd).SendKeys(Constants.PICTURE_PATH);
            }

        #endregion
        /*#region upload profile pictutre
        public static void TestUploadPicture(IWebDriver wd)
        {
            wd.FindElement(By.XPath("//input[@id='fileupload']")).SendKeys(@"C:\Users\Administrator\Desktop\ExcelDATA\Video call snapshot 2.png");
        }
        #endregion*/

        #region Click Save
        public static IWebElement GetSaveButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SaveButton_XPath));
        }
        public static void ClickSaveButton(IWebDriver wd)
        {
            GetSaveButton(wd).Click();

        }
        #endregion


    }
}
