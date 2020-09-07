Feature: SpecFlowFeature4
	In order to have a good nights sleep
	As a hotel visitor
	I want to be able to book a specific room

Scenario: Reserve a room with a king size bed
	Given hotel <123> exists with KingRooms
	And has a KingRoom available
	When a KingRoom is booked
	Then it should return <"Booked this room!">