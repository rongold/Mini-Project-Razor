Feature: HomePage
	Accessing other pages through links in the navbar

@happy
Scenario: Viewing Vaccines
	Given I am on the homepage
	When I click the vaccine link
	Then I go to the vaccinepage