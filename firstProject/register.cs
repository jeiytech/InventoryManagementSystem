using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace firstProject
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text != "" && bunifuMetroTextbox2.Text != "" && bunifuMetroTextbox3.Text != "" && bunifuMetroTextbox4.Text != "" && bunifuMetroTextbox5.Text != "" && bunifuMetroTextbox6.Text != "")
            {
                if (bunifuMetroTextbox5.Text == bunifuMetroTextbox6.Text)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
                        string query = "insert into users(first ,last ,username ,phone ,password ) values(@first, @last, @username, @phone, @password)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@first", bunifuMetroTextbox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@last", bunifuMetroTextbox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", bunifuMetroTextbox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", bunifuMetroTextbox4.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", MD5Hash(bunifuMetroTextbox5.Text.Trim()));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Registered Successfully!...");
                        login login = new login();
                        login.Show();
                        this.Hide();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords doesn't match");
                }
            }
            else
                MessageBox.Show("Fill all fields");
        }

    }
}
