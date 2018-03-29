using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Skills
{
    class Main // Класс для стандартных переменных в программе
    {
        // Цвет форм
        public Color main_colors = Color.FromArgb(181, 213, 202);
        
        // Цвет кнопки без наведения
        public Color button_color = Color.FromArgb(255,252, 214);

        // Цвет кнопки с наведением
        public Color button_color_hover = Color.FromArgb(209, 238, 252);

        // Стандартный: размер, стиль текста
        public Font main__font = new Font("Times New Roman", (14.0f), new FontStyle());

        // Функция выравнивания по центру
        public void center__screen(Form fm)
        {
            // Ставим локацию на центр
            fm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - fm.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - fm.Height) / 2);
        }

    }
}
