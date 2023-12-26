namespace WindowsFormsApp1
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView漢堡展示 = new System.Windows.Forms.ListView();
            this.btn查看購物車 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn2查看購物車 = new System.Windows.Forms.Button();
            this.listView點心展示 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn3查看購物車 = new System.Windows.Forms.Button();
            this.listView飲料展示 = new System.Windows.Forms.ListView();
            this.imageList漢堡商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.imageList點心商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.imageList飲料商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage1.Controls.Add(this.listView漢堡展示);
            this.tabPage1.Controls.Add(this.btn查看購物車);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "漢堡";
            // 
            // listView漢堡展示
            // 
            this.listView漢堡展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView漢堡展示.HideSelection = false;
            this.listView漢堡展示.Location = new System.Drawing.Point(42, 34);
            this.listView漢堡展示.Name = "listView漢堡展示";
            this.listView漢堡展示.Size = new System.Drawing.Size(501, 414);
            this.listView漢堡展示.TabIndex = 22;
            this.listView漢堡展示.UseCompatibleStateImageBehavior = false;
            this.listView漢堡展示.ItemActivate += new System.EventHandler(this.listView漢堡展示_ItemActivate);
            // 
            // btn查看購物車
            // 
            this.btn查看購物車.BackColor = System.Drawing.Color.Silver;
            this.btn查看購物車.Location = new System.Drawing.Point(42, 469);
            this.btn查看購物車.Name = "btn查看購物車";
            this.btn查看購物車.Size = new System.Drawing.Size(501, 40);
            this.btn查看購物車.TabIndex = 21;
            this.btn查看購物車.Text = "查看購物車(結帳)";
            this.btn查看購物車.UseVisualStyleBackColor = false;
            this.btn查看購物車.Click += new System.EventHandler(this.btn查看購物車_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage2.Controls.Add(this.btn2查看購物車);
            this.tabPage2.Controls.Add(this.listView點心展示);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "點心";
            // 
            // btn2查看購物車
            // 
            this.btn2查看購物車.BackColor = System.Drawing.Color.Silver;
            this.btn2查看購物車.Location = new System.Drawing.Point(43, 469);
            this.btn2查看購物車.Name = "btn2查看購物車";
            this.btn2查看購物車.Size = new System.Drawing.Size(501, 40);
            this.btn2查看購物車.TabIndex = 24;
            this.btn2查看購物車.Text = "查看購物車(結帳)";
            this.btn2查看購物車.UseVisualStyleBackColor = false;
            this.btn2查看購物車.Click += new System.EventHandler(this.btn2查看購物車_Click);
            // 
            // listView點心展示
            // 
            this.listView點心展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView點心展示.HideSelection = false;
            this.listView點心展示.Location = new System.Drawing.Point(43, 36);
            this.listView點心展示.Name = "listView點心展示";
            this.listView點心展示.Size = new System.Drawing.Size(501, 414);
            this.listView點心展示.TabIndex = 23;
            this.listView點心展示.UseCompatibleStateImageBehavior = false;
            this.listView點心展示.ItemActivate += new System.EventHandler(this.listView點心展示_ItemActivate);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage3.Controls.Add(this.btn3查看購物車);
            this.tabPage3.Controls.Add(this.listView飲料展示);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(593, 534);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "飲料";
            // 
            // btn3查看購物車
            // 
            this.btn3查看購物車.BackColor = System.Drawing.Color.Silver;
            this.btn3查看購物車.Location = new System.Drawing.Point(42, 469);
            this.btn3查看購物車.Name = "btn3查看購物車";
            this.btn3查看購物車.Size = new System.Drawing.Size(501, 40);
            this.btn3查看購物車.TabIndex = 24;
            this.btn3查看購物車.Text = "查看購物車(結帳)";
            this.btn3查看購物車.UseVisualStyleBackColor = false;
            this.btn3查看購物車.Click += new System.EventHandler(this.btn3查看購物車_Click);
            // 
            // listView飲料展示
            // 
            this.listView飲料展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView飲料展示.HideSelection = false;
            this.listView飲料展示.Location = new System.Drawing.Point(42, 37);
            this.listView飲料展示.Name = "listView飲料展示";
            this.listView飲料展示.Size = new System.Drawing.Size(501, 414);
            this.listView飲料展示.TabIndex = 23;
            this.listView飲料展示.UseCompatibleStateImageBehavior = false;
            this.listView飲料展示.ItemActivate += new System.EventHandler(this.listView飲料展示_ItemActivate);
            // 
            // imageList漢堡商品圖檔
            // 
            this.imageList漢堡商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList漢堡商品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList漢堡商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList點心商品圖檔
            // 
            this.imageList點心商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList點心商品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList點心商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList飲料商品圖檔
            // 
            this.imageList飲料商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList飲料商品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList飲料商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(625, 602);
            this.Controls.Add(this.tabControl1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn查看購物車;
        private System.Windows.Forms.ListView listView漢堡展示;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn2查看購物車;
        private System.Windows.Forms.ListView listView點心展示;
        private System.Windows.Forms.Button btn3查看購物車;
        private System.Windows.Forms.ListView listView飲料展示;
        private System.Windows.Forms.ImageList imageList漢堡商品圖檔;
        private System.Windows.Forms.ImageList imageList點心商品圖檔;
        private System.Windows.Forms.ImageList imageList飲料商品圖檔;
    }
}