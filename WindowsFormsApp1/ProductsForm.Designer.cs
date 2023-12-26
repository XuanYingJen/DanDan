namespace WindowsFormsApp1
{
    partial class ProductsForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn漢堡重新整理 = new System.Windows.Forms.Button();
            this.btn漢堡新增商品 = new System.Windows.Forms.Button();
            this.listView漢堡展示 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn點心重新整理 = new System.Windows.Forms.Button();
            this.btn點心新增商品 = new System.Windows.Forms.Button();
            this.listView點心展示 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn飲料重新整理 = new System.Windows.Forms.Button();
            this.btn飲料新增商品 = new System.Windows.Forms.Button();
            this.listView飲料展示 = new System.Windows.Forms.ListView();
            this.imageList漢堡商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.imageList點心商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.imageList飲料商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(728, 507);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage1.Controls.Add(this.btn漢堡重新整理);
            this.tabPage1.Controls.Add(this.btn漢堡新增商品);
            this.tabPage1.Controls.Add(this.listView漢堡展示);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "漢堡";
            // 
            // btn漢堡重新整理
            // 
            this.btn漢堡重新整理.BackColor = System.Drawing.Color.LightGray;
            this.btn漢堡重新整理.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn漢堡重新整理.Location = new System.Drawing.Point(554, 104);
            this.btn漢堡重新整理.Name = "btn漢堡重新整理";
            this.btn漢堡重新整理.Size = new System.Drawing.Size(134, 49);
            this.btn漢堡重新整理.TabIndex = 7;
            this.btn漢堡重新整理.Text = "重新整理";
            this.btn漢堡重新整理.UseVisualStyleBackColor = false;
            this.btn漢堡重新整理.Click += new System.EventHandler(this.btn漢堡重新整理_Click);
            // 
            // btn漢堡新增商品
            // 
            this.btn漢堡新增商品.BackColor = System.Drawing.Color.LightGray;
            this.btn漢堡新增商品.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn漢堡新增商品.Location = new System.Drawing.Point(554, 33);
            this.btn漢堡新增商品.Name = "btn漢堡新增商品";
            this.btn漢堡新增商品.Size = new System.Drawing.Size(134, 49);
            this.btn漢堡新增商品.TabIndex = 6;
            this.btn漢堡新增商品.Text = "新增商品";
            this.btn漢堡新增商品.UseVisualStyleBackColor = false;
            this.btn漢堡新增商品.Click += new System.EventHandler(this.btn漢堡新增商品_Click);
            // 
            // listView漢堡展示
            // 
            this.listView漢堡展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView漢堡展示.HideSelection = false;
            this.listView漢堡展示.Location = new System.Drawing.Point(31, 33);
            this.listView漢堡展示.Name = "listView漢堡展示";
            this.listView漢堡展示.Size = new System.Drawing.Size(483, 397);
            this.listView漢堡展示.TabIndex = 0;
            this.listView漢堡展示.UseCompatibleStateImageBehavior = false;
            this.listView漢堡展示.ItemActivate += new System.EventHandler(this.listView漢堡展示_ItemActivate);
            this.listView漢堡展示.SelectedIndexChanged += new System.EventHandler(this.listView漢堡展示_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage2.Controls.Add(this.btn點心重新整理);
            this.tabPage2.Controls.Add(this.btn點心新增商品);
            this.tabPage2.Controls.Add(this.listView點心展示);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "點心";
            // 
            // btn點心重新整理
            // 
            this.btn點心重新整理.BackColor = System.Drawing.Color.LightGray;
            this.btn點心重新整理.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn點心重新整理.Location = new System.Drawing.Point(554, 104);
            this.btn點心重新整理.Name = "btn點心重新整理";
            this.btn點心重新整理.Size = new System.Drawing.Size(134, 49);
            this.btn點心重新整理.TabIndex = 10;
            this.btn點心重新整理.Text = "重新整理";
            this.btn點心重新整理.UseVisualStyleBackColor = false;
            this.btn點心重新整理.Click += new System.EventHandler(this.btn點心重新整理_Click);
            // 
            // btn點心新增商品
            // 
            this.btn點心新增商品.BackColor = System.Drawing.Color.LightGray;
            this.btn點心新增商品.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn點心新增商品.Location = new System.Drawing.Point(554, 33);
            this.btn點心新增商品.Name = "btn點心新增商品";
            this.btn點心新增商品.Size = new System.Drawing.Size(134, 49);
            this.btn點心新增商品.TabIndex = 9;
            this.btn點心新增商品.Text = "新增商品";
            this.btn點心新增商品.UseVisualStyleBackColor = false;
            this.btn點心新增商品.Click += new System.EventHandler(this.btn點心新增商品_Click);
            // 
            // listView點心展示
            // 
            this.listView點心展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView點心展示.HideSelection = false;
            this.listView點心展示.Location = new System.Drawing.Point(32, 33);
            this.listView點心展示.Name = "listView點心展示";
            this.listView點心展示.Size = new System.Drawing.Size(483, 397);
            this.listView點心展示.TabIndex = 8;
            this.listView點心展示.UseCompatibleStateImageBehavior = false;
            this.listView點心展示.ItemActivate += new System.EventHandler(this.listView點心展示_ItemActivate);
            this.listView點心展示.SelectedIndexChanged += new System.EventHandler(this.listView點心展示_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage3.Controls.Add(this.btn飲料重新整理);
            this.tabPage3.Controls.Add(this.btn飲料新增商品);
            this.tabPage3.Controls.Add(this.listView飲料展示);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(720, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "飲料";
            // 
            // btn飲料重新整理
            // 
            this.btn飲料重新整理.BackColor = System.Drawing.Color.LightGray;
            this.btn飲料重新整理.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn飲料重新整理.Location = new System.Drawing.Point(554, 104);
            this.btn飲料重新整理.Name = "btn飲料重新整理";
            this.btn飲料重新整理.Size = new System.Drawing.Size(134, 49);
            this.btn飲料重新整理.TabIndex = 10;
            this.btn飲料重新整理.Text = "重新整理";
            this.btn飲料重新整理.UseVisualStyleBackColor = false;
            this.btn飲料重新整理.Click += new System.EventHandler(this.btn飲料重新整理_Click);
            // 
            // btn飲料新增商品
            // 
            this.btn飲料新增商品.BackColor = System.Drawing.Color.LightGray;
            this.btn飲料新增商品.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn飲料新增商品.Location = new System.Drawing.Point(554, 33);
            this.btn飲料新增商品.Name = "btn飲料新增商品";
            this.btn飲料新增商品.Size = new System.Drawing.Size(134, 49);
            this.btn飲料新增商品.TabIndex = 9;
            this.btn飲料新增商品.Text = "新增商品";
            this.btn飲料新增商品.UseVisualStyleBackColor = false;
            this.btn飲料新增商品.Click += new System.EventHandler(this.btn飲料新增商品_Click);
            // 
            // listView飲料展示
            // 
            this.listView飲料展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView飲料展示.HideSelection = false;
            this.listView飲料展示.Location = new System.Drawing.Point(32, 33);
            this.listView飲料展示.Name = "listView飲料展示";
            this.listView飲料展示.Size = new System.Drawing.Size(483, 397);
            this.listView飲料展示.TabIndex = 8;
            this.listView飲料展示.UseCompatibleStateImageBehavior = false;
            this.listView飲料展示.ItemActivate += new System.EventHandler(this.listView飲料展示_ItemActivate);
            this.listView飲料展示.SelectedIndexChanged += new System.EventHandler(this.listView飲料展示_SelectedIndexChanged);
            // 
            // imageList漢堡商品圖檔
            // 
            this.imageList漢堡商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList漢堡商品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList漢堡商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList點心商品圖檔
            // 
            this.imageList點心商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList點心商品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList點心商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList飲料商品圖檔
            // 
            this.imageList飲料商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList飲料商品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList飲料商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(755, 531);
            this.Controls.Add(this.tabControl);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView漢堡展示;
        private System.Windows.Forms.Button btn漢堡重新整理;
        private System.Windows.Forms.Button btn漢堡新增商品;
        private System.Windows.Forms.Button btn點心重新整理;
        private System.Windows.Forms.Button btn點心新增商品;
        private System.Windows.Forms.ListView listView點心展示;
        private System.Windows.Forms.Button btn飲料重新整理;
        private System.Windows.Forms.Button btn飲料新增商品;
        private System.Windows.Forms.ListView listView飲料展示;
        private System.Windows.Forms.ImageList imageList漢堡商品圖檔;
        private System.Windows.Forms.ImageList imageList點心商品圖檔;
        private System.Windows.Forms.ImageList imageList飲料商品圖檔;
        private System.Windows.Forms.ImageList imageList1;
    }
}