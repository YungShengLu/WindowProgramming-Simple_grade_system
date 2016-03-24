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
    public partial class Main : Form {
        // Define the struct of profile.
        public struct Profile {
            public string id;
            public string sex;
            public string phone;
            public string address;
        }

        // Create a profile list.
        LinkedList<Profile> profile = new LinkedList<Profile>();

        // Count the number of the profile.
        int profile_count;

        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            panel_add.Hide();
            panel_delete.Hide();
            panel_query.Hide();

            panel_menu.Show();
        }

        // Menu - add profile
        private void add_Click(object sender, EventArgs e) {
            panel_menu.Hide();
            panel_add.Show();

            profile_count = count_profile();

            warning_add.ForeColor = Color.Blue;
            if (profile_count > 0)
                warning_add.Text = "目前已有 " + profile_count + " 筆資料。";
            else
                warning_add.Text = "請輸入欲新增的資料。";
        }

        // Menu - delete profile
        private void delete_Click(object sender, EventArgs e) {
            panel_menu.Hide();
            panel_delete.Show();

            textBox_delete.Text = "";
            warning_delete.ForeColor = Color.Blue;
            warning_delete.Text = "請輸入欲刪除資料的身分證字號。";
        }

        // Menu - query profile
        private void query_Click(object sender, EventArgs e) {
            panel_menu.Hide();
            panel_query.Visible = true;
            panel_query.Show();

            textBox_query.Text = "";
            warning_query.ForeColor = Color.Blue;
            warning_query.Text = "請輸入欲查詢資料的身分證字號。";
        }

        // Menu - logout
        private void logout_Click(object sender, EventArgs e) {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        // Count profile.
        public int count_profile() {
            LinkedListNode<Profile> head = profile.First;
            int count = 0;

            while (head != null) {
                count += 1;
                head = head.Next;
            }

            return count;
        }

        // Add profile.
        public void add_profile(string id, string sex, string phone, string address) {
            Profile profile_node = new Profile();
            profile_node.id = id;
            profile_node.sex = sex;
            profile_node.phone = phone;
            profile_node.address = address;

            LinkedListNode<Profile> node = new LinkedListNode<Profile>(profile_node);
            profile.AddLast(node);
        }

        private void button_add_back_Click(object sender, EventArgs e) {
            panel_add.Hide();
            panel_menu.Show();
        }

        private void button_add_accept_Click(object sender, EventArgs e) {
            // Check whether the input is empty.
            if (textBox_id.Text == "" || textBox_sex.Text == "" || textBox_phone.Text == "" || textBox_address.Text == "") {
                warning_add.ForeColor = Color.Red;
                warning_add.Text = "輸入不可以為空。";
            }
            else {
                string add_id = textBox_id.Text;
                string add_sex = textBox_sex.Text;
                string add_phone = textBox_phone.Text;
                string add_address = textBox_address.Text;

                // Add new profile into list.
                add_profile(add_id, add_sex, add_phone, add_address);
                profile_count = count_profile();
                
                // Show the warning message.
                warning_add.ForeColor = Color.Green;
                warning_add.Text = "資料已經存入，目前已有 " + profile_count + " 筆資料。";

                // Clean the input box.
                textBox_id.Text = "";
                textBox_sex.Text = "";
                textBox_phone.Text = "";
                textBox_address.Text = "";
            }
        }

        // Query profile.
        public void query_profile(string query_id) {
            LinkedListNode<Profile> head = profile.First;

            while (head != null) {
                if (string.Compare(head.Value.id, query_id, true) == 0) {
                    // Find out the profile.
                    query_sex.Text = head.Value.sex;
                    query_phone.Text = head.Value.phone;
                    query_address.Text = head.Value.address;

                    warning_query.ForeColor = Color.Green;
                    warning_query.Text = "查詢成功。";

                    break;
                }

                head = head.Next;
            }

            if (head == null) {
                warning_query.ForeColor = Color.Red;
                warning_query.Text = "無此筆資料。";
            }
        }

        private void button_query_back_Click(object sender, EventArgs e) {
            textBox_query.Text = "";
            query_sex.Text = "無資料";
            query_phone.Text = "無資料";
            query_address.Text = "無資料";

            panel_query.Hide();
            panel_menu.Show();
        }

        private void button_query_accept_Click(object sender, EventArgs e) {
            string query_id = textBox_query.Text;
            query_profile(query_id);
        }

        // Delete a profile.
        public void delete_profile(string delete_id) {
            LinkedListNode<Profile> head = profile.First;

            while (head != null) {
                if (string.Compare(head.Value.id, delete_id, true) == 0) {
                    // Find out the profile.
                    delete_sex.Text = head.Value.sex;
                    delete_phone.Text = head.Value.phone;
                    delete_address.Text = head.Value.address;

                    warning_delete.ForeColor = Color.Green;
                    warning_delete.Text = "查詢成功。";

                    // Message box.
                    string message = "確定要刪除此筆資料？";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.Yes) {
                        profile.Remove(head);

                        delete_sex.Text = "無資料";
                        delete_phone.Text = "無資料";
                        delete_address.Text = "無資料";

                        // Delete success.
                        warning_delete.ForeColor = Color.Green;
                        warning_delete.Text = "資料刪除成功。";
                    }

                    break;
                }

                head = head.Next;
            }

            if (head == null) {
                warning_query.ForeColor = Color.Red;
                warning_query.Text = "無此筆資料。";
            }
        }

        private void button_delete_back_Click(object sender, EventArgs e) {
            textBox_delete.Text = "";
            delete_sex.Text = "無資料";
            delete_phone.Text = "無資料";
            delete_address.Text = "無資料";
            panel_delete.Hide();
            panel_menu.Show();
        }

        private void button_delete_accept_Click(object sender, EventArgs e) {
            string delete_id = textBox_delete.Text;
            delete_profile(delete_id);
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void textBox_query_TextChanged(object sender, EventArgs e) {

        }
    }
}
