Feature: CheckExistButtonDelete
	Check exist button delete

@mytag
Scenario: Check exist button delete
	Given Find element on page for delete and click
	When Click "Удалить"
	Then Сheck delete is successful