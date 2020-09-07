Feature: SpecFlowFeature4ReservationMessage
	In order to know about a new reservation
	As a hotel/SmartHOTEL developer
	I want a message to notify me about the new reservation

Scenario Outline: Recieve reservation message
	Given hotel <hotelID> has available rooms
	When a new reservation <ExtID> is made with <KingRooms> KingRooms and <TwinRooms> TwinRooms
	Then I should recieve a message <message>

	Examples: 
	| hotelID | ExtID              | KingRooms | TwinRooms | message                                            |
	| 123     | 637347865177017437 | 1         | 0         | The reservation has passed! 123 637347865177017437 |
	| 456     | 637347865177017890 | 0         | 1         | The reservation has not passed!                    |

	 