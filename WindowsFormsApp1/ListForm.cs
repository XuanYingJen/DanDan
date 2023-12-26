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
    public partial class ListForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int DGV筆數 = 0;
        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";//伺服器名稱
            scsb.InitialCatalog = "DanDan";//資料庫名稱
            scsb.IntegratedSecurity = true;//true -> windows驗證 , false -> SQL Server 驗證

            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            產生訂單資料列表DataGridView();
        }
        void 產生訂單資料列表DataGridView()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select ID,Odate as 訂單日期,Ostate as 訂單狀態,Omoney as 訂單總額,PID,Oname as 訂購人,Ophone as 電話 from Orders order by Odate desc;";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                Console.WriteLine($"DGV筆數：{dt.Rows.Count}");
                DGV筆數 = dt.Rows.Count;
                dgv訂單資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
        void 清空欄位()
        {
            txtID.Clear();
            txt訂購人.Clear();
            txt電話.Clear();
            txtContent.Clear();
            txtDate.Clear();
            txt訂單總額.Clear();
            rBtn準備中.Checked = false;
            rBtn已完成.Checked = false;
        }

        private void btn刪除訂單_Click(object sender, EventArgs e)
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
                    string strSQL = "delete from Orders where id = @DeleteID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteID", intID);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    清空欄位();
                    MessageBox.Show($"資料已刪除,{rows}筆資料受影響");
                    產生訂單資料列表DataGridView();
                }
            }
        }

        private void dgv訂單資料列表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < DGV筆數))
            {
                string strSelectID = dgv訂單資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from Orders where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtID.Text = reader["ID"].ToString();
                    txt訂購人.Text = reader["Oname"].ToString();
                    txt電話.Text = reader["Ophone"].ToString();
                    txtContent.Text = reader["Ocontent"].ToString();
                    txtDate.Text = reader["Odate"].ToString();
                    txt訂單總額.Text = reader["Omoney"].ToString();
                    if (reader["Ostate"].ToString() == "準備中")
                        rBtn準備中.Checked = true;
                    else if(reader["Ostate"].ToString() == "已完成")
                        rBtn已完成.Checked = true;
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

        private void rBtn準備中_CheckedChanged(object sender, EventArgs e)
        {
            txtContent.ReadOnly = false;
            txt訂單總額.ReadOnly = false;
        }

        private void rBtn已完成_CheckedChanged(object sender, EventArgs e)
        {
            txtContent.ReadOnly=true;
            txt訂單總額.ReadOnly=true;
        }

        private void btn儲存_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtID.Text, out intID);
            if ((intID > 0) && txtContent.Text!= "" && txt訂單總額.Text!= "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "update Orders set Ocontent=@NewContent, Omoney=@NewMoney, Ostate=@Newstate where id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewContent", txtContent.Text);
                cmd.Parameters.AddWithValue("@NewMoney", txt訂單總額.Text);
                if(rBtn準備中.Checked) 
                    cmd.Parameters.AddWithValue("@Newstate", "準備中");
                else if(rBtn已完成.Checked)
                    cmd.Parameters.AddWithValue("@Newstate", "已完成");

                int rows = cmd.ExecuteNonQuery();//回傳受影響的資料筆數
                con.Close();
                MessageBox.Show($"({rows}個資料列受影響)");
                產生訂單資料列表DataGridView();
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }
    }
}
