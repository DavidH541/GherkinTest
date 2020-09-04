Feature: SpecFlowFeature4ReservationMessage
	In order to know about a new reservation
	As a hotel/a SmartHOTEL developer
	I want a message to notify me about the new reservation

Scenario Outline: Recieve reservation message
	Given hotel <hotelID> has <availableRooms> available rooms
	When a new reservation <ExtID> is made with <reservationRooms> rooms
	Then I should recieve a message <message>

	Examples: 
	| hotelID | availableRooms | ExtID              | reservationRooms | message                                            |
	| 123     | 5              | 637347865177017437 | 2                | The reservation has passed! 123 637347865177017437 |
	| 456     | 5              | 637347865177017890 | 8                | The reservation has not passed!                    |

	 