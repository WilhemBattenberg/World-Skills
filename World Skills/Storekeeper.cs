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

        // Переменная на выход к форме авторизации
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

        // Функция выхода к авторизации
        private void exit_Click(object sender, EventArgs e)
        {
            // Устанавливаем переход
            Login = true;
            // Закрываем форму
            Close();
        }

        // Выход из формы
        private void Storekeeper_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Если +, то открываем первую форму
            if (Login)
            {
                // Создаём экземпляр 
                Form1 fm = new Form1();
            
                // Открываем
                fm.Show();

                return;
            }

            // Иначе закрываем приложение
            Application.Exit();
        }

        // Открытие тканей
        private void tissue_Click(object sender, EventArgs e)
        {
            // Создание экземпляра
            Tissue__List ts = new Tissue__List();

            // Открываем форму
            ts.ShowDialog();
        }

        // Открытие фурнитуры
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра
            Fittings fit = new Fittings();

            // Открываем форму
            fit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFiting ad = new AddFiting();
            ad.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add__Factorias adFact = new Add__Factorias();
            adFact.ShowDialog();
        }
    }
}
