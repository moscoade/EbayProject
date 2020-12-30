Feature: LogIn
	In order to use ebay
	I should be loged in


Background: Login
	Given that i navigate to the website "https://www.ebay.co.uk/"
	And Click on SignIn
	And I enter User name
	And I click continue
	And I enter my password
	And I click Sign In button
	And I should be signed In


Scenario: Search Books
	Given That i navigate to search and enter "Book"
	When I click on search button
	Then Cars should be display


