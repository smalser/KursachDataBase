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
    public partial class Form_Admin : Form
    {
        List<int> newrows = new List<int>();
        bool nonredact = false;

        public Form_Admin()
        {
            InitializeComponent();

        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            Fill_DGV();
        }

        private void Fill_DGV()
        {
            nonredact = true;
            dataGridView1.Rows.Clear();
            foreach (Book b in DataBase.books.Values)
            {
                object[] s = BooktoArr(b);
                dataGridView1.Rows.Add(s);

            }
            nonredact = false;
        }

        // Создание массивов для закидывания книг
        object[] BooktoArr(Book b)
        {
            Button add = new Button() { Text = "Заказать" };
            Button del = new Button() { Text = "Удалить" };
            object[] arr =
            {
                "Заказать",
                "Удалить",
                b.id,
                b.name,
                b.author,
                b.city,
                b.publishing,
                b.year.ToString(),
                b.price_in.ToString(),
                b.price_out.ToString(),
                b.count.ToString(), // Сделать для этого магазина D
                b.rating_clients.ToString("0.00"),
                b.rating_critic.ToString("0.00")
            };

            return arr;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && DataBase.books.ContainsKey((string)senderGrid.Rows[e.RowIndex].Cells[2].Value))
            {
                Console.WriteLine(e.ColumnIndex);
                string id = (string)senderGrid.Rows[e.RowIndex].Cells[2].Value;

                if (e.ColumnIndex == 0) // Когда заказ
                {
                    Form_zakaz fm = new Form_zakaz(id);
                    fm.ShowDialog();
                }
                else if (e.ColumnIndex == 1) // Когда удаление
                {
                    DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить книгу?", "Удалить", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataBase.books[id].delete();
                        Fill_DGV();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Adding fm = new Form_Adding();
            fm.FormClosed += delegate { Fill_DGV(); };
            fm.ShowDialog();

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private bool verifyrow(int i)
        {
            var cells = dataGridView1.Rows[i].Cells;
            //0,1 кнопки
            try
            {
                string id = (string)cells[3].Value,
                   name = (string)cells[4].Value,
                   author = (string)cells[5].Value,
                   city = (string)cells[6].Value,
                   publishing = cells[7].Value.ToString();

                int year = int.Parse((string)cells[8].Value),
                    price_in = int.Parse((string)cells[9].Value),
                    price_out = int.Parse((string)cells[10].Value),
                    count = int.Parse((string)cells[11].Value);

                double rating_clients = double.Parse((string)cells[12].Value),
                rating_critic = double.Parse((string)cells[13].Value);

                new Book(id, name, author, city, publishing, year, price_in, price_out, count, rating_clients, rating_critic);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка: "+ exp.ToString());
                return false;
            }
            return true;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
                dataGridView1.BeginEdit(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Zakazi fm = new Form_Zakazi();
            fm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Statistics fm = new Form_Statistics();
            fm.ShowDialog();
        }
    }
}
