using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosPortfolio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region [로그인] 버튼 클릭 함수입니다.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT * FROM member WHERE name=@name AND pw=@pw";

                using (SqlConnection conn = Connection.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(selectQuery, conn);

                    // 사용자 입력값 파라미터에 넣기
                    cmd.Parameters.AddWithValue("@name", txtID.Text.Trim());
                    cmd.Parameters.AddWithValue("@pw", txtPW.Text.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("로그인 되었습니다.", "확인해주세요");

                            Main main = new Main();
                            main.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.", "확인해주세요");
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnLogin_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [로그인] 버튼 Enter 함수입니다.
        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnLogin.PerformClick(); // 버튼 클릭한 것처럼 실행
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnLogin_KeyPress 에러: " + ex.Message, "에러");
            }
        }
        #endregion
    }
}
