Feature: User Navigation Test Scenerios
	Covers all generic user navigation tests

@CheckUserPage
Scenario: Loading Userpage displays userpage
	Given I am on the Userpage
	Then The page url will be Correct "https://localhost:44328/Covid/Users" and title will be users "Users"

@CreateUser
Scenario: Clicking create User takes me to the create user page
	Given I am on the Userpage
	When I Click CreateUser
	Then The page url will be Correct "https://localhost:44328/Covid/Users/Create" and title will be users "Create"

@UserElements
Scenario: List of users
	Given I am on the Userpage
	Then I will see the correct amount of users

@UserHeaders
Scenario: User Headers Displays Correct Amount
	Given I am on the Userpage
	Then It will display Correct Amount Of User Headers

@UserHeaders
Scenario: User Headers Are Display Correctly
	Given I am on the Userpage
	Then It will display the correct user headers

@UserEdit
Scenario: Click edit brings me to first user edit page
	Given I am on the Userpage
	When I click Edit
	Then The page url will be Correct "https://localhost:44328/Covid/Users/Edit?id=1" and title will be users "Edit"

@UserDetails
Scenario: Click details brings me to first user details page
	Given I am on the Userpage
	When I click Details
	Then The page url will be Correct "https://localhost:44328/Covid/Users/Details?id=1" and title will be users "Details"

@UserAppointment
Scenario: Click appointment brings me to first user appointment page
	Given I am on the Userpage
	When I click Appointment
	Then The page url will be Correct "https://localhost:44328/Covid/Appointments?id=1&handler=User" and title will be users "Appointment"