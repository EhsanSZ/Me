Feature: User Login To Account

#Background: 
#	Given Something Happens

Scenario: User Can Login To Account
	Given i am <username> with password <password>
	And the following users are already available
		| username | password |
		| hossein  | 123      |
	When i try to login to my account
	Then i should get message <result>

	Examples:
		| username | password | result        |
		| hossein  | 123      | Authenticated |
		| ali      | 1598753  | Access Deny   |

Scenario: 