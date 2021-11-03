using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalTest.Hooks;

namespace TechnicalTest.PageObjects
{
    class SportsPage
    {
        IWebDriver driver;

        IWebElement searchBar => driver.FindElement(By.CssSelector("div >a > span.ssrcss-1tmabzc-IconWrapper.eki2hvo6 > svg"));
        IWebElement sports => driver.FindElement(By.CssSelector("#search-input"));
        IWebElement firstHeading => driver.FindElement(By.CssSelector("li:nth-child(1) > div > div > div.ssrcss-som5se-PromoContent.e1f5wbog7 > div.ssrcss-1cbga70-Stack.e1y4nx260 > a"));
        IWebElement lastHeading => driver.FindElement(By.CssSelector("li:nth-child(10) > div > div div.ssrcss-1cbga70-Stack.e1y4nx260 > a"));




        public void LastHeadingIsdisplayed(string text)
        {
            Assert.IsTrue(lastHeading.Displayed);
            Assert.IsTrue(lastHeading.Text == text);
        }


        public void FirstHeadingIsdisplayed(string text)
        {
            Assert.IsTrue(firstHeading.Displayed);
            String first = firstHeading.Text;
            Assert.IsTrue(firstHeading.Text ==text);

        }


        public void EnterSports()
        {
            sports.SendKeys("sports");
            sports.SendKeys(Keys.Enter);
        }

        public void ClickOnSearchBar()
        {
            searchBar.Click();
        }


        public SportsPage()
        {
            driver = BaseTest.driver;
        }

        public void NavigateToBBCWebsite()
        {
            driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
        }
    }
}








    

