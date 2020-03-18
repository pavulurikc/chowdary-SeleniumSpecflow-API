Feature: TimeAndMaterial
	In order to manage Time and Materials record
	As a Turn Up portal admin
	I would like to create, Edit, View and Delete time and material records

@mytag
Scenario: i'd like to add time using valid details
	Given I have logged in TurnUp Portal
	And I navigate to Time and Material page
	Then I should be able to create time record with valid information

Scenario: i'd like to update an existing time record with new information
	Given I have logged in TurnUp Portal
	And I navigate to Time and Material page
	Then I should be able to edit time record with updated information