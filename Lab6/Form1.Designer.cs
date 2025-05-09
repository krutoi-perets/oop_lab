namespace Lab6
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
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.findMinButton = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.showTimeButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(29, 12);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(96, 20);
            this.textBoxMin.TabIndex = 0;
            // 
            // findMinButton
            // 
            this.findMinButton.Location = new System.Drawing.Point(142, 10);
            this.findMinButton.Name = "findMinButton";
            this.findMinButton.Size = new System.Drawing.Size(100, 23);
            this.findMinButton.TabIndex = 1;
            this.findMinButton.Text = "Найти минимум";
            this.findMinButton.UseVisualStyleBackColor = true;
            this.findMinButton.Click += new System.EventHandler(this.findMinButton_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(29, 51);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(96, 20);
            this.textBoxTime.TabIndex = 2;
            // 
            // showTimeButton
            // 
            this.showTimeButton.Location = new System.Drawing.Point(142, 51);
            this.showTimeButton.Name = "showTimeButton";
            this.showTimeButton.Size = new System.Drawing.Size(100, 23);
            this.showTimeButton.TabIndex = 3;
            this.showTimeButton.Text = "Показать время";
            this.showTimeButton.UseVisualStyleBackColor = true;
            this.showTimeButton.Click += new System.EventHandler(this.showTimeButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 136);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(90, 107);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 167);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.showTimeButton);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.findMinButton);
            this.Controls.Add(this.textBoxMin);
            this.Name = "Form1";
            this.Text = "ЛР 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Button findMinButton;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button showTimeButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button loadButton;
    }
}

