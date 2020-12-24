Feature: Registration
	In order use ebay website
	to enjoy it, i need to register

@mytag
Scenario: Registration
	Given that i navigate to the website "https://www.ebay.co.uk/"
	And Click on register
	And I enter my first name
	And I enter my surname
	And I enter my email address
	And I enter my password
	When I click register
	Then I should be registerd