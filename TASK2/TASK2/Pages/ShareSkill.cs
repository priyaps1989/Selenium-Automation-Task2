using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TASK2.Global;

namespace TASK2.Pages
{
    class ShareSkill
    {
        
        #region
        public ShareSkill()
        {
           PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        #endregion

        #region initialise web elements

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        public IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }
        SelectElement dropdown1 => new SelectElement(CategoryDropDown);

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }
        SelectElement dropdown2 => new SelectElement(SubCategoryDropDown);

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//input[@value='']")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

       

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }
         


        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }
        
        //Storing the table of available days
         [FindsBy(How = How.XPath, Using = "//input[@tabindex='0' and @index='1']")]
          private IWebElement Days { get; set; }

        //Click on StartTime dropdown 
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }
        
        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }
       


        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }
        //last page of managelisting
        //[FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[2]")]

        #endregion

        //#region
        //public void Share_Skill()
        //{
        //    GlobalDefinitions.wait(2000);
        //    ShareSkillButton.Click();
        //    GlobalDefinitions.wait(2000);
        //    Title.SendKeys("My Skills");
        //    Description.SendKeys("Im new to testing and I was a banker for 6 years");
        //    CategoryDropDown.Click();
        //    dropdown1.SelectByIndex(2);
        //    SubCategoryDropDown.Click();
        //    dropdown2.SelectByIndex(1);
        //    Tags.Click();
        //    Tags.SendKeys("social media memes");
        //    Tags.SendKeys(Keys.Enter);
        //    ServiceTypeOptions.Click();
        //    LocationTypeOption.Click();
        //    StartDateDropDown.Click();
        //    StartDateDropDown.SendKeys("09102020");
        //    EndDateDropDown.Click();
        //    EndDateDropDown.SendKeys("31122020");
        //    Days.Click();
        //    StartTimeDropDown.Click();
        //    StartTimeDropDown.SendKeys("0245pm");
        //    EndTimeDropDown.Click();
        //    EndTimeDropDown.SendKeys("0545pm");
        //    SkillTradeOption.Click();
        //    SkillExchange.Click();
        //    SkillExchange.SendKeys("marketing skills");
        //    SkillExchange.SendKeys(Keys.Enter);
        //    ActiveOption.Click();
        //    Save.Click();



        //}
        //#endregion
        #region
        public void Share_Skill()
        {
        using (var csv = new CsvReader(new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\TestDataShareSkill.csv")), true))
            {
                while (csv.ReadNextRecord())
                {
                    GlobalDefinitions.wait(2000);
                    ShareSkillButton.Click();
                    GlobalDefinitions.wait(2000);
                    Title.SendKeys(csv[0]);
                    Description.SendKeys(csv[1]);
                    CategoryDropDown.Click();
                    dropdown1.SelectByIndex(2);
                    SubCategoryDropDown.Click();
                    dropdown2.SelectByIndex(1);
                    Tags.Click();
                    Tags.SendKeys(csv[4]);
                    Tags.SendKeys(Keys.Enter);
                    ServiceTypeOptions.Click();
                    LocationTypeOption.Click();
                    StartDateDropDown.Click();
                    StartDateDropDown.SendKeys(csv[7]);
                    EndDateDropDown.Click();
                    EndDateDropDown.SendKeys(csv[8]);
                    Days.Click();
                    StartTimeDropDown.Click();
                    StartTimeDropDown.SendKeys(csv[10]);
                    EndTimeDropDown.Click();
                    EndTimeDropDown.SendKeys(csv[11]);
                    SkillTradeOption.Click();
                    SkillExchange.Click();
                    SkillExchange.SendKeys(csv[13]);
                    SkillExchange.SendKeys(Keys.Enter);
                    ActiveOption.Click();
                    Save.Click();

                }
            }
         }
        #endregion
    }
}
