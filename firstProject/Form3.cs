using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        public void loadform(object form) 
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Log Out", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelhide.Hide();
            loadform(new DashboardForm());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panelhide.Hide();
            loadform(new employeeForm());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            panelhide.Hide();
            loadform(new reportsForm());
        }
    }
}
