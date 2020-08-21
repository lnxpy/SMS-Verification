using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace smart_validator
{
    public partial class Form2 : Form
    {
        string code, agent;

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (txtbox_verification.Text == code)
            {
                if (txtbox_password.Text == txtbox_passconfirm.Text)
                {
                    get_set(agent, txtbox_password.Text);
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ////this.Hide();
                    ////Form1 f1 = new Form1();
                    ////f1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password and its confirmation are not the same.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Varification code is not valid. Please try again.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_set(string username, string pass)
        {
            List<string> new_recs = new List<string> { };
            foreach (var item in File.ReadAllLines("db.txt"))
            {
                string[] splited = item.Split('|');
                if (splited[0] == username)
                {
                    splited[1] = pass;
                }
                new_recs.Add(String.Join("|", splited));
            }
            File.WriteAllText("db.txt", "");
            foreach (var item in new_recs)
            {
                string[] now = { item };
                File.AppendAllLines("db.txt", now);
            }
        }

        public Form2(string verification, string user)
        {
            code = verification;
            agent = user;
            InitializeComponent();
        }
    }
}
