Feature: Appointments Create
	Covers all generic appointments create tests

@HappyPath
Scenario: Loading Appointmentspage displays AppointmentsPage
	Given I am on the Appointment Create Page
	Then I should see <results>
	Examples:
	| results             |
	| Create		      |
	| Appointment         |
	| Location            |
	| Date of Appointment |
	| Vaccine Name        |
	| FullName            |

@HappyPath
Scenario: Back Button
	Given I am on the Appointment Create Page
	When I click the Back To List Button
	#Then I should be redirected back to the AppointmentPage with url: "https://localhost:44328/Covid/Appointments" and title "Appointments"
	Then I should be redirected back to the AppointmentPage with url: "https://localhost:44328/Covid/Appointments"

@HappyPath
Scenario: Successful Appointment
	Given I am on the Appointment Create Page
	And I type a valid location
	And I select a valid date
	When I click the Create Button
	#Then I should be redirected back to the AppointmentPage with url: "https://localhost:44328/Covid/Appointments" and title "Appointments"
	Then I should be redirected back to the AppointmentPage with url: "https://localhost:44328/Covid/Appointments"

@SadPath
Scenario: No Location Error Message
	Given I am on the Appointment Create Page
	When I click the Create Button
	Then I should observe the following error under location: "The Location field is required."

@SadPath
Scenario: No Date Error Message
	Given I am on the Appointment Create Page
	When I click the Create Button
	Then I should observe the following error under date: "The Date of Appointment field is required."

@SadPath
Scenario: Invalid Date Error Message
	Given I am on the Appointment Create Page
	And I click on the DateBar and select an invalid date <input1>
	When I click the Create Button
	Then I should observe the following error under date: "The Date of Appointment field is not valid."
	Examples:
	| input1   |
	| 14121999 |
	| 12033000 |

@SadPath
Scenario: Invalid Location Error Message
	Given I am on the Appointment Create Page
	And I click on the LocationBar and type an invalid location: <input1>
	When I click the Create Button
	Then I should observe the following error under location: "Requires a Capital letter at the begining and can only contain letters, Minimum Length is 1"
	Examples:
	| input1		|
	| 123456		|
	| peterborough	|
	| Peterborough1	|