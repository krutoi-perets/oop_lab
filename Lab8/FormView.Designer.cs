namespace Lab2
{
    partial class FormView
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
            this.create = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.phonenumberInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ratingInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.massInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.yearInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.avgtimeInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.objCount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgtimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(357, 92);
            this.create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(215, 46);
            this.create.TabIndex = 15;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.phonenumberInput);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ratingInput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.massInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.yearInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.avgtimeInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priceInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.create);
            this.groupBox1.Location = new System.Drawing.Point(3, 401);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1168, 148);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод информации";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(655, 91);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(193, 46);
            this.delete.TabIndex = 30;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // phonenumberInput
            // 
            this.phonenumberInput.Location = new System.Drawing.Point(875, 58);
            this.phonenumberInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phonenumberInput.Name = "phonenumberInput";
            this.phonenumberInput.Size = new System.Drawing.Size(125, 22);
            this.phonenumberInput.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(881, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Номер телефона";
            // 
            // ratingInput
            // 
            this.ratingInput.DecimalPlaces = 1;
            this.ratingInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ratingInput.Location = new System.Drawing.Point(777, 58);
            this.ratingInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ratingInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ratingInput.Name = "ratingInput";
            this.ratingInput.Size = new System.Drawing.Size(80, 22);
            this.ratingInput.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(787, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Рейтинг";
            // 
            // massInput
            // 
            this.massInput.DecimalPlaces = 1;
            this.massInput.Location = new System.Drawing.Point(648, 58);
            this.massInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.massInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.massInput.Name = "massInput";
            this.massInput.Size = new System.Drawing.Size(105, 22);
            this.massInput.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Масса";
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(503, 62);
            this.yearInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearInput.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.yearInput.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(91, 22);
            this.yearInput.TabIndex = 23;
            this.yearInput.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Год основания";
            // 
            // avgtimeInput
            // 
            this.avgtimeInput.DecimalPlaces = 2;
            this.avgtimeInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.avgtimeInput.Location = new System.Drawing.Point(339, 62);
            this.avgtimeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avgtimeInput.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.avgtimeInput.Name = "avgtimeInput";
            this.avgtimeInput.Size = new System.Drawing.Size(113, 22);
            this.avgtimeInput.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Среднее время";
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(171, 59);
            this.priceInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(108, 22);
            this.priceInput.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Цена за километр";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(13, 59);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(132, 22);
            this.nameInput.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название фирмы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(924, 374);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Количество объектов";
            // 
            // objCount
            // 
            this.objCount.Location = new System.Drawing.Point(1088, 370);
            this.objCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.objCount.Name = "objCount";
            this.objCount.ReadOnly = true;
            this.objCount.Size = new System.Drawing.Size(68, 22);
            this.objCount.TabIndex = 18;
            this.objCount.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(20, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1137, 340);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Название";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Цена за километр";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Ср. время доставки";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Год основания";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Масса перевезенного груза";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Рейтинг";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Номер телефона";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Метод доставки";
            this.Column8.Items.AddRange(new object[] {
            "По воздуху",
            "По воде",
            "По земле"});
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column10
            // 
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "Метод расчета эффективности";
            this.Column10.Items.AddRange(new object[] {
            "По массе и времени",
            "По возрасту и цене",
            "Сбалансированная"});
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column10.Width = 110;
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Эффективность";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(556, 362);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 28);
            this.save_button.TabIndex = 20;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 550);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.objCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormView";
            this.Text = "Лабораторная работа 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgtimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox objCount;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown priceInput;
        private System.Windows.Forms.NumericUpDown avgtimeInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phonenumberInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ratingInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown massInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown yearInput;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column8;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

