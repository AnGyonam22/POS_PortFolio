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
    public partial class MemberJoinList : Form
    {
        string number = string.Empty; // DataGridView의 값을 저장하기 위해 사용.
        string id = string.Empty;     // DataGridView의 값을 저장하기 위해 사용.
        string pw = string.Empty;     // DataGridView의 값을 저장하기 위해 사용.

        public MemberJoinList()
        {
            InitializeComponent();

            MemberList(); // DataGridView에 DB의 내용을 뿌려줍니다.
        }

        #region DB의 내용을 DataGridView에 뿌려줍니다.
        private void MemberList()
        {
            try
            {
                if (Connection.CheckConnection())
                {
                    string selectQuery = "SELECT * FROM member";

                    using (SqlConnection conn = Connection.GetConnection())
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(selectQuery, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);


                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.Rows.Clear(); // 기존 행만 지우고

                            foreach (DataRow dr in dt.Rows)
                            {
                                dataGridView1.Rows.Add(
                                    dr["id"].ToString(),
                                    dr["name"].ToString(),
                                    dr["pw"].ToString(),
                                    Convert.ToDateTime(dr["joinday"]).ToString("yyyy-MM-dd")
                                );
                            }
                        }
                        else { 
                            MessageBox.Show("조회된 데이터가 없습니다.", "확인해주세요.");
                        }

                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("데이터베이스가 연결되어있지 않습니다.", "확인해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MemberList 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [저장 및 수정] 버튼 함수입니다.
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Connection.CheckConnection())
                {
                    string insertUpdateQuery = "UPDATE member SET name=@id, pw=@pw WHERE id=@number";

                    SqlConnection conn = Connection.GetConnection();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(insertUpdateQuery, conn);
                   
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@pw", pw);
                    cmd.Parameters.AddWithValue("@number", number);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("데이터가 저장되었습니다.", "확인해주세요");
                    }
                    else
                    {
                        MessageBox.Show("다시 한번 확인해주세요.", "확인해주세요");
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("DB가 연결되어 있지않습니다.", "확인해주세요.");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("btnSaveUpdate_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [삭제] 버튼 함수입니다.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Connection.CheckConnection())
                {
                    string insertUpdateQuery = "DELETE FROM member WHERE name=@id AND pw=@pw ";

                    SqlConnection conn = Connection.GetConnection();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(insertUpdateQuery, conn);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@pw", pw);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("데이터가 삭제되었습니다..", "확인해주세요");
                    }
                    else
                    {
                        MessageBox.Show("다시 한번 확인해주세요.", "확인해주세요");
                    }

                    MemberList(); // DB 데이터를 불러옵니다.

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("DB가 연결되어 있지않습니다.", "확인해주세요.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnDelete_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [DataGridView Cell Click] 이벤트 함수입니다.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    number = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : null; // id
                    id     = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : null; // name
                    pw     = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : null; // pw
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("dataGridView1_CellClick 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        
    }
}
