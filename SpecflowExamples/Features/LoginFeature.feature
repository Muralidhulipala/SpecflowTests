Feature: LoginFeature
Verification of login details
Background: 
		Given Launch the applicationin "chrome"
@tag1
@DataSource:data.xlsx  @DataSet:Sheet1
Scenario Outline: Login with the admin
	
	When enter the <username> and <password>
	
	When click on login button
	Then verfiy the home page with Logout button.
	And close the browser
	Examples: 
	| username | password |
	| admin    | admin    |
	| admin    | admin    |
	| admin    | admin    |
	Scenario Outline: Login with the normal user
	
	When enter the <username> and <password>
	
	When click on login button
	Then verfiy the home page with Logout button.
	And close the browser
	Examples: 
	| username | password |
	| admin    | admin    |
	| admin    | admin    |
	| admin    | admin    |