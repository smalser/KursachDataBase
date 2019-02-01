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
    public partial class Form_Kladovshik : Form
    {
        List<Book> books; // База книг
        List<Shop> shops; // База магазинов;
        List<Store> store; // Склад

        TrackBar[,] table; // Пачка кнопок и треков
        Label[] stash; // Склад

        Dictionary<string, Change> changes = new Dictionary<string, Change>(); // Изменения

        public Form_Kladovshik()
        {
            InitializeComponent();
            books = DataBase.books.Values.ToList();
            books.Sort(delegate (Book a, Book b) { return a.name.CompareTo(b.name); });
            shops = DataBase.shops.Values.ToList();
            store = DataBase.store.Values.ToList();
            table = new TrackBar[shops.Count,books.Count];
            stash = new Label[books.Count];
            changes = Change.Creator(books, shops); // Создаем список изменений
        }

        private void Form_Kladovshik_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
        {
            // Названия

            //Число столбцов и строк
            tableLayoutPanel1.ColumnCount = 2 + shops.Count;
            tableLayoutPanel1.RowCount = books.Count;

            // Серединка
            Label l = new Label() {Text="Книга/Мазагин" };
            tableLayoutPanel1.Controls.Add(l,0,0);

            // Склады
            l = new Label() { Text = "На складе" };
            tableLayoutPanel1.Controls.Add(l, shops.Count+1, 0);

            // Названия магазинов
            for (int i = 0; i < shops.Count; i++)
            {
                l = new Label() { Text = shops[i].adress };
                tableLayoutPanel1.Controls.Add(l, 1+i, 0);
            }


            for (int y = 0; y < books.Count; y++)
            {
                // Названия книг
                l = new Label() { Text = books[y].name};
                l.Dock = DockStyle.Right;
                l.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(l, 0, y+1);
                for (int x=0; x < shops.Count; x++)
                {
                    // И трекпады
                    Panel p = CreatePanel(x,y);
                    tableLayoutPanel1.Controls.Add(p, x+1, y+1);
                }
                // И склады
                stash[y] = new Label() { Text = changes[books[y].id].sklad.ToString()};
                tableLayoutPanel1.Controls.Add(stash[y], shops.Count + 1, y + 1);
            }

        }

        private Panel CreatePanel(int x, int y)
        {
            Panel p = new Panel();
            p.Size = new Size(200, 30);

            TrackBar tb = new TrackBar();
            tb.Size = new Size(180, 30);
            tb.Maximum = changes[books[y].id].sklad + changes[books[y].id].changes[shops[x].id];
            tb.Value = changes[books[y].id].changes[shops[x].id];

            Label l = new Label();
            l.Text = tb.Value.ToString();
            tb.ValueChanged += delegate {
                l.Text = tb.Value.ToString();
            };
            p.Controls.Add(l); l.Dock = DockStyle.Left;
            p.Controls.Add(tb); tb.Dock = DockStyle.Left;

            table[x,y] = tb;
            tb.ValueChanged += delegate (object sender, EventArgs e)
            {
                ValueChanged(x, y, sender);
            };

            return p;
        }
        
        private void ValueChanged(int x, int y, object sender) // Х магазин У книга
        {
            TrackBar t = (TrackBar)sender; // Трекер
            int n = t.Value;               // Его значение
            // Меняем значение
            changes[books[y].id].change(shops[x].id, n);

            // И границы
            stash[y].Text = changes[books[y].id].sklad.ToString();
            for (int i=0; i < shops.Count; i++)
            {
                table[i, y].Maximum = table[i, y].Value + changes[books[y].id].sklad;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Change c in changes.Values)
            {
                c.Confirm();
            }
            MessageBox.Show("Изменено!");
        }
    }

    class Change
    {
        public string book_id;
        bool confirmed = true;
        public int sklad,// На складе
        all;  // Все
        // Измененение вида (магазин-количество)
        public Dictionary<int, int> changes = new Dictionary<int, int>();

        // Добавление изменений
        public Change(string id, List<Shop> shops)
        {
            this.book_id = id; 
            sklad = DataBase.books[id].count; // На склад количество
            all = sklad; // Всего склад и 
            
            
            foreach (Shop s in shops)
            {
                Tuple<string, int> t = Tuple.Create(id, s.id); // Пара
                if (DataBase.store.ContainsKey(t))
                {
                    Store st = DataBase.store[Tuple.Create(id, s.id)];
                    changes[s.id] = st.count;
                    all += st.count;
                }
            }
        }

        public void Confirm() // TODO
        {
            if (!confirmed)
            {
                DataBase.books[book_id].Change(count: sklad);

                foreach (int i in changes.Keys)
                {
                    DataBase.store[Tuple.Create(book_id, i)].Change(changes[i]);
                }
            }
            confirmed = true;
        }

        public void change(int id, int count)
        {
            changes[id] = count;
            int used = 0;
            foreach (int i in changes.Keys)
            {
                used += changes[i];
            }
            Console.WriteLine("{0}, {1}", used, all);
            sklad = all - used; // Высчитываем склад
            confirmed = false;
        }

        public static Dictionary<string, Change> Creator(List<Book> books, List<Shop> shops)
        {
            Dictionary<string, Change> c = new Dictionary<string, Change>();

            foreach (Book b in books)
            {
                c.Add(b.id, new Change(b.id, shops));
            }

            return c;
        }
    }
}
