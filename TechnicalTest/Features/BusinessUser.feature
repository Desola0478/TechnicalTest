Feature: BusinessUser
	As a business user, 
	I would like to make a record of all teams which are playing today

@mytag
Scenario: Business Records
	Given I navigate to BBC Sport page
	When I am on today's football score and fixtures
	Then I should be able to output all the team names with a match today