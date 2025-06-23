using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosPortfolio
{
    public partial class PosWindows : Form
    {
        public PosWindows()
        {
            InitializeComponent();
        }


        #region [판매시작] 버튼을 누르면 [로그인] 창이 나옵니다.
        private void btnSalesStart_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                login.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [회원가입] 버튼을 회원가입 창이 나오게하는 함수입니다.
        private void btnJoin_Click(object sender, EventArgs e)
        {
            try
            {
                MemberJoin join = new MemberJoin();
                join.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러: " + ex.Message, "에러");
            }
        }
        #endregion
    }
}
