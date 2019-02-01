namespace KursachBD
{
    partial class Form_Prodavec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.магазинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьМагазинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.корзинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьКорзинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьКорзинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_publishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_price_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_rating_clients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_rating_critic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_korzina = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_cena = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.магазинToolStripMenuItem,
            this.корзинаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // магазинToolStripMenuItem
            // 
            this.магазинToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьМагазинToolStripMenuItem,
            this.выйтиToolStripMenuItem,
            this.выйтиToolStripMenuItem1});
            this.магазинToolStripMenuItem.Name = "магазинToolStripMenuItem";
            this.магазинToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.магазинToolStripMenuItem.Text = "Магазин";
            // 
            // сменитьМагазинToolStripMenuItem
            // 
            this.сменитьМагазинToolStripMenuItem.Name = "сменитьМагазинToolStripMenuItem";
            this.сменитьМагазинToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сменитьМагазинToolStripMenuItem.Text = "Сменить магазин";
            this.сменитьМагазинToolStripMenuItem.Click += new System.EventHandler(this.сменитьМагазинToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.выйтиToolStripMenuItem.Text = "Сменить пользователя";
            // 
            // выйтиToolStripMenuItem1
            // 
            this.выйтиToolStripMenuItem1.Name = "выйтиToolStripMenuItem1";
            this.выйтиToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.выйтиToolStripMenuItem1.Text = "Выйти";
            // 
            // корзинаToolStripMenuItem
            // 
            this.корзинаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьКорзинуToolStripMenuItem,
            this.очиститьКорзинуToolStripMenuItem});
            this.корзинаToolStripMenuItem.Name = "корзинаToolStripMenuItem";
            this.корзинаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.корзинаToolStripMenuItem.Text = "Корзина";
            // 
            // открытьКорзинуToolStripMenuItem
            // 
            this.открытьКорзинуToolStripMenuItem.Name = "открытьКорзинуToolStripMenuItem";
            this.открытьКорзинуToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.открытьКорзинуToolStripMenuItem.Text = "Открыть корзину";
            this.открытьКорзинуToolStripMenuItem.Click += new System.EventHandler(this.открытьКорзинуToolStripMenuItem_Click);
            // 
            // очиститьКорзинуToolStripMenuItem
            // 
            this.очиститьКорзинуToolStripMenuItem.Name = "очиститьКорзинуToolStripMenuItem";
            this.очиститьКорзинуToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.очиститьКорзинуToolStripMenuItem.Text = "Очистить корзину";
            this.очиститьКорзинуToolStripMenuItem.Click += new System.EventHandler(this.очиститьКорзинуToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.d_name,
            this.d_author,
            this.city,
            this.d_publishing,
            this.d_year,
            this.price_in,
            this.d_price_out,
            this.d_count,
            this.d_rating_clients,
            this.d_rating_critic});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 470);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "d_id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // d_name
            // 
            this.d_name.HeaderText = "Название";
            this.d_name.Name = "d_name";
            this.d_name.ReadOnly = true;
            // 
            // d_author
            // 
            this.d_author.HeaderText = "Автор";
            this.d_author.Name = "d_author";
            this.d_author.ReadOnly = true;
            // 
            // city
            // 
            this.city.HeaderText = "d_city";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Visible = false;
            // 
            // d_publishing
            // 
            this.d_publishing.HeaderText = "Издательство";
            this.d_publishing.Name = "d_publishing";
            this.d_publishing.ReadOnly = true;
            // 
            // d_year
            // 
            this.d_year.HeaderText = "Год публикации";
            this.d_year.Name = "d_year";
            this.d_year.ReadOnly = true;
            // 
            // price_in
            // 
            this.price_in.HeaderText = "d_price_in";
            this.price_in.Name = "price_in";
            this.price_in.ReadOnly = true;
            this.price_in.Visible = false;
            // 
            // d_price_out
            // 
            this.d_price_out.HeaderText = "Цена";
            this.d_price_out.Name = "d_price_out";
            this.d_price_out.ReadOnly = true;
            // 
            // d_count
            // 
            this.d_count.HeaderText = "Кол-во";
            this.d_count.Name = "d_count";
            this.d_count.ReadOnly = true;
            // 
            // d_rating_clients
            // 
            this.d_rating_clients.HeaderText = "Рейтинг(клиент)";
            this.d_rating_clients.Name = "d_rating_clients";
            this.d_rating_clients.ReadOnly = true;
            // 
            // d_rating_critic
            // 
            this.d_rating_critic.HeaderText = "Рейтинг(критик)";
            this.d_rating_critic.Name = "d_rating_critic";
            this.d_rating_critic.ReadOnly = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(860, 314);
            this.listBox1.TabIndex = 2;
            this.listBox1.DoubleClick += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 401);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(860, 88);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выбрать магазин";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_cena, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 497);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 78);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.13167F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.86832F));
            this.tableLayoutPanel2.Controls.Add(this.label_korzina, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.77778F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 72);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label_korzina
            // 
            this.label_korzina.AutoSize = true;
            this.label_korzina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_korzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_korzina.Location = new System.Drawing.Point(3, 0);
            this.label_korzina.Name = "label_korzina";
            this.label_korzina.Size = new System.Drawing.Size(59, 33);
            this.label_korzina.TabIndex = 0;
            this.label_korzina.Text = "0";
            this.label_korzina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "товаров в корзине";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(68, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "добавить в корзину";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(3, 36);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 35);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label_cena
            // 
            this.label_cena.AutoSize = true;
            this.label_cena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cena.Location = new System.Drawing.Point(290, 0);
            this.label_cena.Name = "label_cena";
            this.label_cena.Size = new System.Drawing.Size(276, 78);
            this.label_cena.TabIndex = 1;
            this.label_cena.Text = "Итого: 0.00";
            this.label_cena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(572, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 72);
            this.button3.TabIndex = 2;
            this.button3.Text = "Перейти в корзину";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dataBaseBindingSource
            // 
            this.dataBaseBindingSource.DataSource = typeof(KursachBD.DataBase);
            // 
            // Form_Prodavec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Prodavec";
            this.Text = "Товары";
            this.Activated += new System.EventHandler(this.Form_Prodavec_Activated);
            this.Load += new System.EventHandler(this.Form_Prodavec_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataBaseBindingSource;
        private System.Windows.Forms.ToolStripMenuItem магазинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьМагазинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_korzina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_publishing;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_price_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_rating_clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_rating_critic;
        private System.Windows.Forms.ToolStripMenuItem корзинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьКорзинуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьКорзинуToolStripMenuItem;
        private System.Windows.Forms.Label label_cena;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button3;
    }
}