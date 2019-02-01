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
    public partial class Form_Korzina : Form
    {
        Korzina korzina = Form_Prodavec.korzina;
        string selected_id;
        int selected_id_n = 0;
        bool flag = false; // Когда флаг тру можно менять количество

        public Form_Korzina()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += Form_Korzina_Selection_changed;
        }

        private void Form_Korzina_Load(object sender, EventArgs e)
        {
            FillDB();

            // Номер
            selected_id = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
            numericUpDown1.Value = korzina.d[selected_id]; // Забиваем номер
            flag = true;
        }

        private void FillDB()
        {
            flag = false;
            dataGridView1.Rows.Clear();
            foreach(string s in korzina.d.Keys)
            {
                Book b = DataBase.books[s];
                dataGridView1.Rows.Add(new string[] {b.id, b.name, b.author, korzina.d[s].ToString()});
            }
            calculate();
            flag = true;
        }

        private void Form_Korzina_Selection_changed(object sender, EventArgs e)
        {
            flag = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selected_id = (string)dataGridView1.SelectedRows[0].Cells[0].Value; // Находим индекс
                selected_id_n = dataGridView1.SelectedRows[0].Index;

                numericUpDown1.Value = korzina.d[selected_id]; // Забиваем номер
            }
            calculate();
            flag = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!flag)
                return;
            int n = (int)numericUpDown1.Value;
            if (n > korzina.d[selected_id])
            {
                korzina.up(selected_id);
                dataGridView1.Rows[selected_id_n].Cells[3].Value = n;
                // Проверку на наличие книг
                if (numericUpDown1.Value > DataBase.store[Tuple.Create(selected_id, Form_Prodavec.shop_id)].count)
                {
                    numericUpDown1.Value = DataBase.store[Tuple.Create(selected_id, Form_Prodavec.shop_id)].count;
                    MessageBox.Show(string.Format("В этом магазине только {0} экземпляров книги", numericUpDown1.Value.ToString()));
                }
            }
            else if (n == 0) // Если удаление
            {
                button1_Click(sender, e);
            }
            else
            {
                korzina.down(selected_id);
                dataGridView1.Rows[selected_id_n].Cells[3].Value = n;
            }
            calculate();
        }

        private void calculate()
        {
            if (dataGridView1.Rows.Count > 0)
                textBox1.Text = (string)dataGridView1.Rows[selected_id_n].Cells[1].Value;
            else
                textBox1.Text = "";

            label_col.Text = korzina.count.ToString();
            label_cena.Text = korzina.cena.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            korzina.Remove(selected_id);
            FillDB();
        }

        private void button2_Click(object sender, EventArgs e) // Очистить
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите очистить корзину?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                korzina.Clear();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e) // Оформить заказ
        {
            Order o = new Order(Form_Prodavec.shop_id, DateTime.Now, korzina.ToString());
            korzina.minus();
            MessageBox.Show(string.Format("Зказ под номером {0} оформлен", o.id.ToString()));
            korzina.Clear();
            this.Close();
        }
    }

    public class Korzina
    {
        public List<string> list = new List<string>(); // Книги
        public Dictionary<string, int> d = new Dictionary<string, int>(); // Количество
        public int count = 0;
        public double cena = 0;

        public void Add(string id, int c=1)
        {
            for (int i = 0; i < c; i++)
                list.Add(id);
            result();
        }

        public void Remove(string id)
        {
            list.RemoveAll(delegate (string a) { return a == id; });
            result();
        }

        public void Clear()
        {
            list.Clear();
            result();
        }

        public void up(string s)
        {
            list.Add(s);
            result();
        }

        public void down(string s)
        {
            list.Remove(s);
            result();
        }

        public void result()
        {
            count = list.Count();
            cena = 0;
            d = new Dictionary<string, int>();
            foreach (string s in list)
            {
                if (d.ContainsKey(s))
                    d[s]++;
                else
                    d.Add(s, 1);
                cena += DataBase.books[s].price_out;
            }
        }

        public override string ToString() // Вывод для заказа
        {
            string txt = "";
            foreach (string s in d.Keys)
            {
                txt += string.Format("{0} \"{1} {2}\"\n", d[s], DataBase.books[s].name, DataBase.books[s].author);
            }
            txt += "Сумма: " + cena.ToString();

            return txt;
        }

        public void minus()
        {
            int shopid = Form_Prodavec.shop_id;
            foreach (string s in d.Keys)
            {
                var t = Tuple.Create(DataBase.books[s].id, shopid);
                DataBase.store[t].Change(DataBase.store[t].count-d[s]);
                Statistic.sell(DataBase.books[s].id, d[s]);
            }
        }
    }
}
