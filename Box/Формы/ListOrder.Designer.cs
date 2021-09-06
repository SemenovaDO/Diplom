namespace Box
{
    partial class ListOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderNumderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.handicraftBoxDataSet = new Box.HandicraftBoxDataSet();
            this.orderListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderListTableAdapter = new Box.HandicraftBoxDataSetTableAdapters.OrderListTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handicraftBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumderDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderDeliveryDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.townDataGridViewTextBoxColumn,
            this.numberCustomerDataGridViewTextBoxColumn,
            this.CustomerEmail,
            this.CustomerLastName,
            this.CustomerFirstName,
            this.CustomerMiddleName,
            this.costDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderListBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(24, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 324);
            this.dataGridView1.TabIndex = 83;
            // 
            // orderNumderDataGridViewTextBoxColumn
            // 
            this.orderNumderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderNumderDataGridViewTextBoxColumn.DataPropertyName = "OrderNumder";
            this.orderNumderDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.orderNumderDataGridViewTextBoxColumn.Name = "orderNumderDataGridViewTextBoxColumn";
            this.orderNumderDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderNumderDataGridViewTextBoxColumn.Width = 130;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 115;
            // 
            // orderDeliveryDataGridViewTextBoxColumn
            // 
            this.orderDeliveryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderDeliveryDataGridViewTextBoxColumn.DataPropertyName = "OrderDelivery";
            this.orderDeliveryDataGridViewTextBoxColumn.HeaderText = "Дата доставки";
            this.orderDeliveryDataGridViewTextBoxColumn.Name = "orderDeliveryDataGridViewTextBoxColumn";
            this.orderDeliveryDataGridViewTextBoxColumn.Width = 137;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.Width = 102;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 130;
            // 
            // townDataGridViewTextBoxColumn
            // 
            this.townDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.townDataGridViewTextBoxColumn.DataPropertyName = "Town";
            this.townDataGridViewTextBoxColumn.HeaderText = "Город";
            this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
            this.townDataGridViewTextBoxColumn.Width = 83;
            // 
            // numberCustomerDataGridViewTextBoxColumn
            // 
            this.numberCustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberCustomerDataGridViewTextBoxColumn.DataPropertyName = "NumberCustomer";
            this.numberCustomerDataGridViewTextBoxColumn.HeaderText = "Номер заказчика";
            this.numberCustomerDataGridViewTextBoxColumn.Name = "numberCustomerDataGridViewTextBoxColumn";
            this.numberCustomerDataGridViewTextBoxColumn.Width = 156;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerEmail.DataPropertyName = "CustomerEmail";
            this.CustomerEmail.HeaderText = "Email";
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Width = 76;
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerLastName.DataPropertyName = "CustomerLastName";
            this.CustomerLastName.HeaderText = "Фамилия";
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.Width = 107;
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerFirstName.DataPropertyName = "CustomerFirstName";
            this.CustomerFirstName.HeaderText = "Имя";
            this.CustomerFirstName.Name = "CustomerFirstName";
            this.CustomerFirstName.Width = 69;
            // 
            // CustomerMiddleName
            // 
            this.CustomerMiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerMiddleName.DataPropertyName = "CustomerMiddleName";
            this.CustomerMiddleName.HeaderText = "Отчество";
            this.CustomerMiddleName.Name = "CustomerMiddleName";
            this.CustomerMiddleName.Width = 111;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 124;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус заказа";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 132;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 145;
            // 
            // orderListBindingSource1
            // 
            this.orderListBindingSource1.DataMember = "OrderList";
            this.orderListBindingSource1.DataSource = this.handicraftBoxDataSet;
            // 
            // handicraftBoxDataSet
            // 
            this.handicraftBoxDataSet.DataSetName = "HandicraftBoxDataSet";
            this.handicraftBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderListBindingSource
            // 
            this.orderListBindingSource.DataMember = "OrderList";
            this.orderListBindingSource.DataSource = this.handicraftBoxDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(51, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 79;
            this.label4.Text = "Поиск по заказчику:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(815, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 29);
            this.button5.TabIndex = 78;
            this.button5.Text = "Назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(792, 556);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 46);
            this.button4.TabIndex = 77;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(420, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 46);
            this.button3.TabIndex = 76;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(24, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 46);
            this.button2.TabIndex = 75;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(815, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 29);
            this.button1.TabIndex = 74;
            this.button1.Text = "Сбросить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(231, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 29);
            this.comboBox1.TabIndex = 73;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 21);
            this.label3.TabIndex = 72;
            this.label3.Text = "Сортировка по статусу:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 57);
            this.label1.TabIndex = 71;
            this.label1.Text = "Шкатулка рукоделия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-2, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 42);
            this.panel1.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(944, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оНасToolStripMenuItem,
            this.словарьToolStripMenuItem,
            this.калькуляторToolStripMenuItem,
            this.вопросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(281, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оНасToolStripMenuItem
            // 
            this.оНасToolStripMenuItem.Name = "оНасToolStripMenuItem";
            this.оНасToolStripMenuItem.Size = new System.Drawing.Size(82, 31);
            this.оНасToolStripMenuItem.Text = "О нас";
            this.оНасToolStripMenuItem.Click += new System.EventHandler(this.оНасToolStripMenuItem_Click);
            // 
            // словарьToolStripMenuItem
            // 
            this.словарьToolStripMenuItem.Name = "словарьToolStripMenuItem";
            this.словарьToolStripMenuItem.Size = new System.Drawing.Size(109, 31);
            this.словарьToolStripMenuItem.Text = "Словарь";
            this.словарьToolStripMenuItem.Click += new System.EventHandler(this.словарьToolStripMenuItem_Click);
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(154, 31);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            this.калькуляторToolStripMenuItem.Click += new System.EventHandler(this.калькуляторToolStripMenuItem_Click);
            // 
            // вопросыToolStripMenuItem
            // 
            this.вопросыToolStripMenuItem.Name = "вопросыToolStripMenuItem";
            this.вопросыToolStripMenuItem.Size = new System.Drawing.Size(117, 31);
            this.вопросыToolStripMenuItem.Text = "Вопросы";
            this.вопросыToolStripMenuItem.Click += new System.EventHandler(this.вопросыToolStripMenuItem_Click);
            // 
            // orderListTableAdapter
            // 
            this.orderListTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 29);
            this.textBox1.TabIndex = 84;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ListOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handicraftBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оНасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вопросыToolStripMenuItem;
        private HandicraftBoxDataSet handicraftBoxDataSet;
        private System.Windows.Forms.BindingSource orderListBindingSource;
        private HandicraftBoxDataSetTableAdapters.OrderListTableAdapter orderListTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderListBindingSource1;
    }
}