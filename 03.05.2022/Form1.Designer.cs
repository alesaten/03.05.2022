namespace _03._05._2022
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
            this.components = new System.ComponentModel.Container();
            this.ChoiceForm_label = new System.Windows.Forms.Label();
            this.ListViewForm_button = new System.Windows.Forms.Button();
            this.TreeViewForm_button = new System.Windows.Forms.Button();
            this.MainForm_timer = new System.Windows.Forms.Timer(this.components);
            this.MainForm_progressBar = new System.Windows.Forms.ProgressBar();
            this.DateTimeMonthCalendar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChoiceForm_label
            // 
            this.ChoiceForm_label.AutoSize = true;
            this.ChoiceForm_label.Location = new System.Drawing.Point(52, 9);
            this.ChoiceForm_label.Name = "ChoiceForm_label";
            this.ChoiceForm_label.Size = new System.Drawing.Size(96, 13);
            this.ChoiceForm_label.TabIndex = 0;
            this.ChoiceForm_label.Text = "Выберите форму:";
            // 
            // ListViewForm_button
            // 
            this.ListViewForm_button.Location = new System.Drawing.Point(12, 40);
            this.ListViewForm_button.Name = "ListViewForm_button";
            this.ListViewForm_button.Size = new System.Drawing.Size(177, 23);
            this.ListViewForm_button.TabIndex = 1;
            this.ListViewForm_button.Text = "Страны";
            this.ListViewForm_button.UseVisualStyleBackColor = true;
            // 
            // TreeViewForm_button
            // 
            this.TreeViewForm_button.Location = new System.Drawing.Point(12, 69);
            this.TreeViewForm_button.Name = "TreeViewForm_button";
            this.TreeViewForm_button.Size = new System.Drawing.Size(177, 23);
            this.TreeViewForm_button.TabIndex = 2;
            this.TreeViewForm_button.Text = "Континенты";
            this.TreeViewForm_button.UseVisualStyleBackColor = true;
            // 
            // MainForm_progressBar
            // 
            this.MainForm_progressBar.Location = new System.Drawing.Point(12, 144);
            this.MainForm_progressBar.Name = "MainForm_progressBar";
            this.MainForm_progressBar.Size = new System.Drawing.Size(177, 23);
            this.MainForm_progressBar.TabIndex = 3;
            // 
            // DateTimeMonthCalendar_button
            // 
            this.DateTimeMonthCalendar_button.Location = new System.Drawing.Point(12, 98);
            this.DateTimeMonthCalendar_button.Name = "DateTimeMonthCalendar_button";
            this.DateTimeMonthCalendar_button.Size = new System.Drawing.Size(177, 23);
            this.DateTimeMonthCalendar_button.TabIndex = 4;
            this.DateTimeMonthCalendar_button.Text = "Работа с датами";
            this.DateTimeMonthCalendar_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 179);
            this.Controls.Add(this.DateTimeMonthCalendar_button);
            this.Controls.Add(this.MainForm_progressBar);
            this.Controls.Add(this.TreeViewForm_button);
            this.Controls.Add(this.ListViewForm_button);
            this.Controls.Add(this.ChoiceForm_label);
            this.Name = "Form1";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChoiceForm_label;
        private System.Windows.Forms.Button ListViewForm_button;
        private System.Windows.Forms.Button TreeViewForm_button;
        private System.Windows.Forms.Timer MainForm_timer;
        private System.Windows.Forms.ProgressBar MainForm_progressBar;
        private System.Windows.Forms.Button DateTimeMonthCalendar_button;
    }
}

