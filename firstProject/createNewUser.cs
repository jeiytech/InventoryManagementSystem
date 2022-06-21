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
    public partial class createNewUser : Form
    {
        public createNewUser()
        {
            InitializeComponent();
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

        private void Mregister_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && typecomboTxt.Text != "")
            {
                if (textBox5.Text == textBox6.Text)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30");
                        string query = "insert into users(first ,last ,username ,phone ,password ,usertype ) values(@first, @last, @username, @phone, @password, @usertype)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@first", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@last", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", textBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", textBox4.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", MD5Hash(textBox5.Text.Trim()));
                        cmd.Parameters.AddWithValue("@usertype", typecomboTxt.Text.Trim());
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Registered Successfuly");
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
