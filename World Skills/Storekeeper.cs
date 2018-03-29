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
    public partial class Storekeeper : Form
    {
        // Подключение класса для использование стандартных данных
        Main standart = new Main();

        // Подключение класса для работы с бд
        Connecting connect = new Connecting();

        bool Login = false;
        public Storekeeper()
        {
            InitializeComponent();
        }

        private void Storekeeper_Load(object sender, EventArgs e)
        {
            // Красим форму в стандартный цвет
            this.BackColor = standart.main_colors;

            // Выравниваем форму по центру
            standart.center__screen(this);

           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Login = true;
            Close();
        }

        private void Storekeeper_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Login)
            {
                Form1 fm = new Form1();
                fm.Show();
                return;
            }
            Application.Exit();
        }

        private void tissue_Click(object sender, EventArgs e)
        {
            Tissue__List ts = new Tissue__List();
            ts.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fittings fit = new Fittings();
            fit.ShowDialog();
        }
    }
}
