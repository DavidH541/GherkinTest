Feature: SpecFlowFeature3CashWithdrawal
	In order to get money
	As a customer
	I want to withdraw money from an ATM.
	
Scenario: Successful withdrawal from an account in credit
	Given I have deposited $100 in my account
	When I withdraw $20
	Then $20 should be dispensed
	