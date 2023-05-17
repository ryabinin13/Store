
namespace Store
{
    partial class AddForm
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
            this.comboBoxCategoryForAdd = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownCostForAdd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAreaForAdd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIdForAdd = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerForAdd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostForAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaForAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdForAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategoryForAdd
            // 
            this.comboBoxCategoryForAdd.FormattingEnabled = true;
            this.comboBoxCategoryForAdd.Items.AddRange(new object[] {
            "еда",
            "для дома",
            "книги"});
            this.comboBoxCategoryForAdd.Location = new System.Drawing.Point(230, 267);
            this.comboBoxCategoryForAdd.Name = "comboBoxCategoryForAdd";
            this.comboBoxCategoryForAdd.Size = new System.Drawing.Size(198, 21);
            this.comboBoxCategoryForAdd.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(61, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Категория";
            // 
            // numericUpDownCostForAdd
            // 
            this.numericUpDownCostForAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCostForAdd.Location = new System.Drawing.Point(230, 216);
            this.numericUpDownCostForAdd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCostForAdd.Name = "numericUpDownCostForAdd";
            this.numericUpDownCostForAdd.Size = new System.Drawing.Size(198, 22);
            this.numericUpDownCostForAdd.TabIndex = 53;
            this.numericUpDownCostForAdd.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownAreaForAdd
            // 
            this.numericUpDownAreaForAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAreaForAdd.Location = new System.Drawing.Point(230, 137);
            this.numericUpDownAreaForAdd.Name = "numericUpDownAreaForAdd";
            this.numericUpDownAreaForAdd.Size = new System.Drawing.Size(196, 22);
            this.numericUpDownAreaForAdd.TabIndex = 52;
            this.numericUpDownAreaForAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownIdForAdd
            // 
            this.numericUpDownIdForAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownIdForAdd.Location = new System.Drawing.Point(230, 64);
            this.numericUpDownIdForAdd.Name = "numericUpDownIdForAdd";
            this.numericUpDownIdForAdd.Size = new System.Drawing.Size(198, 22);
            this.numericUpDownIdForAdd.TabIndex = 51;
            this.numericUpDownIdForAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerForAdd
            // 
            this.dateTimePickerForAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerForAdd.Location = new System.Drawing.Point(230, 180);
            this.dateTimePickerForAdd.Name = "dateTimePickerForAdd";
            this.dateTimePickerForAdd.Size = new System.Drawing.Size(195, 22);
            this.dateTimePickerForAdd.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(59, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Стоимость в день";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(55, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Дата поступления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(59, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Площадь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Id товара";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(230, 96);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 22);
            this.textBoxName.TabIndex = 44;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(204, 348);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(211, 60);
            this.buttonAdd.TabIndex = 56;
            this.buttonAdd.Text = "Принять товар";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxCategoryForAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDownCostForAdd);
            this.Controls.Add(this.numericUpDownAreaForAdd);
            this.Controls.Add(this.numericUpDownIdForAdd);
            this.Controls.Add(this.dateTimePickerForAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostForAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAreaForAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdForAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategoryForAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownCostForAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownAreaForAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownIdForAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerForAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
    }
}