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
using System.Xml.Linq;

namespace PosPortfolio
{
    public partial class MemberJoin : Form
    {
        public MemberJoin()
        {
            InitializeComponent();

            txtAdminPw.Focus(); // TextBox에 focus가 가게합니다.
            grpAdminPw.Visible = false; // 관리자 비밀번호 창을 처음에는 숨김처리 합니다.> [회원정보보기] 버튼 클릭하면 나옵니다.
        }

        #region [회원가입] 버튼입니다.
        private void btnJoin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Connection.CheckConnection())
                {
                    string insertQuery = "INSERT INTO member(name, pw) VALUES(@name, @pw)";

                    SqlConnection conn = Connection.GetConnection();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@name", txtId.Text.Trim());
                    cmd.Parameters.AddWithValue("@pw", txtPw.Text.Trim());

                    int result = cmd.ExecuteNonQuery();
                    if(result > 0)
                    {
                        MessageBox.Show("회원가입이 완료되었습니다.", "확인해주세요");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("다시 한번 입력해주세요.", "확인해주세요");
                        return;
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("데이터베이스가 연결되어있지 않습니다.", "확인해주세요.");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("DB가 연결되어 있지않습니다.", "확인해주세요.");
            }
        }
        #endregion

        #region [회원정보보기] 버튼 입니다.(관리자 비밀번호 창이 나옵니다.)
        private void btnJoinList_Click(object sender, EventArgs e)
        {
            try
            {
                grpAdminPw.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("btnJoinList_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region 관리자 비밀번호 창의 [닫기] 버튼입니다.
        private void lblCancel_Click(object sender, EventArgs e)
        {
            try
            {
                grpAdminPw.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lblCancel_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region 관리자 비밀번호 창의 [확인] 버튼입니다.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtAdminPw.Text.Trim() == "2580")
                {
                    MemberJoinList mList = new MemberJoinList();
                    mList.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("2580이 비밀번호입니다. 2580 눌러주세요", "확인해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnConfirm_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region 관리자 비밀번호 창의 [확인]을 Enter로 실행 시켜주는 KeyPress함수입니다. 
        private void txtAdminPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnConfirm.PerformClick(); // 버튼 클릭한 것처럼 실행
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("txtAdminPw_KeyPress 에러: " + ex.Message, "에러");
            }
        }
        #endregion
    }
}
