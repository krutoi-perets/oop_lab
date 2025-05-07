namespace Lab2
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
            this.create = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generator = new System.Windows.Forms.Button();
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.showAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgtimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(211, 92);
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
            this.groupBox1.Controls.Add(this.generator);
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
            // generator
            // 
            this.generator.Location = new System.Drawing.Point(493, 92);
            this.generator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(215, 46);
            this.generator.TabIndex = 31;
            this.generator.Text = "10000 элементов";
            this.generator.UseVisualStyleBackColor = true;
            this.generator.Click += new System.EventHandler(this.generator_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(777, 92);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(193, 46);
            this.delete.TabIndex = 30;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // phonenumberInput
            // 
            this.phonenumberInput.Location = new System.Drawing.Point(1013, 60);
            this.phonenumberInput.Margin = new System.Windows.Forms.Padding(4);
            this.phonenumberInput.Name = "phonenumberInput";
            this.phonenumberInput.Size = new System.Drawing.Size(140, 22);
            this.phonenumberInput.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1013, 39);
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
            this.ratingInput.Location = new System.Drawing.Point(875, 59);
            this.ratingInput.Margin = new System.Windows.Forms.Padding(4);
            this.ratingInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ratingInput.Name = "ratingInput";
            this.ratingInput.Size = new System.Drawing.Size(95, 22);
            this.ratingInput.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(871, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Рейтинг";
            // 
            // massInput
            // 
            this.massInput.DecimalPlaces = 1;
            this.massInput.Location = new System.Drawing.Point(688, 59);
            this.massInput.Margin = new System.Windows.Forms.Padding(4);
            this.massInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.massInput.Name = "massInput";
            this.massInput.Size = new System.Drawing.Size(120, 22);
            this.massInput.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Масса";
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(543, 62);
            this.yearInput.Margin = new System.Windows.Forms.Padding(4);
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
            this.yearInput.Size = new System.Drawing.Size(105, 22);
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
            this.label4.Location = new System.Drawing.Point(539, 42);
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
            this.avgtimeInput.Location = new System.Drawing.Point(379, 62);
            this.avgtimeInput.Margin = new System.Windows.Forms.Padding(4);
            this.avgtimeInput.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.avgtimeInput.Name = "avgtimeInput";
            this.avgtimeInput.Size = new System.Drawing.Size(128, 22);
            this.avgtimeInput.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Среднее время";
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(211, 60);
            this.priceInput.Margin = new System.Windows.Forms.Padding(4);
            this.priceInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(123, 22);
            this.priceInput.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Цена за километр";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(13, 59);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4);
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
            this.objCount.Margin = new System.Windows.Forms.Padding(4);
            this.objCount.Name = "objCount";
            this.objCount.ReadOnly = true;
            this.objCount.Size = new System.Drawing.Size(68, 22);
            this.objCount.TabIndex = 18;
            this.objCount.Text = "0";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(280, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(647, 112);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(476, 286);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(235, 39);
            this.showAll.TabIndex = 20;
            this.showAll.Text = "Вывести все";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 550);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.objCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgtimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button generator;
    }
}

