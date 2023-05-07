
namespace Store
{
    partial class StoreForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAmountOfMoney = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAmountOfMoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.dateTimePickerForAdd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerForCalculate = new System.Windows.Forms.DateTimePicker();
            this.listBoxPrint = new System.Windows.Forms.ListBox();
            this.numericUpDownIdForAdd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAreaForAdd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCostForAdd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIdForSIzeMoney = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIdForFind = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIdForDelete = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonFileWrite = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxCategoryForAdd = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonGroupByCategory = new System.Windows.Forms.Button();
            this.buttonSearchName = new System.Windows.Forms.Button();
            this.textBoxForFindName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdForAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaForAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostForAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdForSIzeMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdForFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdForDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.Location = new System.Drawing.Point(1020, 9);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(168, 50);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "Печать всех товаров";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(38, 9);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(171, 50);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Принять товар";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(181, 110);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 26);
            this.textBoxName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Площадь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата поступления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Стоимость в день";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(420, 9);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(183, 60);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Найти товар по Id";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id товара";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(586, 473);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(176, 74);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Отправить товар";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(560, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Id товара";
            // 
            // buttonAmountOfMoney
            // 
            this.buttonAmountOfMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAmountOfMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAmountOfMoney.Location = new System.Drawing.Point(38, 391);
            this.buttonAmountOfMoney.Name = "buttonAmountOfMoney";
            this.buttonAmountOfMoney.Size = new System.Drawing.Size(176, 74);
            this.buttonAmountOfMoney.TabIndex = 20;
            this.buttonAmountOfMoney.Text = "Узнать размер выручки за период";
            this.buttonAmountOfMoney.UseVisualStyleBackColor = false;
            this.buttonAmountOfMoney.Click += new System.EventHandler(this.buttonAmountOfMoney_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "до какого числа хранить";
            // 
            // textBoxAmountOfMoney
            // 
            this.textBoxAmountOfMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAmountOfMoney.Location = new System.Drawing.Point(245, 556);
            this.textBoxAmountOfMoney.Multiline = true;
            this.textBoxAmountOfMoney.Name = "textBoxAmountOfMoney";
            this.textBoxAmountOfMoney.Size = new System.Drawing.Size(151, 25);
            this.textBoxAmountOfMoney.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(427, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Id товара";
            // 
            // buttonFile
            // 
            this.buttonFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFile.Location = new System.Drawing.Point(476, 180);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(350, 90);
            this.buttonFile.TabIndex = 26;
            this.buttonFile.Text = "Считать с файла";
            this.buttonFile.UseVisualStyleBackColor = false;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // dateTimePickerForAdd
            // 
            this.dateTimePickerForAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerForAdd.Location = new System.Drawing.Point(181, 194);
            this.dateTimePickerForAdd.Name = "dateTimePickerForAdd";
            this.dateTimePickerForAdd.Size = new System.Drawing.Size(195, 26);
            this.dateTimePickerForAdd.TabIndex = 27;
            // 
            // dateTimePickerForCalculate
            // 
            this.dateTimePickerForCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerForCalculate.Location = new System.Drawing.Point(245, 519);
            this.dateTimePickerForCalculate.Name = "dateTimePickerForCalculate";
            this.dateTimePickerForCalculate.Size = new System.Drawing.Size(187, 26);
            this.dateTimePickerForCalculate.TabIndex = 28;
            // 
            // listBoxPrint
            // 
            this.listBoxPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPrint.FormattingEnabled = true;
            this.listBoxPrint.ItemHeight = 20;
            this.listBoxPrint.Location = new System.Drawing.Point(962, 109);
            this.listBoxPrint.Name = "listBoxPrint";
            this.listBoxPrint.Size = new System.Drawing.Size(277, 344);
            this.listBoxPrint.TabIndex = 29;
            // 
            // numericUpDownIdForAdd
            // 
            this.numericUpDownIdForAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownIdForAdd.Location = new System.Drawing.Point(181, 78);
            this.numericUpDownIdForAdd.Name = "numericUpDownIdForAdd";
            this.numericUpDownIdForAdd.Size = new System.Drawing.Size(198, 26);
            this.numericUpDownIdForAdd.TabIndex = 30;
            this.numericUpDownIdForAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownAreaForAdd
            // 
            this.numericUpDownAreaForAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAreaForAdd.Location = new System.Drawing.Point(181, 151);
            this.numericUpDownAreaForAdd.Name = "numericUpDownAreaForAdd";
            this.numericUpDownAreaForAdd.Size = new System.Drawing.Size(196, 26);
            this.numericUpDownAreaForAdd.TabIndex = 31;
            this.numericUpDownAreaForAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCostForAdd
            // 
            this.numericUpDownCostForAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCostForAdd.Location = new System.Drawing.Point(181, 230);
            this.numericUpDownCostForAdd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCostForAdd.Name = "numericUpDownCostForAdd";
            this.numericUpDownCostForAdd.Size = new System.Drawing.Size(198, 26);
            this.numericUpDownCostForAdd.TabIndex = 32;
            this.numericUpDownCostForAdd.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownIdForSIzeMoney
            // 
            this.numericUpDownIdForSIzeMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownIdForSIzeMoney.Location = new System.Drawing.Point(245, 478);
            this.numericUpDownIdForSIzeMoney.Name = "numericUpDownIdForSIzeMoney";
            this.numericUpDownIdForSIzeMoney.Size = new System.Drawing.Size(188, 26);
            this.numericUpDownIdForSIzeMoney.TabIndex = 33;
            this.numericUpDownIdForSIzeMoney.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownIdForFind
            // 
            this.numericUpDownIdForFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownIdForFind.Location = new System.Drawing.Point(529, 90);
            this.numericUpDownIdForFind.Name = "numericUpDownIdForFind";
            this.numericUpDownIdForFind.Size = new System.Drawing.Size(63, 26);
            this.numericUpDownIdForFind.TabIndex = 34;
            this.numericUpDownIdForFind.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownIdForDelete
            // 
            this.numericUpDownIdForDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownIdForDelete.Location = new System.Drawing.Point(675, 556);
            this.numericUpDownIdForDelete.Name = "numericUpDownIdForDelete";
            this.numericUpDownIdForDelete.Size = new System.Drawing.Size(140, 26);
            this.numericUpDownIdForDelete.TabIndex = 35;
            this.numericUpDownIdForDelete.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(16, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Результат";
            // 
            // buttonFileWrite
            // 
            this.buttonFileWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonFileWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFileWrite.Location = new System.Drawing.Point(476, 282);
            this.buttonFileWrite.Name = "buttonFileWrite";
            this.buttonFileWrite.Size = new System.Drawing.Size(350, 89);
            this.buttonFileWrite.TabIndex = 38;
            this.buttonFileWrite.Text = "Сохранить изменения";
            this.buttonFileWrite.UseVisualStyleBackColor = false;
            this.buttonFileWrite.Click += new System.EventHandler(this.buttonFileWrite_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Категория";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(959, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 41;
            this.label12.Text = "Id товара";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1076, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Имя";
            // 
            // comboBoxCategoryForAdd
            // 
            this.comboBoxCategoryForAdd.FormattingEnabled = true;
            this.comboBoxCategoryForAdd.Items.AddRange(new object[] {
            "еда",
            "для дома",
            "книги"});
            this.comboBoxCategoryForAdd.Location = new System.Drawing.Point(181, 281);
            this.comboBoxCategoryForAdd.Name = "comboBoxCategoryForAdd";
            this.comboBoxCategoryForAdd.Size = new System.Drawing.Size(198, 25);
            this.comboBoxCategoryForAdd.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(1154, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 20);
            this.label14.TabIndex = 44;
            this.label14.Text = "Категория";
            // 
            // buttonGroupByCategory
            // 
            this.buttonGroupByCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonGroupByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroupByCategory.Location = new System.Drawing.Point(1020, 495);
            this.buttonGroupByCategory.Name = "buttonGroupByCategory";
            this.buttonGroupByCategory.Size = new System.Drawing.Size(182, 81);
            this.buttonGroupByCategory.TabIndex = 45;
            this.buttonGroupByCategory.Text = "Сгруппировать товары по категории";
            this.buttonGroupByCategory.UseVisualStyleBackColor = false;
            this.buttonGroupByCategory.Click += new System.EventHandler(this.buttonGroupByCategory_Click);
            // 
            // buttonSearchName
            // 
            this.buttonSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchName.Location = new System.Drawing.Point(690, 12);
            this.buttonSearchName.Name = "buttonSearchName";
            this.buttonSearchName.Size = new System.Drawing.Size(183, 60);
            this.buttonSearchName.TabIndex = 46;
            this.buttonSearchName.Text = "Найти товар по имени";
            this.buttonSearchName.UseVisualStyleBackColor = false;
            this.buttonSearchName.Click += new System.EventHandler(this.buttonSearchName_Click);
            // 
            // textBoxForFindName
            // 
            this.textBoxForFindName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForFindName.Location = new System.Drawing.Point(690, 90);
            this.textBoxForFindName.Name = "textBoxForFindName";
            this.textBoxForFindName.Size = new System.Drawing.Size(183, 26);
            this.textBoxForFindName.TabIndex = 47;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1294, 599);
            this.Controls.Add(this.textBoxForFindName);
            this.Controls.Add(this.buttonSearchName);
            this.Controls.Add(this.buttonGroupByCategory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxCategoryForAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonFileWrite);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownIdForDelete);
            this.Controls.Add(this.numericUpDownIdForFind);
            this.Controls.Add(this.numericUpDownIdForSIzeMoney);
            this.Controls.Add(this.numericUpDownCostForAdd);
            this.Controls.Add(this.numericUpDownAreaForAdd);
            this.Controls.Add(this.numericUpDownIdForAdd);
            this.Controls.Add(this.listBoxPrint);
            this.Controls.Add(this.dateTimePickerForCalculate);
            this.Controls.Add(this.dateTimePickerForAdd);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAmountOfMoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAmountOfMoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonPrint);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximumSize = new System.Drawing.Size(2331, 2000);
            this.MinimumSize = new System.Drawing.Size(1085, 549);
            this.Name = "StoreForm";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdForAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaForAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostForAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdForSIzeMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdForFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdForDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAmountOfMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAmountOfMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.DateTimePicker dateTimePickerForAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerForCalculate;
        private System.Windows.Forms.ListBox listBoxPrint;
        private System.Windows.Forms.NumericUpDown numericUpDownIdForAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownAreaForAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownCostForAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownIdForSIzeMoney;
        private System.Windows.Forms.NumericUpDown numericUpDownIdForFind;
        private System.Windows.Forms.NumericUpDown numericUpDownIdForDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonFileWrite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxCategoryForAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonGroupByCategory;
        private System.Windows.Forms.Button buttonSearchName;
        private System.Windows.Forms.TextBox textBoxForFindName;
    }
}

