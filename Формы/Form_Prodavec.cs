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
    public partial class Form_Prodavec : Form
    {
        public static int shop_id; // Ид выбранного мазагина
        public Shop shop; // И сам магазин

        static public Korzina korzina = new Korzina(); // Корзина из покупок
        public string cena = "Итого: 0.00";
        


        public Form_Prodavec()
        {
            InitializeComponent();
        }

        private void Form_Prodavec_Load(object sender, EventArgs e)
        {
            Select_shop();
        }

        // Функция вывода выбора магазина
        private void Select_shop()
        {
            // Скрытие 
            dataGridView1.Visible = false;
            tableLayoutPanel1.Visible = false;

            // Показ
            panel1.Visible = true;
            listBox1.Items.Clear();
            foreach (Shop s in DataBase.shops.Values)
            {
                listBox1.Items.Add(s.adress);
            }
        }



        // Функция заполнения списка книг
        private void Fill_DGV()
        {
            dataGridView1.Visible = true;
            tableLayoutPanel1.Visible = true;
            dataGridView1.Rows.Clear();
            foreach (Book b in DataBase.books.Values)
            {
                string[] s = BooktoArr(b);
                if (int.Parse(s[8]) > 0)
                    dataGridView1.Rows.Add(s);
            }
        }

        // Создание массивов для закидывания книг
        string[] BooktoArr(Book b)
        {
            string[] arr =
            {
                b.id,
                b.name,
                b.author,
                b.city,
                b.publishing,
                b.year.ToString(),
                b.price_in.ToString(),
                b.price_out.ToString(),
                DataBase.store[Tuple.Create(b.id,shop_id)].count.ToString(), // Сделать для этого магазина D
                b.rating_clients.ToString("0.00"),
                b.rating_critic.ToString("0.00")
            };

            return arr;
        }

        private void сменитьМагазинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            tableLayoutPanel1.Visible = false;
            Select_shop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int shop_id = listBox1.SelectedIndex;
            try
            {
                shop = DataBase.shops[shop_id];
                Form_Prodavec.shop_id = shop_id;
            }
            catch {
                return;
            };
            Text = "Магазин: " + shop.adress;
            panel1.Visible = false;
            Fill_DGV();
        }

        // Добавление в корзину
        private void button2_Click(object sender, EventArgs e)
        {
            string id = (string)dataGridView1.SelectedRows[0].Cells[0].Value; // Находим индекс
            // Добавляем в корзину н книг
            korzina.Add(id, (int)numericUpDown1.Value);
            numericUpDown1.Value = 1; // И ставим счетчик на 1
            Calculate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Неотрицательное число
            if (numericUpDown1.Value < 1)
                numericUpDown1.Value = 1;

            // Проверку на наличие книг
            string id = (string)dataGridView1.SelectedRows[0].Cells[0].Value; // Находим индекс
            if (numericUpDown1.Value > DataBase.store[Tuple.Create(id, shop_id)].count)
            {
                numericUpDown1.Value = DataBase.store[Tuple.Create(id, shop_id)].count;
                MessageBox.Show(string.Format("В этом магазине только {0} экземпляров книги", numericUpDown1.Value.ToString()));
            }
        }

        private void Calculate()
        {
            label_cena.Text = "Итого: " + korzina.cena.ToString("0.00");
            label_korzina.Text = korzina.count.ToString(); // Меняем число в корзине
        }

        private void открытьКорзинуToolStripMenuItem_Click(object sender, EventArgs e) // Открыть корзину
        {
            if (korzina.list.Count() > 0)
            {
                Form_Korzina fmk = new Form_Korzina();
                fmk.ShowDialog();
                Fill_DGV();
            }
            else
                MessageBox.Show("Корзина пуста");
        }

        private void Form_Prodavec_Activated(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            открытьКорзинуToolStripMenuItem_Click(sender, e);
        }

        private void очиститьКорзинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            korzina.Clear();
            Calculate();
        }
    }
}
