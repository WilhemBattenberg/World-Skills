using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Skills
{
    public partial class Customer : Form
    {
        Main default__setting = new Main();

        Connecting connect = new Connecting();

        bool Login = false;

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            this.BackColor = default__setting.main_colors;
            default__setting.center__screen(this);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Login = true;
            Close();
        }

        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Login)
            {
                Form1 fm = new Form1();
                fm.Show();
                return;
            }
            Application.Exit();
        }
    }
}
