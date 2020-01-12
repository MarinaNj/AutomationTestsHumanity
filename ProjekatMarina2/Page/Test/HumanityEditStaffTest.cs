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
using ProjekatMarina2.Page;

namespace ProjekatMarina2.Page.Test
{
   public class HumanityEditStaffTest
    {
        public static void TestUploadPicture()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Drive Initialized!");
            Thread.Sleep(3000);

            HumanityHome.NavigateTo(wd);
            HumanityHome.ClickCookies(wd);
            HumanityHome.ClickLogIn(wd);

            TestLogin.FillForm(wd, "xeyiro8556@mailer9.net", "Mikica345");
            HuamnityLogin.ClickButtonLogIn(wd);
            HumanityProfile.ClickProfileMenu(wd);
            HumanityProfile.ClickProfile(wd);
            HumanityEditStaff.ClickEditDetails(wd);

            HumanityEditStaff.TestUploadPicture(wd);
            Thread.Sleep(5000);
            HumanityEditStaff.SendNickname(wd, "Maki");
            HumanityEditStaff.ClickSaveButton(wd);

        }
    }
}
