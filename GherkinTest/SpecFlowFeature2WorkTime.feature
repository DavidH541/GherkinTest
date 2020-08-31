Feature: SpecFlowFeature2WorkTime
	In order to tell if I should be working today
	As an employee of SmartHOTEL
	I want to be told if I should work today

@mytag
Scenario Outline: I should or should not work today
	Given today is "<today>"
	When I ask if I should work today
	Then I should be told "<answer>"

	Examples: 
	| today     | answer |
	| Sunday    | No!    |
	| Saturday  | No!    |
	| Monday    | Yes!   |
	| Tuesday   | Yes!   |
	| Wednesday | Yes!   |
	| Thursday  | Yes!   |
	| Friday    | Yes!   |