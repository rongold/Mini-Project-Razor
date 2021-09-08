Feature: Signin
	As a registered user of the saucedemo website
	I want to be able to sign in
	So that I can browse and buy the products

@sad
Scenario: Wrong Passowrd
	Given I am on the signin page
	And I have entered the username "Standard_user"
	And I have entered the password "sauce"
	When I click submit
	Then I should see an error message "Epic sadface: Username and password do not match any user in this service"

@login
Scenario: Invalid email - using SpecFlow assist
	Given I am on the signin page
	And I have the following credentials:
	| UserName		| Password |
	| standard_user | nish     |
	When I click submit
	Then I should see an error message "Epic sadface: Username and password do not match any user in this service"

@loginSadPaths
Scenario: UnSuccesful Logins
	Given I am on the signin page
	And I have entered the usernames <input1>
	And I have entered the passwords <input2>
	When I click submit
	Then I should see an error messages <result>
Examples:
| input1          | input2       | result                                                                    |
| standard_user   | sauce        | Epic sadface: Username and password do not match any user in this service |
| locked_out_user | secret_sauce | Epic sadface: Sorry, this user has been locked out.                       |
|                 |              | Epic sadface: Username is required                                        |

@SadPath
Scenario: No Login
	Given I am on the signin page
	When I tryto access the Invetory page
	Then I should see an error message "Epic sadface: You can only access '/inventory.html' when you are logged in."

@loginHappyPaths
Scenario: Succesful Logins
	Given I am on the signin page
	And I have entered the usernames <input1>
	And I have entered the password "secret_sauce"
	When I click submit
	Then I should be directed to the following website "https://www.saucedemo.com/inventory.html"
Examples:
| input1					|
| standard_user				|
| problem_user				|
| performance_glitch_user	|

@displayBurgerButton
Scenario: Burger Button
	Given I have successfully logged in
	When I click on the burger button
	Then I should view <result>
Examples:
|	result			|
|	ALL ITEMS		|
|	ABOUT			|
|	LOGOUT			|
|	RESET APP STATE	|

@AboutPage
Scenario: Press About Button
	Given I have successfully logged in
	When I click on the burger button
	And I click on the ABOUT button
	Then I should be directed to the following website "https://saucelabs.com/"

@LoginPage
Scenario: Press LogOut Button
	Given I have successfully logged in
	When I click on the burger button
	And I click on the LOGOUT button
	Then I should be directed to the following website "https://www.saucedemo.com/"