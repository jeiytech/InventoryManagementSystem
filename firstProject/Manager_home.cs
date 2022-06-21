using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
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
    public partial class Manager_home : Form
    {
        public Manager_home()
        {
            InitializeComponent();
        }

        public void loadform(object form)
        {
            if (this.mainpanel3.Controls.Count > 0)
                this.mainpanel3.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel3.Controls.Add(f);
            this.mainpanel3.Tag = f;
            f.Show();
        }

        void panelForm()
        {
            slide_panel1.Hide();
            slide_panel2.Hide();
            slide_panel3.Hide();
            slide_panel4.Hide();
            slide_panel5.Hide();
        }


        private void Manager_home_Load(object sender, System.EventArgs e)
        {
            Manager_home manager = new Manager_home();
            manager.FormBorderStyle = FormBorderStyle.Sizable;
            panelForm();
        }


        //logout button
        private void logout_btn_Click(object sender, System.EventArgs e)
        {
            login login = new login();
            this.Close();
            login.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            panelForm();
            slide_panel1.Show();
            loadform(new Add_Item());
        }

        private void delete_Click(object sender, EventArgs e)
        {
            panelForm();
            slide_panel3.Show();
            loadform(new Delete_Item());
        }

        private void paid_orders_Click(object sender, EventArgs e)
        {
            panelForm();
            slide_panel4.Show();
            loadform(new Paid_Order());
        }

        private void update_Click(object sender, EventArgs e)
        {
            panelForm();
            slide_panel2.Show();
            loadform(new Update_Item());
        }

        private void unpaid_orders_Click(object sender, EventArgs e)
        {
            panelForm();
            slide_panel5.Show();
            loadform(new Unpaid_Order());
        }
    }
}
