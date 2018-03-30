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
    public partial class AddFiting : Form
    {
        public AddFiting()
        {
            InitializeComponent();
        }
        // Подключение класса для использование стандартных данных
        Main standart = new Main();

        // Подключение класса для работы с бд
        Connecting connect = new Connecting();

        private void AddFiting_Load(object sender, EventArgs e)
        {
            Add.BackColor = button1.BackColor = standart.button_color;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "mySQLDataSet.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter.Fill(this.mySQLDataSet.Фурнитура);
           
            // Задание стандартогом цвета
            this.BackColor = standart.main_colors;

            // Размещение по центру
            standart.center__screen(this);
            
            // Задание стандартогом цвета кнопке
            Add.BackColor = standart.button_color;

            Types.Items.Add("Не выбрана");

            //  получение данных из груп бокса
            string cmd = connect.connection("Select Артикул, Наименование From Фурнитура", true, "Get__FUR");

            // Заносим в гроуп бокс данные полученные ранее
            for (int i = 0; i < cmd.Split('|').Length - 1; i++)
            {
                // Если нет, то убираем
                if (cmd.Split('|')[i] != " ")
                    Types.Items.Add(cmd.Split('|')[i]);
            }
        }

        // Функция на перемещение ползунка в комбоьоксе
        private void Types_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Забираем всё в Таг
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                // Проверка на ошибку
                if ( dataGridView1[0, i].Value == null || dataGridView1[1, i].Value == null || dataGridView1[2, i].Value == null || dataGridView1[3, i].Value  == null || dataGridView1[0, i].Value.ToString() == " " || dataGridView1[1, i].Value.ToString() == " " || dataGridView1[2, i].Value.ToString() == " " || dataGridView1[3, i].Value.ToString() == " ")
                    MessageBox.Show("Запись: " + dataGridView1[0, i].Value + " " + dataGridView1[1, i].Value + " " + dataGridView1[2, i].Value + " " + dataGridView1[3, i].Value + "Не будет записана из-за некоректных данных","Ошибка заполнения datagridview",MessageBoxButtons.OK);

                else //Иначе записб
                     Types.Tag += dataGridView1[0, i].Value + "%" + dataGridView1[1, i].Value + "%" + dataGridView1[2, i].Value + "%" + dataGridView1[3, i].Value + "%" + "|";
            
            //Удаление строек
            for (int i=dataGridView1.Rows.Count-1;i>=0;i--)
                dataGridView1.Rows.RemoveAt(i);
            
        }

        //Добавление строки
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Ошибка на пустую строку
            try
            {
                // Записываем артикуль
                dataGridView1[0, e.RowIndex].Value = Types.SelectedItem.ToString().Split(' ')[0];
                dataGridView1[1, e.RowIndex].Value = dataGridView1[2, e.RowIndex].Value = 0.ToString();
            }
            catch( Exception ex)
            { }
        }

        // Добавление строки
        private void button1_Click(object sender, EventArgs e)
        {
            // Добавление строки
            dataGridView1.Rows.Add();
        }

        // Если ячейка выбрана
        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Ошибка на преобразование типов
            try
            {
                // Умножение
                dataGridView1[3, e.RowIndex].Value = (Convert.ToDecimal((dataGridView1[1, e.RowIndex].Value).ToString().Replace('.', ',')) * Convert.ToDecimal((dataGridView1[2, e.RowIndex].Value).ToString().Replace('.', ','))).ToString();
            }
            catch(Exception ex)
            {

            }
        }

        // Запись в бд
        private void Add_Click(object sender, EventArgs e)
        {
            // Записываем последнее в Таг
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                // Проверка на ноль
                if (dataGridView1[0, i].Value == null || dataGridView1[1, i].Value == null || dataGridView1[2, i].Value == null || dataGridView1[3, i].Value == null || dataGridView1[0, i].Value.ToString() == " " || dataGridView1[1, i].Value.ToString() == " " || dataGridView1[2, i].Value.ToString() == " " || dataGridView1[3, i].Value.ToString() == " ")
                    MessageBox.Show("Запись: " + dataGridView1[0, i].Value + " " + dataGridView1[1, i].Value + " " + dataGridView1[2, i].Value + " " + dataGridView1[3, i].Value + "Не будет записана из-за некоректных данных", "Ошибка заполнения datagridview", MessageBoxButtons.OK);

                else // Запись в Таг
                    Types.Tag += dataGridView1[0, i].Value + "%" + dataGridView1[1, i].Value + "%" + dataGridView1[2, i].Value + "%" + dataGridView1[3, i].Value + "%" + "|";

            // Проверка на ноль
            if (Types.Tag.ToString() == "")
                return;

            // Проверка на ввод Имени
            if (Log.Text == "" || Log.Text == " ")
            {
                // Ошибка и выход
                MessageBox.Show("Введите имя!!!", "Нет имени пользователя", MessageBoxButtons.OK);
                return;
            }


            // Делаем уникальную партию 
            string pat = DateTime.Now.ToString()+ Log.Text;

            // Парсим таг
            string[] dat = Types.Tag.ToString().Split('|');

            int count = 0;

            // Проходимся по таг
            for(int i=0;i<dat.Length-1;i++)
            {
                // Ошибка на уникальность
                try
                {
                    // Запись
                    connect.connection("Insert into [Склад_фурнитуры] Values ('" + pat + " " + i + "' , '" + dat[i].Split('%')[0] + "' , '" + dat[i].Split('%')[2] + "' , '" + dat[i].Split('%')[3] + "')", false, "");
                    
                    // ++
                    count++;
                }
                catch(Exception ex)
                {

                }
            }
            // Ввод о строках
            MessageBox.Show(Log.Text + " Записалось " + count + " строк из " + (dat.Length-1).ToString(),"О записи",MessageBoxButtons.OK);

            // Нулируем
            Types.Tag = null;

            // Убираем Логин
            Log.Text = "";

            //Удаление строек
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
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
