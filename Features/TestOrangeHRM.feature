@Sprint1
Feature: TestOrangeHRM

Test orange hrm website login functionality

Background:
   Given User is on the orange hrm login page

@sanity
Scenario Outline: Verify login for orange hrm website
	When User enters the "<usrname>" and "<passwd>" in the text fields
	When User clicks on submit button
	Then User is navigated to home page
 
Examples: 
| usrname | passwd   |
| Admin   | admin123 |

@regression
Scenario Outline: Verify login for orange hrm website for invalid credentails
	When User enters the "<usrname>" and "<passwd>" in the text fields
	When User clicks on submit button
	Then User is  on the  home page and error is displayed
 
Examples: 
| usrname | passwd   |
| Admin   | admin1235 |


