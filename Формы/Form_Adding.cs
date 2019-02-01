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
    public partial class Form_Adding : Form
    {
        string id = "",
            name = "",
            author = "",
            city = "",
            publishing = "";
        int year = 0,
            price_in = 0,
            price_out = 0,
            count = 0;
        double rating_clients = 0,
            rating_critic = 0;

        TextBox[] tb;

        public Form_Adding(string id = "")
        {
            InitializeComponent();
            this.id = id;
            if (id != "" && DataBase.books.ContainsKey(id))
            {
                Book b = DataBase.books[id];
                id = b.id;
                name = b.name;
                author = b.author;
                city = b.city;
                publishing = b.publishing;
                year = b.year;
                price_in = b.price_in;
                price_out = b.price_out;
                count = b.count;
                rating_clients = b.rating_clients;
                rating_critic = b.rating_critic;
            }
        }

        private void Form_Adding_Load(object sender, EventArgs e)
        {
            textBox01.Text = id;
            textBox02.Text = name;
            textBox03.Text = author;
            textBox04.Text = city;
            textBox05.Text = publishing;
            textBox06.Text = year.ToString();
            textBox07.Text = price_in.ToString();
            textBox08.Text = price_out.ToString();
            textBox09.Text = count.ToString();
            textBox10.Text = rating_clients.ToString("0.00");
            textBox11.Text = rating_critic.ToString("0.00");

            tb = new TextBox[] { textBox01, textBox02, textBox03, textBox04, textBox05, textBox06, textBox07, textBox08, textBox09, textBox10, textBox11 };
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Ид
        {
            id = textBox01.Text;

            if (textBox01.Text != "")
                textBox01.BackColor = Color.PaleGreen;
            else
                textBox01.BackColor = Color.LightPink;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Название
        {
            name = textBox02.Text;

            if (textBox02.Text != "")
                textBox02.BackColor = Color.PaleGreen;
            else
                textBox02.BackColor = Color.LightPink;
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Автор
        {
            author = textBox03.Text;

            textBox03.BackColor = Color.PaleGreen;
        }


        private void textBox4_TextChanged(object sender, EventArgs e) // Город
        {
            city = textBox04.Text;
            textBox04.BackColor = Color.PaleGreen;
        }


        private void textBox5_TextChanged(object sender, EventArgs e) // Издательство
        {
            publishing = textBox05.Text;
            textBox05.BackColor = Color.PaleGreen;
        }

        private void textBox6_TextChanged(object sender, EventArgs e) // Год
        {
            try
            {
                year = int.Parse(textBox06.Text);
                if (year >= 1900 && year<=DateTime.Now.Year)
                    textBox06.BackColor = Color.PaleGreen;
                else
                    textBox06.BackColor = Color.LightPink;
            }
            catch
            {
                textBox06.BackColor = Color.LightPink;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e) // цена
        {
            try
            {
                price_in = int.Parse(textBox07.Text);
                if (price_in > 0)
                    textBox07.BackColor = Color.PaleGreen;
                else
                    textBox07.BackColor = Color.LightPink;
            }
            catch
            {
                textBox07.BackColor = Color.LightPink;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e) // Цена продажи
        {
            try
            {
                price_out = int.Parse(textBox08.Text);
                if (price_out > 0)
                    textBox08.BackColor = Color.PaleGreen;
                else
                    textBox08.BackColor = Color.LightPink;
            }
            catch
            {
                textBox08.BackColor = Color.LightPink;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e) // Количество
        {
            try
            {
                count = int.Parse(textBox09.Text);
                if (count > 0 && count <=500)
                    textBox09.BackColor = Color.PaleGreen;
                else
                    textBox09.BackColor = Color.LightPink;
            }
            catch
            {
                textBox09.BackColor = Color.LightPink;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e) // 
        {
            try
            {
                rating_clients = double.Parse(textBox10.Text.Replace(".",","));
                if (rating_clients >= 0 && rating_clients <= 5)
                    textBox10.BackColor = Color.PaleGreen;
                else
                    textBox10.BackColor = Color.LightPink;
            }
            catch
            {
                textBox10.BackColor = Color.LightPink;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rating_critic = double.Parse(textBox11.Text.Replace(".", ","));
                if (rating_critic >= 0 && rating_critic <= 5)
                    textBox11.BackColor = Color.PaleGreen;
                else
                    textBox11.BackColor = Color.LightPink;
            }
            catch
            {
                textBox11.BackColor = Color.LightPink;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool v = true;
            foreach (TextBox t in tb)
            {
                if (t.BackColor == Color.LightPink) {
                    v = false;
                    break;
                }
            }
            if (!v)
            {
                MessageBox.Show("Ошибка заполнения, проверьте красные поля");
                return;
            }

            new Book(id, name, author, city, publishing, year, price_in, price_out, count, rating_clients, rating_critic);
            if (DataBase.books.ContainsKey(id))
                MessageBox.Show(string.Format("Книга {0} добавлена", name));
            else
                MessageBox.Show("Произошла ошибка");
            this.Close();
        }

    }
}
