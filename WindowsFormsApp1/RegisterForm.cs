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

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";//伺服器名稱
            scsb.InitialCatalog = "DanDan";//資料庫名稱
            scsb.IntegratedSecurity = true;//true -> windows驗證 , false -> SQL Server 驗證

            GlobalVar.strDBConnectionString = scsb.ConnectionString;
        }

        private void btn送出_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txt密碼.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select Phone from Person where Phone=@NewPhone;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("此帳號已存在!");
                    reader.Close();
                    con.Close();
                }
                else
                {
                    reader.Close();
                    strSQL = "insert into Person (Pname,Phone,Paddress,Pbirth,Pemail,Password,Permission,Ptype) values (@NewName,@NewPhone,@NewAddress,@NewBirth,@NewEmail,@NewPassword,@NewPermission,@NewPtype);";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                    cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                    cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                    cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                    cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                    cmd.Parameters.AddWithValue("@NewPermission", 4);
                    cmd.Parameters.AddWithValue("@NewPtype", "審核中");

                    int rows = cmd.ExecuteNonQuery();//回傳受影響的資料筆數
                    con.Close();
                    MessageBox.Show($"({rows}個資料列受影響)");

                    MessageBox.Show("已完成註冊申請，等待系統管理員審核通過即可使用~");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }
    }
}
