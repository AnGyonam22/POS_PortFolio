using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PosPortfolio
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

            Db_Product_List();
        }

        #region [DB의 상품 리스트]를 상단 화면에 뿌려주고. 클릭시 DataGridView에 [바코드],[상품명],[가격],[수량]이 나옵니다.
        private void Db_Product_List()
        {
            try
            {
                if (Connection.CheckConnection())
                {
                    panProductDBList.Controls.Clear(); 

                    string selectQuery = "SELECT * FROM product";

                    using (SqlConnection conn = Connection.GetConnection())
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int x = 10, y = 10; // 초기 위치

                            while (reader.Read())
                            {
                                string productBarcode  = reader["barcode"].ToString();
                                string productName     = reader["name"].ToString().Trim();
                                string productNumber   = reader["number"].ToString().Trim();
                                string productPrice    = reader["price"].ToString().Trim();

                                

                                Panel itemPanel = new Panel();
                                itemPanel.Size = new Size(100, 120);
                                itemPanel.Location = new Point(x, y);
                                itemPanel.BorderStyle = BorderStyle.FixedSingle;

                                PictureBox pic = new PictureBox();
                                pic.Size = new Size(90, 60);
                                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                                pic.Location = new Point(5, 5);

                                if (!reader.IsDBNull(0))
                                {
                                    byte[] imgBytes = (byte[])reader["img"];
                                    using (MemoryStream ms = new MemoryStream(imgBytes))
                                    {
                                        pic.Image = System.Drawing.Image.FromStream(ms);
                                    }
                                }

                                Label lblName = new Label();
                                lblName.Text = reader["name"].ToString().Trim();
                                lblName.Location = new Point(5, 70);
                                lblName.Size = new Size(90, 20);
                                lblName.TextAlign = ContentAlignment.MiddleCenter;
                                lblName.Font = new Font("맑은 고딕", 8, FontStyle.Bold);

                                Label lblPrice = new Label();
                                lblPrice.Text = reader["price"].ToString().Trim();
                                lblPrice.Location = new Point(5, 95);
                                lblPrice.Size = new Size(90, 20);
                                lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                                lblPrice.Font = new Font("맑은 고딕", 8);

                                itemPanel.Controls.Add(pic);
                                itemPanel.Controls.Add(lblName);
                                itemPanel.Controls.Add(lblPrice);

                                panProductDBList.Controls.Add(itemPanel);
                                x += 110;
                                if (x + 100 > panProductDBList.Width)
                                {
                                    x = 10;
                                    y += 140;
                                }

                                string b = productBarcode;
                                string n = productName;
                                string num = productNumber;
                                string p = productPrice;

                                // DB 상품 클릭하면 DataGridView에 뿌려지고.
                                // 총 가격을 표시해줌.
                                EventHandler addToGrid = (s, eArgs) =>
                                {
                                    dataGridView1.Rows.Add(b, n, num, p);

                                    int totalPrice = 0;
                                    foreach (DataGridViewRow row in dataGridView1.Rows)
                                    {
                                        if (row.Cells[3].Value != null &&
                                            int.TryParse(row.Cells[3].Value.ToString(), out int price))
                                        {
                                            totalPrice += price;
                                        }
                                    }
                                    lblTotal.Text = totalPrice.ToString();
                                };

                                pic.Click      += addToGrid;
                                lblName.Click  += addToGrid;
                                lblPrice.Click += addToGrid;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Db_Product_List 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [1] 버튼 클릭 함수입니다.
        private void btnOne_Click(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text += "1";
            }
            catch(Exception ex)
            {
                MessageBox.Show("btnOne_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [2] 버튼 클릭 함수입니다.
        private void btnTwo_Click(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text += "2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnTwo_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [3] 버튼 클릭 함수입니다.
        private void btnThree_Click(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text += "3";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnThree_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [4] 버튼 클릭 함수입니다.
        private void btnFor_Click(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text += "4";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnFor_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [5] 버튼 클릭 함수입니다.
        private void btnFive_Click(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text += "5";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnFive_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [6] 버튼 클릭 함수입니다.
        private void btnSix_Click(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text += "6";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnSix_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [7] 버튼 클릭 함수입니다.
        private void btnSeven_Click(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text += "7";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnSeven_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [8] 버튼 클릭 함수입니다.
        private void btnEight_Click(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text += "8";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnEight_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [9] 버튼 클릭 함수입니다.
        private void btnNine_Click(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text += "9";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnNine_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [0] 버튼 클릭 함수입니다.
        private void btnZero_Click(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text += "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnZero_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [<-] 버튼 클릭 함수입니다.
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtEdit.Text))
                {
                    txtEdit.Text = txtEdit.Text.Remove(txtEdit.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnBack_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [상품 등록] 버튼 클릭 함수입니다.
        private void btnProductAddDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ProductAdd add = new ProductAdd();
                add.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnProductAddDelete_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [현금결제] 버튼 클릭 함수입니다.
        private void btnCash_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtEdit.Text))
                {
                    if (Convert.ToInt32(lblTotal.Text) == Convert.ToInt32(txtEdit.Text))
                    {
                        MessageBox.Show("결제가 되었습니다.", "확인해주세요.");
                        lblTotal.Text = string.Empty;
                        txtEdit.Text = string.Empty;
                        dataGridView1.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("총가격과 결제금액이 같지않습니다.", "확인해주세요");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("가격을 입력 해주세요.", "확인해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnCash_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion


        #region [갱신] 버튼 클릭 함수입니다.
        private void btnReplash_Click(object sender, EventArgs e)
        {
            try
            {
                if (Connection.CheckConnection())
                {
                    panProductDBList.Controls.Clear();

                    string selectQuery = "SELECT * FROM product";

                    using (SqlConnection conn = Connection.GetConnection())
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int x = 10, y = 10; // 초기 위치

                            while (reader.Read())
                            {
                                string productBarcode = reader["barcode"].ToString();
                                string productName = reader["name"].ToString().Trim();
                                string productNumber = reader["number"].ToString().Trim();
                                string productPrice = reader["price"].ToString().Trim();



                                Panel itemPanel = new Panel();
                                itemPanel.Size = new Size(100, 120);
                                itemPanel.Location = new Point(x, y);
                                itemPanel.BorderStyle = BorderStyle.FixedSingle;

                                PictureBox pic = new PictureBox();
                                pic.Size = new Size(90, 60);
                                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                                pic.Location = new Point(5, 5);

                                if (!reader.IsDBNull(0))
                                {
                                    byte[] imgBytes = (byte[])reader["img"];
                                    using (MemoryStream ms = new MemoryStream(imgBytes))
                                    {
                                        pic.Image = System.Drawing.Image.FromStream(ms);
                                    }
                                }

                                Label lblName = new Label();
                                lblName.Text = reader["name"].ToString().Trim();
                                lblName.Location = new Point(5, 70);
                                lblName.Size = new Size(90, 20);
                                lblName.TextAlign = ContentAlignment.MiddleCenter;
                                lblName.Font = new Font("맑은 고딕", 8, FontStyle.Bold);

                                Label lblPrice = new Label();
                                lblPrice.Text = reader["price"].ToString().Trim();
                                lblPrice.Location = new Point(5, 95);
                                lblPrice.Size = new Size(90, 20);
                                lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                                lblPrice.Font = new Font("맑은 고딕", 8);

                                itemPanel.Controls.Add(pic);
                                itemPanel.Controls.Add(lblName);
                                itemPanel.Controls.Add(lblPrice);

                                panProductDBList.Controls.Add(itemPanel);
                                x += 110;
                                if (x + 100 > panProductDBList.Width)
                                {
                                    x = 10;
                                    y += 140;
                                }

                                string b = productBarcode;
                                string n = productName;
                                string num = productNumber;
                                string p = productPrice;

                                // DB 상품 클릭하면 DataGridView에 뿌려지고.
                                // 총 가격을 표시해줌.
                                EventHandler addToGrid = (s, eArgs) =>
                                {
                                    dataGridView1.Rows.Add(b, n, num, p);

                                    int totalPrice = 0;
                                    foreach (DataGridViewRow row in dataGridView1.Rows)
                                    {
                                        if (row.Cells[3].Value != null &&
                                            int.TryParse(row.Cells[3].Value.ToString(), out int price))
                                        {
                                            totalPrice += price;
                                        }
                                    }
                                    lblTotal.Text = totalPrice.ToString();
                                };

                                pic.Click += addToGrid;
                                lblName.Click += addToGrid;
                                lblPrice.Click += addToGrid;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnReplash_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion
    }
}
