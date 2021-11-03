Feature: Sports
	As a sport user
	I would like to read articles related to sport

@mytag
Scenario: Sport Articles
	Given I navigate to BBC website
	When I click on search bar
	And I enter in sports in the search bar
	Then the first heading on the page "BBC Sports Update: 'BBC Sports Update" is displayed
	And the last heading on the page "The Adventure Show: 2020/21: Winter Sports" is displayed