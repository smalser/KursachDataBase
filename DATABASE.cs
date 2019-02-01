using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace KursachBD
{
    public static class SQLConnection // Тут будем хранить статическое подключение
    {
        public static MySqlConnection connection; // Подключение

        public static void init()
        {
            string sql_string = "Database=bookshop;Data Source=localhost;User Id=root;Password=root";
            connection = new MySqlConnection(sql_string);
        }
    }

    public static class DataBase
    {
        public static MySqlConnection connection = SQLConnection.connection; // Подключение

        public static Dictionary<String, Book> books = new Dictionary<String, Book>(); // База книг
        public static Dictionary<int, Shop> shops = new Dictionary<int, Shop>(); // База магазинов
        public static Dictionary<Tuple<string, int>, Store> store = new Dictionary<Tuple<string, int>, Store>(); // Склад
        public static Dictionary<int, Order> orders = new Dictionary<int, Order>(); // Таблица покупок

        // Счиытвание книг
        static public void get_books(bool full = false)
        {
            string text = "SELECT * FROM books"; // Стандартынй запрос
            connection.Open(); // Открываем соединение
            MySqlCommand command = new MySqlCommand(text, connection); // Подаем запрос
            MySqlDataReader reader = command.ExecuteReader(); // Выполняем и смотрим вывод
            int k = 0; // Для справки

            if (full)
                books.Clear();

            while (reader.Read()) // Пока есть вывод
            {
                Book n = new Book(reader);
                // Если такого ид нет
                if (!books.ContainsKey(n.id))
                {
                    books.Add(n.id, n);
                    k++;
                    Console.WriteLine("Добавлена книга {0}", n.id);
                }
            }
            connection.Close(); // И закрываем
            Console.WriteLine("Изменено записей книг {0}\n", k);
        }

        // Считывание магазинов
        static public void get_shops(bool full = false)
        {
            string text = "SELECT * FROM shops"; // Стандартынй запрос
            connection.Open(); // Открываем соединение
            MySqlCommand command = new MySqlCommand(text, connection); // Подаем запрос
            MySqlDataReader reader = command.ExecuteReader(); // Выполняем и смотрим вывод
            int k = 0; // Для справки

            if (full)
                shops.Clear();

            while (reader.Read()) // Пока есть вывод
            {
                Shop n = new Shop(reader);
                // Если такого ид нет
                if (!shops.ContainsKey(n.id))
                {
                    shops.Add(n.id, n);
                    k++;
                    Console.WriteLine("Добавлен магазин {0}", n.id);
                }
            }
            connection.Close(); // И закрываем
            Console.WriteLine("Изменено записей магазинов {0}\n", k);
        }

        // Считывание склада
        static public void get_store(bool full = false)
        {
            string text = "SELECT * FROM store"; // Стандартынй запрос
            connection.Open(); // Открываем соединение
            MySqlCommand command = new MySqlCommand(text, connection); // Подаем запрос
            MySqlDataReader reader = command.ExecuteReader(); // Выполняем и смотрим вывод
            int k = 0; // Для справки

            if (full)
                store.Clear();

            while (reader.Read()) // Пока есть вывод
            {
                Store n = new Store(reader);
                // Если такого ид нет
                if (!store.ContainsKey(Tuple.Create(n.book_id, n.shop_id)))
                {
                    store.Add(Tuple.Create(n.book_id, n.shop_id), n);
                    k++;
                    Console.WriteLine("Добавлена запись склада {0}-{1}", n.book_id, n.shop_id);
                }
            }
            connection.Close(); // И закрываем
            Console.WriteLine("Изменено записей склада {0}\n", k);
        }

        // Считывание заказов
        static public void get_orders(bool full = false)
        {
            string text = "SELECT * FROM orders"; // Стандартынй запрос
            connection.Open(); // Открываем соединение
            MySqlCommand command = new MySqlCommand(text, connection); // Подаем запрос
            MySqlDataReader reader = command.ExecuteReader(); // Выполняем и смотрим вывод
            int k = 0; // Для справки

            if (full)
                orders.Clear();

            while (reader.Read()) // Пока есть вывод
            {
                Order n = new Order(reader);
                // Если такого ид нет
                if (!shops.ContainsKey(n.id))
                {
                    orders.Add(n.id, n);
                    k++;
                    Console.WriteLine("Добавлен заказ {0}", n.id);
                }
            }
            connection.Close(); // И закрываем
            Console.WriteLine("Изменено записей заказа {0}\n", k);
        }

        // Обновить все
        static public void get_all(bool full = false)
        {
            get_books(full);
            get_shops(full);
            get_store(full);
            get_orders(full);
        }

        // Выполнение команды
        static public string execute(string a)
        {
            string txt = "";
            try // Делаем через трай чтобы по любому закрыть соединение
            {
                connection.Open(); // Открываем соединение
                MySqlCommand command = new MySqlCommand(a, connection); // Подаем запрос
                MySqlDataReader reader = command.ExecuteReader(); // Выполняем и смотрим вывод
                while (reader.Read())
                {
                    try
                    {
                        string t = reader.GetString(0);
                        txt += t + "\n";
                        Console.WriteLine(t);
                    }
                    catch (Exception) { }
               }
            }
            catch (Exception exp) // Если ловим ошибку дублируем
            {
                throw exp;
            }

            finally
            {
                connection.Close();
            }

            return txt;
        }

        static public void Roll_Store()
        {
            Random rnd = new Random();
            foreach (string b in books.Keys)
                foreach (int s in shops.Keys)
                {
                    Tuple<string, int> t = Tuple.Create(b, s);
                    if (store.ContainsKey(t))
                    {
                        store[t].Change(rnd.Next(0,30));
                        Console.WriteLine("Изменено {0}-{1}",b,s);
                    }
                    else
                    {
                        new Store(b, s, rnd.Next(0, 30));
                        Console.WriteLine("Добавлено {0}-{1}", b, s);
                    }
                }
        }
    }

    public class Book
    {
        public string id,
            name,
            author,
            city,
            publishing;
        public int year,
            price_in,
            price_out,
            count;
        public double rating_clients,
            rating_critic;

        // Конструктор ридером(из бд)
        public Book(MySqlDataReader reader)
        {
            id = reader.GetString(0);
            name = reader.GetString(1);
            author = reader.GetString(2);
            city = reader.GetString(3);
            publishing = reader.GetString(4);
            year = reader.GetInt16(5);
            price_in = reader.GetInt16(6);
            price_out = reader.GetInt16(7);
            count = reader.GetInt16(8);
            rating_clients = reader.GetFloat(9);
            rating_critic = reader.GetFloat(10);
        }

        // Конструктор аргументами
        public Book(string id, string name, string author, string city, string publishing, int year, int price_in, int price_out, int count, double rating_clients, double rating_critic)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.city = city;
            this.publishing = publishing;

            this.year = year;

            this.price_in = price_in;
            this.price_out = price_out;
            this.count = count;

            this.rating_clients = rating_clients;
            this.rating_critic = rating_critic;

            // Добавляем себя в базу
            try
            {
                add();
            }
            catch (MySql.Data.MySqlClient.MySqlException exp)
            {
                if (exp.ToString().Contains("Duplicate")) {
                    Console.WriteLine("Замечено дублирование!");
                    update();
                }
                else
                    Console.WriteLine(exp.ToString());
                
            }
            //DataBase.get_books(); // и заново считываем
        }

        // Изменение
        public void Change(string name="-", string author="-", string city="-", string publishing="-", int year=-1, int price_in=-1, int price_out=-1, int count=-1, double rating_clients=-1, double rating_critic=-1)
        {
            if (name != "-")
                this.name = name;
            if (author != "-")
                this.author = author;
            if (city != "-")
                this.city = city;
            if (publishing != "-")
                this.publishing = publishing;

            if (year != -1)
                this.year = year;
            if (price_in != -1)
                this.price_in = price_in;
            if (price_out != -1)
                this.price_out = price_out;
            if (count != -1)
                this.count = count;
            if (rating_clients != -1)
                this.rating_clients = rating_clients;
            if (rating_critic != -1)
                this.rating_critic = rating_critic;

            update(); // Обновим в базе
        }

        // Добавление в базу данных
        public void add() 
        {
            string text = string.Format("insert into books (id, name, author, city, publishing, year, price_in, price_out, count, rating_clients, rating_critic) " +
                "values ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}, {8}, {9}, {10});", 
                id, name, author, city, publishing, year, price_in, price_out, count, rating_clients.ToString("0.00").Replace(",","."), rating_critic.ToString("0.00").Replace(",", "."));
            Console.WriteLine(text);

            DataBase.execute(text);

            DataBase.books.Add(id, this);

            // И в стор тоже заносим нули
            foreach (Shop s in DataBase.shops.Values)
            {
                var t = Tuple.Create(id, s.id);
                if (!DataBase.store.ContainsKey(t))
                {
                    new Store(id, s.id, 0);
                }
            }
            
        }

        // Обновление в базе данных
        public void update()
        {
            string set = "";
            set += string.Format("name = '{0}', author = '{1}', city = '{2}', publishing = '{3}', year = {4}, " +
                "price_in = {5}, price_out = {6}, count = {7}, rating_clients = {8}, rating_critic = {9}",
                name, author, city, publishing, year, price_in, price_out, count, rating_clients.ToString("0.00").Replace(',', '.'), rating_critic.ToString("0.00").Replace(',', '.'));

            string responce = string.Format("UPDATE books set {0} where id = '{1}'", set, id);
            DataBase.execute(responce);
        }

        // Удаление из базы данных
        public void delete()
        {
            Tuple<string, int>[] ts = DataBase.store.Keys.ToArray();
            foreach (Tuple<string,int> t in ts)
            {
                if (t.Item1 == this.id)
                {
                    DataBase.store[t].delete();
                }
            }
            string txt = "delete from books where id = '" + id + "'";
            DataBase.execute(txt); // Удаляем из БД
            DataBase.books.Remove(this.id); // И у себя
        }
    }

    // Магазины
    public class Shop
    {
        public int id;
        public string adress,
            telephone,
            worktime;

        // Конструктор ридером(из бд)
        public Shop(MySqlDataReader reader)
        {
            id = reader.GetInt32(0);
            adress = reader.GetString(1);
            telephone = reader.GetString(2);
            worktime = reader.GetString(3);
        }

        // Конструктор аргументами
        public Shop(int id, string adress, string telephone, string worktime)
        {
            this.id = id;
            this.adress = adress;
            this.telephone = telephone;
            this.worktime = worktime;

            // Добавляем себя в базу
            try
            {
                add();
            }
            catch (MySql.Data.MySqlClient.MySqlException exp)
            {
                if (exp.ToString().Contains("Duplicate"))
                {
                    Console.WriteLine("Замечено дублирование!");
                    update();
                }
                else
                    Console.WriteLine(exp.ToString());
            }
            //DataBase.get_shops(); // и заново считываем
        }

        // Изменение
        public void Change(int id = -1, string adress = "-", string telephone = "-", string worktime = "-")
        {
            if (id != -1)
                this.id = id;

            if (adress != "-")
                this.adress = adress;
            if (telephone != "-")
                this.telephone = telephone;
            if (worktime != "-")
                this.worktime = worktime;

            update(); // Обновим в базе
            //DataBase.get_shops();
        }

        // Добавление в базу данных
        public void add()
        {
            string text = string.Format("insert into shops (id, adress, telephone, worktime) " +
                "values ({0}, '{1}', '{2}', '{3}')",
                id, adress, telephone, worktime);

            DataBase.execute(text);

            DataBase.shops.Add(id, this);
        }

        // Обновление в базе данных
        public void update()
        {
            string set = "";
            set += string.Format("adress = '{0}', telephone = '{1}', worktime = '{2}'",
                adress, telephone, worktime);

            string responce = string.Format("UPDATE shops set {0} where id = {1}", set, id);
            DataBase.execute(responce);
        }

        // Удаление из базы данных
        public void delete()
        {
            string txt = "delete from shops where id = " + id.ToString();
            DataBase.execute(txt); // Удаляем из бд
            DataBase.shops.Remove(this.id); // И у себя
        }
    }

    // Склад
    public class Store
    {
        public string book_id;
        public int shop_id,
        count;

        // Конструктор ридером(из бд)
        public Store(MySqlDataReader reader)
        {
            book_id = reader.GetString(0);
            shop_id = reader.GetInt32(1);
            count = reader.GetInt32(2);
        }

        // Конструктор аргументами
        public Store(string book_id, int shop_id, int count)
        {
            this.book_id = book_id;
            this.shop_id = shop_id;
            this.count = count;

            // Добавляем себя в базу
            try
            {
                add();
            }
            catch (MySql.Data.MySqlClient.MySqlException exp)
            {
                if (exp.ToString().Contains("Duplicate"))
                {
                    Console.WriteLine("Замечено дублирование!");
                    update();
                }
                else
                    Console.WriteLine(exp.ToString());
            }
            //DataBase.get_store(); // и заново считываем
        }

        // Изменение
        public void Change(int count)
        {
            if (count < 0)
                throw new Exception("Количество меньше нуля");
            this.count = count;

            update(); // Обновим в базе
            //DataBase.get_store();
        }

        // Легкое сложение
        public static Store operator +(Store a, int b)
        {
            a.count += b;

            a.update();
            return a;
        }

        // Легкое вычитание
        public static Store operator -(Store a, int b)
        {
            a.count -= b;

            a.update();
            return a;
        }

        // Добавление в базу данных
        public void add()
        {
            // Если такое уже есть
            if (DataBase.store.ContainsKey(Tuple.Create(book_id, shop_id)))
            {
                Console.WriteLine("Ловим повтор");
                this.update();
                return;
            }
            string text = string.Format("insert into store (book_id, shop_id, count) " +
                "values ('{0}', {1}, {2})",
                book_id, shop_id, count);

            DataBase.execute(text);
            DataBase.store.Add(Tuple.Create(book_id, shop_id), this);
        }

        // Обновление в базе данных
        public void update()
        {
            string responce = string.Format("UPDATE store set count = {0} where book_id = '{1}' and shop_id = {2}", count, book_id, shop_id);
            Console.WriteLine(responce);
            DataBase.execute(responce);
        }


        // Удаление из базы данных
        public void delete()
        {
            string txt = string.Format("delete from store where book_id = '{0}' and shop_id = {1}", book_id, shop_id);
            DataBase.execute(txt); // Удаляем из бд
            DataBase.store.Remove(Tuple.Create(book_id, shop_id)); // И у себя
        }
    }

    // Покупки
    public class Order
    {
        public int id,
            shop_id;
        public DateTime time;
        public string info;

        // Конструктор ридером(из бд)
        public Order(MySqlDataReader reader)
        {
            id = reader.GetInt32(0);
            shop_id = reader.GetInt32(1);
            time = reader.GetDateTime(2);
            info = reader.GetString(3);
        }

        // Конструктор аргументами
        public Order(int shop_id, DateTime time, string info)
        {
            this.shop_id = shop_id;
            this.time = time;
            this.info = info;

            // Добавляем себя в базу
            add();
            //DataBase.get_orders(); // и заново считываем
        }

        // Добавление в базу данных
        public void add()
        {
            string text = string.Format("insert into orders (shop_id, time, info) " +
                "values ({0}, '{1}', '{2}')",
                shop_id, time.ToString("yyyy-MM-dd HH:mm:ss.fff"), info);

            DataBase.execute(text);
            int id = int.Parse(DataBase.execute("select last_insert_id() from orders LIMIT 1").Trim());
            this.id = id;

            DataBase.orders.Add(id, this);
        }

        // Удаление из базы данных
        public void delete()
        {
            string txt = "delete from orders where id = " + id.ToString();
            DataBase.execute(txt); // Удаляем из бд
            DataBase.orders.Remove(this.id); // И у себя
        }
    }

    // Статистика
    public static class Statistic
    {
        public static Dictionary<string, Dictionary<string, int>> months= new Dictionary<string, Dictionary<string, int>>();

        public static void init()
        {
            string text = "SELECT * FROM statistics"; // Стандартынй запрос
            DataBase.connection.Open(); // Открываем соединение
            MySqlCommand command = new MySqlCommand(text, DataBase.connection); // Подаем запрос
            MySqlDataReader reader = command.ExecuteReader(); // Выполняем и смотрим вывод
            int k = 0; // Для справки

            while (reader.Read()) // Пока есть вывод
            {
                string dt = reader.GetString(0);
                string id = reader.GetString(1);
                int c = reader.GetInt32(2);

                if (months.ContainsKey(dt))
                {
                    if (months[dt].ContainsKey(id))
                        months[dt][id] = c;
                    else
                        months[dt].Add(id, c);
                }
                else
                {
                    months.Add(dt, new Dictionary<string, int>());
                    months[dt].Add(id, c);
                }
            }
            DataBase.connection.Close(); // И закрываем
            Console.WriteLine("Изменено записей магазинов {0}\n", k);
        }

        public static void sell(string id, int c)
        {
            string dt = DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

            if (months.ContainsKey(dt))
            {
                if (months[dt].ContainsKey(id))
                {
                    months[dt][id] = c;
                    update(c, id, dt);
                }
                else
                {
                    months[dt].Add(id, c);
                    add(c, id, dt);
                }
            }
            else
            {
                months.Add(dt, new Dictionary<string, int>());
                months[dt].Add(id, c);
                add(c, id, dt);
            }
        }

        public static void add(int count, string book_id, string date)
        {
            string text = string.Format("insert into statistics (date, book_id, count) values ('{0}', '{1}', {2});",date, book_id, count);
            Console.WriteLine(text);
            DataBase.execute(text);
        }

        public static void update(int count, string book_id, string date)
        {
            string responce = string.Format("UPDATE statistics set count = {0} where book_id = '{1}' and date = '{2}'", count, book_id, date);
            Console.WriteLine(responce);
            DataBase.execute(responce);
        }

        public static string[] Get_Months()
        {
            try
            {
                return months.Keys.ToArray();
            }
            catch
            {
                return new string[0];
            }
        }

    }

}

