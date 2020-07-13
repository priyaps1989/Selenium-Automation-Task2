using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
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
    class LoginPage
    {
        #region

                
        public LoginPage()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        #endregion

       

        #region  Initialize Web Elements 
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
        public IWebElement SigninButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[1]/input")]
        public IWebElement UserName { get; set; }



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
        public IWebElement Password { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "Sign Out")]
        public IWebElement SignOutButton { get; set; }


        #endregion
        //#region To access Path from resource file

        //public static IEnumerable Login()
        //{
        //    using (var csv = new CsvReader(new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\task 2\\login.csv")), true))
        //    {
        //        while (csv.ReadNextRecord())
        //        {

        //            yield return new[] { csv[1], csv[2] };

        //        }
        //    }
        //}
        //#endregion

        //[TestCaseSource("Login")]

        
        public void Login_Steps()
        {
            
            using (var csv = new CsvReader(new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\login.csv")), true))
            {
                while (csv.ReadNextRecord())
                {
                    SigninButton.Click();
                    UserName.SendKeys(csv[1]);
                    Password.SendKeys(csv[2]);
                    LoginButton.Click();
                    GlobalDefinitions.wait(2000);
                    Assert.That(SignOutButton.Displayed);

                }
            }
            


        }
        
       
    }
}
