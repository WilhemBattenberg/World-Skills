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
    public partial class Tissue__List : Form
    {

        // Подключение класса для использование стандартных данных
        Main standart = new Main();

        // Подключение класса для работы с бд
        Connecting connect = new Connecting();

        public Tissue__List()
        {
            InitializeComponent();
        }

        private void Tissue__List_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mySQLDataSet.Ткани". При необходимости она может быть перемещена или удалена.
            this.тканиTableAdapter.Fill(this.mySQLDataSet.Ткани);
            // Выравниваем форму по центру
            standart.center__screen(this);

            

            // Красим форму в стандартный цвет
            this.BackColor = standart.main_colors;
            comboBox1.Items.Add("Нет");
            string dat = connect.connection("Select [Артикул],[Название] from [Ткани]", true, "Get__Tissue");
            for (int i = 0; i < dat.Split('|').Length; i++)
                comboBox1.Items.Add(dat.Split('|')[i]);
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Items[comboBox1.SelectedIndex].ToString()=="Нет")
            {
                тканиBindingSource.Filter = "";
                return;
            }
            тканиBindingSource.Filter = "Артикул = '"+ comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(' ')[0]+ "'";
        }
    }
}
