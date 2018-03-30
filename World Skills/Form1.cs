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
    public partial class Form1 : Form
    { 
        // Подключение класса для использование стандартных данных
        Main standart = new Main();

        // Подключение класса для работы с бд
        Connecting connect = new Connecting();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Красим форму в стандартный цвет
            this.BackColor = standart.main_colors;
            

            // Задаём для формы стандартный шрифт, размер шрита 
            this.Font = standart.main__font;

            // Задаём для надписей стандартный шрифт, размер шрита 
            label2.Font =label1.Font = standart.main__font;

            // Задаём стандартный цвет для кнопок
            In.BackColor = Reg.BackColor = standart.button_color;

            // Задаём символ для скрытие пароля
            Password.PasswordChar = '*';

            // Выравниваем форму по центру
            standart.center__screen(this);
        }

        // Функция срабатывающая при наведении на кнопку
        private void button_MouseEnter(object sender, EventArgs e)
        {
                // Выбираем кнопку на которую прошло наведение
                Button bt = (Button)sender;

                // Задаём цвет кнопке
                bt.BackColor = standart.button_color_hover;
        }

        // Функция срабатывающая после наведении на кнопку
        private void button_MouseLeave(object sender, EventArgs e)
        {
            // Выбираем кнопку у которой прошла функция
            Button bt = (Button)sender;

            // Задаём цвет кнопке
            bt.BackColor = standart.button_color;
        }

        // Функция авторизации
        private void In_Click(object sender, EventArgs e)
        {
            // Получение пользователя по Логину и паролю
            string answer = connect.connection("Select [Type],[Comment] from [Пользователи] where [Login] = '" + Login.Text + "' and Password = '"+Password.Text+"'",true, "auth");
            
            // Проверка на полученный id
            if(answer == "Error404" || answer == "" )
            {
                // Вывод сообщения об ошибке
                MessageBox.Show("Введённые данные не коректны","Ошибка авторизации",MessageBoxButtons.OK);

                // Выход из-за ошибки
                return;
            }
            
            // Проверка на соответствующий тип пользователя
            switch(answer.Split(' ')[0])
            {
                // Если пользователь Заказчик
                case "Заказчик": {

                        // Создание экземпляра Заказчик
                        Customer cust = new Customer();

                        // Открытие формы
                        cust.Show();

                        //Скрытие текущей формы
                        this.Hide();

                 break; }

                // Если пользователь Менеджер
                case "Менеджер":
                    {
                        // Создание экземпляра Заказчик
                        Manager man = new Manager();

                        // Открытие формы
                        man.Show();

                        //Скрытие текущей формы
                        this.Hide();

                        break;
                    }
                
                // Если пользователь Кладовщик
                case "Кладовщик":
                    {
                        // Создание экземпляра Кладовщик
                        Storekeeper stok = new Storekeeper();

                        // Открытие формы
                        stok.Show();

                        //Скрытие текущей формы
                        this.Hide();

                        break;
                    }
                // Если пользователь Руководитель
                case "Руководитель":
                    {
                        MessageBox.Show("Руководитель");
                        break;
                    }
            }
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            // Создание объекта формы регистрации
            Reg rg = new Reg();
            
            // Открытие формы Регистрации
            rg.ShowDialog();

            // Проверка на создание пользователя 
            if (Convert.ToBoolean(rg.Tag.ToString().Split('|')[0]))
            {
                // Запись логина созданного пользователя
                Login.Text = rg.Tag.ToString().Split('|')[1];

                // Запись пароля созданного пользователя
                Password.Text = rg.Tag.ToString().Split('|')[2];
            }
        }

        // Закрытие формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Завершение приложения
            Application.Exit();
        }
    }
}
