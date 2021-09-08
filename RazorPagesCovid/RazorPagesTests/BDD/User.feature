Feature: User Test Scenerios
	Covers all tests on the user page

@CheckUserPage
Scenario: Loading Userpage displays userpage
	Given I am on the Userpage
	Then The page url will be Correct "https://localhost:44328/Covid/Users" and title will be users "Users"
