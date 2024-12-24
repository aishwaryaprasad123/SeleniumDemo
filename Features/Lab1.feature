@Sprint3
Feature: Lab1

A short summary of the feature

@sanity
Scenario: Verify form completion without clicking submit
    Given User is on the registration page
    When User enters "<name>", "<email>", and "<password>" in the text fields
    And User selects "<gender>" as gender
    And User chooses "<employmentStatus>" using the radio button
    And User selects "<dateOfBirth>" as date of birth
    Then The submit button should be enabled but not clicked
 
    Examples:
      | name        | email             | password  | gender  | employmentStatus | dateOfBirth |
      | Aishwarya    | aish@gmail.com  | pass123   | Male    | Employed         | 1999-01-02  |
      | Varsha   | varsh@gmail.com  | securePwd | Female  | Student          | 2000-05-06  |