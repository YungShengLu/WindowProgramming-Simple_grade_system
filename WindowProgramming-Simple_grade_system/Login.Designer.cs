namespace F74039025_W4_3 {
    partial class Login {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.textbox_account = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.warning = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_1.Location = new System.Drawing.Point(56, 108);
            this.label_1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(68, 24);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "帳    號";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_2.Location = new System.Drawing.Point(56, 155);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(68, 24);
            this.label_2.TabIndex = 1;
            this.label_2.Text = "密    碼";
            // 
            // textbox_account
            // 
            this.textbox_account.Location = new System.Drawing.Point(132, 103);
            this.textbox_account.Name = "textbox_account";
            this.textbox_account.Size = new System.Drawing.Size(209, 29);
            this.textbox_account.TabIndex = 2;
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(132, 155);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(209, 29);
            this.textbox_password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(136, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(60, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "登    入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.warning);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textbox_password);
            this.panel1.Controls.Add(this.textbox_account);
            this.panel1.Controls.Add(this.label_2);
            this.panel1.Controls.Add(this.label_1);
            this.panel1.Location = new System.Drawing.Point(36, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 341);
            this.panel1.TabIndex = 6;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(60, 297);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 21);
            this.warning.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(473, 457);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.TextBox textbox_account;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label warning;
    }
}

