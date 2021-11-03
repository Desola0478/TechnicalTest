using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalTest.Hooks;

namespace TechnicalTest.PageObjects
{
    class LoginPage
    {
        IWebDriver driver;

        IWebElement signIn => driver.FindElement(By.XPath("//*[@id='header-content'']/div[2]/nav/div[1]/div/div[1]/ul[2]/li[1]"));
        IWebElement invalidEmailAddress => driver.FindElement(By.CssSelector("#user-identifier-input"));
        IWebElement invalidPassword => driver.FindElement(By.CssSelector("#password-input"));
        IWebElement signInButton => driver.FindElement(By.CssSelector("#submit-button > span"));
        IWebElement errorMessage => driver.FindElement(By.CssSelector("#form-message-password > p"));
        IWebElement validPassword => driver.FindElement(By.CssSelector("#password-input"));
        IWebElement invalidEmailErrorMessage => driver.FindElement(By.CssSelector("p > span > span"));
        IWebElement validEmailAddress => driver.FindElement(By.CssSelector("#user-identifier-input"));
        IWebElement invalidPasswordErrorMessage => driver.FindElement(By.CssSelector("p > span > span:nth-child(3)"));
        IWebElement blankEmailAddress => driver.FindElement(By.CssSelector("#user-identifier-input"));
        IWebElement blankPassword => driver.FindElement(By.CssSelector("#password-input"));
        IWebElement blankEmailErrorMessage => driver.FindElement(By.CssSelector("#form-message-username > p > span"));
        IWebElement blankPasswordErrorMessage => driver.FindElement(By.CssSelector("#form-message-password > p > span"));




        public void BlankPasswordErrorMessageIsdisplayed(string text)
        {
            Assert.IsTrue(blankPasswordErrorMessage.Displayed);
            Assert.IsTrue(blankPasswordErrorMessage.Text == text);
        }

        public void BlankEmailErrorMessage(string text)
        {
            Assert.IsTrue(blankEmailErrorMessage.Displayed);
            String first = blankEmailErrorMessage.Text;
            Assert.IsTrue(blankEmailErrorMessage.Text == text);

        }

        public void EnterBlankPassword()
        {
            blankPassword.SendKeys("");
        }

        public void EnterBlankEmailAddress()
        {
            blankEmailAddress.SendKeys("");
        }


        public void InvalidPasswordErrorMessageIsDisplayed()
        {
            Assert.IsTrue(invalidPasswordErrorMessage.Displayed);
        }


        public void EnterValidEmailAddress()
        {
            validEmailAddress.SendKeys("");
        }

        public void InvalidEmailErrorMessageIsDisplayed()
        {
            Assert.IsTrue(invalidEmailErrorMessage.Displayed);
        }


        public void EnterValidPassword()
        {
            validPassword.SendKeys("");
        }


        public void ErrorMessageIsDisplayed()
        {
            Assert.IsTrue(errorMessage.Displayed);
        }

        public void ClickOnSignInButton()
        {
            signInButton.Click();
        }

        public void EnterInvalidPassword()
        {
            invalidPassword.SendKeys("");
        }

        public void EnterInvalidEmailAddress()
        {
            invalidEmailAddress.SendKeys("");
        }

        public void ClickOnSignIn()
        { 
            signIn.Click();
        }

        public LoginPage()
        {
            driver = BaseTest.driver;
        }

        public void NavigateToBBCWebsite()
        {
            driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
        }
    }
}
