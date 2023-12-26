namespace WindowsFormsApp1
{
    partial class MemberForm
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
            this.groupBox進階搜尋 = new System.Windows.Forms.GroupBox();
            this.listBox進階搜尋結果 = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp結束時間 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始時間 = new System.Windows.Forms.DateTimePicker();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.cbox搜尋欄位 = new System.Windows.Forms.ComboBox();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox功能按鈕 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn資料刪除 = new System.Windows.Forms.Button();
            this.btn資料新增 = new System.Windows.Forms.Button();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.groupBox資料欄位 = new System.Windows.Forms.GroupBox();
            this.groupBox狀態 = new System.Windows.Forms.GroupBox();
            this.rBtn已停權 = new System.Windows.Forms.RadioButton();
            this.rBtn已開通 = new System.Windows.Forms.RadioButton();
            this.rBtn審核中 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv會員資料列表 = new System.Windows.Forms.DataGridView();
            this.groupBox進階搜尋.SuspendLayout();
            this.groupBox功能按鈕.SuspendLayout();
            this.groupBox資料欄位.SuspendLayout();
            this.groupBox狀態.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料列表)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox進階搜尋
            // 
            this.groupBox進階搜尋.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox進階搜尋.Controls.Add(this.listBox進階搜尋結果);
            this.groupBox進階搜尋.Controls.Add(this.label16);
            this.groupBox進階搜尋.Controls.Add(this.label15);
            this.groupBox進階搜尋.Controls.Add(this.label12);
            this.groupBox進階搜尋.Controls.Add(this.label11);
            this.groupBox進階搜尋.Controls.Add(this.label14);
            this.groupBox進階搜尋.Controls.Add(this.label13);
            this.groupBox進階搜尋.Controls.Add(this.dtp結束時間);
            this.groupBox進階搜尋.Controls.Add(this.dtp開始時間);
            this.groupBox進階搜尋.Controls.Add(this.btn搜尋);
            this.groupBox進階搜尋.Controls.Add(this.cbox搜尋欄位);
            this.groupBox進階搜尋.Controls.Add(this.txt搜尋關鍵字);
            this.groupBox進階搜尋.Controls.Add(this.label10);
            this.groupBox進階搜尋.Controls.Add(this.label8);
            this.groupBox進階搜尋.Font = new System.Drawing.Font("微軟正黑體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox進階搜尋.Location = new System.Drawing.Point(12, 72);
            this.groupBox進階搜尋.Name = "groupBox進階搜尋";
            this.groupBox進階搜尋.Size = new System.Drawing.Size(277, 447);
            this.groupBox進階搜尋.TabIndex = 3;
            this.groupBox進階搜尋.TabStop = false;
            this.groupBox進階搜尋.Text = "進階搜尋";
            // 
            // listBox進階搜尋結果
            // 
            this.listBox進階搜尋結果.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox進階搜尋結果.FormattingEnabled = true;
            this.listBox進階搜尋結果.ItemHeight = 25;
            this.listBox進階搜尋結果.Location = new System.Drawing.Point(6, 374);
            this.listBox進階搜尋結果.Name = "listBox進階搜尋結果";
            this.listBox進階搜尋結果.Size = new System.Drawing.Size(265, 79);
            this.listBox進階搜尋結果.TabIndex = 15;
            this.listBox進階搜尋結果.SelectedIndexChanged += new System.EventHandler(this.listBox進階搜尋結果_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(4, 346);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 14;
            this.label16.Text = "搜尋結果";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(4, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(273, 25);
            this.label15.TabIndex = 13;
            this.label15.Text = "-----------------------------";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(4, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(273, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "-----------------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(4, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(273, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "-----------------------------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(10, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "到";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(10, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "從";
            // 
            // dtp結束時間
            // 
            this.dtp結束時間.Location = new System.Drawing.Point(48, 207);
            this.dtp結束時間.Name = "dtp結束時間";
            this.dtp結束時間.Size = new System.Drawing.Size(224, 34);
            this.dtp結束時間.TabIndex = 8;
            // 
            // dtp開始時間
            // 
            this.dtp開始時間.Location = new System.Drawing.Point(48, 159);
            this.dtp開始時間.Name = "dtp開始時間";
            this.dtp開始時間.Size = new System.Drawing.Size(224, 34);
            this.dtp開始時間.TabIndex = 7;
            this.dtp開始時間.Value = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.LightGray;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(6, 275);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(265, 43);
            this.btn搜尋.TabIndex = 6;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // cbox搜尋欄位
            // 
            this.cbox搜尋欄位.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox搜尋欄位.FormattingEnabled = true;
            this.cbox搜尋欄位.Location = new System.Drawing.Point(6, 60);
            this.cbox搜尋欄位.Name = "cbox搜尋欄位";
            this.cbox搜尋欄位.Size = new System.Drawing.Size(117, 33);
            this.cbox搜尋欄位.TabIndex = 5;
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(134, 60);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(137, 34);
            this.txt搜尋關鍵字.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(4, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "生日區間指定";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(4, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "欄位進階搜尋";
            // 
            // dtp生日
            // 
            this.dtp生日.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日.Location = new System.Drawing.Point(125, 205);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(323, 34);
            this.dtp生日.TabIndex = 53;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(125, 259);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 34);
            this.txtEmail.TabIndex = 52;
            // 
            // txt地址
            // 
            this.txt地址.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(125, 152);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(323, 34);
            this.txt地址.TabIndex = 51;
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(125, 312);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(323, 34);
            this.txt電話.TabIndex = 50;
            // 
            // txt姓名
            // 
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(125, 99);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(323, 34);
            this.txt姓名.TabIndex = 49;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(125, 44);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(323, 34);
            this.txtID.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(67, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "生日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(56, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(67, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "*電話(帳號)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(58, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "*姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(86, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID";
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(125, 364);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '●';
            this.txt密碼.Size = new System.Drawing.Size(323, 34);
            this.txt密碼.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(58, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "*密碼";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(437, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 31);
            this.label9.TabIndex = 60;
            this.label9.Text = "會員詳細資料表";
            // 
            // groupBox功能按鈕
            // 
            this.groupBox功能按鈕.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox功能按鈕.Controls.Add(this.btn清空欄位);
            this.groupBox功能按鈕.Controls.Add(this.btn資料刪除);
            this.groupBox功能按鈕.Controls.Add(this.btn資料新增);
            this.groupBox功能按鈕.Controls.Add(this.btn資料修改);
            this.groupBox功能按鈕.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox功能按鈕.Location = new System.Drawing.Point(788, 72);
            this.groupBox功能按鈕.Name = "groupBox功能按鈕";
            this.groupBox功能按鈕.Size = new System.Drawing.Size(171, 291);
            this.groupBox功能按鈕.TabIndex = 61;
            this.groupBox功能按鈕.TabStop = false;
            this.groupBox功能按鈕.Text = "功能按鈕";
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.Location = new System.Drawing.Point(15, 229);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(139, 43);
            this.btn清空欄位.TabIndex = 5;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn資料刪除
            // 
            this.btn資料刪除.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料刪除.ForeColor = System.Drawing.Color.Red;
            this.btn資料刪除.Location = new System.Drawing.Point(15, 166);
            this.btn資料刪除.Name = "btn資料刪除";
            this.btn資料刪除.Size = new System.Drawing.Size(139, 43);
            this.btn資料刪除.TabIndex = 4;
            this.btn資料刪除.Text = "資料刪除";
            this.btn資料刪除.UseVisualStyleBackColor = true;
            this.btn資料刪除.Click += new System.EventHandler(this.btn資料刪除_Click);
            // 
            // btn資料新增
            // 
            this.btn資料新增.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料新增.ForeColor = System.Drawing.Color.Blue;
            this.btn資料新增.Location = new System.Drawing.Point(13, 44);
            this.btn資料新增.Name = "btn資料新增";
            this.btn資料新增.Size = new System.Drawing.Size(139, 43);
            this.btn資料新增.TabIndex = 3;
            this.btn資料新增.Text = "資料新增";
            this.btn資料新增.UseVisualStyleBackColor = true;
            this.btn資料新增.Click += new System.EventHandler(this.btn資料新增_Click);
            // 
            // btn資料修改
            // 
            this.btn資料修改.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料修改.Location = new System.Drawing.Point(13, 106);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(139, 43);
            this.btn資料修改.TabIndex = 2;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.UseVisualStyleBackColor = true;
            this.btn資料修改.Click += new System.EventHandler(this.btn資料修改_Click);
            // 
            // groupBox資料欄位
            // 
            this.groupBox資料欄位.BackColor = System.Drawing.Color.LemonChiffon;
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
            this.groupBox資料欄位.Location = new System.Drawing.Point(295, 72);
            this.groupBox資料欄位.Name = "groupBox資料欄位";
            this.groupBox資料欄位.Size = new System.Drawing.Size(487, 447);
            this.groupBox資料欄位.TabIndex = 62;
            this.groupBox資料欄位.TabStop = false;
            this.groupBox資料欄位.Text = "資料欄位";
            // 
            // groupBox狀態
            // 
            this.groupBox狀態.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox狀態.Controls.Add(this.rBtn已停權);
            this.groupBox狀態.Controls.Add(this.rBtn已開通);
            this.groupBox狀態.Controls.Add(this.rBtn審核中);
            this.groupBox狀態.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox狀態.Location = new System.Drawing.Point(787, 369);
            this.groupBox狀態.Name = "groupBox狀態";
            this.groupBox狀態.Size = new System.Drawing.Size(172, 150);
            this.groupBox狀態.TabIndex = 63;
            this.groupBox狀態.TabStop = false;
            this.groupBox狀態.Text = "狀態";
            // 
            // rBtn已停權
            // 
            this.rBtn已停權.AutoSize = true;
            this.rBtn已停權.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rBtn已停權.Location = new System.Drawing.Point(14, 112);
            this.rBtn已停權.Name = "rBtn已停權";
            this.rBtn已停權.Size = new System.Drawing.Size(97, 29);
            this.rBtn已停權.TabIndex = 2;
            this.rBtn已停權.Text = "已停權";
            this.rBtn已停權.UseVisualStyleBackColor = true;
            this.rBtn已停權.CheckedChanged += new System.EventHandler(this.rBtn已停權_CheckedChanged);
            // 
            // rBtn已開通
            // 
            this.rBtn已開通.AutoSize = true;
            this.rBtn已開通.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rBtn已開通.Location = new System.Drawing.Point(14, 68);
            this.rBtn已開通.Name = "rBtn已開通";
            this.rBtn已開通.Size = new System.Drawing.Size(97, 29);
            this.rBtn已開通.TabIndex = 1;
            this.rBtn已開通.Text = "已開通";
            this.rBtn已開通.UseVisualStyleBackColor = true;
            this.rBtn已開通.CheckedChanged += new System.EventHandler(this.rBtn已開通_CheckedChanged);
            // 
            // rBtn審核中
            // 
            this.rBtn審核中.AutoSize = true;
            this.rBtn審核中.Checked = true;
            this.rBtn審核中.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rBtn審核中.Location = new System.Drawing.Point(14, 24);
            this.rBtn審核中.Name = "rBtn審核中";
            this.rBtn審核中.Size = new System.Drawing.Size(97, 29);
            this.rBtn審核中.TabIndex = 0;
            this.rBtn審核中.TabStop = true;
            this.rBtn審核中.Text = "審核中";
            this.rBtn審核中.UseVisualStyleBackColor = true;
            this.rBtn審核中.CheckedChanged += new System.EventHandler(this.rBtn審核中_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.dgv會員資料列表);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 525);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 157);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "會員資料列表";
            // 
            // dgv會員資料列表
            // 
            this.dgv會員資料列表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv會員資料列表.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv會員資料列表.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgv會員資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv會員資料列表.Location = new System.Drawing.Point(9, 33);
            this.dgv會員資料列表.Name = "dgv會員資料列表";
            this.dgv會員資料列表.ReadOnly = true;
            this.dgv會員資料列表.RowHeadersWidth = 62;
            this.dgv會員資料列表.RowTemplate.Height = 31;
            this.dgv會員資料列表.Size = new System.Drawing.Size(932, 117);
            this.dgv會員資料列表.TabIndex = 0;
            this.dgv會員資料列表.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv會員資料列表_CellContentClick);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(969, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox狀態);
            this.Controls.Add(this.groupBox資料欄位);
            this.Controls.Add(this.groupBox功能按鈕);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox進階搜尋);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.groupBox進階搜尋.ResumeLayout(false);
            this.groupBox進階搜尋.PerformLayout();
            this.groupBox功能按鈕.ResumeLayout(false);
            this.groupBox資料欄位.ResumeLayout(false);
            this.groupBox資料欄位.PerformLayout();
            this.groupBox狀態.ResumeLayout(false);
            this.groupBox狀態.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料列表)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox進階搜尋;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp結束時間;
        private System.Windows.Forms.DateTimePicker dtp開始時間;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbox搜尋欄位;
        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox功能按鈕;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn資料刪除;
        private System.Windows.Forms.Button btn資料新增;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.GroupBox groupBox資料欄位;
        private System.Windows.Forms.GroupBox groupBox狀態;
        private System.Windows.Forms.RadioButton rBtn已停權;
        private System.Windows.Forms.RadioButton rBtn已開通;
        private System.Windows.Forms.RadioButton rBtn審核中;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBox進階搜尋結果;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv會員資料列表;
    }
}