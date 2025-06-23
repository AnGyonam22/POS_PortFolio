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
using System.IO;

namespace PosPortfolio
{
    public partial class ProductAdd : Form
    {
        private Main mainForm;
        private byte[] imageBytes;

        public ProductAdd()
        {
            InitializeComponent();
        }

        #region [등록하기] 버튼 클릭 함수입니다.
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Connection.CheckConnection())
                {
                    string insertQuery = "INSERT INTO product(img, barcode, name, number, price) " +
                                         "VALUES(@img, @barcode, @name, @number, @price) ";

                    SqlConnection conn = Connection.GetConnection();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(insertQuery, conn);

                    cmd.Parameters.AddWithValue("@img", imageBytes != (Object)DBNull.Value ? imageBytes : null); // ← 여기에 바이트 배열
                    cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@number", txtNumber.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);

                    int result = cmd.ExecuteNonQuery();
                    if(result > 0)
                    {
                        MessageBox.Show("저장되었습니다.", "확인해주세요.");
                    }
                    else
                    {
                        MessageBox.Show("저장 안되었습니다.", "확인해주세요.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnProductAdd_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion

        #region [이미지 선택] 버튼 클릭 함수입니다.
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromFile(ofd.FileName);

                        // 이미지 → byte[]
                        imageBytes = File.ReadAllBytes(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnSelectImage_Click 에러: " + ex.Message, "에러");
            }
        }
        #endregion
    }
}
