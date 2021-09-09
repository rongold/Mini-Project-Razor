Feature: Appointments
	Covers all generic appointments tests

@CheckAppointmentsPage
Scenario: Loading Appointmentspage displays AppointmentsPage
	Given I am on the Homepage
	When I click the Appointments Button
	Then The AppointmentPage url will be Correct "https://localhost:44328/Covid/Appointments" and title will be "Appointments"

	@CheckAppointmentsPage
Scenario: On the Appointmentspag
	Given I am on the AppointmentsPage
	Then I should view <results>
	Examples:
	| results                          |
	| Location                         |
	| Date of Appointment              |
	| Vaccine                          |
	| User                             |
	| Minimum wait of next Appointment |

@CreateNew
Scenario: Create new Page 
	Given I am on the AppointmentsPage
	When I click the CreateNew Button
	Then The AppointmentPage url will be Correct "https://localhost:44328/Covid/Appointments/Create" and title will be "Create"