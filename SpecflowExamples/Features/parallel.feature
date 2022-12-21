Feature: UserformvalidationFeature
entering the details in user form
Background: 
		Given Launch the applicationin "firefox"
@tag1

Scenario Outline: Login with the admin user
	
	When enter the <username> and <password>
	
	When click on login button
	Then verfiy the home page with Logout button.
	And close the browser
	Examples: 
	| username | password |
	| admin    | admin    |
	
	