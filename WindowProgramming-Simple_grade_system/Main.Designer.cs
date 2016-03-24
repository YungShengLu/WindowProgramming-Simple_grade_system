namespace F74039025_W4_3 {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.query = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_add = new System.Windows.Forms.Panel();
            this.panel_query = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.query_address = new System.Windows.Forms.Label();
            this.query_phone = new System.Windows.Forms.Label();
            this.query_sex = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.warning_query = new System.Windows.Forms.Label();
            this.textBox_query = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_query_accept = new System.Windows.Forms.Button();
            this.button_query_back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.warning_add = new System.Windows.Forms.Label();
            this.button_add_accept = new System.Windows.Forms.Button();
            this.button_add_back = new System.Windows.Forms.Button();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_sex = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_delete = new System.Windows.Forms.Panel();
            this.groupBox_delete = new System.Windows.Forms.GroupBox();
            this.delete_address = new System.Windows.Forms.Label();
            this.delete_phone = new System.Windows.Forms.Label();
            this.delete_sex = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.warning_delete = new System.Windows.Forms.Label();
            this.textBox_delete = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button_delete_accept = new System.Windows.Forms.Button();
            this.button_delete_back = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.panel_add.SuspendLayout();
            this.panel_query.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panel_delete.SuspendLayout();
            this.groupBox_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(137, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add.Location = new System.Drawing.Point(78, 84);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(235, 34);
            this.add.TabIndex = 1;
            this.add.Text = "新    增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.delete.Location = new System.Drawing.Point(78, 134);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(235, 34);
            this.delete.TabIndex = 2;
            this.delete.Text = "刪    除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // query
            // 
            this.query.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.query.Location = new System.Drawing.Point(78, 185);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(235, 34);
            this.query.TabIndex = 3;
            this.query.Text = "查    詢";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.logout.Location = new System.Drawing.Point(78, 236);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(235, 34);
            this.logout.TabIndex = 4;
            this.logout.Text = "登    出";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.logout);
            this.panel_menu.Controls.Add(this.query);
            this.panel_menu.Controls.Add(this.delete);
            this.panel_menu.Controls.Add(this.add);
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Location = new System.Drawing.Point(74, 59);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(387, 307);
            this.panel_menu.TabIndex = 5;
            // 
            // panel_add
            // 
            this.panel_add.Controls.Add(this.warning_add);
            this.panel_add.Controls.Add(this.button_add_accept);
            this.panel_add.Controls.Add(this.button_add_back);
            this.panel_add.Controls.Add(this.textBox_address);
            this.panel_add.Controls.Add(this.textBox_phone);
            this.panel_add.Controls.Add(this.textBox_sex);
            this.panel_add.Controls.Add(this.textBox_id);
            this.panel_add.Controls.Add(this.label6);
            this.panel_add.Controls.Add(this.label5);
            this.panel_add.Controls.Add(this.label4);
            this.panel_add.Controls.Add(this.label3);
            this.panel_add.Controls.Add(this.label2);
            this.panel_add.Location = new System.Drawing.Point(74, 35);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(387, 365);
            this.panel_add.TabIndex = 6;
            // 
            // panel_query
            // 
            this.panel_query.Controls.Add(this.groupBox);
            this.panel_query.Controls.Add(this.warning_query);
            this.panel_query.Controls.Add(this.textBox_query);
            this.panel_query.Controls.Add(this.label8);
            this.panel_query.Controls.Add(this.button_query_accept);
            this.panel_query.Controls.Add(this.button_query_back);
            this.panel_query.Controls.Add(this.label7);
            this.panel_query.Location = new System.Drawing.Point(74, 35);
            this.panel_query.Name = "panel_query";
            this.panel_query.Size = new System.Drawing.Size(387, 365);
            this.panel_query.TabIndex = 7;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.query_address);
            this.groupBox.Controls.Add(this.query_phone);
            this.groupBox.Controls.Add(this.query_sex);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox.Location = new System.Drawing.Point(54, 134);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(296, 130);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "查詢資料";
            // 
            // query_address
            // 
            this.query_address.AutoSize = true;
            this.query_address.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.query_address.Location = new System.Drawing.Point(120, 87);
            this.query_address.Name = "query_address";
            this.query_address.Size = new System.Drawing.Size(58, 21);
            this.query_address.TabIndex = 7;
            this.query_address.Text = "無資料";
            // 
            // query_phone
            // 
            this.query_phone.AutoSize = true;
            this.query_phone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.query_phone.Location = new System.Drawing.Point(120, 58);
            this.query_phone.Name = "query_phone";
            this.query_phone.Size = new System.Drawing.Size(58, 21);
            this.query_phone.TabIndex = 7;
            this.query_phone.Text = "無資料";
            // 
            // query_sex
            // 
            this.query_sex.AutoSize = true;
            this.query_sex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.query_sex.Location = new System.Drawing.Point(120, 31);
            this.query_sex.Name = "query_sex";
            this.query_sex.Size = new System.Drawing.Size(58, 21);
            this.query_sex.TabIndex = 7;
            this.query_sex.Text = "無資料";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(45, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "地    址";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(45, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "電    話";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(45, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "性    別";
            // 
            // warning_query
            // 
            this.warning_query.AutoSize = true;
            this.warning_query.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.warning_query.ForeColor = System.Drawing.Color.Blue;
            this.warning_query.Location = new System.Drawing.Point(50, 272);
            this.warning_query.Name = "warning_query";
            this.warning_query.Size = new System.Drawing.Size(250, 21);
            this.warning_query.TabIndex = 7;
            this.warning_query.Text = "請輸入欲查詢資料的身分證字號。";
            // 
            // textBox_query
            // 
            this.textBox_query.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_query.Location = new System.Drawing.Point(178, 83);
            this.textBox_query.Name = "textBox_query";
            this.textBox_query.Size = new System.Drawing.Size(172, 29);
            this.textBox_query.TabIndex = 7;
            this.textBox_query.TextChanged += new System.EventHandler(this.textBox_query_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(67, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "身分證字號";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button_query_accept
            // 
            this.button_query_accept.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_query_accept.Location = new System.Drawing.Point(213, 309);
            this.button_query_accept.Name = "button_query_accept";
            this.button_query_accept.Size = new System.Drawing.Size(137, 37);
            this.button_query_accept.TabIndex = 7;
            this.button_query_accept.Text = "查    詢";
            this.button_query_accept.UseVisualStyleBackColor = true;
            this.button_query_accept.Click += new System.EventHandler(this.button_query_accept_Click);
            // 
            // button_query_back
            // 
            this.button_query_back.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_query_back.Location = new System.Drawing.Point(54, 309);
            this.button_query_back.Name = "button_query_back";
            this.button_query_back.Size = new System.Drawing.Size(137, 37);
            this.button_query_back.TabIndex = 7;
            this.button_query_back.Text = "回選單";
            this.button_query_back.UseVisualStyleBackColor = true;
            this.button_query_back.Click += new System.EventHandler(this.button_query_back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(148, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 40);
            this.label7.TabIndex = 7;
            this.label7.Text = "查    詢";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // warning_add
            // 
            this.warning_add.AutoSize = true;
            this.warning_add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.warning_add.ForeColor = System.Drawing.Color.Blue;
            this.warning_add.Location = new System.Drawing.Point(67, 286);
            this.warning_add.Name = "warning_add";
            this.warning_add.Size = new System.Drawing.Size(170, 21);
            this.warning_add.TabIndex = 11;
            this.warning_add.Text = "請輸入欲新增的資料。";
            // 
            // button_add_accept
            // 
            this.button_add_accept.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_add_accept.Location = new System.Drawing.Point(197, 317);
            this.button_add_accept.Name = "button_add_accept";
            this.button_add_accept.Size = new System.Drawing.Size(137, 37);
            this.button_add_accept.TabIndex = 10;
            this.button_add_accept.Text = "確    認";
            this.button_add_accept.UseVisualStyleBackColor = true;
            this.button_add_accept.Click += new System.EventHandler(this.button_add_accept_Click);
            // 
            // button_add_back
            // 
            this.button_add_back.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_add_back.Location = new System.Drawing.Point(54, 317);
            this.button_add_back.Name = "button_add_back";
            this.button_add_back.Size = new System.Drawing.Size(137, 37);
            this.button_add_back.TabIndex = 9;
            this.button_add_back.Text = "回選單";
            this.button_add_back.UseVisualStyleBackColor = true;
            this.button_add_back.Click += new System.EventHandler(this.button_add_back_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_address.Location = new System.Drawing.Point(166, 235);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(184, 29);
            this.textBox_address.TabIndex = 8;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_phone.Location = new System.Drawing.Point(166, 192);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(184, 29);
            this.textBox_phone.TabIndex = 7;
            // 
            // textBox_sex
            // 
            this.textBox_sex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_sex.Location = new System.Drawing.Point(166, 147);
            this.textBox_sex.Name = "textBox_sex";
            this.textBox_sex.Size = new System.Drawing.Size(184, 29);
            this.textBox_sex.TabIndex = 6;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_id.Location = new System.Drawing.Point(166, 102);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(184, 29);
            this.textBox_id.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(50, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "地           址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(50, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "電           話";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(50, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "性           別";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(50, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "身分證字號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(141, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "新    增";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel_delete
            // 
            this.panel_delete.Controls.Add(this.groupBox_delete);
            this.panel_delete.Controls.Add(this.warning_delete);
            this.panel_delete.Controls.Add(this.textBox_delete);
            this.panel_delete.Controls.Add(this.label19);
            this.panel_delete.Controls.Add(this.button_delete_accept);
            this.panel_delete.Controls.Add(this.button_delete_back);
            this.panel_delete.Controls.Add(this.label20);
            this.panel_delete.Location = new System.Drawing.Point(74, 35);
            this.panel_delete.Name = "panel_delete";
            this.panel_delete.Size = new System.Drawing.Size(387, 365);
            this.panel_delete.TabIndex = 8;
            // 
            // groupBox_delete
            // 
            this.groupBox_delete.Controls.Add(this.delete_address);
            this.groupBox_delete.Controls.Add(this.delete_phone);
            this.groupBox_delete.Controls.Add(this.delete_sex);
            this.groupBox_delete.Controls.Add(this.label15);
            this.groupBox_delete.Controls.Add(this.label16);
            this.groupBox_delete.Controls.Add(this.label17);
            this.groupBox_delete.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_delete.Location = new System.Drawing.Point(54, 134);
            this.groupBox_delete.Name = "groupBox_delete";
            this.groupBox_delete.Size = new System.Drawing.Size(296, 130);
            this.groupBox_delete.TabIndex = 7;
            this.groupBox_delete.TabStop = false;
            this.groupBox_delete.Text = "刪除資料";
            // 
            // delete_address
            // 
            this.delete_address.AutoSize = true;
            this.delete_address.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.delete_address.Location = new System.Drawing.Point(120, 87);
            this.delete_address.Name = "delete_address";
            this.delete_address.Size = new System.Drawing.Size(58, 21);
            this.delete_address.TabIndex = 5;
            this.delete_address.Text = "無資料";
            // 
            // delete_phone
            // 
            this.delete_phone.AutoSize = true;
            this.delete_phone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.delete_phone.Location = new System.Drawing.Point(120, 58);
            this.delete_phone.Name = "delete_phone";
            this.delete_phone.Size = new System.Drawing.Size(58, 21);
            this.delete_phone.TabIndex = 4;
            this.delete_phone.Text = "無資料";
            // 
            // delete_sex
            // 
            this.delete_sex.AutoSize = true;
            this.delete_sex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.delete_sex.Location = new System.Drawing.Point(120, 31);
            this.delete_sex.Name = "delete_sex";
            this.delete_sex.Size = new System.Drawing.Size(58, 21);
            this.delete_sex.TabIndex = 3;
            this.delete_sex.Text = "無資料";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(45, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "地    址";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(45, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 21);
            this.label16.TabIndex = 1;
            this.label16.Text = "電    話";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(45, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "性    別";
            // 
            // warning_delete
            // 
            this.warning_delete.AutoSize = true;
            this.warning_delete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.warning_delete.ForeColor = System.Drawing.Color.Blue;
            this.warning_delete.Location = new System.Drawing.Point(50, 272);
            this.warning_delete.Name = "warning_delete";
            this.warning_delete.Size = new System.Drawing.Size(250, 21);
            this.warning_delete.TabIndex = 6;
            this.warning_delete.Text = "請輸入欲刪除資料的身分證字號。";
            // 
            // textBox_delete
            // 
            this.textBox_delete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_delete.Location = new System.Drawing.Point(178, 83);
            this.textBox_delete.Name = "textBox_delete";
            this.textBox_delete.Size = new System.Drawing.Size(172, 29);
            this.textBox_delete.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(67, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 24);
            this.label19.TabIndex = 4;
            this.label19.Text = "身分證字號";
            // 
            // button_delete_accept
            // 
            this.button_delete_accept.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_delete_accept.Location = new System.Drawing.Point(213, 309);
            this.button_delete_accept.Name = "button_delete_accept";
            this.button_delete_accept.Size = new System.Drawing.Size(137, 37);
            this.button_delete_accept.TabIndex = 3;
            this.button_delete_accept.Text = "刪    除";
            this.button_delete_accept.UseVisualStyleBackColor = true;
            this.button_delete_accept.Click += new System.EventHandler(this.button_delete_accept_Click);
            // 
            // button_delete_back
            // 
            this.button_delete_back.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_delete_back.Location = new System.Drawing.Point(54, 309);
            this.button_delete_back.Name = "button_delete_back";
            this.button_delete_back.Size = new System.Drawing.Size(137, 37);
            this.button_delete_back.TabIndex = 2;
            this.button_delete_back.Text = "回選單";
            this.button_delete_back.UseVisualStyleBackColor = true;
            this.button_delete_back.Click += new System.EventHandler(this.button_delete_back_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(148, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 40);
            this.label20.TabIndex = 0;
            this.label20.Text = "刪    除";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(541, 421);
            this.Controls.Add(this.panel_query);
            this.Controls.Add(this.panel_add);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_delete);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            this.panel_query.ResumeLayout(false);
            this.panel_query.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel_delete.ResumeLayout(false);
            this.panel_delete.PerformLayout();
            this.groupBox_delete.ResumeLayout(false);
            this.groupBox_delete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_sex;
        private System.Windows.Forms.Button button_add_accept;
        private System.Windows.Forms.Button button_add_back;
        private System.Windows.Forms.Panel panel_query;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_query_back;
        private System.Windows.Forms.Label warning_add;
        private System.Windows.Forms.TextBox textBox_query;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_query_accept;
        private System.Windows.Forms.Label warning_query;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label query_address;
        private System.Windows.Forms.Label query_phone;
        private System.Windows.Forms.Label query_sex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_delete;
        private System.Windows.Forms.GroupBox groupBox_delete;
        private System.Windows.Forms.Label delete_address;
        private System.Windows.Forms.Label delete_phone;
        private System.Windows.Forms.Label delete_sex;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label warning_delete;
        private System.Windows.Forms.TextBox textBox_delete;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button_delete_accept;
        private System.Windows.Forms.Button button_delete_back;
        private System.Windows.Forms.Label label20;
    }
}