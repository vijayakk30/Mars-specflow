Feature: AddProfile TestCases
	In order to update my profile 
	As a Skill Seller
	I want to add the Education,Skills and Certification details
@mytag
Scenario: Check if user could able to add Education details 
	Given I clicked on the Education tab under Profile page
	When I add  education details
	Then that Education details should be displayed on my listings


	@mytag
Scenario: Check if user could able to add Skills  
	Given I clicked on the Skills tab under Profile page
	When I add  Skills 
	Then that Skills should be displayed on my listings

	@mytag
Scenario: Check if user could able to add Certifications  
	Given I clicked on the Certifications tab under Profile page
	When I add  Certifications 
	Then that Certifications should be displayed on my listings


Feature: Update Profile TestCases
	In order to update my profile 
	As a Skill Seller
	I want to Update the Language,Education,Skills and Certification details

@mytag
Scenario: Check if user could able to update Language details 
	Given I clicked on the Language tab under Profile page
	When I update  Language details
	Then that  updated Language details should be displayed on my listings


@mytag
Scenario: Check if user could able to update Education details 
	Given I clicked on the Education tab under Profile page
	When I update  education details
	Then that  updated Education details should be displayed on my listings

@mytag
Scenario: Check if user could able to Update Skills  
	Given I clicked on the Skills tab under Profile page
	When I update Skills 
	Then that  updated Skills should be displayed on my listings
@mytag
Scenario: Check if user could able to Update Certification Details 
	Given I clicked on the Certification tab under Profile page
	When I update Certifications 
	Then that  updated Certifications should be displayed on my listings

