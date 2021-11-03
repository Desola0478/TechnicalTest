using System;
using TechnicalTest.PageObjects;
using TechTalk.SpecFlow;

namespace TechnicalTest.StepDefinitions
{
    [Binding]
    public class SportsSteps
    {

        SportsPage sportspage;

        public SportsSteps()
        {
            sportspage = new SportsPage();
        }


        [When(@"I click on search bar")]
        public void WhenIClickOnSearchBar()
        {
            sportspage.ClickOnSearchBar();
        }
        
        [When(@"I enter in sports in the search bar")]
        public void WhenIEnterInSportsInTheSearchBar()
        {
            sportspage.EnterSports();
        }


        [Then(@"the first heading on the page ""(.*)"" is displayed")]
        public void ThenTheFirstHeadingOnThePageIsDisplayed(string text)
        {
            sportspage.FirstHeadingIsdisplayed(text);
        }

        [Then(@"the last heading on the page ""(.*)"" is displayed")]
        public void ThenTheLastHeadingOnThePageIsDisplayed(string text)
        {
            sportspage.LastHeadingIsdisplayed(text);
        }


    }
}
