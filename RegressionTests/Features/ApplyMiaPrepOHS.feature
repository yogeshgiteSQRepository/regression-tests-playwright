Feature: Apply for MiaPrep Online High School
	As a parent user, register and apply for MOHS

Scenario: Sign up for MiaPrep Online High School
	Given parent user is on the miaprep online high school website
	When user click on 'Online High School' and verify partial url 'online-school'
	When user click on 'Apply Now' and verify partial url 'miaplazahelp'
	Then user verify before application page
	When user click on Next button
	Then user verify parent information page
	When user click on Next button
	Then user verify errors on page
	When user fill parent details into form using below given data
	| Key        | Value                |
	| FirstName  | John                 |
	| LastName   | Doe                  |
	| Email      | john.doe@example.com |
	| Phone      | 9881479390			|
	| Secparent  | No                   |
	| HowDidHear | TikTok               |
	| Date	     | 12-Sep-2024          |
	When user click on Next button
	Then user verify student information page
