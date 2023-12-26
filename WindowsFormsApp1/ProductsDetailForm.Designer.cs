namespace WindowsFormsApp1
{
    partial class ProductsDetailForm
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
            this.groupBox商品新增 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn儲存修改2 = new System.Windows.Forms.Button();
            this.btn選取商品照片2 = new System.Windows.Forms.Button();
            this.groupBox商品修改 = new System.Windows.Forms.GroupBox();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn選取商品照片 = new System.Windows.Forms.Button();
            this.pictureBox商品圖檔 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt商品類別 = new System.Windows.Forms.TextBox();
            this.btn刪除商品 = new System.Windows.Forms.Button();
            this.groupBox商品新增.SuspendLayout();
            this.groupBox商品修改.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox商品新增
            // 
            this.groupBox商品新增.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox商品新增.Controls.Add(this.btn清空欄位);
            this.groupBox商品新增.Controls.Add(this.btn儲存修改2);
            this.groupBox商品新增.Controls.Add(this.btn選取商品照片2);
            this.groupBox商品新增.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox商品新增.Location = new System.Drawing.Point(23, 430);
            this.groupBox商品新增.Name = "groupBox商品新增";
            this.groupBox商品新增.Size = new System.Drawing.Size(422, 87);
            this.groupBox商品新增.TabIndex = 26;
            this.groupBox商品新增.TabStop = false;
            this.groupBox商品新增.Text = "商品新增";
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.BackColor = System.Drawing.Color.LightGray;
            this.btn清空欄位.Location = new System.Drawing.Point(305, 34);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(111, 39);
            this.btn清空欄位.TabIndex = 3;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = false;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn儲存修改2
            // 
            this.btn儲存修改2.BackColor = System.Drawing.Color.LightGray;
            this.btn儲存修改2.Location = new System.Drawing.Point(176, 34);
            this.btn儲存修改2.Name = "btn儲存修改2";
            this.btn儲存修改2.Size = new System.Drawing.Size(111, 39);
            this.btn儲存修改2.TabIndex = 2;
            this.btn儲存修改2.Text = "儲存修改";
            this.btn儲存修改2.UseVisualStyleBackColor = false;
            this.btn儲存修改2.Click += new System.EventHandler(this.btn儲存修改2_Click);
            // 
            // btn選取商品照片2
            // 
            this.btn選取商品照片2.BackColor = System.Drawing.Color.LightGray;
            this.btn選取商品照片2.Location = new System.Drawing.Point(6, 33);
            this.btn選取商品照片2.Name = "btn選取商品照片2";
            this.btn選取商品照片2.Size = new System.Drawing.Size(151, 39);
            this.btn選取商品照片2.TabIndex = 2;
            this.btn選取商品照片2.Text = "選取商品照片";
            this.btn選取商品照片2.UseVisualStyleBackColor = false;
            this.btn選取商品照片2.Click += new System.EventHandler(this.btn選取商品照片2_Click);
            // 
            // groupBox商品修改
            // 
            this.groupBox商品修改.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox商品修改.Controls.Add(this.btn儲存修改);
            this.groupBox商品修改.Controls.Add(this.btn選取商品照片);
            this.groupBox商品修改.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox商品修改.Location = new System.Drawing.Point(468, 430);
            this.groupBox商品修改.Name = "groupBox商品修改";
            this.groupBox商品修改.Size = new System.Drawing.Size(337, 87);
            this.groupBox商品修改.TabIndex = 25;
            this.groupBox商品修改.TabStop = false;
            this.groupBox商品修改.Text = "商品修改";
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.BackColor = System.Drawing.Color.LightGray;
            this.btn儲存修改.Location = new System.Drawing.Point(211, 33);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(111, 39);
            this.btn儲存修改.TabIndex = 1;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = false;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn選取商品照片
            // 
            this.btn選取商品照片.BackColor = System.Drawing.Color.LightGray;
            this.btn選取商品照片.Location = new System.Drawing.Point(17, 33);
            this.btn選取商品照片.Name = "btn選取商品照片";
            this.btn選取商品照片.Size = new System.Drawing.Size(151, 39);
            this.btn選取商品照片.TabIndex = 0;
            this.btn選取商品照片.Text = "選取商品照片";
            this.btn選取商品照片.UseVisualStyleBackColor = false;
            this.btn選取商品照片.Click += new System.EventHandler(this.btn選取商品照片_Click);
            // 
            // pictureBox商品圖檔
            // 
            this.pictureBox商品圖檔.Location = new System.Drawing.Point(468, 88);
            this.pictureBox商品圖檔.Name = "pictureBox商品圖檔";
            this.pictureBox商品圖檔.Size = new System.Drawing.Size(337, 306);
            this.pictureBox商品圖檔.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox商品圖檔.TabIndex = 24;
            this.pictureBox商品圖檔.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(463, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "商品圖檔";
            // 
            // txt商品描述
            // 
            this.txt商品描述.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品描述.Location = new System.Drawing.Point(23, 248);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(422, 146);
            this.txt商品描述.TabIndex = 22;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Location = new System.Drawing.Point(116, 153);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(303, 29);
            this.txt商品價格.TabIndex = 21;
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.Location = new System.Drawing.Point(116, 100);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(303, 29);
            this.txt商品名稱.TabIndex = 20;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(116, 49);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(75, 29);
            this.txtID.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(18, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "*商品價格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(18, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "商品描述(1000字以內)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(18, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "*商品名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(77, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "商品詳細資訊";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(230, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "商品類別";
            // 
            // txt商品類別
            // 
            this.txt商品類別.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品類別.Location = new System.Drawing.Point(328, 49);
            this.txt商品類別.Name = "txt商品類別";
            this.txt商品類別.ReadOnly = true;
            this.txt商品類別.Size = new System.Drawing.Size(91, 34);
            this.txt商品類別.TabIndex = 28;
            // 
            // btn刪除商品
            // 
            this.btn刪除商品.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除商品.ForeColor = System.Drawing.Color.Red;
            this.btn刪除商品.Location = new System.Drawing.Point(693, 12);
            this.btn刪除商品.Name = "btn刪除商品";
            this.btn刪除商品.Size = new System.Drawing.Size(125, 51);
            this.btn刪除商品.TabIndex = 29;
            this.btn刪除商品.Text = "刪除商品";
            this.btn刪除商品.UseVisualStyleBackColor = true;
            this.btn刪除商品.Click += new System.EventHandler(this.btn刪除商品_Click);
            // 
            // ProductsDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(830, 526);
            this.Controls.Add(this.btn刪除商品);
            this.Controls.Add(this.txt商品類別);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox商品新增);
            this.Controls.Add(this.groupBox商品修改);
            this.Controls.Add(this.pictureBox商品圖檔);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductsDetailForm";
            this.Text = "ProductsDetailForm";
            this.Load += new System.EventHandler(this.ProductsDetailForm_Load);
            this.groupBox商品新增.ResumeLayout(false);
            this.groupBox商品修改.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox商品新增;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn儲存修改2;
        private System.Windows.Forms.Button btn選取商品照片2;
        private System.Windows.Forms.GroupBox groupBox商品修改;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn選取商品照片;
        private System.Windows.Forms.PictureBox pictureBox商品圖檔;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt商品描述;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt商品類別;
        private System.Windows.Forms.Button btn刪除商品;
    }
}