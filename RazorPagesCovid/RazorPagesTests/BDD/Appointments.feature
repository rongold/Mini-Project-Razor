Feature: Appointments
	Simple calculator for adding two numbers

@CheckAppointmentsPage
Scenario: Loading Appointmentspage displays AppointmentsPage
	Given I am on the Homepage
	When I click the Appointments Button
	Then The AppointmentPage url will be Correct "https://localhost:44328/Covid/Appointments" and title will be users "Index"

@CreateNew
Scenario: Create new Page 
	Given I am on the AppointmentPage
	When I click the CreateNew Button
	Then The AppointmentPage url will be Correct "https://localhost:44328/Covid/Appointments/Create" and title will be users "Create"