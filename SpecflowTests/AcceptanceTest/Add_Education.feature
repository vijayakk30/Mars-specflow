Feature: AddEducation
	In order to update my profile 
	As a Skill Seller
	I want to add the Education details

@mytag
Scenario: Check if user could able to add Education details 
	Given I clicked on the Education tab under Profile page
	When I add  Education details
	Then that Education details should be displayed on my listings