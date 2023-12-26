using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (GlobalVar.is登入成功 == false)
            {
                LoginForm myLoginForm = new LoginForm();
                myLoginForm.ShowDialog();
            }

            if (GlobalVar.使用者權限 == 1) //系統管理員
            {
                lbl登入資訊.Text = $"系統管理員：{GlobalVar.使用者名稱}";

                btn餐點訂購單.Visible = true;
                btn會員資料管理.Visible = true;
                btn商品管理.Visible = true;
                btn訂單管理.Visible = true;
                btn系統管理.Visible = true;
            }
            else if (GlobalVar.使用者權限 == 2) //店長
            {
                lbl登入資訊.Text = $"店長：{GlobalVar.使用者名稱}";

                btn餐點訂購單.Visible = true;
                btn會員資料管理.Visible = true;
                btn商品管理.Visible = true;
                btn訂單管理.Visible = true;
                btn系統管理.Visible = true;
            }
            else if (GlobalVar.使用者權限 == 3) //店員
            {
                lbl登入資訊.Text = $"店員：{GlobalVar.使用者名稱}";

                btn餐點訂購單.Visible = true;
                btn會員資料管理.Visible = true;
                btn商品管理.Visible = true;
                btn訂單管理.Visible = true;
                btn系統管理.Visible = false;
            }
            else if (GlobalVar.使用者權限 == 4) //會員
            {
                lbl登入資訊.Text = $"會員：{GlobalVar.使用者名稱}";
                btn餐點訂購單.Visible = true;
                btn會員資料管理.Visible = false;
                btn商品管理.Visible = false;
                btn訂單管理.Visible = false;
                btn系統管理.Visible = false;
            }
        }

        private void btn餐點訂購單_Click(object sender, EventArgs e)
        {
            OrderForm myOrderForm = new OrderForm();
            myOrderForm.ShowDialog();
        }

        private void btn會員資料管理_Click(object sender, EventArgs e)
        {
            MemberForm myMemberForm = new MemberForm();
            myMemberForm.ShowDialog();
        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            ProductsForm myProductsForm = new ProductsForm();
            myProductsForm.ShowDialog();
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            ListForm myListForm = new ListForm();
            myListForm.ShowDialog();
        }

        private void btn系統管理_Click(object sender, EventArgs e)
        {
            StaffForm myStaffForm = new StaffForm();
            myStaffForm.ShowDialog();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {

        }
    }
}
