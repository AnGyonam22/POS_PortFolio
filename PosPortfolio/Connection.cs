using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosPortfolio
{
    internal class Connection
    {
        private static readonly string connStr = "Server=DESKTOP-V9SK341\\SQLTEST_DB;Database=pos;Integrated Security=True;";

        // MSSQL에 고정 연결 제공
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }

        // 연결 상태 확인 메서드
        public static bool CheckConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}


/*
 * 
CREATE DATABASE pos;

CREATE table member(
 id INT IDENTITY(1,1) PRIMARY KEY,
 name char(30) NOT NULL,
 pw char(30) NOT NULL,
 joinday DATETIME DEFAULT GETDATE() 
);

create table product(
	img VARBINARY(MAX),
	barcode char(20) NOT NULL,
	name char(50) NOT NULL,
	number char(50) NOT NULL,
	price char(50) NOT NULL
);

 
 */