Feature: Add_Skill
	In order to update my profile 
	As a skill trader
	I want to add the Skills that I know

@mytag
Scenario: Check if user could able to add Skills  
	Given I clicked on the Skills tab under Profile page
	When I add  Skills 
	Then that Skills should be displayed on my listings