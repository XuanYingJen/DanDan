using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ProductsDetailForm : Form
    {
        public int selectID = 0;
        public string strType = "";
        int intType = 0;
        string image_修改後的檔名 = "";
        bool is修改圖檔 = false;

        
        public ProductsDetailForm()
        {
            InitializeComponent();
        }

        private void ProductsDetailForm_Load(object sender, EventArgs e)
        {
            txtID.Text = selectID.ToString();
            txt商品類別.Text = strType;

            if (selectID == 0) //新增商品
            {
                groupBox商品新增.Visible = true;
                groupBox商品修改.Visible = false;
                btn刪除商品.Visible = false;
            }
            else               //修改商品
            {
                groupBox商品新增.Visible = false;
                groupBox商品修改.Visible = true;
                btn刪除商品.Visible = true;
            }

            if (strType == "漢堡") intType = 1;
            else if (strType == "點心") intType = 2;
            else if (strType == "飲料") intType = 3;
            else intType = 0;

            顯示商品詳細資訊();
        }
        void 顯示商品詳細資訊()
        {
            if(selectID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from Product where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtID.Text = reader["id"].ToString();
                    txt商品名稱.Text = reader["pname"].ToString();
                    txt商品價格.Text = reader["price"].ToString();
                    txt商品描述.Text = reader["pdesc"].ToString();
                    image_修改後的檔名 = reader["pimage"].ToString();
                    string 完整圖檔路徑 = GlobalVar.image_dir + @"\" + image_修改後的檔名;
                    pictureBox商品圖檔.Image = Image.FromFile(完整圖檔路徑);
                }
                reader.Close();
                con.Close();
            }
        }
        void 選取商品照片()
        {
            OpenFileDialog f = new OpenFileDialog(); //檔案開啟對話框
            f.Filter = "檔案類型(*.jpg, *.jpeg,*.png)|*.jpeg;*.jpg;*.png";//篩選檔案類型 -> 自由發揮|接受的附檔名
            DialogResult R = f.ShowDialog();  //使用者回傳的結果
            if (R == DialogResult.OK) //使用者選擇"確定"
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);//f.FileName完整檔案路徑
                string 圖片副檔名 = System.IO.Path.GetExtension(f.SafeFileName).ToLower();
                Console.WriteLine(圖片副檔名);
                Random myRnd = new Random();
                image_修改後的檔名 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + 圖片副檔名;
                is修改圖檔 = true;
                Console.WriteLine(image_修改後的檔名);
            }
        }

        private void btn選取商品照片_Click(object sender, EventArgs e)
        {
            選取商品照片();
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "update Product set PName=@NewName, Price=@NewPrice, Pdesc=@NewDesc, Pimage=@NewImage where ID=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_修改後的檔名);

                int rows = cmd.ExecuteNonQuery(); //如果用來新增修改刪除,成功它會返回受影響的列數,失敗返回0
                con.Close();

                if (is修改圖檔 == true)
                {
                    string 完整圖檔路徑 = GlobalVar.image_dir + @"\" + image_修改後的檔名;
                    pictureBox商品圖檔.Image.Save(完整圖檔路徑);
                    is修改圖檔 = false;
                }
                MessageBox.Show($"資料異動成功, 影響{rows}筆資料");
                this.Close();
            }
            else
            {
                MessageBox.Show("請檢查必填欄位。");
            }
        }

        private void btn選取商品照片2_Click(object sender, EventArgs e)
        {
            選取商品照片();
        }

        private void btn儲存修改2_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into Product values(@NewName, @NewPrice, @NewDesc, @NewImage, @NewType);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_修改後的檔名);
                cmd.Parameters.AddWithValue("@NewType", intType);

                int rows = cmd.ExecuteNonQuery(); //如果用來新增修改刪除,成功它會返回受影響的列數,失敗返回0
                con.Close();

                if (is修改圖檔 == true)
                {
                    string 完整圖檔路徑 = GlobalVar.image_dir + @"\" + image_修改後的檔名;
                    pictureBox商品圖檔.Image.Save(完整圖檔路徑);
                    is修改圖檔 = false;
                }
                MessageBox.Show($"資料異動成功, 影響{rows}筆資料");
                this.Close();
            }
            else
            {
                MessageBox.Show("請檢查必填欄位。");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txt商品名稱.Clear();
            txt商品價格.Clear();
            txt商品描述.Clear();
            pictureBox商品圖檔.Image = null;
        }

        private void btn刪除商品_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("確認刪除?", "是否刪除?", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "delete from Product where ID=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                int rows = cmd.ExecuteNonQuery(); //如果用來新增修改刪除,成功它會返回受影響的列數,失敗返回0
                con.Close();

                MessageBox.Show($"資料異動成功, 影響{rows}筆資料");
                this.Close();
            }
        }
    }
}
