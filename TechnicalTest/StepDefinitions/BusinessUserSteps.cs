using System;
using TechnicalTest.PageObjects;
using TechTalk.SpecFlow;

namespace TechnicalTest.StepDefinitions
{
    [Binding]
    public class BusinessUserSteps
    {
        BusinessUserPage businessownerpage;

        public BusinessUserSteps()
        {
            businessownerpage = new BusinessUserPage();
        }

        [Given(@"I navigate to BBC Sport page")]
        public void GivenINavigateToBBCSportPage()
        {
            businessownerpage.SportPage();
        }

        [When(@"I am on today's football score and fixtures")]
        public void WhenIAmOnTodaySFootballScoreAndFixtures()
        {
            businessownerpage.ValidatePage();
        }

        [Then(@"I should be able to output all the team names with a match today")]
        public void ThenIShouldBeAbleToOutputAllTheTeamNamesWithAMatchToday()
        {
            businessownerpage.OutputTeam();
        }
    }
}
