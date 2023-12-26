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
    public partial class LoginForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "DanDan";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            int intID = 0;
            if ((txt帳號.Text != "") && (txt密碼.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from Person where Phone = @SearchPhone and Password=@SearchPassword and Ptype=@SearchPtype;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchPhone", txt帳號.Text);
                cmd.Parameters.AddWithValue("@SearchPassword", txt密碼.Text);
                cmd.Parameters.AddWithValue("@SearchPtype", "已開通");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    GlobalVar.is登入成功 = true;
                    GlobalVar.使用者名稱 = reader["Pname"].ToString();
                    GlobalVar.使用者電話 = reader["Phone"].ToString();
                    GlobalVar.使用者ID = (int)reader["ID"];
                    GlobalVar.使用者權限 = (int)reader["Permission"];
                    MessageBox.Show($"登入成功!\n{GlobalVar.使用者名稱}，歡迎使用本程式。");
                    this.Close();//關閉表單
                }
                
                reader.Close();
                con.Close();
                if (GlobalVar.is登入成功 == false)
                {
                    MessageBox.Show("登入失敗");
                }
            }
            else
            {
                MessageBox.Show("請輸入登入資料");
            }
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            RegisterForm myRigisterForm = new RegisterForm();
            myRigisterForm.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVar.is登入成功 == true)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
