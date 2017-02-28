Feature: ArticleRepositoryTests
	In order to 是否對資料庫正常動作
	As a 專業的工程師
	I want to be 驗證資料庫資料是否跟我預期的一樣

@mytag
Scenario: Article新增一筆
	Given 要新增的資料
	| CategoryID | Tags | Title | ImgUrl     | Content | CreateAccount | ModfiyAccount | PublishStatus |
	| 1          | tag1 | name  | "test.jpg" | test    | test          | test          | 1             |
	And 預期回傳資料
	| CategoryID | Tags | Title | ImgUrl     | Content | CreateAccount | ModfiyAccount | PublishStatus |
	| 1          | tag1 | name  | "test.jpg" | test    | test          | test          | 1             |
	When 透過Add方法新增一筆資料到Article裡面
	Then 要跟預期內容一樣

Scenario: Article修改一筆ByArticleID
	Given 新增測試資料
	| CategoryID | Tags | Title | ImgUrl     | Content | CreateAccount | CreateDateTime | ModfiyAccount | ModfiyDateTime | PublishStatus |
	| 1          | tag1 | name  | "test.jpg" | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             |
	Given 要修改的資料
	| CategoryID | Tags | Title | ImgUrl      | Content | ModfiyAccount | PublishStatus |
	| 2          | tag2 | name2 | "test2.jpg" | test2   | test2         | 2             |
	And 預期回傳資料
	| CategoryID | Tags | Title | ImgUrl      | Content | ModfiyAccount | PublishStatus |
	| 2          | tag2 | name2 | "test2.jpg" | test2   | test2         | 2             |
	When 透過Udate方法修改資料
	Then 要跟預期內容一樣

Scenario: Article查詢一筆ByArticleID
	Given 新增測試資料
	| CategoryID | Tags | Title | ImgUrl      | Content | CreateAccount | CreateDateTime | ModfiyAccount | ModfiyDateTime | PublishStatus |
	| 1          | tag1 | name  | "test.jpg"  | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             |
	| 2          | tag2 | name2 | "test2.jpg" | test2   | test2         | 2017-02-28     | test2          | 2017-02-28     | 2             |
	And 預期回傳資料
	| CategoryID | Tags | Title | ImgUrl      | Content | ModfiyAccount | PublishStatus |
	| 2          | tag2 | name2 | "test2.jpg" | test2   | test2         | 2             |
	When 透過GetByArticleID方法查詢第 2 筆資料
	Then 要跟預期內容一樣

Scenario: Article刪除一筆ByArticleID
	Given 新增測試資料
	| CategoryID | Tags | Title | ImgUrl      | Content | CreateAccount | CreateDateTime | ModfiyAccount | ModfiyDateTime | PublishStatus |
	| 1          | tag1 | name  | "test.jpg"  | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             |
	| 2          | tag2 | name2 | "test2.jpg" | test2   | test2         | 2017-02-28     | test2         | 2017-02-28     | 2             |
	And 預期回傳資料
	| CategoryID | Tags | Title | ImgUrl      | Content | ModfiyAccount | PublishStatus |
	| 2          | tag2 | name2 | "test2.jpg" | test2   | test2         | 2             |
	When 透過Delete方法刪除第一筆資料
	Then 要跟預期內容一樣

Scenario: Article查詢分頁
	Given 新增測試資料
	| CategoryID | Tags | Title | ImgUrl      | Content | CreateAccount | CreateDateTime | ModfiyAccount | ModfiyDateTime | PublishStatus |
	| 1          | tag1 | name  | "test.jpg"  | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             |
	| 2          | tag2 | name2 | "test2.jpg" | test2   | test2         | 2017-02-28     | test2         | 2017-02-28     | 2             |
	| 3          | tag1 | name  | "test.jpg"  | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             |
	| 4          | tag1 | name  | "test.jpg"  | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             |
	| 5          | tag1 | name  | "test.jpg"  | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             |
	| 6          | tag1 | name  | "test.jpg"  | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             |
	| 7          | tag1 | name  | "test.jpg"  | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             |
	| 8          | tag1 | name  | "test.jpg"  | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             |
	| 9          | tag1 | name  | "test.jpg"  | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             |
	| 10          | tag1 | name  | "test.jpg"  | test    | test          | 2017-02-28     | test          | 2017-02-28     | 1             | 
	And 預期回傳資料
	| CategoryID | Tags | Title | ImgUrl      | Content | ModfiyAccount | PublishStatus |
	| 6          | tag1 | name  | "test.jpg"  | test    | test          | 1             |
	| 7          | tag1 | name  | "test.jpg"  | test    | test          | 1             |
	| 8          | tag1 | name  | "test.jpg"  | test    | test          | 1             |
	When 透過GetByPage方法取第6筆取3筆
	Then 要跟預期內容一樣
