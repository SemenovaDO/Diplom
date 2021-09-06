namespace Box
{
    partial class ListMaterials
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
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfPackagingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handicraftBoxDataSet = new Box.HandicraftBoxDataSet();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.materialTableAdapter = new Box.HandicraftBoxDataSetTableAdapters.MaterialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handicraftBoxDataSet)).BeginInit();
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
            this.articleDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.typeOfPackagingDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.structureDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 289);
            this.dataGridView1.TabIndex = 69;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.Width = 102;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 109;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 124;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 130;
            // 
            // typeOfPackagingDataGridViewTextBoxColumn
            // 
            this.typeOfPackagingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.typeOfPackagingDataGridViewTextBoxColumn.DataPropertyName = "TypeOfPackaging";
            this.typeOfPackagingDataGridViewTextBoxColumn.HeaderText = "Тип упаковки";
            this.typeOfPackagingDataGridViewTextBoxColumn.Name = "typeOfPackagingDataGridViewTextBoxColumn";
            this.typeOfPackagingDataGridViewTextBoxColumn.Width = 145;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "Тип продукта";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.Width = 145;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 119;
            // 
            // structureDataGridViewTextBoxColumn
            // 
            this.structureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.structureDataGridViewTextBoxColumn.DataPropertyName = "Structure";
            this.structureDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.structureDataGridViewTextBoxColumn.Name = "structureDataGridViewTextBoxColumn";
            this.structureDataGridViewTextBoxColumn.Width = 114;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Размер";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.Width = 92;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.handicraftBoxDataSet;
            // 
            // handicraftBoxDataSet
            // 
            this.handicraftBoxDataSet.DataSetName = "HandicraftBoxDataSet";
            this.handicraftBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Бисер",
            "Бумага",
            "Бусины",
            "Вспомогательные жидкости",
            "Декоративные элементы ",
            "Заготовки/основы",
            "Иглы ",
            "Инструменты для вязания",
            "Каллиграфия",
            "Канваа",
            "Карандаши/фломастеры",
            "Картон",
            "Краски ",
            "Крючки",
            "Ленты/шнуры",
            "Мольберты ",
            "Мулине",
            "Наборы для вышивания",
            "Наборы для скрапбукинга",
            "Наклейки",
            "Наполнител",
            "Нитки",
            "Палитры ",
            "Пастель/мел",
            "Пенал/сумки/тубусы",
            "Пряжа",
            "Пяльцы",
            "Спицы",
            "Станки",
            "Ткани",
            "Украшения",
            "Фартуки",
            "Фурнитура ",
            "Холсты ",
            "Штампинг"});
            this.comboBox3.Location = new System.Drawing.Point(283, 127);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(287, 29);
            this.comboBox3.TabIndex = 67;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(55, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 21);
            this.label4.TabIndex = 65;
            this.label4.Text = "Сортировка по категории:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Акварель",
            "Акрил декоративный",
            "Акрил художественный",
            "Аксессуары для шитья",
            "Аппликации самоклеющиеся",
            "Бисер",
            "Блокатор",
            "Булавка",
            "Бумага",
            "Бусины",
            "Вилка",
            "Гель",
            "Грунт",
            "Гуашь",
            "Гуммиарабик",
            "Декоративные ленты",
            "Декоративные элементы",
            "Держатели для штампов",
            "Дыроколы",
            "Жидкость",
            "Заготовки",
            "Загуститель",
            "Зажимы для шнуров",
            "Замедлитель",
            "Застежки",
            "Игла",
            "Иглы",
            "Игольницы",
            "Инструмент",
            "Инструменты",
            "Инструменты для шитья",
            "Карандаши",
            "Картон",
            "Кисти",
            "Клеевые пистолеты",
            "Клей",
            "Книги",
            "Кнопки",
            "Кольца",
            "Кольцо",
            "Контуры",
            "Концевики для шнуров",
            "Коробка",
            "Красители для ткани",
            "Краски аэрозольные",
            "Краски пальчиковые",
            "Кружево",
            "Крючки",
            "Крючок",
            "Лак",
            "Лента",
            "Линейка",
            "Лупы",
            "Лэмпворк",
            "Люверсы",
            "Магниты",
            "Манекены",
            "Масло",
            "Медиум",
            "Мел",
            "Молнии",
            "Мольберт",
            "Наборы",
            "Наборы инструментов",
            "Наклейки",
            "Наконечник",
            "Наперстки",
            "Наперсток",
            "Наполнители",
            "Нашивки",
            "Нитка",
            "Нитки",
            "Ножи для вырубки и формы для тиснения",
            "Ножи и резаки для бумаги",
            "Ножницы",
            "Ножницы фигурные",
            "Органайзер",
            "Органайзеры",
            "Основы ",
            "Пайетки",
            "Палитры",
            "Панель",
            "Папка",
            "Паста",
            "Пастель",
            "Пенал",
            "Пигмент",
            "Планшеты",
            "Подвески",
            "Помпон",
            "Принадлежности для кроя",
            "Пряжа",
            "Пряжки и шлевки",
            "Пуговицы",
            "Разбавитель",
            "Растворитель",
            "Ручка",
            "Светильники",
            "Сиккатив",
            "Спицы",
            "Спреи",
            "Станки",
            "Стразы",
            "Сумка",
            "Счетчик рядов",
            "Темпера",
            "Термоаппликации",
            "Технические ленты",
            "Ткань",
            "Тубус",
            "Тушь",
            "Украшения",
            "Фартуки",
            "Фиксатор",
            "Фломастеры",
            "Фурнитура для бюстгальтеров",
            "Фурнитура для одежды",
            "Фурнитура сумочная",
            "Холсты",
            "Хольнитены",
            "Цветы",
            "Цепочка",
            "Челнок",
            "Чернила",
            "Чехол",
            "Шила",
            "Шкатулки",
            "Шнуры",
            "Шпульки",
            "Штампы",
            "Штемпельные подушечки",
            "Шторная фурнитура",
            "Эбру",
            "Этюдники"});
            this.comboBox2.Location = new System.Drawing.Point(283, 217);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(287, 29);
            this.comboBox2.TabIndex = 68;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 21);
            this.label2.TabIndex = 66;
            this.label2.Text = "Сортировка по типу продукты:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(815, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 29);
            this.button5.TabIndex = 64;
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
            this.button4.TabIndex = 63;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(436, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 46);
            this.button3.TabIndex = 62;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(24, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 46);
            this.button2.TabIndex = 61;
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
            this.button1.TabIndex = 60;
            this.button1.Text = "Сбросить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Без упаковки",
            "В баночке",
            "В блистере",
            "В пакете",
            "В пакете с еврослотом",
            "В тубе",
            "Моток",
            "Моточек",
            "На бобине"});
            this.comboBox1.Location = new System.Drawing.Point(283, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 29);
            this.comboBox1.TabIndex = 59;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Сортировка по типу упаковки:";
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
            this.label1.TabIndex = 57;
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
            this.panel1.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(944, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // ListMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
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
            this.Name = "ListMaterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.BindingSource materialBindingSource;
        private HandicraftBoxDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfPackagingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn structureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
    }
}