namespace Box
{
    partial class EditMaterials
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
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(308, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(398, 26);
            this.label13.TabIndex = 132;
            this.label13.Text = "Редакторивание данных материала";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.comboBox1.Location = new System.Drawing.Point(653, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 31);
            this.comboBox1.TabIndex = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(515, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 127;
            this.label9.Text = "Тип упаковки:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 126;
            this.label8.Text = "Количество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 122;
            this.label4.Text = "Стоимость:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 121;
            this.label3.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 120;
            this.label2.Text = "Артикул:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 39);
            this.button2.TabIndex = 118;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 39);
            this.button1.TabIndex = 117;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(143, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 32);
            this.textBox3.TabIndex = 111;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(143, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 32);
            this.textBox2.TabIndex = 110;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(143, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(135, 32);
            this.textBox1.TabIndex = 109;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(143, 208);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(141, 32);
            this.maskedTextBox1.TabIndex = 108;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.comboBox2.Location = new System.Drawing.Point(653, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(290, 31);
            this.comboBox2.TabIndex = 133;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.comboBox3.Location = new System.Drawing.Point(653, 106);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(290, 31);
            this.comboBox3.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(516, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 135;
            this.label1.Text = "Тип продукта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(536, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 136;
            this.label5.Text = "Категория:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(34, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 137;
            this.label6.Text = "Описание:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(143, 251);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 96);
            this.richTextBox1.TabIndex = 138;
            this.richTextBox1.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(573, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 139;
            this.label7.Text = "Размер:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox2.Location = new System.Drawing.Point(653, 208);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(218, 32);
            this.maskedTextBox2.TabIndex = 140;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 404);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditMaterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditMaterials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}