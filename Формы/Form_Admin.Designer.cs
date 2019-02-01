namespace KursachBD
{
    partial class Form_Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.d_zakup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.d_delete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.d_zakup,
            this.d_delete,
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 510);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // d_zakup
            // 
            this.d_zakup.HeaderText = "Закупить";
            this.d_zakup.Name = "d_zakup";
            this.d_zakup.ReadOnly = true;
            // 
            // d_delete
            // 
            this.d_delete.HeaderText = "Удалить";
            this.d_delete.Name = "d_delete";
            this.d_delete.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
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
            this.city.HeaderText = "Город издания ";
            this.city.Name = "city";
            this.city.ReadOnly = true;
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
            this.price_in.HeaderText = "Цена закупки";
            this.price_in.Name = "price_in";
            this.price_in.ReadOnly = true;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 382F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 508);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1025, 60);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(646, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить книгу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Посмотреть заказы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(282, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(358, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Посмотреть статистику";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form_Admin";
            this.Text = "Form_Admin";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn d_zakup;
        private System.Windows.Forms.DataGridViewButtonColumn d_delete;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}