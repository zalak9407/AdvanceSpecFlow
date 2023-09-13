Feature: LoginFeature

As a Existing user 
I would like to login into Mars 
so that I can see My profile


Scenario: I use valid inputs to login
	Given I click on Signin button
	When I enter valid Username and Password
	Then I should be able to see my Username in the profile page  

Scenario: Login with invalid Username and Password
    Given I click on Signin button
    When I enter invalid Username and Password
    Then I should see the Invalid Username error message

Scenario: Login with 2nd Record data(null Username and Password) from my LoginUserData file
    Given I click on Signin button
    When I Enter null Username and Password
    Then I should see The error Message like Please enter valid email address

Scenario: Login with 3rd Record data(Invalid Username and null 5symbols Password) from my LoginUserData file
    Given I click on Signin button
    When I Enter Invalid Username and null 5 symbols Password
    Then I should see The error Message like Please enter valid email address and Password must be at least 6character

Scenario: Login with 4th Record data(No value in Username and Password) from my LoginUserData file
    Given I click on Signin button
    When I am not entering any value in Username and Password
    Then I should see The error Message like Please enter valid email address and Password must be at least 6character

Scenario: Login with 5th Record data(Invalid Username and no Password) from my LoginUserData file
    Given I click on Signin button
    When I Enter invalid Username and without Password try to login
    Then I should see The error Message like Please enter valid email address and Password must be at least 6character

Scenario: Login with 6th Record data(Random Username and  Password) from my LoginUserData file
    Given I click on Signin button
    When I Enter random Username and Password
    Then I should see the Invalid Username error message

Scenario: Login with 7th Record data(No Username and Wrong Password) from my LoginUserData file
    Given I click on Signin button
    When I do not enter Username and enter wrong PAssword
    Then I should see The error Message like Please enter valid email address

Scenario: Login with 8th Record data(Valid Username and 5digit Password) from my LoginUserData file
    Given I click on Signin button
    When I Enter valid Username and 5Digit PAssword
    Then I should see The error Message like Password must be at least 6character

Scenario: Login with 9th Record data(wrong Username and Password) from my LoginUserData file
    Given I click on Signin button
    When I Enter Wrong Username and wrong PAssword
    Then I should see the Invalid Username error message