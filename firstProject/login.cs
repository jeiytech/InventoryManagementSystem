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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register signup = new register();
            signup.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, System.EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
                SqlDataAdapter sda = new SqlDataAdapter("select * from users where username='" + bunifuMetroTextbox1.Text.Trim() + "'and password='" + MD5Hash(bunifuMetroTextbox2.Text.Trim()) + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("select * from users where username='" + bunifuMetroTextbox1.Text.Trim() + "'and password='" + MD5Hash(bunifuMetroTextbox2.Text.Trim()) + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        userdetail user = new userdetail();
                        user.setUname((string)reader["username"].ToString());

                        if ((string)reader["usertype"].ToString() == "member")
                        {
                            Home home = new Home();
                            this.Hide();
                            home.FormBorderStyle = FormBorderStyle.Sizable;
                            home.Show();
                        }
                        if ((string)reader["usertype"].ToString() == "manager")
                        {
                            Manager_home manager = new Manager_home();
                            this.Hide();
                            manager.FormBorderStyle = FormBorderStyle.Sizable;
                            manager.Show();
                        }
                        if ((string)reader["usertype"].ToString() == "admin")
                        {
                            Admin_home admin = new Admin_home();
                            this.Hide();
                            admin.FormBorderStyle = FormBorderStyle.Sizable;
                            admin.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }

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
    }
}
