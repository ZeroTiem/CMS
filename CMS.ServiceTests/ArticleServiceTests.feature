Feature: ArticleServiceTests
	In order to 避免邏輯錯誤
	As a 專業的工程師
	I want to 驗證是否可以正常運行邏輯與預期是否一樣

@mytag
Scenario: Article新增邏輯
	Given 要新增的資料 
	| CategoryID | Tags | Title | ImgUrl     | Content | CreateAccount | ModifyAccount | PublishStatus |
	| 1          | tag1 | name  | "test.jpg" | test    | test          | test          | 1             |
	When 使用Add方法新增
	Then 預期回傳true

Scenario: Article修改ByArticleID邏輯
	Given 要修改的資料
	| CategoryID | Tags | Title | ImgUrl     | Content | CreateAccount | ModifyAccount | PublishStatus |
	| 1          | tag1 | name  | "test.jpg" | test    | test          | test          | 1             |
	And ArticleID 是 1
	When 使用Update方法修改
	Then 預期回傳true

Scenario: Article查詢ByArticleID邏輯
	Given 預期回傳
	| CategoryID | Tags | Title | ImgUrl     | Content | CreateAccount | ModifyAccount | PublishStatus |
	| 1          | tag1 | name  | "test.jpg" | test    | test          | test          | 1             |
	And ArticleID 是 1
	When 使用GetByArticleID方法
	Then 要跟預期內容一樣

Scenario: Article查詢分頁邏輯
	Given 預期回傳
	| CategoryID | Tags | Title | ImgUrl     | Content | CreateAccount | ModifyAccount | PublishStatus |
	| 1          | tag1 | name  | "test.jpg" | test    | test          | test          | 1             |
	| 2          | tag2 | name  | "test.jpg" | test    | test          | test          | 1             |
	| 3          | tag3 | name  | "test.jpg" | test    | test          | test          | 1             |
	| 4          | tag4 | name  | "test.jpg" | test    | test          | test          | 1             |
	When 使用GetByPage方法 從 第 1 筆 取 4 筆
	Then 要跟預期內容一樣

Scenario: Category刪除ByArticleID邏輯
	Given ArticleID 是 1
	When 使用Delete方法
	Then 預期回傳true
