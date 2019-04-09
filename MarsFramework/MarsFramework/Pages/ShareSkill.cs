using AutoItX3Lib;
using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;
using static MarsFramework.Global.Base;

namespace MarsFramework.Pages
{
    class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region Initialize Web Elements

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a")]
        private IWebElement ShareSkillBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        private IWebElement TitleTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        private IWebElement DescriptionTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select")]
        private IWebElement CategoryDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")]
        private IWebElement SubcategoryDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        private IWebElement TagsTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        private IWebElement TagsTextbox1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement HourlyService { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement OneoffService { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement OnSite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        private IWebElement Online { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]
        private IWebElement StartdateTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]
        private IWebElement EnddateTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")]
        private IWebElement SunCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input")]
        private IWebElement SunStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input")]
        private IWebElement SunEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")]
        private IWebElement MonCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")]
        private IWebElement MonStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")]
        private IWebElement MonEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input")]
        private IWebElement TueCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input")]
        private IWebElement TueStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input")]
        private IWebElement TueEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")]
        private IWebElement WedCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")]
        private IWebElement WedStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input")]
        private IWebElement WedEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input")]
        private IWebElement ThuCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input")]
        private IWebElement ThuStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input")]
        private IWebElement ThuEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[1]/div/input")]
        private IWebElement FriCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[2]/input")]
        private IWebElement FriStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[3]/input")]
        private IWebElement FriEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[1]/div/input")]
        private IWebElement SatCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input")]
        private IWebElement SatStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[3]/input")]
        private IWebElement SatEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        private IWebElement SkillExchangeButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchangeTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement CreditButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input")]
        private IWebElement CreditAmount { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        private IWebElement PlusCircleIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/div[2]/i")]
        private IWebElement RemoveItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        private IWebElement ActiveRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement HiddenRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
        private IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/section[1]/div/a[3]")]
        private IWebElement ManageListingsTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr/td[7]/div/input")]
        private IWebElement ActiveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement YesButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > section.nav-secondary > div > a:nth-child(2)")]
        private IWebElement ProfileTab { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr/td[4]")]
        //private IWebElement ItemToDelete { get; set; }

        //[FindsBy(How = How.XPath, Using = "")]
        //private IWebElement  { get; set; }

        //[FindsBy(How = How.XPath, Using = "")]
        //private IWebElement  { get; set; }



        #endregion

        internal void AddSkill()
        {
            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "Skill");

            ShareSkillBtn.Click();
            Global.GlobalDefinitions.wait(5);

            TitleTextbox.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            DescriptionTextbox.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            CategoryDropdown.Click();
            var category = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select"));
            var selectElement = new SelectElement(category);
            selectElement.SelectByIndex(3);

            SubcategoryDropdown.Click();
            var subcategory = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            var selectElement1 = new SelectElement(subcategory);
            selectElement1.SelectByIndex(3);

            TagsTextbox.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            TagsTextbox.SendKeys(Keys.Enter);

            TagsTextbox1.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(3, "Tags"));
            TagsTextbox1.SendKeys(Keys.Enter);

            OneoffService.Click();
            Thread.Sleep(500);
            HourlyService.Click();
            Thread.Sleep(500);

            OnSite.Click();
            Thread.Sleep(500);
            Online.Click();


            StartdateTextbox.Click();
            StartdateTextbox.SendKeys(DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"));

            EnddateTextbox.Click();
            EnddateTextbox.SendKeys(DateTime.Now.AddMonths(1).ToString("dd/MM/yyyy"));

            SunCheckBox.Click();
            SunStartTime.Click();
            SunStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartHour"));
            SunStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartMinutes"));
            SunStartTime.SendKeys(Keys.Up);
            SunEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndHour"));
            SunEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndMinutes"));
            SunEndTime.SendKeys(Keys.ArrowDown);

            MonCheckBox.Click();
            MonStartTime.Click();
            MonStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartHour"));
            MonStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartMinutes"));
            MonStartTime.SendKeys(Keys.Up);
            MonEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndHour"));
            MonEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndMinutes"));
            MonEndTime.SendKeys(Keys.ArrowDown);

            TueCheckBox.Click();
            TueStartTime.Click();
            TueStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartHour"));
            TueStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartMinutes"));
            TueStartTime.SendKeys(Keys.Up);
            TueEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndHour"));
            TueEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndMinutes"));
            TueEndTime.SendKeys(Keys.ArrowDown);

            WedCheckBox.Click();
            WedStartTime.Click();
            WedStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartHour"));
            WedStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartMinutes"));
            WedStartTime.SendKeys(Keys.Up);
            WedEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndHour"));
            WedEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndMinutes"));
            WedEndTime.SendKeys(Keys.ArrowDown);

            ThuCheckBox.Click();
            ThuStartTime.Click();
            ThuStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartHour"));
            ThuStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartMinutes"));
            ThuStartTime.SendKeys(Keys.Up);
            ThuEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndHour"));
            ThuEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndMinutes"));
            ThuEndTime.SendKeys(Keys.ArrowDown);

            FriCheckBox.Click();
            FriStartTime.Click();
            FriStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartHour"));
            FriStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartMinutes"));
            FriStartTime.SendKeys(Keys.Up);
            FriEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndHour"));
            FriEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndMinutes"));
            FriEndTime.SendKeys(Keys.ArrowDown);

            SatCheckBox.Click();
            SatStartTime.Click();
            SatStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartHour"));
            SatStartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartMinutes"));
            SatStartTime.SendKeys(Keys.Up);
            SatEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndHour"));
            SatEndTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndMinutes"));
            SatEndTime.SendKeys(Keys.ArrowDown);

            SkillExchangeButton.Click();
            SkillExchangeTag.Click();
            SkillExchangeTag.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "SkillToExchange"));
            SkillExchangeTag.SendKeys(Keys.Enter);
            
            CreditButton.Click();
            CreditAmount.Click();
            CreditAmount.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "CreditAmount"));

            PlusCircleIcon.Click();


            //Upload file
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            autoIt.Send(@"C:\Users\Nemesis\Pictures\TanslatePix\zodiac.jpg");
            Thread.Sleep(500);
            autoIt.Send("{ENTER}");

            Thread.Sleep(500);
            PlusCircleIcon.Click();

            AutoItX3 autoIt1 = new AutoItX3();
            autoIt1.WinActivate("Open");
            Thread.Sleep(500);
            autoIt1.Send(@"C:\Users\Nemesis\Pictures\TanslatePix\doggie.jpg");
            Thread.Sleep(500);
            autoIt1.Send("{ENTER}");

            Thread.Sleep(500);
            RemoveItem.Click();

            HiddenRadioButton.Click();
            Thread.Sleep(1000);
            ActiveRadioButton.Click();

            SaveButton.Click();

            Global.GlobalDefinitions.wait(5);


            //Add Skill Verification
            ManageListingsTab.Click();

            Global.GlobalDefinitions.wait(5);

            string ExpectedText = Global.GlobalDefinitions.ExcelLib.ReadData(2, "Description");
            string ActualText = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr/td[4]")).Text;

            if (ExpectedText.Equals(ActualText))
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Add Skill Successful");
                String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "AddSkill_Pass");
                test.Log(LogStatus.Info, "Image example: " + img);
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Add Skill UnSuccessful");
                String img1 = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "AddSkill_Fail");
                test.Log(LogStatus.Info, "Image example: " + img1);
            }
           
        }
        

        //Edit Added Skill------------------//
        internal void EditSkill()
        {
            ActiveButton.Click(); //clicking active button
            Thread.Sleep(2000);
            ActiveButton.Click(); //clicking Active button
            Thread.Sleep(7000);
        }


        //Delete Added Skill----------------//
        internal void DeleteSkill()
        {
            Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr/td[8]/i[3]")).Click();

            Global.GlobalDefinitions.wait(5);

            YesButton.Click();
            Global.GlobalDefinitions.wait(5);

            Global.GlobalDefinitions.wait(5);Global.GlobalDefinitions.driver.FindElement(By.XPath("//html/body"));

            GlobalDefinitions.driver.SwitchTo().DefaultContent();
            Thread.Sleep(500);

            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest("Delete Skill Test");                       

            try
            {
                string ExpectedText1 = Global.GlobalDefinitions.ExcelLib.ReadData(2, "Description");
                string ActualText1 = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr/td[4]")).Text;

                if (ExpectedText1.Equals(ActualText1))
                {
                    Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Delete Skill UnSuccessful");
                    String img2 = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "DeleteSkill_Fail");
                    test.Log(LogStatus.Info, "Image example: " + img2);
                }
               
            }
            catch (NoSuchElementException)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Delete Skill Successful");
                String img3 = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "DeleteSkill_Pass");
                test.Log(LogStatus.Info, "Image example: " + img3);
            }            

        }

    }
}

