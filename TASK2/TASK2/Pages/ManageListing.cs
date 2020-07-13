using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TASK2.Global;
using TASK2.Tests;
using ExcelLibrary;

namespace TASK2.Pages
{
    class ManageListing
    {
        #region
        public ManageListing()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        #endregion

        #region initialise web elements
        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement ManageListingsLink { get; set; }

        //View the listing
        //i[@class='eye icon'])[1]
        [FindsBy(How = How.XPath, Using = ("//div[@id='listing-management-section']/div[2]/div/div/table/tbody/tr/td[8]/div/button"))]
        private IWebElement View { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "//div[@id='listing-management-section']/div[2]/div/div/table/tbody/tr/td[8]/div/button[2]")]
        private IWebElement Edit { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//div[@id='listing-management-section']/div[2]/div/div/table/tbody/tr/td[8]/div/button[3]/i")]
        private IWebElement Delete { get; set; }



        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[3]/button[2]/i")]
        private IWebElement ClickActionsButton { get; set; }

        #endregion

        // view manage listing

        #region
        public void View_Manage_List()
        {
            GlobalDefinitions.wait(2000);
            ManageListingsLink.Click();
            GlobalDefinitions.wait(2000);
            View.Click();
            GlobalDefinitions.wait(2000);
            ManageListingsLink.Click();
        }
        #endregion

        //Edit Manage Listing
        #region
        public void Edit_Manage_List()
        {
            GlobalDefinitions.wait(2000);
            ManageListingsLink.Click();
            Edit.Click();
            ShareSkill ShareSkillObj;
            ShareSkillObj = new ShareSkill();
            ShareSkillObj.Share_Skill();
            ManageListingsLink.Click();
            GlobalDefinitions.wait(1000);

        }
        #endregion

        //Delete Manage Listing
        #region
        public void Delete_Manage_List()
        {
            GlobalDefinitions.wait(2000);
            ManageListingsLink.Click();
            GlobalDefinitions.wait(2000);
            Delete.Click();
            ClickActionsButton.Click();
            GlobalDefinitions.wait(2000);

        }
        #endregion
    }
}
