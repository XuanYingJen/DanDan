namespace WindowsFormsApp1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn登入 = new System.Windows.Forms.Button();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn註冊 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.Color.Gold;
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(71, 416);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(241, 51);
            this.btn登入.TabIndex = 12;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // txt密碼
            // 
            this.txt密碼.Location = new System.Drawing.Point(71, 332);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '●';
            this.txt密碼.Size = new System.Drawing.Size(241, 29);
            this.txt密碼.TabIndex = 11;
            // 
            // txt帳號
            // 
            this.txt帳號.Location = new System.Drawing.Point(71, 272);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(241, 29);
            this.txt帳號.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(66, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(66, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "帳號(電話)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn註冊
            // 
            this.btn註冊.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊.ForeColor = System.Drawing.Color.Blue;
            this.btn註冊.Location = new System.Drawing.Point(308, 1);
            this.btn註冊.Name = "btn註冊";
            this.btn註冊.Size = new System.Drawing.Size(75, 38);
            this.btn註冊.TabIndex = 14;
            this.btn註冊.Text = "註冊";
            this.btn註冊.UseVisualStyleBackColor = true;
            this.btn註冊.Click += new System.EventHandler(this.btn註冊_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(385, 492);
            this.Controls.Add(this.btn註冊);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn註冊;
    }
}