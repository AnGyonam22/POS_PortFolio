- 사용한 DB와 테이블입니다.
------------------------
DB 생성: CREATE DATABASE pos;
------------------------------------------------------------------------------------------------
회원가입 테이블 생성 :
CREATE table member(
 id INT IDENTITY(1,1) PRIMARY KEY,
 name char(30) NOT NULL,
 pw char(30) NOT NULL,
 joinday DATETIME DEFAULT GETDATE() 
);
------------------------------------------------------------------------
상품 목록 테이블 생성
create table product(
	img VARBINARY(MAX),
	barcode char(20) NOT NULL,
	name char(50) NOT NULL,
	number char(50) NOT NULL,
	price char(50) NOT NULL
);
