using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OrderDetailForm : Form
    {
        public int selectID = 0;
        int int商品單價 = 0;
        int int商品數量 = 0;
        string image_修改後的檔名 = "";

        
        

        public OrderDetailForm()
        {
            InitializeComponent();
        }

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            int商品數量 = 0;
            txt商品備註.Text = "";
            顯示商品詳細資訊();
        }
        void 顯示商品詳細資訊()
        {
            if (selectID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from Product where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int商品單價 = (int)reader["price"];
                    lbl商品顯示.Text = reader["pname"].ToString() + " $" + reader["price"].ToString();
                    image_修改後的檔名 = reader["pimage"].ToString();
                    string 完整圖檔路徑 = GlobalVar.image_dir + @"\" + image_修改後的檔名;
                    pictureBox商品圖檔.Image = Image.FromFile(完整圖檔路徑);
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn減_Click(object sender, EventArgs e)
        {
            int商品數量 = Convert.ToInt32(lbl商品數量.Text);
            if (int商品數量 <= 0)
            {
                lbl商品數量.Text = "0";
            }
            else
            {
                lbl商品數量.Text = Convert.ToString(int商品數量-1);
            }
        }

        private void btn加_Click(object sender, EventArgs e)
        {
            int商品數量 = Convert.ToInt32(lbl商品數量.Text);
            if (int商品數量 < int.MaxValue -1)
            {
                int商品數量++;
                lbl商品數量.Text = Convert.ToString(int商品數量);
            }
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            if(int商品數量 == 0)
            {
                MessageBox.Show("請選擇數量!");
            }
            else
            {
                ArrayList 訂購單品資訊 = new ArrayList();
                //string str商品列表 = "";
                訂購單品資訊.Add(lbl商品顯示.Text); //0
                訂購單品資訊.Add(int商品數量); //1
                訂購單品資訊.Add(int商品單價 * int商品數量); //2
                if (txt商品備註.Text == "")
                    訂購單品資訊.Add(txt商品備註.Text);
                else
                {
                    string remark = $"(備註：{txt商品備註.Text})";
                    訂購單品資訊.Add(remark);
                }
                GlobalVar.list訂購品項資料集合.Add(訂購單品資訊);
                MessageBox.Show("已加入購物車!");
                this.Close();
            }
            
        }
    }
}
