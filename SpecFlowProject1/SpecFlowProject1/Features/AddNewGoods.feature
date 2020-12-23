Feature: AddNewGoods
	Add new goods in list

@mytag
Scenario: Add new goods
	Given I open "https://localhost:44377/Goods" pages
	When I Click button "Добавить запись"
	And Enter informations "Title" and "Color" and "Price"
	And Click "Create"
	Then Goods added is succesful