Feature: FormStates

@Target:Chrome @Target:Firefox @Cleanup @Set2
Scenario: Check required of form items
Given a contact named TestContact with the following values
    | Property   | Value |
    | First Name | John  |
    | Last Name  | Smith |
    | Job Title  | CLO   |
Then TestContact's form has the following form state
    | Property           | State       |
    | First Name         | Recommended |
    | Last Name          | Required    |
    | Job Title          | Optional    |

@Target:Chrome @Target:Firefox @Cleanup @Set2
Scenario: Check locked state of form items
Given a contact named TestContact with the following values
    | Property   | Value |
    | First Name | John  |
    | Last Name  | Smith |
    | Job Title  | CLO   |
Then TestContact's form has the following form state
    | Property                       | State    |
    | First Name                     | Unlocked |
    | Last Date Included in Campaign | Locked   |


@Target:Chrome @Target:Firefox @Cleanup @Set2
Scenario: Check visiblity of form items
When an account named TestAccount is created with the following values
	| Property     | Value                   |
	| Account Name | DynamicHands            |
	| Main Phone   | 0612345678              |
	| Website      | https://dynamichands.nl |
	| Industry     | Consulting              |
Then TestAccount's form has the following form state
	| Property  | State     |
	| SIC Code  | Visible   |
	| Ownership | Invisible |

@Target:Chrome @Target:Firefox @Cleanup @Set2
Scenario: Check combined state of form items
Given a contact named TestContact with the following values
    | Property   | Value |
    | First Name | John  |
    | Last Name  | Smith |
    | Job Title  | CLO   |
Then TestContact's form has the following form state
    | Property                       | State                          |
    | First Name                     | Recommended, Unlocked, Visible |
    | Last Name                      | Required, Unlocked, Visible    |
    | Job Title                      | Optional, Unlocked, Visible    |
    | Last Date Included in Campaign | Locked, Optional, Visible      |

@Target:Chrome @Target:Firefox @Cleanup @Set2
Scenario: Ribbon button availability
Given a account named TestAccount with the following values
    | Property     | Value        |
    | Account Name | DynamicHands |
Then TestAccount's form has the following ribbon state
    | Property   | State     |
    | Activate   | Visible   |
    | Deactivate | Invisible |
    | Run Report | Visible   |