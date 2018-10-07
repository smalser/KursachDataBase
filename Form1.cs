using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace KursachBD
{
    public partial class Form1 : Form
    {
        public static DataBase db;

        public Form1()
        {
            InitializeComponent();
            SQLConnection.init();
            db = new DataBase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.get("SELECT * FROM test");
        }
    }

    public static class SQLConnection // Тут будем хранить статическое подключение
    {
        public static MySqlConnection connection; // Подключение

        public static void init()
        {
            string sql_string = "Database=bookshop;Data Source=localhost;User Id=root;Password=root";
            connection = new MySqlConnection(sql_string);
        }
    }


    public class DataBase
    {
        static MySqlConnection connection = SQLConnection.connection; // Подключение

        public DataBase()
        {

        }

        static public string get_books(string text)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand(text, connection);
            MySqlDataReader Reader;
            Reader = command.ExecuteReader();

            String a="", b="";
            while (Reader.Read())
            {
                a = Reader.GetString(0);
                b = Reader.GetString(1);
            }

            String name = a + b;
            Console.WriteLine(name);
            connection.Close();
            return name;
        }

    }

    public class DB_books
    {
        string id,
            name,
            author,
            city,
            publishing;
        DateTime year;
        int price_in,
            price_out,
            count;
        float rating_clients,
            rating_critic;


        public DB_books(MySqlDataReader reader)
        {
            id = reader.GetString(0);
            name = reader.GetString(1);
            author = reader.GetString(2);
            city = reader.GetString(3);
            publishing = reader.GetString(4);
            year = reader.GetDateTime(5);
            price_in = reader.GetInt16(6);
            price_out = reader.GetInt16(7);
            count = reader.GetInt16(8);
            rating_clients = reader.GetFloat(9);
            rating_clients = reader.GetFloat(10);
        }

        public DB_books(string id, string name, string author, string city, string publishing, int year, int price_in, int price_out, int count, float rating_clients, float rating_critic)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.city = city;
            this.publishing = publishing;

            this.year = new DateTime();
            this.year.AddYears(year);

            this.price_in = price_in;
            this.price_out = price_out;
            this.count = count;

            this.rating_clients = rating_clients;
            this.rating_critic = rating_critic;
        }

        public void update()
        {
            string set = "";


            string responce = "UPDATE books set ({0}) where id={1}";
        }
    }
}
