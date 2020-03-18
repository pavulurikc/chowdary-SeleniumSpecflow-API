Feature: Customer
	In order to manage Customer record
	As a Turn Up portal admin
	I would like to create, Edit, View and Delete Customer records

@mytag
Scenario: I'd like to add Customer using valid details
	Given I logged in to TurnUp Portal
	And I navigate to Customer page
	Then I should be able to create Customer record with valid information

Scenario: i'd like to update an existing time record with new information
	Given I logged in to TurnUp Portal
	And I navigate to Customer page
	Then I should be able to edit Customer record with updated information