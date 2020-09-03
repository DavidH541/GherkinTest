Feature: SpecFlowFeature3CashWithdrawal
	In order to get money
	As a customer
	I want to withdraw money from an ATM.

Scenario: Succesfull withdrawal from an account in credit
	Given my account has been credited with $100
	When I withdraw $20
	Then $20 should be dispensed
	And the balance of my account should be $80
	
#Scenario Outline: Succesfull or unsuccesfull withdrawal from an account in credit
#	Given I have deposited "<deposit>" in my account
#	When I withdraw "<withdrawal>"
#	Then "<money>" should be dispensed
#	And the balance of my account should be "<balance>"
	
#	Examples: 
#	| deposit | withdrawal | money      | balance |
#	| 100     | 20         | 20         | 80      |
#	| 10      | 10         | 10         | 0       |
#	| 0       | 0          | 0          | 0       |
#	| 10      | 0          | 0          | 10      |
#	| 0       | 10         | 0          | 0       |
#	| 100     | 200        | 0          | 100     |