namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn系統管理 = new System.Windows.Forms.Button();
            this.btn商品管理 = new System.Windows.Forms.Button();
            this.btn訂單管理 = new System.Windows.Forms.Button();
            this.btn會員資料管理 = new System.Windows.Forms.Button();
            this.btn餐點訂購單 = new System.Windows.Forms.Button();
            this.lbl登入資訊 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(190, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "單單漢堡管理系統";
            // 
            // btn系統管理
            // 
            this.btn系統管理.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn系統管理.Location = new System.Drawing.Point(225, 498);
            this.btn系統管理.Name = "btn系統管理";
            this.btn系統管理.Size = new System.Drawing.Size(205, 71);
            this.btn系統管理.TabIndex = 10;
            this.btn系統管理.Text = "系統管理";
            this.btn系統管理.UseVisualStyleBackColor = true;
            this.btn系統管理.Click += new System.EventHandler(this.btn系統管理_Click);
            // 
            // btn商品管理
            // 
            this.btn商品管理.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品管理.Location = new System.Drawing.Point(225, 311);
            this.btn商品管理.Name = "btn商品管理";
            this.btn商品管理.Size = new System.Drawing.Size(205, 71);
            this.btn商品管理.TabIndex = 9;
            this.btn商品管理.Text = "商品管理";
            this.btn商品管理.UseVisualStyleBackColor = true;
            this.btn商品管理.Click += new System.EventHandler(this.btn商品管理_Click);
            // 
            // btn訂單管理
            // 
            this.btn訂單管理.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單管理.Location = new System.Drawing.Point(225, 405);
            this.btn訂單管理.Name = "btn訂單管理";
            this.btn訂單管理.Size = new System.Drawing.Size(205, 71);
            this.btn訂單管理.TabIndex = 8;
            this.btn訂單管理.Text = "訂單管理";
            this.btn訂單管理.UseVisualStyleBackColor = true;
            this.btn訂單管理.Click += new System.EventHandler(this.btn訂單管理_Click);
            // 
            // btn會員資料管理
            // 
            this.btn會員資料管理.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員資料管理.Location = new System.Drawing.Point(225, 221);
            this.btn會員資料管理.Name = "btn會員資料管理";
            this.btn會員資料管理.Size = new System.Drawing.Size(205, 71);
            this.btn會員資料管理.TabIndex = 7;
            this.btn會員資料管理.Text = "會員資料管理";
            this.btn會員資料管理.UseVisualStyleBackColor = true;
            this.btn會員資料管理.Click += new System.EventHandler(this.btn會員資料管理_Click);
            // 
            // btn餐點訂購單
            // 
            this.btn餐點訂購單.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn餐點訂購單.Location = new System.Drawing.Point(225, 127);
            this.btn餐點訂購單.Name = "btn餐點訂購單";
            this.btn餐點訂購單.Size = new System.Drawing.Size(205, 71);
            this.btn餐點訂購單.TabIndex = 6;
            this.btn餐點訂購單.Text = "餐點訂購單";
            this.btn餐點訂購單.UseVisualStyleBackColor = true;
            this.btn餐點訂購單.Click += new System.EventHandler(this.btn餐點訂購單_Click);
            // 
            // lbl登入資訊
            // 
            this.lbl登入資訊.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl登入資訊.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl登入資訊.Location = new System.Drawing.Point(414, 9);
            this.lbl登入資訊.Name = "lbl登入資訊";
            this.lbl登入資訊.Size = new System.Drawing.Size(215, 28);
            this.lbl登入資訊.TabIndex = 11;
            this.lbl登入資訊.Text = "登入資訊";
            this.lbl登入資訊.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(641, 596);
            this.Controls.Add(this.lbl登入資訊);
            this.Controls.Add(this.btn系統管理);
            this.Controls.Add(this.btn商品管理);
            this.Controls.Add(this.btn訂單管理);
            this.Controls.Add(this.btn會員資料管理);
            this.Controls.Add(this.btn餐點訂購單);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "系統主選單";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn系統管理;
        private System.Windows.Forms.Button btn商品管理;
        private System.Windows.Forms.Button btn訂單管理;
        private System.Windows.Forms.Button btn會員資料管理;
        private System.Windows.Forms.Button btn餐點訂購單;
        private System.Windows.Forms.Label lbl登入資訊;
    }
}

