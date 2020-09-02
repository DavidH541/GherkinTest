Feature: SpecFlowFeature3CashWithdrawal
	In order to get money
	As a customer
	I want to withdraw money from an ATM.
	
Scenario Outline: Successful withdrawal from an account in credit
	Given I have deposited "<amount1>" in my account
	When I withdraw "<amount2>"
	Then "<amount3>" should be dispensed
	
	Examples: 
	| amount1 | amount2 | amount3 |
	| 100     | 20      | 20      |
	| 10      | 10      | 10      | 
	| 0       | 0       | 0       |
	| 10      | 0       | 0       |
	| 0       | 10      | 0       |