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
    public partial class OrderListForm : Form
    {
        int 訂單總價 = 0;
        string str訂單內容 = "";
        public OrderListForm()
        {
            InitializeComponent();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            if (GlobalVar.使用者權限 == 1 || GlobalVar.使用者權限 == 2 || GlobalVar.使用者權限 == 3)
            {
                txt訂購人.ReadOnly = false;
                txt電話.ReadOnly = false;
            }
            else if (GlobalVar.使用者權限 == 4)
            {
                txt訂購人.ReadOnly = true;
                txt電話.ReadOnly = true;

                txt訂購人.Text = GlobalVar.使用者名稱;
                txt電話.Text = GlobalVar.使用者電話;
            }
            foreach (ArrayList 訂購單品 in GlobalVar.list訂購品項資料集合)
            {
                string 品項名稱 = (string)訂購單品[0];
                int 單品數量 = (int)訂購單品[1];
                int 單品總價 = (int)訂購單品[2];
                string 單品備註 = 訂購單品[3].ToString();
                Console.WriteLine((string)訂購單品[3]);

                string strInfo = string.Format("{0} , x{1}, 共{2}元 {3}", 品項名稱, 單品數量, 單品總價, 單品備註);
                listBox訂購品項列表.Items.Add(strInfo);
            }

            groupBox購物袋.Visible = false;
            計算訂單總價();
        }
        void 計算訂單總價()
        {
            訂單總價 = 0; 
            foreach (ArrayList 訂購單品 in GlobalVar.list訂購品項資料集合)
            {
                訂單總價 += (int)訂購單品[2];
            }
            if ((radioBtn是.Checked == true) && (GlobalVar.list訂購品項資料集合.Count > 0))
            {
                訂單總價 += 1;
            }
            lbl訂單總價.Text = "訂單總價：" + 訂單總價.ToString();
        }

        private void radioBtn內用_CheckedChanged(object sender, EventArgs e)
        {
            groupBox購物袋.Visible = false;
            計算訂單總價();
        }

        private void radioBtn外帶_CheckedChanged(object sender, EventArgs e)
        {
            groupBox購物袋.Visible = true;
        }

        private void radioBtn是_CheckedChanged(object sender, EventArgs e)
        {
            計算訂單總價();
        }

        private void radioBtn否_CheckedChanged(object sender, EventArgs e)
        {
            計算訂單總價();
        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (listBox訂購品項列表.SelectedIndex >= 0)
            {
                int selIndex = listBox訂購品項列表.SelectedIndex;
                GlobalVar.list訂購品項資料集合.RemoveAt(selIndex);
                listBox訂購品項列表.Items.RemoveAt(selIndex);

            }
            else
                MessageBox.Show("請選擇移除品項!");
        }

        private void btn清除所選品項_Click(object sender, EventArgs e)
        {
            listBox訂購品項列表.Items.Clear();
            GlobalVar.list訂購品項資料集合.Clear();
            計算訂單總價();
        }

        private void listBox訂購品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn輸出訂購單檔案_Click(object sender, EventArgs e)
        {
            if ((txt訂購人.Text != "") && (txt電話.Text != ""))
            {
                if (listBox訂購品項列表.Items.Count == 0)
                {
                    MessageBox.Show("請加入訂購品項");
                }
                else if (radioBtn內用.Checked == false && radioBtn外帶.Checked == false)
                {
                    MessageBox.Show("請檢查必填欄位!");
                }
                else if (radioBtn外帶.Checked == true && radioBtn是.Checked == false && radioBtn否.Checked == false)
                {
                    MessageBox.Show("請檢查必填欄位!");
                }
                else
                {
                    string str檔案目錄 = @"C:\Users\winni\OneDrive\Desktop\資策會\期中個人專題";
                    Random myRnd = new Random();
                    int rndNum = myRnd.Next(10000, 100000);
                    string str檔名 = DateTime.Now.ToString("yyMMddHHss") + rndNum + "訂購檔.txt";
                    string str完整檔案路徑 = str檔案目錄 + @"\" + str檔名;

                    Console.WriteLine(str完整檔案路徑);

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.InitialDirectory = str檔案目錄;//預設儲存目錄
                    sfd.FileName = str檔名;//預設檔名
                    sfd.Filter = "文字檔|*.txt";//只把.txt檔顯示在目錄中

                    DialogResult R = sfd.ShowDialog();

                    if (R == DialogResult.OK)
                        str完整檔案路徑 = sfd.FileName;
                    else
                        return;

                    //訂單內容輸出
                    List<string> list訂單資訊 = new List<string>();
                    list訂單資訊.Add("***************** 單單漢堡店訂購單 ********************");
                    list訂單資訊.Add("------------------------------------------------------");
                    list訂單資訊.Add($"訂購時間：{DateTime.Now}");
                    list訂單資訊.Add($"訂購人：{txt訂購人.Text}");
                    list訂單資訊.Add($"電話：{txt電話.Text}");
                    list訂單資訊.Add("=================== << 訂購品項 >> ====================");
                    foreach (ArrayList 訂購單品 in GlobalVar.list訂購品項資料集合)
                    {
                        string 品項名稱 = (string)訂購單品[0];
                        int 單品數量 = (int)訂購單品[1];
                        int 單品總價 = (int)訂購單品[2];
                        string 單品備註 = 訂購單品[3].ToString();
                        Console.WriteLine((string)訂購單品[3]);

                        string strInfo = string.Format("{0} , x{1}, 共{2}元 {3}", 品項名稱, 單品數量, 單品總價, 單品備註);
                        list訂單資訊.Add(strInfo);
                        str訂單內容 = str訂單內容 + strInfo + "\r\n";
                    }
                    list訂單資訊.Add("======================================================");
                    if (radioBtn內用.Checked)
                    {
                        list訂單資訊.Add("內用");
                        str訂單內容 += "內用";
                    }
                    else if (radioBtn外帶.Checked == true && radioBtn是.Checked == true)
                    {
                        list訂單資訊.Add("外帶,加購物袋");
                        str訂單內容 += "外帶,加購物袋";
                    }
                    else if (radioBtn外帶.Checked == true && radioBtn否.Checked == true)
                    {
                        list訂單資訊.Add("外帶");
                        str訂單內容 += "外帶";
                    }

                    list訂單資訊.Add($"{lbl訂單總價.Text}");
                    list訂單資訊.Add("======================================================");
                    list訂單資訊.Add("********************** 謝謝光臨 ***********************");

                    System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8);
                    MessageBox.Show("訂購單儲存成功");

                    ///////////////////////////////////////////////////////////////////////////////
                    //新增訂單資料至資料庫
                    int PID = 0;
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();
                    string strSQL = "select ID from Person where Pname=@SearchPname and Phone=@SearchPhone;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchPname", txt訂購人.Text);
                    cmd.Parameters.AddWithValue("@SearchPhone", txt電話.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        PID = (int)reader["ID"];
                    }
                    reader.Close();

                    if (PID != 0)
                    {
                        strSQL = "insert into Orders (Ocontent,Omoney,Odate,Ostate,PID,Oname,Ophone) values (@NewOcontent,@NewOmoney,@NewOdate,@NewOstate,@NewPID,@NewOname,@NewOphone);";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewOcontent", str訂單內容); 
                        cmd.Parameters.AddWithValue("@NewOmoney", 訂單總價);
                        cmd.Parameters.AddWithValue("@NewOdate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@NewOstate", "準備中");
                        cmd.Parameters.AddWithValue("@NewPID", PID);
                        cmd.Parameters.AddWithValue("@NewOname", txt訂購人.Text);
                        cmd.Parameters.AddWithValue("@NewOphone", txt電話.Text);
                    }
                    else
                    {
                        strSQL = "insert into Orders (Ocontent,Omoney,Odate,Ostate,Oname,Ophone) values (@NewOcontent,@NewOmoney,@NewOdate,@NewOstate,@NewOname,@NewOphone);";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewOcontent", str訂單內容);
                        cmd.Parameters.AddWithValue("@NewOmoney", 訂單總價);
                        cmd.Parameters.AddWithValue("@NewOdate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@NewOstate", "準備中");
                        cmd.Parameters.AddWithValue("@NewOname", txt訂購人.Text);
                        cmd.Parameters.AddWithValue("@NewOphone", txt電話.Text);
                    }
                    int rows = cmd.ExecuteNonQuery();//回傳受影響的資料筆數
                    con.Close();
                    MessageBox.Show($"({rows}個資料列受影響)");
                    listBox訂購品項列表.Items.Clear();
                    GlobalVar.list訂購品項資料集合.Clear();
                    計算訂單總價();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
 
        }
        private void btn繼續訂購_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

