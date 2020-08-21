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
using System.Text.RegularExpressions;
using Kavenegar;

namespace smart_validator
{
    public partial class Form1 : Form
    {
        string record_structure = "{0}|{1}|{2}|{3}";
        List<string> usernames = new List<string> { };
        List<string> phones = new List<string> { };
        string code = "";

        Dictionary<string, string> all_records = new Dictionary<string, string> { }; 

        public Form1()
        {
            InitializeComponent();
        }

        private void lnk_newacc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tc_mycontrol.SelectedIndex = 1;
        }

        private void lnk_forgetpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtbox_username.Text != "")
            {
                all_records_updater();
                if (all_records.Keys.Contains(txtbox_username.Text))
                {
                    code = token_generator();
                    try
                    {
                        var sender_me = "<SENDER-ID>";
                        var receptor = username_to_phone(txtbox_username.Text);
                        string hidden_phone = hide_phone(receptor);
                        var message = "Thanks for using smart-validator!\nYour verification code: " + code;
                        var api = new Kavenegar.KavenegarApi("<WEBAPI-TOKEN>"); // Should be registered on kavenegar
                        api.Send(sender_me, receptor, message);
                        MessageBox.Show("Verification code has been sent to "+hidden_phone+".", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form2 f2 = new Form2(code, txtbox_username.Text);
                        f2.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Please check your network connection.\nYour account should be charged enough on Kavenegar.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("The entered username is not a valid one.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill up your username.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void clear_all()
        {
            TextBox[] all_items = { txtboxC_username, txtboxC_password, txtboxC_passconfirm, txtboxC_email, txtboxC_phone };
            foreach (var item in all_items)
            {
                item.Text = "";
            }
        }

        private bool check_if_not_empty()
        {
            TextBox[] all_items = { txtboxC_username, txtboxC_password, txtboxC_passconfirm, txtboxC_email, txtboxC_phone};
            foreach (var item in all_items)
                if (item.Text == "")
                    return false;
            return true;
        }

        private void updater()
        {
            string[] records = File.ReadAllLines("db.txt");
            foreach (var record in records)
            {
                string[] splited = record.Split('|');
                try
                {
                    usernames.Add(splited[0]);
                    phones.Add(splited[3]);
                }catch { }
            }
        }

        private void all_records_updater()
        {
            all_records.Clear();
            foreach (var record in File.ReadAllLines("db.txt"))
            {
                string[] splited_record = record.Split('|');
                try { all_records.Add(splited_record[0].ToString(), splited_record[1].ToString()); } catch { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtboxC_password.Text != txtboxC_passconfirm.Text)
            {
                MessageBox.Show("Password and its confirmation are not the same.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (check_if_not_empty())
                {
                    updater();
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = regex.Match(txtboxC_email.Text);
                    if (match.Success)
                    {
                        if (phones.Contains(txtboxC_phone.Text) ||
                        usernames.Contains(txtboxC_username.Text))
                            MessageBox.Show("This username or phone number already registered. Try another one.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            string[] record = { String.Format(record_structure, txtboxC_username.Text, txtboxC_password.Text, txtboxC_email.Text, txtboxC_phone.Text) };
                            try
                            {
                                File.AppendAllLines("db.txt", record);
                                MessageBox.Show("New user added.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clear_all();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Database file not found.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Email is not valid.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please fill up all fields.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (txtbox_username.Text != "" &&
                txtbox_password.Text != "")
            {
                all_records_updater();
                if (all_records.Keys.Contains(txtbox_username.Text))
                {
                    if (all_records[txtbox_username.Text] == txtbox_password.Text)
                    {
                        MessageBox.Show("Welcome back " + txtbox_username.Text + "!", "Logged in!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Login failed for " + txtbox_username.Text + "! Neither username or password is valid.", "Log in Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show("Login failed for " + txtbox_username.Text + "! Neither username or password is valid.", "Log in Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please fill up all fields.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static string token_generator()
        {
            List<string> alphs = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string token = "";
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                token += rnd.Next(0, 10);
            }
            return token;
        }
        private string username_to_phone(string username)
        {
            foreach (var record in File.ReadAllLines("db.txt"))
            {
                string[] splitted = record.Split('|');
                if (splitted[0] == username)
                {
                    return splitted[3];
                }
            }
            return "";
        }
        private string hide_phone(string number)
        {
            string hidden = "";
            for (int i = 0; i < 11; i++)
            {
                if (i >= 4 && i<=7)
                {
                    hidden += "*";
                }
                else
                {
                    hidden += number[i];
                }
            }
            return hidden;
        }
    }
}
