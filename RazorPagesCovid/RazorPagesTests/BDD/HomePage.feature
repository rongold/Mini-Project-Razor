Feature: HomePage
	Accessing other pages through links in the navbar

@happy
Scenario: Viewing Vaccines
	Given I am on the homepage
	When I click the vaccine link
	Then I go to the vaccinepage

@happy 
Scenario: Viewing Users
Given I am on the homepage
When I click the Users Button
Then I go to the Users page

@happy
Scenario: View Appointment
Given I am on the homepage
When I click the appointments button
Then I go to the appointments page

@happy
Scenario: View Privacy
Given I am on the homepage
When I click the privacy button
Then I go to the privacy page
