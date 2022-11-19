Feature: Authentication

@Target:Chrome
Scenario: Logging in with a salesperson
	Given the current logged in user named MyUser
	When an account named TestAccount is created with the following values
		| Property     | Value    |
		| Account Name | Checkbox |
	Then TestAccount has the following values
		| Property | Value  |
		| Owner    | MyUser |