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
    public partial class Manager : Form
    {
        // Подключение класса для использование стандартных данных
        Main standart = new Main();

        // Подключение класса для работы с бд
        Connecting connect = new Connecting();

        bool Login = false;
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // Выравниваем форму по центру
            standart.center__screen(this);

            // Красим форму в стандартный цвет
            this.BackColor = standart.main_colors;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Login = true;
            Close();
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Login)
            {
                Form1 fm = new Form1();
                fm.Show();
                return;
            }
            Application.Exit();
        }
    }
}
