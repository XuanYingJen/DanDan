using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MemberForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<int> SearchIDs = new List<int>();//存 id 資料
        int DGV筆數 = 0;//DataGridView的資料筆數
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";//伺服器名稱
            scsb.InitialCatalog = "DanDan";//資料庫名稱
            scsb.IntegratedSecurity = true;//true -> windows驗證 , false -> SQL Server 驗證

            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            cbox搜尋欄位.Items.Add("姓名");
            cbox搜尋欄位.Items.Add("電話");
            cbox搜尋欄位.Items.Add("地址");
            cbox搜尋欄位.Items.Add("email");
            cbox搜尋欄位.SelectedIndex = 0;


            產生會員資料表DataGridView();
        }
        void 清空欄位()
        {
            txtID.Clear();
            txt姓名.Clear();
            txt電話.Clear();
            txt地址.Clear();
            txtEmail.Clear();
            txt密碼.Clear();
            dtp生日.Value = DateTime.Now;

            listBox進階搜尋結果.Items.Clear();
            txt搜尋關鍵字.Clear() ;
            dtp開始時間.Value = Convert.ToDateTime("1940-01-01");
            dtp結束時間.Value = DateTime.Now;
        }
        void 產生會員資料表DataGridView()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "";
            if(GlobalVar.使用者權限 == 1 || GlobalVar.使用者權限 == 2)
                strSQL = "select ID,Pname as 姓名,Phone as 電話,Paddress as 地址,Pbirth as 生日,Pemail as Email,Password as 密碼,Ptype as 狀態 from Person where Permission=4;";
            else
                strSQL = "select ID,Pname as 姓名,Phone as 電話,Paddress as 地址,Pbirth as 生日,Pemail as Email,Ptype as 狀態 from Person where Permission=4;";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                Console.WriteLine($"DGV筆數：{dt.Rows.Count}");
                DGV筆數 = dt.Rows.Count;
                dgv會員資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            if (txt搜尋關鍵字.Text != "")
            {
                SearchIDs.Clear();

                string str欄位名稱 = "";
                if (cbox搜尋欄位.SelectedItem.ToString() == "姓名")
                    str欄位名稱 = "Pname";
                else if (cbox搜尋欄位.SelectedItem.ToString() == "電話")
                    str欄位名稱 = "Phone";
                else if (cbox搜尋欄位.SelectedItem.ToString() == "地址")
                    str欄位名稱 = "Paddress";
                else if (cbox搜尋欄位.SelectedItem.ToString() == "email")
                    str欄位名稱 = "Pemail";


                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = $"select * from Person where Pbirth >= @StartBirth and Pbirth <= @EndBirth and {str欄位名稱} like @SearchKeyWord;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@StartBirth", dtp開始時間.Value);
                cmd.Parameters.AddWithValue("@EndBirth", dtp結束時間.Value);
                cmd.Parameters.AddWithValue("@SearchKeyWord", $"%{txt搜尋關鍵字.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    SearchIDs.Add((int)reader["ID"]);
                    listBox進階搜尋結果.Items.Add($"{reader["ID"]} {reader["Pname"]} {reader["Phone"]}");
                    count++;
                }
                if (count == 0)
                    MessageBox.Show("查無此人");
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入查詢關鍵字");
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
                if(intID != (int)reader["ID"])
                {
                    exist = true;
                    MessageBox.Show("此帳號已存在!");
                    reader.Close();
                    con.Close();
                }
                
            }

            if ((exist == false) && (intID > 0) && (txt姓名.Text != "") && (txt電話.Text != "") && (txt密碼.Text != ""))
            {
                reader.Close();
                strSQL = "update Person set Pname=@NewName, Phone=@NewPhone, Paddress=@NewAddress, Pemail=@NewEmail, Pbirth=@NewBirth, Password=@NewPassword, Ptype=@NewPtype where id=@SearchID;";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);

                if(rBtn審核中.Checked)
                    cmd.Parameters.AddWithValue("@NewPtype", "審核中");
                else if (rBtn已開通.Checked)
                    cmd.Parameters.AddWithValue("@NewPtype", "已開通");
                else
                    cmd.Parameters.AddWithValue("@NewPtype", "已停權");

                int rows = cmd.ExecuteNonQuery();//回傳受影響的資料筆數
                con.Close();
                MessageBox.Show($"({rows}個資料列受影響)");
                產生會員資料表DataGridView();
            }
            else if((exist == false))
            {
                MessageBox.Show("欄位資料不齊全");
            }
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
                    cmd.Parameters.AddWithValue("@NewPermission", 4);

                    if(rBtn審核中.Checked)
                        cmd.Parameters.AddWithValue("@NewPtype", "審核中");
                    else if(rBtn已開通.Checked)
                        cmd.Parameters.AddWithValue("@NewPtype", "已開通");
                    else
                        cmd.Parameters.AddWithValue("@NewPtype", "已停權");

                    int rows = cmd.ExecuteNonQuery();//回傳受影響的資料筆數
                    con.Close();
                    MessageBox.Show($"({rows}個資料列受影響)");
                    產生會員資料表DataGridView();
                    清空欄位();
                }
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        private void btn資料刪除_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要刪除此筆資料嗎?", "刪除確認", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK) 
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
                    產生會員資料表DataGridView();
                }
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void rBtn審核中_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtn已開通_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtn已停權_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox進階搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox進階搜尋結果.SelectedIndex >= 0)
            {
                int selectID = SearchIDs[listBox進階搜尋結果.SelectedIndex];
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

        private void dgv會員資料列表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < DGV筆數))
            {
                string strSelectID = dgv會員資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
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

                    if (reader["Ptype"].ToString() == "審核中" || reader["Ptype"].ToString() == "")
                        rBtn審核中.Checked = true;
                    else if (reader["Ptype"].ToString() == "已開通")
                        rBtn已開通.Checked = true;
                    else if (reader["Ptype"].ToString() == "已停權")
                        rBtn已停權.Checked = true;


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
