namespace Box
{
    partial class ListMasterClass
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
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handicraftBoxDataSet1 = new Box.HandicraftBoxDataSet();
            this.handicraftBoxDataSet = new Box.HandicraftBoxDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.masterClassTableAdapter = new Box.HandicraftBoxDataSetTableAdapters.MasterClassTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handicraftBoxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handicraftBoxDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(799, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 43);
            this.button5.TabIndex = 104;
            this.button5.Text = "Назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(414, 557);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 46);
            this.button3.TabIndex = 103;
            this.button3.Text = "Открыть ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(295, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 29);
            this.textBox1.TabIndex = 102;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 21);
            this.label2.TabIndex = 101;
            this.label2.Text = "Поиск по названию документа:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.masterClassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 342);
            this.dataGridView1.TabIndex = 100;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 54;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "Назване файла";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.Width = 138;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 119;
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            this.extensionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
            this.extensionDataGridViewTextBoxColumn.HeaderText = "Разрешение";
            this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            this.extensionDataGridViewTextBoxColumn.Width = 130;
            // 
            // masterClassBindingSource
            // 
            this.masterClassBindingSource.DataMember = "MasterClass";
            this.masterClassBindingSource.DataSource = this.handicraftBoxDataSet1;
            // 
            // handicraftBoxDataSet1
            // 
            this.handicraftBoxDataSet1.DataSetName = "HandicraftBoxDataSet";
            this.handicraftBoxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // handicraftBoxDataSet
            // 
            this.handicraftBoxDataSet.DataSetName = "HandicraftBoxDataSet";
            this.handicraftBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(799, 557);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 46);
            this.button4.TabIndex = 99;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(31, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 46);
            this.button2.TabIndex = 98;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(799, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 43);
            this.button1.TabIndex = 97;
            this.button1.Text = "Сбросить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-2, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 42);
            this.panel1.TabIndex = 96;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(285, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 57);
            this.label1.TabIndex = 95;
            this.label1.Text = "Шкатулка рукоделия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // masterClassTableAdapter
            // 
            this.masterClassTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Аппликация",
            "Батик",
            "Бисероплетение",
            "Валяние",
            "Витраж",
            "Выжигание",
            "Вышивание",
            "Вязание",
            "Декупаж",
            "Изонить",
            "Карвинг",
            "Квиллинг",
            "Кружево",
            "Лампворк",
            "Лепка",
            "Мозаика",
            "Оригами",
            "Плетение",
            "Прядение",
            "Резьба",
            "Рисование",
            "Роспись",
            "Скрапбукинг",
            "Ткацкое дело",
            "Ткачество",
            "Флористика",
            "Хохлома",
            "Художественная обработка кожи",
            "Шитьё"});
            this.comboBox1.Location = new System.Drawing.Point(295, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(323, 29);
            this.comboBox1.TabIndex = 105;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(66, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 21);
            this.label3.TabIndex = 106;
            this.label3.Text = "Сортировка по категории:";
            // 
            // ListMasterClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ListMasterClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListMasterClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handicraftBoxDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handicraftBoxDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оНасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вопросыToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private HandicraftBoxDataSet handicraftBoxDataSet;
        private HandicraftBoxDataSet handicraftBoxDataSet1;
        private System.Windows.Forms.BindingSource masterClassBindingSource;
        private HandicraftBoxDataSetTableAdapters.MasterClassTableAdapter masterClassTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}