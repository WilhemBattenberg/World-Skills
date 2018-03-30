using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
namespace World_Skills
{
    public partial class Design__Product : Form
    {
        public Design__Product()
        {
            InitializeComponent();
        }

        // Патч к файлам картинок
        string Path__files =  "..\\..\\..";

        
        // Подключение класса для использование стандартных данных
        Main standart = new Main();

        // Подключение класса для работы с бд
        Connecting connect = new Connecting();

        private void Design__Product_Load(object sender, EventArgs e)
        {
            this.BackColor = standart.main_colors;

            pictureBox2.Size = new Size(100, 100);
            standart.center__screen(this);

            string dat = connect.connection("Select [Артикул],[Название] from [Ткани]", true, "Get__Tissue");

            // Заполнение комбобокса
            for (int i = 0; i < dat.Split('|').Length; i++)
                Tissue.Items.Add(dat.Split('|')[i]);

            // Выбираем первый индекс
            Tissue.SelectedIndex = 0;

            string cmd = connect.connection("Select Артикул, Наименование from Фурнитура", true, "Get__FUR");

            for (int i = 0; i < cmd.Split('|').Length; i++)
                Fiture.Items.Add(cmd.Split('|')[i]);

            Fiture.SelectedIndex = 0;
        }

        private void Tissue_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image bmp;
            string d = connect.connection("Select [Изображение] from [Ткани] where Артикул = '" + Tissue.Items[Tissue.SelectedIndex].ToString().Split(' ')[0] + "' ", true, "Get__Picture");
            try
            {
                bmp = Image.FromFile(Path__files + d);
            }
            catch(Exception ex)
            {
                d = Path__files + "\\images\\404.png";
                bmp = Image.FromFile(d); }
            
            pictureBox2.Image = bmp;
        }

        private void Lenght_ValueChanged(object sender, EventArgs e)
        {
            pictureBox2.Size = (new Size((int) Lenght.Value, (int)Widht.Value));
        }
    }
}
