namespace WindowsFormsApp1
{
    partial class OrderListForm
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
            this.btn繼續訂購 = new System.Windows.Forms.Button();
            this.btn輸出訂購單檔案 = new System.Windows.Forms.Button();
            this.btn清除所選品項 = new System.Windows.Forms.Button();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.listBox訂購品項列表 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.groupBox內用外帶 = new System.Windows.Forms.GroupBox();
            this.radioBtn外帶 = new System.Windows.Forms.RadioButton();
            this.radioBtn內用 = new System.Windows.Forms.RadioButton();
            this.groupBox購物袋 = new System.Windows.Forms.GroupBox();
            this.radioBtn否 = new System.Windows.Forms.RadioButton();
            this.radioBtn是 = new System.Windows.Forms.RadioButton();
            this.groupBox內用外帶.SuspendLayout();
            this.groupBox購物袋.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(262, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "訂購品項列表(購物車結帳)";
            // 
            // btn繼續訂購
            // 
            this.btn繼續訂購.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn繼續訂購.Location = new System.Drawing.Point(441, 479);
            this.btn繼續訂購.Name = "btn繼續訂購";
            this.btn繼續訂購.Size = new System.Drawing.Size(333, 43);
            this.btn繼續訂購.TabIndex = 17;
            this.btn繼續訂購.Text = "繼續訂購(關閉表單)";
            this.btn繼續訂購.UseVisualStyleBackColor = true;
            this.btn繼續訂購.Click += new System.EventHandler(this.btn繼續訂購_Click);
            // 
            // btn輸出訂購單檔案
            // 
            this.btn輸出訂購單檔案.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn輸出訂購單檔案.ForeColor = System.Drawing.Color.Blue;
            this.btn輸出訂購單檔案.Location = new System.Drawing.Point(34, 479);
            this.btn輸出訂購單檔案.Name = "btn輸出訂購單檔案";
            this.btn輸出訂購單檔案.Size = new System.Drawing.Size(385, 43);
            this.btn輸出訂購單檔案.TabIndex = 16;
            this.btn輸出訂購單檔案.Text = "輸出訂購單檔案";
            this.btn輸出訂購單檔案.UseVisualStyleBackColor = true;
            this.btn輸出訂購單檔案.Click += new System.EventHandler(this.btn輸出訂購單檔案_Click);
            // 
            // btn清除所選品項
            // 
            this.btn清除所選品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所選品項.ForeColor = System.Drawing.Color.Red;
            this.btn清除所選品項.Location = new System.Drawing.Point(579, 143);
            this.btn清除所選品項.Name = "btn清除所選品項";
            this.btn清除所選品項.Size = new System.Drawing.Size(186, 42);
            this.btn清除所選品項.TabIndex = 15;
            this.btn清除所選品項.Text = "清除所有品項";
            this.btn清除所選品項.UseVisualStyleBackColor = true;
            this.btn清除所選品項.Click += new System.EventHandler(this.btn清除所選品項_Click);
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.Location = new System.Drawing.Point(389, 143);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(176, 42);
            this.btn移除所選品項.TabIndex = 14;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = true;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl訂單總價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.Location = new System.Drawing.Point(441, 407);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(333, 59);
            this.lbl訂單總價.TabIndex = 13;
            this.lbl訂單總價.Text = "訂單總價 000000 元";
            this.lbl訂單總價.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox訂購品項列表
            // 
            this.listBox訂購品項列表.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購品項列表.FormattingEnabled = true;
            this.listBox訂購品項列表.HorizontalScrollbar = true;
            this.listBox訂購品項列表.ItemHeight = 30;
            this.listBox訂購品項列表.Location = new System.Drawing.Point(34, 203);
            this.listBox訂購品項列表.Name = "listBox訂購品項列表";
            this.listBox訂購品項列表.Size = new System.Drawing.Size(740, 184);
            this.listBox訂購品項列表.TabIndex = 10;
            this.listBox訂購品項列表.SelectedIndexChanged += new System.EventHandler(this.listBox訂購品項列表_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "*訂購人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(46, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "*電話";
            // 
            // txt訂購人
            // 
            this.txt訂購人.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人.Location = new System.Drawing.Point(124, 88);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.ReadOnly = true;
            this.txt訂購人.Size = new System.Drawing.Size(170, 39);
            this.txt訂購人.TabIndex = 20;
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(124, 146);
            this.txt電話.Name = "txt電話";
            this.txt電話.ReadOnly = true;
            this.txt電話.Size = new System.Drawing.Size(227, 39);
            this.txt電話.TabIndex = 21;
            // 
            // groupBox內用外帶
            // 
            this.groupBox內用外帶.Controls.Add(this.radioBtn外帶);
            this.groupBox內用外帶.Controls.Add(this.radioBtn內用);
            this.groupBox內用外帶.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox內用外帶.Location = new System.Drawing.Point(389, 54);
            this.groupBox內用外帶.Name = "groupBox內用外帶";
            this.groupBox內用外帶.Size = new System.Drawing.Size(172, 73);
            this.groupBox內用外帶.TabIndex = 22;
            this.groupBox內用外帶.TabStop = false;
            this.groupBox內用外帶.Text = "*內用or外帶?";
            // 
            // radioBtn外帶
            // 
            this.radioBtn外帶.AutoSize = true;
            this.radioBtn外帶.Location = new System.Drawing.Point(90, 38);
            this.radioBtn外帶.Name = "radioBtn外帶";
            this.radioBtn外帶.Size = new System.Drawing.Size(77, 29);
            this.radioBtn外帶.TabIndex = 1;
            this.radioBtn外帶.Text = "外帶";
            this.radioBtn外帶.UseVisualStyleBackColor = true;
            this.radioBtn外帶.CheckedChanged += new System.EventHandler(this.radioBtn外帶_CheckedChanged);
            // 
            // radioBtn內用
            // 
            this.radioBtn內用.AutoSize = true;
            this.radioBtn內用.Checked = true;
            this.radioBtn內用.Location = new System.Drawing.Point(6, 38);
            this.radioBtn內用.Name = "radioBtn內用";
            this.radioBtn內用.Size = new System.Drawing.Size(77, 29);
            this.radioBtn內用.TabIndex = 0;
            this.radioBtn內用.TabStop = true;
            this.radioBtn內用.Text = "內用";
            this.radioBtn內用.UseVisualStyleBackColor = true;
            this.radioBtn內用.CheckedChanged += new System.EventHandler(this.radioBtn內用_CheckedChanged);
            // 
            // groupBox購物袋
            // 
            this.groupBox購物袋.Controls.Add(this.radioBtn否);
            this.groupBox購物袋.Controls.Add(this.radioBtn是);
            this.groupBox購物袋.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox購物袋.Location = new System.Drawing.Point(579, 54);
            this.groupBox購物袋.Name = "groupBox購物袋";
            this.groupBox購物袋.Size = new System.Drawing.Size(186, 73);
            this.groupBox購物袋.TabIndex = 23;
            this.groupBox購物袋.TabStop = false;
            this.groupBox購物袋.Text = "*加購購物袋?";
            // 
            // radioBtn否
            // 
            this.radioBtn否.AutoSize = true;
            this.radioBtn否.Checked = true;
            this.radioBtn否.Location = new System.Drawing.Point(128, 38);
            this.radioBtn否.Name = "radioBtn否";
            this.radioBtn否.Size = new System.Drawing.Size(57, 29);
            this.radioBtn否.TabIndex = 1;
            this.radioBtn否.TabStop = true;
            this.radioBtn否.Text = "否";
            this.radioBtn否.UseVisualStyleBackColor = true;
            this.radioBtn否.CheckedChanged += new System.EventHandler(this.radioBtn否_CheckedChanged);
            // 
            // radioBtn是
            // 
            this.radioBtn是.AutoSize = true;
            this.radioBtn是.Location = new System.Drawing.Point(6, 38);
            this.radioBtn是.Name = "radioBtn是";
            this.radioBtn是.Size = new System.Drawing.Size(116, 29);
            this.radioBtn是.TabIndex = 0;
            this.radioBtn是.Text = "是(+1元)";
            this.radioBtn是.UseVisualStyleBackColor = true;
            this.radioBtn是.CheckedChanged += new System.EventHandler(this.radioBtn是_CheckedChanged);
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.groupBox購物袋);
            this.Controls.Add(this.groupBox內用外帶);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn繼續訂購);
            this.Controls.Add(this.btn輸出訂購單檔案);
            this.Controls.Add(this.btn清除所選品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.listBox訂購品項列表);
            this.Controls.Add(this.label1);
            this.Name = "OrderListForm";
            this.Text = "OrderListForm";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            this.groupBox內用外帶.ResumeLayout(false);
            this.groupBox內用外帶.PerformLayout();
            this.groupBox購物袋.ResumeLayout(false);
            this.groupBox購物袋.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn繼續訂購;
        private System.Windows.Forms.Button btn輸出訂購單檔案;
        private System.Windows.Forms.Button btn清除所選品項;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.ListBox listBox訂購品項列表;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.GroupBox groupBox內用外帶;
        private System.Windows.Forms.RadioButton radioBtn外帶;
        private System.Windows.Forms.RadioButton radioBtn內用;
        private System.Windows.Forms.GroupBox groupBox購物袋;
        private System.Windows.Forms.RadioButton radioBtn否;
        private System.Windows.Forms.RadioButton radioBtn是;
    }
}