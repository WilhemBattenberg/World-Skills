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
        // Подключение класса для использование стандартных данных
        Main standart = new Main();

        // Подключение класса для работы с бд
        Connecting connect = new Connecting();

        // Определяет выход из пользователя
        bool Login = false;

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // Красим форму
            this.BackColor = standart.main_colors;

            // Выравниваем форму
            standart.center__screen(this);

        }

        // Нажатие выхода в авторизацию
        private void exit_Click(object sender, EventArgs e)
        {
            // ставим +
            Login = true;

            // Закрытие формы
            Close();
        }


        // Завершение формы
        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Если да то перехо на авторизацию
            if(Login)
            {
                // Создание экземпляра
                Form1 fm = new Form1();

                // Открытие формы
                fm.Show();


                return;
            }
            // Иначе завершение приложения
            Application.Exit();
        }
    }
}
