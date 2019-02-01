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
    public partial class Form_zakaz : Form
    {
        Book book;
        int count = 0;

        public Form_zakaz(string book_id)
        {
            InitializeComponent();
            book = DataBase.books[book_id];
            trackBar1.TickFrequency = count / 20;
        }

        private void Form_zakaz_Load(object sender, EventArgs e)
        {
            textBox1.Lines = new string[] { "Вы хотите заказать:\n", book.name };
            double cena = count * book.price_in;
            textBox2.Lines = new string[] { "Цена заказа:\n", cena.ToString("0.00") };
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            count = Convert.ToInt32(numericUpDown1.Value);
            if (count > trackBar1.Maximum)
                trackBar1.Maximum = count + 10;
            else if (count < trackBar1.Maximum) {
                if (count < 100)
                    trackBar1.Maximum = 100;
                else
                    trackBar1.Maximum = count + 10;
                    }
            trackBar1.TickFrequency = trackBar1.Maximum / 20;
            upd();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            count = trackBar1.Value;
            upd();
        }

        private void upd()
        {
            trackBar1.Value = count;
            numericUpDown1.Value = count;
            double cena = count * book.price_in;
            textBox2.Lines = new string[] { "Цена заказа:\n", cena.ToString("0.00") };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            book.Change(count:book.count+=count);
            this.Close();
            MessageBox.Show("Выполнено");
        }
    }
}
