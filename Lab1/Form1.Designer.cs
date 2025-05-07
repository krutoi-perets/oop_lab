namespace Lab1
{
    partial class Form1
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
            this.enter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameShow = new System.Windows.Forms.Button();
            this.priceHex = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.avgtimeInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.yearInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.massInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ratingInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.phonenumberInput = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgtimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingInput)).BeginInit();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(355, 75);
            this.enter.Margin = new System.Windows.Forms.Padding(2);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(161, 37);
            this.enter.TabIndex = 15;
            this.enter.Text = "Создать";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
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
            this.groupBox1.Controls.Add(this.enter);
            this.groupBox1.Location = new System.Drawing.Point(2, 326);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(876, 120);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод информации";
            // 
            // nameShow
            // 
            this.nameShow.Location = new System.Drawing.Point(223, 242);
            this.nameShow.Name = "nameShow";
            this.nameShow.Size = new System.Drawing.Size(145, 51);
            this.nameShow.TabIndex = 22;
            this.nameShow.Text = "Вывести название фирмы";
            this.nameShow.UseVisualStyleBackColor = true;
            this.nameShow.Click += new System.EventHandler(this.nameShow_Click);
            // 
            // priceHex
            // 
            this.priceHex.Location = new System.Drawing.Point(508, 242);
            this.priceHex.Name = "priceHex";
            this.priceHex.Size = new System.Drawing.Size(173, 51);
            this.priceHex.TabIndex = 21;
            this.priceHex.Text = "Вывести в шестнадцатиричном представлении";
            this.priceHex.UseVisualStyleBackColor = true;
            this.priceHex.Click += new System.EventHandler(this.priceHex_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(693, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Количество объектов";
            // 
            // objCount
            // 
            this.objCount.Location = new System.Drawing.Point(816, 301);
            this.objCount.Name = "objCount";
            this.objCount.ReadOnly = true;
            this.objCount.Size = new System.Drawing.Size(52, 20);
            this.objCount.TabIndex = 18;
            this.objCount.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(56, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(774, 59);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Цена за километр";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Ср. время доставки";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Год основания";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Масса";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Рейтинг";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Номер телефона";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название фирмы";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(10, 48);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Цена за километр";
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(158, 49);
            this.priceInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(92, 20);
            this.priceInput.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Среднее время";
            // 
            // avgtimeInput
            // 
            this.avgtimeInput.DecimalPlaces = 2;
            this.avgtimeInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.avgtimeInput.Location = new System.Drawing.Point(284, 50);
            this.avgtimeInput.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.avgtimeInput.Name = "avgtimeInput";
            this.avgtimeInput.Size = new System.Drawing.Size(96, 20);
            this.avgtimeInput.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Год основания";
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(407, 50);
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
            this.yearInput.Size = new System.Drawing.Size(79, 20);
            this.yearInput.TabIndex = 23;
            this.yearInput.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Масса";
            // 
            // massInput
            // 
            this.massInput.DecimalPlaces = 1;
            this.massInput.Location = new System.Drawing.Point(516, 48);
            this.massInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.massInput.Name = "massInput";
            this.massInput.Size = new System.Drawing.Size(90, 20);
            this.massInput.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Рейтинг";
            // 
            // ratingInput
            // 
            this.ratingInput.DecimalPlaces = 1;
            this.ratingInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ratingInput.Location = new System.Drawing.Point(656, 48);
            this.ratingInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ratingInput.Name = "ratingInput";
            this.ratingInput.Size = new System.Drawing.Size(71, 20);
            this.ratingInput.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(760, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Номер телефона";
            // 
            // phonenumberInput
            // 
            this.phonenumberInput.Location = new System.Drawing.Point(760, 49);
            this.phonenumberInput.Name = "phonenumberInput";
            this.phonenumberInput.Size = new System.Drawing.Size(106, 20);
            this.phonenumberInput.TabIndex = 29;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(331, 93);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(200, 13);
            this.info.TabIndex = 23;
            this.info.Text = "Здесь будет выводиться информация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 447);
            this.Controls.Add(this.info);
            this.Controls.Add(this.priceHex);
            this.Controls.Add(this.nameShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.objCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgtimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button priceHex;
        private System.Windows.Forms.Button nameShow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox objCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
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
        private System.Windows.Forms.Label info;
    }
}

