Feature: SpecFlowFeature5ResponseInDB
	In order to check if the reservation went through
	As a hotel/SmartHOTEL developer
	I want a response from the DB

Scenario: response in DB from a reservation
	Given there is a hotel with hotelID <42075>
	When there is a reservation with ExternalID <637347865177017437>
	Then I expect a response in the DB