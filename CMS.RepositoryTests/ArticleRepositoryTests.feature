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
	| ArticleName | Kind | publishStatus | CreateAccount | CreateDateTime | ModfiyAccount | ModfiyDateTime |
	| 1            | 1    | 1             | test          | 2017-02-27     | test          | 2017-02-27     |
	| 2            | 2    | 2             | test2         | 2017-02-27     | test2         | 2017-02-27     |
	And 預期回傳資料
	| ArticleName | Kind | publishStatus | CreateAccount | ModfiyAccount |
	| 2            | 2    | 2             | test2         | test2         |
	When 透過GetByArticleID方法查詢第 2 筆資料
	Then 要跟預期內容一樣

Scenario: Article刪除一筆ByArticleID
	Given 新增測試資料
	| ArticleName | Kind | publishStatus | CreateAccount | CreateDateTime | ModfiyAccount | ModfiyDateTime |
	| 1            | 1    | 1             | test          | 2017-02-27     | test          | 2017-02-27     |
	| 2            | 2    | 2             | test2         | 2017-02-27     | test2         | 2017-02-27     |
	And 預期回傳資料
	| ArticleName | Kind | publishStatus | CreateAccount | ModfiyAccount |
	| 2            | 2    | 2             | test2         | test2         |
	When 透過Delete方法刪除第一筆資料
	Then 要跟預期內容一樣

Scenario: Article查詢分頁
	Given 新增測試資料
	| ArticleName | Kind | publishStatus | CreateAccount | CreateDateTime | ModfiyAccount | ModfiyDateTime |
	| 1            | 1    | 1             | test1         | 2017-02-27     | test1         | 2017-02-27     |
	| 2            | 2    | 2             | test2         | 2017-02-27     | test2         | 2017-02-27     |
	| 3            | 3    | 3             | test3         | 2017-02-27     | test3         | 2017-02-27     |
	| 4            | 4    | 4             | test4         | 2017-02-27     | test4         | 2017-02-27     |
	| 5            | 5    | 5             | test5         | 2017-02-27     | test5         | 2017-02-27     |
	| 6            | 6    | 6             | test6         | 2017-02-27     | test6         | 2017-02-27     |
	| 7            | 7    | 7             | test7         | 2017-02-27     | test7         | 2017-02-27     |
	| 8            | 8    | 8             | test8         | 2017-02-27     | test8         | 2017-02-27     |
	| 9            | 9    | 9             | test9         | 2017-02-27     | test9         | 2017-02-27     |
	| 10           | 10   | 10            | test10        | 2017-02-27     | test10        | 2017-02-27     |
	And 預期回傳資料
	| ArticleName | Kind | publishStatus | CreateAccount | ModfiyAccount |
	| 7            | 7    | 7             | test7         | test7         |
	| 8            | 8    | 8             | test8         | test8         |
	| 9            | 9    | 9             | test9         | test9         |
	| 10           | 10   | 10            | test10        | test10        |
	When 透過GetByPage方法取第7筆取4筆
	Then 要跟預期內容一樣
