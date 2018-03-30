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
    public partial class Add__Factorias : Form
    {
        public Add__Factorias()
        {
            InitializeComponent();
        }
        // Подключение класса для использование стандартных данных
        Main standart = new Main();

        // Подключение класса для работы с бд
        Connecting connect = new Connecting();

        private void Add__Factorias_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mySQLDataSet.Ткани". При необходимости она может быть перемещена или удалена.
            this.тканиTableAdapter.Fill(this.mySQLDataSet.Ткани);
            // Красим форму в стандартный цвет
            this.BackColor = standart.main_colors;

            
            // Задаём для формы стандартный шрифт, размер шрита 
            this.Font = standart.main__font;

            // Размещение по центру
            standart.center__screen(this);

            // Стандартный цвет кнопок
            button3.BackColor = standart.button_color;
           
        }

        // Нажатие кнопки для отправки
        private void button3_Click(object sender, EventArgs e)
        {
            // Выъод без логина
            if(Log.Text == "" || Log.Text == " ")
            {
                MessageBox.Show("Имя пользователя не введенно", "Нехватка данных", MessageBoxButtons.OK);
            }

           
            // Прохождение по циклу
            for(int i=0; i<dataGridView1.Rows.Count-1;i++)
            {
                
                connect.connection("Insert Into [Склад_Ткани] Values ('" + dataGridView1[0, i].Value.ToString() + "' , '" + dataGridView1[0, i].Value.ToString() + "' , '" + Log.Text + "')", false, "");
            }
            // Выводим сообщение оудчном
            MessageBox.Show("Успешно!", "Успешно", MessageBoxButtons.OK);

            // Удаление строк
            for (int i = dataGridView1.RowCount - 2; i >= 0; i--)
                dataGridView1.Rows.RemoveAt(i);
        }

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

    }

}
