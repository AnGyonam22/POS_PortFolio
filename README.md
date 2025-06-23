# POS 판매 프로그램
winform을 이용해서 POS 판매프로그램을 만들었습니다.

# 실행 방법
1."회원가입"으로 아이디를 생성합니다. <br/>
2."판매시작"으로 로그인을 합니다. <br/>
3."상품등록"으로 이미지와 내용을 입력하고 등록 버튼을 누릅니다. <br/>
4."DB상품갱신"눌러서 추가한 상품이 나오게 합니다.
5.추가한 상품을 클릭하면 DataGridView에 나옵니다.
6.합산한 결과가 밑에 Total에 나옵니다.

# 사용한 DB와 테이블입니다.
```SQL
DB 생성: CREATE DATABASE pos;

회원가입 테이블 생성 :
CREATE table member(
 id INT IDENTITY(1,1) PRIMARY KEY,
 name char(30) NOT NULL,
 pw char(30) NOT NULL,
 joinday DATETIME DEFAULT GETDATE() 
);

상품 목록 테이블 생성
create table product(
	img VARBINARY(MAX),
	barcode char(20) NOT NULL,
	name char(50) NOT NULL,
	number char(50) NOT NULL,
	price char(50) NOT NULL
);
```
