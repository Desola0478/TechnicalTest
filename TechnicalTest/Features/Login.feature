Feature: BBC Login
	As a QA
	I would like to verify all negative scenarios for login


Background: Negative Login
	Given I navigate to BBC website
	And I click on sign in


	Scenario: Invalid Login details
	When I enter invalid email address 
	And I enter invalid password
	And I click on sign in button
	Then the error message "Sorry, that password isn't valid. Please include something that isn't a letter" is displayed
	

	Scenario: Invalid email
	When I enter invalid email address 
	And I enter valid password
	And I click on sign in button
	Then invalid email error message "Sorry, we can't find an account with that email. You can register for a new account or get help here." is displayed


Scenario: Invalid password
	When I enter valid email address 
	And I enter invalid password
	And I click on sign in button
	Then invalid password error message "Sorry, that password is too short. It needs to be eight characters or more." is displayed


	Scenario: Blank Login details
	When I didn't enter email address 
	And I didn't enter letter password
	And I click on sign in button
	Then blank email error message "Something's missing. Please check and try again." is displayed
	And blank password error message "Something's missing. Please check and try again." is displayed



