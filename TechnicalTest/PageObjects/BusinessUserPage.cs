using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalTest.Hooks;

namespace TechnicalTest.PageObjects
{
    class BusinessUserPage
    {
        IWebDriver driver;
        IWebElement validate => driver.FindElement(By.CssSelector("#page"));
        IWebElement divTitle => driver.FindElement(By.ClassName("qa-match-block"));

       
        
        public void OutputTeam()
        {
            IList<IWebElement> elements = divTitle.FindElements(By.ClassName("gs-o-list-ui gs-o-list-ui--top-no-border gs-o-list-ui--bottom-no-border"));
            foreach (IWebElement e in elements)
            {

                System.Console.WriteLine(e.Text);
            }
            //else
            //{
            //    System.Console.WriteLine("There are no matches today");
            //}
            

        }

        public void ValidatePage()
        {
            string title =  validate.Text;
            Assert.IsTrue(title == "Football Scores & Fixtures");
        }


        public BusinessUserPage()
        {
            driver = BaseTest.driver;
        }


        public void SportPage()
        {
            driver.Navigate().GoToUrl("https://www.bbc.co.uk/sport/football/scores-fixtures");
        }


    }
}
