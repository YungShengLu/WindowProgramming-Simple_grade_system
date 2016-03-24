using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74039025_W4_3 {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string account = textbox_account.Text;
            string password = textbox_password.Text;

            if (string.Compare(account, "F74039025", true) == 0) {
                if (string.Compare(password, "1111", true) == 0) {
                    // Login success.
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }
                else {
                    textbox_account.Text = "";
                    textbox_password.Text = "";
                    warning.ForeColor = Color.Red;
                    warning.Text = "輸入的帳號或密碼有誤，請重新輸入。";
                }
            }
            else {
                textbox_account.Text = "";
                textbox_password.Text = "";
                warning.ForeColor = Color.Red;
                warning.Text = "輸入的帳號或密碼有誤，請重新輸入。";
            }
        }
    }
}
