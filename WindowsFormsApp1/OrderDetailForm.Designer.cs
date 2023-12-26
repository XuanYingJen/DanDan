namespace WindowsFormsApp1
{
    partial class OrderDetailForm
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
            this.lbl商品數量 = new System.Windows.Forms.Label();
            this.btn加 = new System.Windows.Forms.Button();
            this.btn減 = new System.Windows.Forms.Button();
            this.lbl商品顯示 = new System.Windows.Forms.Label();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.pictureBox商品圖檔 = new System.Windows.Forms.PictureBox();
            this.txt商品備註 = new System.Windows.Forms.TextBox();
            this.lbl備註 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl商品數量
            // 
            this.lbl商品數量.AutoSize = true;
            this.lbl商品數量.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl商品數量.Location = new System.Drawing.Point(208, 291);
            this.lbl商品數量.Name = "lbl商品數量";
            this.lbl商品數量.Size = new System.Drawing.Size(24, 25);
            this.lbl商品數量.TabIndex = 22;
            this.lbl商品數量.Text = "0";
            // 
            // btn加
            // 
            this.btn加.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加.Location = new System.Drawing.Point(257, 283);
            this.btn加.Name = "btn加";
            this.btn加.Size = new System.Drawing.Size(42, 45);
            this.btn加.TabIndex = 21;
            this.btn加.Text = "+";
            this.btn加.UseVisualStyleBackColor = true;
            this.btn加.Click += new System.EventHandler(this.btn加_Click);
            // 
            // btn減
            // 
            this.btn減.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn減.Location = new System.Drawing.Point(141, 283);
            this.btn減.Name = "btn減";
            this.btn減.Size = new System.Drawing.Size(42, 45);
            this.btn減.TabIndex = 20;
            this.btn減.Text = "–";
            this.btn減.UseVisualStyleBackColor = true;
            this.btn減.Click += new System.EventHandler(this.btn減_Click);
            // 
            // lbl商品顯示
            // 
            this.lbl商品顯示.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl商品顯示.Location = new System.Drawing.Point(96, 244);
            this.lbl商品顯示.Name = "lbl商品顯示";
            this.lbl商品顯示.Size = new System.Drawing.Size(256, 31);
            this.lbl商品顯示.TabIndex = 19;
            this.lbl商品顯示.Text = "商品名稱";
            this.lbl商品顯示.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.BackColor = System.Drawing.Color.Silver;
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.Location = new System.Drawing.Point(65, 515);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(315, 40);
            this.btn加入購物車.TabIndex = 23;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = false;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // pictureBox商品圖檔
            // 
            this.pictureBox商品圖檔.Location = new System.Drawing.Point(113, 12);
            this.pictureBox商品圖檔.Name = "pictureBox商品圖檔";
            this.pictureBox商品圖檔.Size = new System.Drawing.Size(224, 225);
            this.pictureBox商品圖檔.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox商品圖檔.TabIndex = 24;
            this.pictureBox商品圖檔.TabStop = false;
            // 
            // txt商品備註
            // 
            this.txt商品備註.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品備註.Location = new System.Drawing.Point(66, 365);
            this.txt商品備註.Multiline = true;
            this.txt商品備註.Name = "txt商品備註";
            this.txt商品備註.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品備註.Size = new System.Drawing.Size(314, 133);
            this.txt商品備註.TabIndex = 25;
            // 
            // lbl備註
            // 
            this.lbl備註.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl備註.Location = new System.Drawing.Point(60, 331);
            this.lbl備註.Name = "lbl備註";
            this.lbl備註.Size = new System.Drawing.Size(256, 31);
            this.lbl備註.TabIndex = 26;
            this.lbl備註.Text = "備註：";
            this.lbl備註.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(438, 567);
            this.Controls.Add(this.lbl備註);
            this.Controls.Add(this.txt商品備註);
            this.Controls.Add(this.pictureBox商品圖檔);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.lbl商品數量);
            this.Controls.Add(this.btn加);
            this.Controls.Add(this.btn減);
            this.Controls.Add(this.lbl商品顯示);
            this.Name = "OrderDetailForm";
            this.Text = "OrderDetailForm";
            this.Load += new System.EventHandler(this.OrderDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl商品數量;
        private System.Windows.Forms.Button btn加;
        private System.Windows.Forms.Button btn減;
        private System.Windows.Forms.Label lbl商品顯示;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.PictureBox pictureBox商品圖檔;
        private System.Windows.Forms.TextBox txt商品備註;
        private System.Windows.Forms.Label lbl備註;
    }
}