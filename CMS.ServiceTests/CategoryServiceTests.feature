Feature: CategoryServiceTests
	In order to 避免邏輯錯誤
	As a 專業的工程師
	I want to 驗證是否可以正常運行邏輯與預期是否一樣

@mytag
Scenario: Category新增邏輯
	Given 要新增的資料
	| CategoryName | Kind | publishStatus | CreateAccount | ModifyAccount |
	| test         | 1    | 1             | test          | test          |
	When 使用Add方法新增
	Then 預期回傳true

Scenario: Category修改ByCategoryID邏輯
	Given 要修改的資料
	| CategoryName | Kind | publishStatus | CreateAccount | ModifyAccount |
	| test         | 1    | 1             | test          | test          |
	And CategoryID 是 1
	When 使用Update方法修改
	Then 預期回傳true

Scenario: Category查詢ByCategoryID邏輯
	Given 預期回傳
	| CategoryName | Kind | publishStatus | CreateAccount | CreateDateTime | ModifyAccount | ModifyDateTime |
	| test         | 1    | 1             | test          | 2017-02-27     | test          | 2017-02-27     |
	And CategoryID 是 1
	When 使用GetByCategoryID方法
	Then 要跟預期內容一樣

Scenario: Category查詢分頁邏輯
	Given 預期回傳
	| CategoryName | Kind | publishStatus | CreateAccount | CreateDateTime | ModifyAccount | ModifyDateTime |
	| test         | 1    | 1             | test          | 2017-02-27     | test          | 2017-02-27     |
	| test         | 2    | 2             | test          | 2017-02-27     | test          | 2017-02-27     |
	| test         | 3    | 3             | test          | 2017-02-27     | test          | 2017-02-27     |
	| test         | 4    | 4             | test          | 2017-02-27     | test          | 2017-02-27     |
	When 使用GetByPage方法 從 第 1 筆 取 4 筆
	Then 要跟預期內容一樣

Scenario: Category刪除ByCategoryID邏輯
	Given CategoryID 是 1
	When 使用Delete方法
	Then 預期回傳true
