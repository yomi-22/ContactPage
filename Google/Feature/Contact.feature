Feature: Contact Page
	In order to see the contact details
	As a  user
	I need to click on contact us link
	

@Browser:Chrome
Scenario: Contact us
	Given I am on homepage
	When I click on contact
	Then I should see the contact details
	