Feature: CategoryRepositoryTests
	In order to 是否對資料庫正常動作
	As a 專業的工程師
	I want to be 驗證資料庫資料是否跟我預期的一樣

@mytag
Scenario: Category新增一筆
	Given 要新增的資料
	| CategoryName | Kind | publishStatus | CreateAccount | ModfiyAccount |
	| test         | 1    | 1             | test          | test          |
	And 預期回傳資料
	| CategoryName | Kind | publishStatus | CreateAccount | ModfiyAccount |
	| test         | 1    | 1             | test          | test          |
	When 透過Add方法新增一筆資料到Category裡面
	Then 要跟預期內容一樣

Scenario: Category修改一筆ByCategoryID
	Given 新增測試資料
	| CategoryName | Kind | publishStatus | CreateAccount | CreateDateTime | ModfiyAccount | ModfiyDateTime |
	| test         | 1    | 1             | test          | 2017-02-27     | test          | 2017-02-27     |
	Given 要修改的資料
	| CategoryName | Kind | publishStatus | CreateAccount | ModfiyAccount |
	| test1        | 2    | 2             | test          | test1         |
	And 預期回傳資料
	| CategoryName | Kind | publishStatus | CreateAccount | ModfiyAccount |
	| test1        | 2    | 2             | test          | test1         |
	When 透過Udate方法修改資料
	Then 要跟預期內容一樣

Scenario: Category查詢一筆ByCategoryID
	Given 新增測試資料
	| CategoryName | Kind | publishStatus | CreateAccount | CreateDateTime | ModfiyAccount | ModfiyDateTime |
	| 1            | 1    | 1             | test          | 2017-02-27     | test          | 2017-02-27     |
	| 2            | 2    | 2             | test2         | 2017-02-27     | test2         | 2017-02-27     |
	And 預期回傳資料
	| CategoryName | Kind | publishStatus | CreateAccount | ModfiyAccount |
	| 2            | 2    | 2             | test2         | test2         |
	When 透過GetByCategoryID方法查詢第 2 筆資料
	Then 要跟預期內容一樣

Scenario: Category刪除一筆ByCategoryID
	Given 新增測試資料
	| CategoryName | Kind | publishStatus | CreateAccount | CreateDateTime | ModfiyAccount | ModfiyDateTime |
	| 1            | 1    | 1             | test          | 2017-02-27     | test          | 2017-02-27     |
	| 2            | 2    | 2             | test2         | 2017-02-27     | test2         | 2017-02-27     |
	And 預期回傳資料
	| CategoryName | Kind | publishStatus | CreateAccount | ModfiyAccount |
	| 2            | 2    | 2             | test2         | test2         |
	When 透過Delete方法刪除第一筆資料
	Then 要跟預期內容一樣
