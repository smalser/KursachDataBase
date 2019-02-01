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
    public partial class Form_Statistics : Form
    {
        string selected;

        public Form_Statistics()
        {
            selected = "";
            InitializeComponent();
        }

        private void Form_Statistics_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Statistic.Get_Months());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = (string)listBox1.SelectedItem;
            if (Statistic.months.ContainsKey(s))
            {
                dataGridView1.Rows.Clear();
                foreach (string str in Statistic.months[s].Keys)
                {
                    dataGridView1.Rows.Add(new string[] {DataBase.books[str].name, Statistic.months[s][str].ToString()});
                }
            }
        }
    }
}
