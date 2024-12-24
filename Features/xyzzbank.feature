Feature: xyzzbank


A short summary of the feature
 
Background: 
	Given : user in on login page

Scenario: customer Login
	When customer clicks on Customer Login button
	And Selects the name
	And user Clicks on login button
	Then user is logged in and can see data


Scenario Outline: Bank Manager Login 
Given the Bank Manager is on the login page,
When the Bank Manager clicks on the "Bank Manager Login" button
And selects the "Add Customer" tab
And enters the First Name in the corresponding field
And enters the Last Name in the corresponding field
And enters the Postcode in the corresponding field
And clicks on the "Add Customer" button
And clicks on the "OK" button in the confirmation dialog
Then the customer is successfully added

Scenario Outline: Bank Manager Login into the XYZ
Given The Bank Manager is on the login page,
And Manager Click to the Login button
And the Manger clicks to the Open Account button
And Select the Customer name
And Slect the Currency
Then then go to Home page

Scenario Outline: Bank Manager Login into the Customer search
Given  Bank Manager is on the login Page
And the Manager Click to the Login button
And Click into Customer button
And Search the Customer name
And delete the Customer detail
Then go back to home page











