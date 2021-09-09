Feature: HomePage
	Accessing other pages through links in the navbar
@happy 
Scenario: Staying On Homepage
Given I am on the homepage
When I click the homepage button
Then I should stay on the homepage
@happy
Scenario: Staying on Homepage 2
Given I am on the homepage
When I click the razorpage button
Then I should stay on the homepage

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
Scenario: Viewing Appointment
Given I am on the homepage
When I click the appointments button
Then I go to the appointments page

@happy
Scenario: Viewing Privacy
Given I am on the homepage
When I click the privacy button
Then I go to the privacy page
