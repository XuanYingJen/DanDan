namespace WindowsFormsApp1
{
    partial class StaffForm
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
            this.groupBox資料欄位 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv員工資料列表 = new System.Windows.Forms.DataGridView();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn資料刪除 = new System.Windows.Forms.Button();
            this.btn資料新增 = new System.Windows.Forms.Button();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cBox權限 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox資料欄位.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv員工資料列表)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox資料欄位
            // 
            this.groupBox資料欄位.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox資料欄位.Controls.Add(this.cBox權限);
            this.groupBox資料欄位.Controls.Add(this.label8);
            this.groupBox資料欄位.Controls.Add(this.btn清空欄位);
            this.groupBox資料欄位.Controls.Add(this.btn資料刪除);
            this.groupBox資料欄位.Controls.Add(this.btn資料新增);
            this.groupBox資料欄位.Controls.Add(this.btn資料修改);
            this.groupBox資料欄位.Controls.Add(this.txtID);
            this.groupBox資料欄位.Controls.Add(this.label1);
            this.groupBox資料欄位.Controls.Add(this.label2);
            this.groupBox資料欄位.Controls.Add(this.label3);
            this.groupBox資料欄位.Controls.Add(this.label4);
            this.groupBox資料欄位.Controls.Add(this.txt密碼);
            this.groupBox資料欄位.Controls.Add(this.label5);
            this.groupBox資料欄位.Controls.Add(this.label7);
            this.groupBox資料欄位.Controls.Add(this.label6);
            this.groupBox資料欄位.Controls.Add(this.txt姓名);
            this.groupBox資料欄位.Controls.Add(this.txt電話);
            this.groupBox資料欄位.Controls.Add(this.dtp生日);
            this.groupBox資料欄位.Controls.Add(this.txt地址);
            this.groupBox資料欄位.Controls.Add(this.txtEmail);
            this.groupBox資料欄位.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox資料欄位.Location = new System.Drawing.Point(12, 53);
            this.groupBox資料欄位.Name = "groupBox資料欄位";
            this.groupBox資料欄位.Size = new System.Drawing.Size(947, 393);
            this.groupBox資料欄位.TabIndex = 63;
            this.groupBox資料欄位.TabStop = false;
            this.groupBox資料欄位.Text = "資料欄位";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(98, 52);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(323, 34);
            this.txtID.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(59, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "*姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(446, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "*電話(帳號)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(40, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "地址";
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(565, 160);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.Size = new System.Drawing.Size(323, 34);
            this.txt密碼.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(29, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(498, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "*密碼";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(40, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "生日";
            // 
            // txt姓名
            // 
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(98, 107);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(323, 34);
            this.txt姓名.TabIndex = 49;
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(565, 108);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(323, 34);
            this.txt電話.TabIndex = 50;
            // 
            // dtp生日
            // 
            this.dtp生日.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日.Location = new System.Drawing.Point(98, 213);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(323, 34);
            this.dtp生日.TabIndex = 53;
            // 
            // txt地址
            // 
            this.txt地址.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(98, 160);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(323, 34);
            this.txt地址.TabIndex = 51;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(98, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 34);
            this.txtEmail.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.dgv員工資料列表);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 179);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "員工資料列表";
            // 
            // dgv員工資料列表
            // 
            this.dgv員工資料列表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv員工資料列表.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv員工資料列表.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgv員工資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv員工資料列表.Location = new System.Drawing.Point(6, 33);
            this.dgv員工資料列表.Name = "dgv員工資料列表";
            this.dgv員工資料列表.ReadOnly = true;
            this.dgv員工資料列表.RowHeadersWidth = 62;
            this.dgv員工資料列表.RowTemplate.Height = 31;
            this.dgv員工資料列表.Size = new System.Drawing.Size(932, 140);
            this.dgv員工資料列表.TabIndex = 0;
            this.dgv員工資料列表.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv員工資料列表_CellContentClick);
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.Location = new System.Drawing.Point(749, 332);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(139, 43);
            this.btn清空欄位.TabIndex = 61;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn資料刪除
            // 
            this.btn資料刪除.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料刪除.ForeColor = System.Drawing.Color.Red;
            this.btn資料刪除.Location = new System.Drawing.Point(521, 332);
            this.btn資料刪除.Name = "btn資料刪除";
            this.btn資料刪除.Size = new System.Drawing.Size(139, 43);
            this.btn資料刪除.TabIndex = 60;
            this.btn資料刪除.Text = "資料刪除";
            this.btn資料刪除.UseVisualStyleBackColor = true;
            this.btn資料刪除.Click += new System.EventHandler(this.btn資料刪除_Click);
            // 
            // btn資料新增
            // 
            this.btn資料新增.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料新增.ForeColor = System.Drawing.Color.Blue;
            this.btn資料新增.Location = new System.Drawing.Point(64, 332);
            this.btn資料新增.Name = "btn資料新增";
            this.btn資料新增.Size = new System.Drawing.Size(139, 43);
            this.btn資料新增.TabIndex = 59;
            this.btn資料新增.Text = "資料新增";
            this.btn資料新增.UseVisualStyleBackColor = true;
            this.btn資料新增.Click += new System.EventHandler(this.btn資料新增_Click);
            // 
            // btn資料修改
            // 
            this.btn資料修改.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料修改.Location = new System.Drawing.Point(293, 332);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(139, 43);
            this.btn資料修改.TabIndex = 58;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.UseVisualStyleBackColor = true;
            this.btn資料修改.Click += new System.EventHandler(this.btn資料修改_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(507, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 62;
            this.label8.Text = "權限";
            // 
            // cBox權限
            // 
            this.cBox權限.FormattingEnabled = true;
            this.cBox權限.Location = new System.Drawing.Point(565, 52);
            this.cBox權限.Name = "cBox權限";
            this.cBox權限.Size = new System.Drawing.Size(121, 33);
            this.cBox權限.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(402, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 31);
            this.label9.TabIndex = 65;
            this.label9.Text = "員工詳細資料表";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(974, 652);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox資料欄位);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.groupBox資料欄位.ResumeLayout(false);
            this.groupBox資料欄位.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv員工資料列表)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox資料欄位;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv員工資料列表;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn資料刪除;
        private System.Windows.Forms.Button btn資料新增;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.ComboBox cBox權限;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}