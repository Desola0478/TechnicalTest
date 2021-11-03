using System;
using TechnicalTest.PageObjects;
using TechTalk.SpecFlow;

namespace TechnicalTest.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {

        LoginPage loginpage;

        public LoginSteps()
        {
            loginpage = new LoginPage();
        }

        [Given(@"I navigate to BBC website")]
        public void GivenINavigateToBBCWebsite()
        {
            loginpage.NavigateToBBCWebsite();
        }

        [Given(@"I click on sign in")]
        public void GivenIClickOnSignIn()
        {
            loginpage.ClickOnSignIn();
        }
        
        [When(@"I enter invalid email address")]
        public void WhenIEnterInvalidEmailAddress()
        {
            loginpage.EnterInvalidEmailAddress();
        }
        
        [When(@"I enter invalid password")]
        public void WhenIEnterInvalidPassword()
        {
            loginpage.EnterInvalidPassword();
        }
        
        [When(@"I click on sign in button")]
        public void WhenIClickOnSignInButton()
        {
            loginpage.ClickOnSignInButton();
        }

        [Then(@"the error message ""(.*)"" is displayed")]
        public void ThenTheErrorMessageIsDisplayed(string p0)
        {
            loginpage.ErrorMessageIsDisplayed();
            
        }


        [When(@"I enter valid password")]
        public void WhenIEnterValidPassword()
        {
            loginpage.EnterValidPassword();
        }

        [Then(@"invalid email error message ""(.*)"" is displayed")]
        public void ThenInvalidEmailErrorMessageIsDisplayed(string p0)
        {
            loginpage.InvalidEmailErrorMessageIsDisplayed();
        }


        [When(@"I enter valid email address")]
        public void WhenIEnterValidEmailAddress()
        {
            loginpage.EnterValidPassword();
        }

        [Then(@"invalid password error message ""(.*)"" is displayed")]
        public void ThenInvalidPasswordErrorMessageIsDisplayed(string p0)
        {
            loginpage.InvalidPasswordErrorMessageIsDisplayed();
        }


        [When(@"I didn't enter email address")]
        public void WhenIDidnTEnterEmailAddress()
        {
            loginpage.EnterBlankEmailAddress();
        }

        [When(@"I didn't enter letter password")]
        public void WhenIDidnTEnterLetterPassword()
        {
            loginpage.EnterBlankPassword();
        }

        [Then(@"blank email error message ""(.*)"" is displayed")]
        public void ThenBlankEmailErrorMessageIsDisplayed(string text)
        {
            loginpage.BlankPasswordErrorMessageIsdisplayed(text);
        }

        [Then(@"blank password error message ""(.*)"" is displayed")]
        public void ThenBlankPasswordErrorMessageIsDisplayed(string text)
        {
            loginpage.BlankPasswordErrorMessageIsdisplayed(text);
        }





    }
}
