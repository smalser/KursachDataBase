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
    public partial class Form_Zakazi : Form
    {
        Dictionary<int, int> slov = new Dictionary<int, int>();
        public Form_Zakazi()
        {
            InitializeComponent();
        }

        private void Form_Zakazi_Load(object sender, EventArgs e)
        {
            int n = 0;
            foreach (int i in DataBase.orders.Keys)
            {
                listBox1.Items.Add(DataBase.orders[i].id);
                slov.Add(n++, i);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = slov[listBox1.SelectedIndex];
            if (DataBase.orders.ContainsKey(i))
            {
                 string[] str= DataBase.orders[i].info.Split('\n');
                textBox1.Lines = str;
            }
        }
    }
}
