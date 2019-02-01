using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase.get_all(true);
            Statistic.init();
        }

        private void button3_Click(object sender, EventArgs e) // Продавец
        {
            Form_Prodavec fmp = new Form_Prodavec(); // Форма продавца
            fmp.FormClosed += delegate { this.Show(); }; // Обработка закрытия

            fmp.Show(); // Показываем
            this.Hide(); // ЗАкрываем эту
        }


        private void button2_Click(object sender, EventArgs e) // Кладовщик
        {
            Form_Kladovshik fmk = new Form_Kladovshik(); // Форма кладовщика
            fmk.FormClosed += delegate { this.Show(); }; // Обработка закрытия

            fmk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // Администратор
        {
            Form_Admin fma = new Form_Admin(); // Форма админа
            fma.FormClosed += delegate { this.Show(); }; // Обработка закрытия

            fma.Show();
            this.Hide();
        }
    }
}
