namespace WindowsFormsApp1
{
    partial class ListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtn已完成 = new System.Windows.Forms.RadioButton();
            this.rBtn準備中 = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txt訂單總額 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv訂單資料列表 = new System.Windows.Forms.DataGridView();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn刪除訂單 = new System.Windows.Forms.Button();
            this.btn儲存 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單資料列表)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂單編號";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(375, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 31);
            this.label9.TabIndex = 73;
            this.label9.Text = "訂單管理表單";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(504, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "訂單日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "訂單內容";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(15, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "訂單總額";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtn已完成);
            this.groupBox1.Controls.Add(this.rBtn準備中);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(498, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 82);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂單狀態";
            // 
            // rBtn已完成
            // 
            this.rBtn已完成.AutoSize = true;
            this.rBtn已完成.Location = new System.Drawing.Point(115, 33);
            this.rBtn已完成.Name = "rBtn已完成";
            this.rBtn已完成.Size = new System.Drawing.Size(97, 29);
            this.rBtn已完成.TabIndex = 1;
            this.rBtn已完成.TabStop = true;
            this.rBtn已完成.Text = "已完成";
            this.rBtn已完成.UseVisualStyleBackColor = true;
            this.rBtn已完成.CheckedChanged += new System.EventHandler(this.rBtn已完成_CheckedChanged);
            // 
            // rBtn準備中
            // 
            this.rBtn準備中.AutoSize = true;
            this.rBtn準備中.Location = new System.Drawing.Point(12, 33);
            this.rBtn準備中.Name = "rBtn準備中";
            this.rBtn準備中.Size = new System.Drawing.Size(97, 29);
            this.rBtn準備中.TabIndex = 0;
            this.rBtn準備中.TabStop = true;
            this.rBtn準備中.Text = "準備中";
            this.rBtn準備中.UseVisualStyleBackColor = true;
            this.rBtn準備中.CheckedChanged += new System.EventHandler(this.rBtn準備中_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(125, 89);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 34);
            this.txtID.TabIndex = 78;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(20, 167);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(438, 145);
            this.txtContent.TabIndex = 79;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDate.Location = new System.Drawing.Point(602, 89);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(234, 34);
            this.txtDate.TabIndex = 80;
            // 
            // txt訂單總額
            // 
            this.txt訂單總額.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂單總額.Location = new System.Drawing.Point(113, 327);
            this.txt訂單總額.Name = "txt訂單總額";
            this.txt訂單總額.Size = new System.Drawing.Size(112, 34);
            this.txt訂單總額.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(231, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 82;
            this.label5.Text = "元";
            // 
            // dgv訂單資料列表
            // 
            this.dgv訂單資料列表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv訂單資料列表.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv訂單資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv訂單資料列表.Location = new System.Drawing.Point(20, 377);
            this.dgv訂單資料列表.Name = "dgv訂單資料列表";
            this.dgv訂單資料列表.RowHeadersWidth = 62;
            this.dgv訂單資料列表.RowTemplate.Height = 31;
            this.dgv訂單資料列表.Size = new System.Drawing.Size(816, 182);
            this.dgv訂單資料列表.TabIndex = 83;
            this.dgv訂單資料列表.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv訂單資料列表_CellContentClick);
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(602, 182);
            this.txt電話.Name = "txt電話";
            this.txt電話.ReadOnly = true;
            this.txt電話.Size = new System.Drawing.Size(170, 34);
            this.txt電話.TabIndex = 87;
            // 
            // txt訂購人
            // 
            this.txt訂購人.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人.Location = new System.Drawing.Point(602, 136);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.ReadOnly = true;
            this.txt訂購人.Size = new System.Drawing.Size(170, 34);
            this.txt訂購人.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(504, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 85;
            this.label6.Text = "電話";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(504, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 84;
            this.label7.Text = "訂購人";
            // 
            // btn刪除訂單
            // 
            this.btn刪除訂單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除訂單.ForeColor = System.Drawing.Color.Red;
            this.btn刪除訂單.Location = new System.Drawing.Point(709, 12);
            this.btn刪除訂單.Name = "btn刪除訂單";
            this.btn刪除訂單.Size = new System.Drawing.Size(127, 45);
            this.btn刪除訂單.TabIndex = 88;
            this.btn刪除訂單.Text = "刪除訂單";
            this.btn刪除訂單.UseVisualStyleBackColor = true;
            this.btn刪除訂單.Click += new System.EventHandler(this.btn刪除訂單_Click);
            // 
            // btn儲存
            // 
            this.btn儲存.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存.ForeColor = System.Drawing.Color.Black;
            this.btn儲存.Location = new System.Drawing.Point(761, 320);
            this.btn儲存.Name = "btn儲存";
            this.btn儲存.Size = new System.Drawing.Size(75, 43);
            this.btn儲存.TabIndex = 89;
            this.btn儲存.Text = "儲存";
            this.btn儲存.UseVisualStyleBackColor = true;
            this.btn儲存.Click += new System.EventHandler(this.btn儲存_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(852, 571);
            this.Controls.Add(this.btn儲存);
            this.Controls.Add(this.btn刪除訂單);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv訂單資料列表);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt訂單總額);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單資料列表)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtn已完成;
        private System.Windows.Forms.RadioButton rBtn準備中;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txt訂單總額;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv訂單資料列表;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn刪除訂單;
        private System.Windows.Forms.Button btn儲存;
    }
}