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
    public partial class StaffForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<int> SearchIDs = new List<int>();//存 id 資料
        int DGV筆數 = 0;//DataGridView的資料筆數
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";//伺服器名稱
            scsb.InitialCatalog = "DanDan";//資料庫名稱
            scsb.IntegratedSecurity = true;//true -> windows驗證 , false -> SQL Server 驗證

            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            cBox權限.Items.Add("店長");
            cBox權限.Items.Add("員工");
            cBox權限.SelectedIndex = 0;

            產生員工資料表DataGridView();
        }
        void 產生員工資料表DataGridView()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select ID,Pname as 姓名,Phone as 電話,Paddress as 地址,Pbirth as 生日,Pemail as Email,Password as 密碼,Permission as 權限 from Person where Permission=2 or Permission=3;";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                Console.WriteLine($"DGV筆數：{dt.Rows.Count}");
                DGV筆數 = dt.Rows.Count;
                dgv員工資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
        void 清空欄位()
        {
            txtID.Clear();
            txt姓名.Clear();
            txt電話.Clear();
            txt地址.Clear();
            txtEmail.Clear();
            txt密碼.Clear();
            cBox權限.SelectedIndex = 0;
            dtp生日.Value = DateTime.Now;
        }

        private void btn資料新增_Click(object sender, EventArgs e)
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
                    cmd.Parameters.AddWithValue("@NewPtype", "已開通");

                    if (cBox權限.SelectedIndex == 0)
                        cmd.Parameters.AddWithValue("@NewPermission", 2);
                    else if (cBox權限.SelectedIndex == 1)
                        cmd.Parameters.AddWithValue("@NewPermission", 3);


                    int rows = cmd.ExecuteNonQuery();//回傳受影響的資料筆數
                    con.Close();
                    MessageBox.Show($"({rows}個資料列受影響)");
                    產生員工資料表DataGridView();
                    清空欄位();
                }
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }
        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtID.Text, out intID);

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select ID,Phone from Person where Phone=@NewPhone;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            bool exist = false; //帳號是否已存在
            if (reader.Read())
            {
                if (intID != (int)reader["ID"])
                {
                    exist = true;
                    MessageBox.Show("此帳號已存在!");
                    reader.Close();
                    con.Close();
                }

            }

            if ((exist == false) && (intID > 0) && (txt姓名.Text != "") && (txt電話.Text != "") && (txt密碼.Text != ""))
            {
                reader.Close ();

                strSQL = "update Person set Pname=@NewName, Phone=@NewPhone, Paddress=@NewAddress, Pemail=@NewEmail, Pbirth=@NewBirth, Password=@NewPassword, Permission=@NewPermission where id=@SearchID;";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);

                if (cBox權限.SelectedIndex == 0)
                    cmd.Parameters.AddWithValue("@NewPermission", 2);
                else if (cBox權限.SelectedIndex == 1)
                    cmd.Parameters.AddWithValue("@NewPermission", 3);

                int rows = cmd.ExecuteNonQuery();//回傳受影響的資料筆數
                con.Close();
                MessageBox.Show($"({rows}個資料列受影響)");
                產生員工資料表DataGridView();
            }
            else if (exist == false)
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        private void btn資料刪除_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要刪除此筆資料嗎?", "刪除確認", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int intID = 0;
                Int32.TryParse(txtID.Text, out intID);

                if (intID > 0)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();
                    string strSQL = "delete from Person where id = @DeleteID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteID", intID);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    清空欄位();
                    MessageBox.Show($"資料已刪除,{rows}筆資料受影響");
                    產生員工資料表DataGridView();
                }
            }
                
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void dgv員工資料列表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < DGV筆數))
            {
                string strSelectID = dgv員工資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from Person where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtID.Text = reader["ID"].ToString();
                    txt姓名.Text = reader["Pname"].ToString();
                    txt電話.Text = reader["Phone"].ToString();
                    txt地址.Text = reader["Paddress"].ToString();
                    txtEmail.Text = reader["Pemail"].ToString();
                    txt密碼.Text = reader["Password"].ToString();
                    dtp生日.Value = (DateTime)reader["Pbirth"];

                    if ((int)reader["Permission"] == 2)
                        cBox權限.SelectedIndex = 0;
                    else if ((int)reader["Permission"] == 3)
                        cBox權限.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
