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
    public partial class Fittings : Form
    {
        public Fittings()
        {
            InitializeComponent();
        }

        // Подключение класса для использование стандартных данных
        Main standart = new Main();

        // Подключение класса для работы с бд
        Connecting connect = new Connecting();
        private void Fittings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mySQLDataSet.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter.Fill(this.mySQLDataSet.Фурнитура);
            string cmd = connect.connection("Select Артикул, Наименование From Фурнитура", true, "Get__FUR");
            comboBox1.Items.Add("Все");
            for(int i=0;i<cmd.Split('|').Length-1;i++)
            {
                if(cmd.Split('|')[i]!=" ")
                comboBox1.Items.Add(cmd.Split('|')[i]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Все")
            {
                фурнитураBindingSource.Filter = "";
                return;
            }
            else
            {
                фурнитураBindingSource.Filter = "Артикул = '"+ comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(' ')[0]+"'";
            }
        }
    }
}
