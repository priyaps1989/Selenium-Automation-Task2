using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK2.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Threading;
using System.Collections;
using LumenWorks.Framework.IO.Csv;
using System.IO;

namespace TASK2.Global
{
    
    class Base
    {
       
        #region
        [OneTimeSetUp]
        
        public void TimeSetup()
        {
             
             GlobalDefinitions.driver = new ChromeDriver();
             GlobalDefinitions.driver.Manage().Window.Maximize();
             GlobalDefinitions.driver.Navigate().GoToUrl("http://192.168.99.100:5000/Home");
             
             LoginPage loginObj;
             loginObj = new LoginPage();
             loginObj.Login_Steps();
             //loginObj.Login();


        }
        #endregion

      
        #region
        [OneTimeTearDown]
        public void TearDown()
        {
            GlobalDefinitions.driver.Close();
            GlobalDefinitions.driver.Quit();

        }
        #endregion
    }
}
