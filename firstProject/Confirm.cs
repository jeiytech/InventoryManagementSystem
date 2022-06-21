using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Data.Sql;

namespace firstProject
{
    public partial class Confirm : Form
    {
        public Home MyParent { get; set; }
        public Confirm()
        {
            InitializeComponent();
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = MyParent.ItemList;
        }

        private void Confirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyParent.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyParent.ItemList = "";
            MyParent.TotalPrice = 0;
            MyParent.UpdateQuery = "";
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                userdetail user = new userdetail();
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
                string query = "insert into orders( [user],details, price) values('" + user.getUname().Trim() + "','" + MyParent.ItemList + "','" + MyParent.TotalPrice + "')" + MyParent.UpdateQuery + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added Successfully...");
                button1_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
