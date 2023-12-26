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
    public partial class ProductsForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(); //建立SQL連線字串
        List<string> listProductName_漢堡 = new List<string>();
        List<string> listProductName_點心 = new List<string>();
        List<string> listProductName_飲料 = new List<string>();
        List<int> listPrice_漢堡 = new List<int>();
        List<int> listPrice_點心 = new List<int>();
        List<int> listPrice_飲料 = new List<int>();
        List<int> listID_漢堡 = new List<int>();
        List<int> listID_點心 = new List<int>();
        List<int> listID_飲料 = new List<int>();
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "DanDan";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            讀取漢堡商品資料庫();
            讀取點心商品資料庫();
            讀取飲料商品資料庫();
            顯示ListView漢堡_圖片模式();
            顯示ListView點心_圖片模式();
            顯示ListView飲料_圖片模式();
        }
        void 讀取漢堡商品資料庫()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open(); //正式連線
            string strSQL = "select top 200 * from Product where Ptype = 1;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0; //資料筆數
            while (reader.Read()) //逐行讀取
            {
                listID_漢堡.Add((int)reader["ID"]);
                listProductName_漢堡.Add((string)reader["PName"]);
                listPrice_漢堡.Add((int)reader["Price"]);
                string image_name = (string)reader["Pimage"];
                string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                Image img產品圖檔 = Image.FromFile(完整圖檔路徑);
                imageList漢堡商品圖檔.Images.Add(img產品圖檔);
                count++;
            }
            reader.Close();
            con.Close(); //關閉連線
            Console.WriteLine($"讀取{count}筆資料");
        }
        void 讀取點心商品資料庫()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open(); //正式連線
            string strSQL = "select top 200 * from Product where Ptype = 2;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0; //資料筆數
            while (reader.Read()) //逐行讀取
            {
                listID_點心.Add((int)reader["ID"]);
                listProductName_點心.Add((string)reader["PName"]);
                listPrice_點心.Add((int)reader["Price"]);
                string image_name = (string)reader["Pimage"];
                string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                Image img產品圖檔 = Image.FromFile(完整圖檔路徑);
                imageList點心商品圖檔.Images.Add(img產品圖檔);
                count++;
            }
            reader.Close();
            con.Close(); //關閉連線
            Console.WriteLine($"讀取{count}筆資料");
        }
        void 讀取飲料商品資料庫()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open(); //正式連線
            string strSQL = "select top 200 * from Product where Ptype = 3;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0; //資料筆數
            while (reader.Read()) //逐行讀取
            {
                listID_飲料.Add((int)reader["ID"]);
                listProductName_飲料.Add((string)reader["PName"]);
                listPrice_飲料.Add((int)reader["Price"]);
                string image_name = (string)reader["Pimage"];
                string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                Image img產品圖檔 = Image.FromFile(完整圖檔路徑);
                imageList飲料商品圖檔.Images.Add(img產品圖檔);
                count++;
            }
            reader.Close();
            con.Close(); //關閉連線
            Console.WriteLine($"讀取{count}筆資料");
        }
        void 顯示ListView漢堡_圖片模式()
        {
            listView漢堡展示.Clear();
            listView漢堡展示.View = View.LargeIcon;//LargeIcon,Tile,List,SmallIcon
            imageList漢堡商品圖檔.ImageSize = new Size(100, 100);
            listView漢堡展示.LargeImageList = imageList漢堡商品圖檔; //LargeIcon, Tile
            listView漢堡展示.SmallImageList = imageList漢堡商品圖檔; //SmallIcon, List

            for (int i = 0; i < imageList漢堡商品圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProductName_漢堡[i]}\n${listPrice_漢堡[i]}元";
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Tag = listID_漢堡[i]; // Tag -> 藏東西用
                listView漢堡展示.Items.Add(item);
            }
        }
        void 顯示ListView點心_圖片模式()
        {
            listView點心展示.Clear();
            listView點心展示.View = View.LargeIcon;//LargeIcon,Tile,List,SmallIcon
            imageList點心商品圖檔.ImageSize = new Size(100, 100);
            listView點心展示.LargeImageList = imageList點心商品圖檔; //LargeIcon, Tile
            listView點心展示.SmallImageList = imageList點心商品圖檔; //SmallIcon, List

            for (int i = 0; i < imageList點心商品圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProductName_點心[i]}\n${listPrice_點心[i]}元";
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Tag = listID_點心[i]; // Tag -> 藏東西用
                listView點心展示.Items.Add(item);
            }
        }
        void 顯示ListView飲料_圖片模式()
        {
            listView飲料展示.Clear();
            listView飲料展示.View = View.LargeIcon;//LargeIcon,Tile,List,SmallIcon
            imageList飲料商品圖檔.ImageSize = new Size(100, 100);
            listView飲料展示.LargeImageList = imageList飲料商品圖檔; //LargeIcon, Tile
            listView飲料展示.SmallImageList = imageList飲料商品圖檔; //SmallIcon, List

            for (int i = 0; i < imageList飲料商品圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProductName_飲料[i]}\n${listPrice_飲料[i]}元";
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Tag = listID_飲料[i]; // Tag -> 藏東西用
                listView飲料展示.Items.Add(item);
            }
        }
        void 重新載入漢堡商品資料()
        {
            listID_漢堡.Clear();
            listPrice_漢堡.Clear();
            listProductName_漢堡.Clear();
            imageList漢堡商品圖檔.Images.Clear();
            讀取漢堡商品資料庫();
            顯示ListView漢堡_圖片模式();
        }
        void 重新載入點心商品資料()
        {
            listID_點心.Clear();
            listPrice_點心.Clear();
            listProductName_點心.Clear();
            imageList點心商品圖檔.Images.Clear();
            讀取點心商品資料庫();
            顯示ListView點心_圖片模式();
        }
        void 重新載入飲料商品資料()
        {
            listID_飲料.Clear();
            listPrice_飲料.Clear();
            listProductName_飲料.Clear();
            imageList飲料商品圖檔.Images.Clear();
            讀取飲料商品資料庫();
            顯示ListView飲料_圖片模式();
        }

        private void btn漢堡新增商品_Click(object sender, EventArgs e)
        {
            ProductsDetailForm myProductsDetailForm = new ProductsDetailForm();
            myProductsDetailForm.strType = "漢堡";
            myProductsDetailForm.ShowDialog();
        }

        private void btn漢堡重新整理_Click(object sender, EventArgs e)
        {
            重新載入漢堡商品資料();
        }

        private void listView漢堡展示_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn點心新增商品_Click(object sender, EventArgs e)
        {
            ProductsDetailForm myProductsDetailForm = new ProductsDetailForm();
            myProductsDetailForm.strType = "點心";
            myProductsDetailForm.ShowDialog();
        }

        private void btn點心重新整理_Click(object sender, EventArgs e)
        {
            重新載入點心商品資料();
        }

        private void listView點心展示_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn飲料新增商品_Click(object sender, EventArgs e)
        {
            ProductsDetailForm myProductsDetailForm = new ProductsDetailForm();
            myProductsDetailForm.strType = "飲料";
            myProductsDetailForm.ShowDialog();
        }

        private void btn飲料重新整理_Click(object sender, EventArgs e)
        {
            重新載入飲料商品資料();
        }

        private void listView飲料展示_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView漢堡展示_ItemActivate(object sender, EventArgs e)
        {
            ProductsDetailForm myProductsDetailForm = new ProductsDetailForm();
            myProductsDetailForm.selectID = (int)listView漢堡展示.SelectedItems[0].Tag; //SelectedItems[0] -> 第一個選的項目(因為ListView可複選)
            myProductsDetailForm.strType = "漢堡";
            myProductsDetailForm.ShowDialog();
        }

        private void listView點心展示_ItemActivate(object sender, EventArgs e)
        {
            ProductsDetailForm myProductsDetailForm = new ProductsDetailForm();
            myProductsDetailForm.selectID = (int)listView點心展示.SelectedItems[0].Tag;
            myProductsDetailForm.strType = "點心";
            myProductsDetailForm.ShowDialog();
        }

        private void listView飲料展示_ItemActivate(object sender, EventArgs e)
        {
            ProductsDetailForm myProductsDetailForm = new ProductsDetailForm();
            myProductsDetailForm.selectID = (int)listView飲料展示.SelectedItems[0].Tag;
            myProductsDetailForm.strType = "飲料";
            myProductsDetailForm.ShowDialog();
            
            
        }
    }
}
