Feature: CheckExistData
	Check exists data

@mytag
Scenario: Check exist data
	Given I open "https://localhost:44377/Goods" pages
	When I check new data
	Then Test is sucssesfull