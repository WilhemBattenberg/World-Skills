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
    public partial class Reg : Form
    {
        // Подключение класса для использование стандартных данных
        Main default__setting = new Main();

        // Подключение класса для работы с бд
        Connecting connect = new Connecting();

        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            // Красим форму в стандартный цвет
            this.BackColor = default__setting.main_colors;

            // Задаём стандартный цвет для кнопок
            Add.BackColor = Nun.BackColor = default__setting.button_color;

            // Выравниваем форму по центру
            default__setting.center__screen(this);
        }

        // Функция срабатывающая при наведении на кнопку
        private void button_MouseEnter(object sender, EventArgs e)
        {
            // Выбираем кнопку на которую прошло наведение
            Button bt = (Button)sender;

            // Задаём цвет кнопке
            bt.BackColor = default__setting.button_color_hover;

            // Выравниваем форму по центру
            default__setting.center__screen(this);
        }

        // Функция срабатывающая после наведении на кнопку
        private void button_MouseLeave(object sender, EventArgs e)
        {
            // Выбираем кнопку у которой прошла функция
            Button bt = (Button)sender;

            // Задаём цвет кнопке
            bt.BackColor = default__setting.button_color;
        }

        // Функция Регистрации пользователя
        private void Add_Click(object sender, EventArgs e)
        {   
            // Проверка на пустые значения
            if(Login.Text == "" || Login.Text == " " || Password.Text == "" || Password.Text == " ")
            {
                // Вывод сообщения ошибки
                MessageBox.Show("Нельзя оставлять пустые строчки","Ошибка ввода данных",MessageBoxButtons.OK);

                // Выход из функции
                return;
            }

            // Получение id по логину пользователя, который хочет зарегистрироваться
            string id = connect.connection("Select [id] from [Пользователи] where [Login] = '" + Login.Text + "'",true, "get_id");
            
            // Проверка на ошибку нахождения логина в бд
            if(id!= "Error404")
            {
                // Вывод сообщения ошибки
                MessageBox.Show("Пользователь уже создан в бд","Ошибка регистрации",MessageBoxButtons.OK);

                // Выход из функции
                return;
            }

            // Создание нового пользователя
            id = connect.connection("Insert  Into [Пользователи] Values ('" + Login.Text + "' , '" + Password.Text + "' , 'Заказчик' , '" + Name.Text + "')",false,"");

            // Вывод сообщения о успешной регистрации
            MessageBox.Show("Добро пожаловать в нашу программу " + Name.Text.ToString(), "Добро пожаловать", MessageBoxButtons.OK);

            // Запись данных при регистрации
            this.Tag = true.ToString()+"|"+Login.Text+"|"+Password.Text;

            // Закрытие формы
            this.Close();
        }

        private void Nun_Click(object sender, EventArgs e)
        {
            //Запись пустых данных
            this.Tag = false.ToString() + "|";

            // Закрытие формы
            Close();
        }

        private void Reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Проверкатна нажатие крестика в верхнем меню
            if(this.Tag.ToString()==" " || this.Tag.ToString()=="")
            {
                // Запись пустого Таг
                this.Tag = false.ToString() + "|";
            }

        }
    }
}
