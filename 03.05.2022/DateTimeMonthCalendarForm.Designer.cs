namespace _03._05._2022
{
    partial class DateTimeMonthCalendarForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_panel = new System.Windows.Forms.Panel();
            this.ChosenDate_label = new System.Windows.Forms.Label();
            this.TimeFormat_radioButton = new System.Windows.Forms.RadioButton();
            this.ShortFormat_radioButton = new System.Windows.Forms.RadioButton();
            this.LongFormat_radioButton = new System.Windows.Forms.RadioButton();
            this.ChoiceFormat_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePicker_radioButton = new System.Windows.Forms.RadioButton();
            this.MonthCalendar_radioButton = new System.Windows.Forms.RadioButton();
            this.MonthCalendar_panel = new System.Windows.Forms.Panel();
            this.BoldDateYear_textBox = new System.Windows.Forms.TextBox();
            this.BoldDateMonth_textBox = new System.Windows.Forms.TextBox();
            this.BoldDateYear_label = new System.Windows.Forms.Label();
            this.BoldDateMonth_label = new System.Windows.Forms.Label();
            this.BoldDateDay_textBox = new System.Windows.Forms.TextBox();
            this.BoldDate_button = new System.Windows.Forms.Button();
            this.BoldDateDay_label = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.DateTimePicker_panel.SuspendLayout();
            this.MonthCalendar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 9);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // DateTimePicker_panel
            // 
            this.DateTimePicker_panel.Controls.Add(this.ChosenDate_label);
            this.DateTimePicker_panel.Controls.Add(this.TimeFormat_radioButton);
            this.DateTimePicker_panel.Controls.Add(this.ShortFormat_radioButton);
            this.DateTimePicker_panel.Controls.Add(this.LongFormat_radioButton);
            this.DateTimePicker_panel.Controls.Add(this.ChoiceFormat_label);
            this.DateTimePicker_panel.Controls.Add(this.dateTimePicker);
            this.DateTimePicker_panel.Location = new System.Drawing.Point(218, 44);
            this.DateTimePicker_panel.Name = "DateTimePicker_panel";
            this.DateTimePicker_panel.Size = new System.Drawing.Size(174, 359);
            this.DateTimePicker_panel.TabIndex = 1;
            // 
            // ChosenDate_label
            // 
            this.ChosenDate_label.AutoSize = true;
            this.ChosenDate_label.Location = new System.Drawing.Point(9, 332);
            this.ChosenDate_label.Name = "ChosenDate_label";
            this.ChosenDate_label.Size = new System.Drawing.Size(0, 13);
            this.ChosenDate_label.TabIndex = 5;
            // 
            // TimeFormat_radioButton
            // 
            this.TimeFormat_radioButton.AutoSize = true;
            this.TimeFormat_radioButton.Location = new System.Drawing.Point(12, 249);
            this.TimeFormat_radioButton.Name = "TimeFormat_radioButton";
            this.TimeFormat_radioButton.Size = new System.Drawing.Size(58, 17);
            this.TimeFormat_radioButton.TabIndex = 4;
            this.TimeFormat_radioButton.TabStop = true;
            this.TimeFormat_radioButton.Text = "Время";
            this.TimeFormat_radioButton.UseVisualStyleBackColor = true;
            // 
            // ShortFormat_radioButton
            // 
            this.ShortFormat_radioButton.AutoSize = true;
            this.ShortFormat_radioButton.Location = new System.Drawing.Point(12, 228);
            this.ShortFormat_radioButton.Name = "ShortFormat_radioButton";
            this.ShortFormat_radioButton.Size = new System.Drawing.Size(121, 17);
            this.ShortFormat_radioButton.TabIndex = 3;
            this.ShortFormat_radioButton.TabStop = true;
            this.ShortFormat_radioButton.Text = "Сокращённая дата";
            this.ShortFormat_radioButton.UseVisualStyleBackColor = true;
            // 
            // LongFormat_radioButton
            // 
            this.LongFormat_radioButton.AutoSize = true;
            this.LongFormat_radioButton.Location = new System.Drawing.Point(12, 209);
            this.LongFormat_radioButton.Name = "LongFormat_radioButton";
            this.LongFormat_radioButton.Size = new System.Drawing.Size(89, 17);
            this.LongFormat_radioButton.TabIndex = 2;
            this.LongFormat_radioButton.TabStop = true;
            this.LongFormat_radioButton.Text = "Полная дата";
            this.LongFormat_radioButton.UseVisualStyleBackColor = true;
            // 
            // ChoiceFormat_label
            // 
            this.ChoiceFormat_label.AutoSize = true;
            this.ChoiceFormat_label.Location = new System.Drawing.Point(9, 193);
            this.ChoiceFormat_label.Name = "ChoiceFormat_label";
            this.ChoiceFormat_label.Size = new System.Drawing.Size(102, 13);
            this.ChoiceFormat_label.TabIndex = 1;
            this.ChoiceFormat_label.Text = "Выберите формат:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите вид:";
            // 
            // DateTimePicker_radioButton
            // 
            this.DateTimePicker_radioButton.AutoSize = true;
            this.DateTimePicker_radioButton.Location = new System.Drawing.Point(218, 9);
            this.DateTimePicker_radioButton.Name = "DateTimePicker_radioButton";
            this.DateTimePicker_radioButton.Size = new System.Drawing.Size(174, 17);
            this.DateTimePicker_radioButton.TabIndex = 3;
            this.DateTimePicker_radioButton.TabStop = true;
            this.DateTimePicker_radioButton.Text = "Раскрывающийся календарь";
            this.DateTimePicker_radioButton.UseVisualStyleBackColor = true;
            // 
            // MonthCalendar_radioButton
            // 
            this.MonthCalendar_radioButton.AutoSize = true;
            this.MonthCalendar_radioButton.Location = new System.Drawing.Point(99, 9);
            this.MonthCalendar_radioButton.Name = "MonthCalendar_radioButton";
            this.MonthCalendar_radioButton.Size = new System.Drawing.Size(80, 17);
            this.MonthCalendar_radioButton.TabIndex = 4;
            this.MonthCalendar_radioButton.TabStop = true;
            this.MonthCalendar_radioButton.Text = "Календарь";
            this.MonthCalendar_radioButton.UseVisualStyleBackColor = true;
            // 
            // MonthCalendar_panel
            // 
            this.MonthCalendar_panel.Controls.Add(this.BoldDateYear_textBox);
            this.MonthCalendar_panel.Controls.Add(this.BoldDateMonth_textBox);
            this.MonthCalendar_panel.Controls.Add(this.BoldDateYear_label);
            this.MonthCalendar_panel.Controls.Add(this.BoldDateMonth_label);
            this.MonthCalendar_panel.Controls.Add(this.BoldDateDay_textBox);
            this.MonthCalendar_panel.Controls.Add(this.BoldDate_button);
            this.MonthCalendar_panel.Controls.Add(this.BoldDateDay_label);
            this.MonthCalendar_panel.Controls.Add(this.Calendar);
            this.MonthCalendar_panel.Location = new System.Drawing.Point(15, 44);
            this.MonthCalendar_panel.Name = "MonthCalendar_panel";
            this.MonthCalendar_panel.Size = new System.Drawing.Size(184, 359);
            this.MonthCalendar_panel.TabIndex = 5;
            // 
            // BoldDateYear_textBox
            // 
            this.BoldDateYear_textBox.Location = new System.Drawing.Point(9, 287);
            this.BoldDateYear_textBox.Name = "BoldDateYear_textBox";
            this.BoldDateYear_textBox.Size = new System.Drawing.Size(164, 20);
            this.BoldDateYear_textBox.TabIndex = 7;
            // 
            // BoldDateMonth_textBox
            // 
            this.BoldDateMonth_textBox.Location = new System.Drawing.Point(9, 248);
            this.BoldDateMonth_textBox.Name = "BoldDateMonth_textBox";
            this.BoldDateMonth_textBox.Size = new System.Drawing.Size(164, 20);
            this.BoldDateMonth_textBox.TabIndex = 6;
            // 
            // BoldDateYear_label
            // 
            this.BoldDateYear_label.AutoSize = true;
            this.BoldDateYear_label.Location = new System.Drawing.Point(6, 271);
            this.BoldDateYear_label.Name = "BoldDateYear_label";
            this.BoldDateYear_label.Size = new System.Drawing.Size(72, 13);
            this.BoldDateYear_label.TabIndex = 5;
            this.BoldDateYear_label.Text = "Введите год:";
            // 
            // BoldDateMonth_label
            // 
            this.BoldDateMonth_label.AutoSize = true;
            this.BoldDateMonth_label.Location = new System.Drawing.Point(6, 232);
            this.BoldDateMonth_label.Name = "BoldDateMonth_label";
            this.BoldDateMonth_label.Size = new System.Drawing.Size(87, 13);
            this.BoldDateMonth_label.TabIndex = 4;
            this.BoldDateMonth_label.Text = "Введите месяц:";
            // 
            // BoldDateDay_textBox
            // 
            this.BoldDateDay_textBox.Location = new System.Drawing.Point(9, 209);
            this.BoldDateDay_textBox.Name = "BoldDateDay_textBox";
            this.BoldDateDay_textBox.Size = new System.Drawing.Size(164, 20);
            this.BoldDateDay_textBox.TabIndex = 3;
            // 
            // BoldDate_button
            // 
            this.BoldDate_button.Location = new System.Drawing.Point(9, 327);
            this.BoldDate_button.Name = "BoldDate_button";
            this.BoldDate_button.Size = new System.Drawing.Size(164, 23);
            this.BoldDate_button.TabIndex = 2;
            this.BoldDate_button.Text = "Выделить";
            this.BoldDate_button.UseVisualStyleBackColor = true;
            // 
            // BoldDateDay_label
            // 
            this.BoldDateDay_label.AutoSize = true;
            this.BoldDateDay_label.Location = new System.Drawing.Point(6, 193);
            this.BoldDateDay_label.Name = "BoldDateDay_label";
            this.BoldDateDay_label.Size = new System.Drawing.Size(79, 13);
            this.BoldDateDay_label.TabIndex = 1;
            this.BoldDateDay_label.Text = "Введите день:";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(9, 9);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            // 
            // DateTimeMonthCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.MonthCalendar_panel);
            this.Controls.Add(this.MonthCalendar_radioButton);
            this.Controls.Add(this.DateTimePicker_radioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePicker_panel);
            this.Name = "DateTimeMonthCalendarForm";
            this.Text = "Работа с датами";
            this.DateTimePicker_panel.ResumeLayout(false);
            this.DateTimePicker_panel.PerformLayout();
            this.MonthCalendar_panel.ResumeLayout(false);
            this.MonthCalendar_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel DateTimePicker_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton DateTimePicker_radioButton;
        private System.Windows.Forms.RadioButton MonthCalendar_radioButton;
        private System.Windows.Forms.Panel MonthCalendar_panel;
        private System.Windows.Forms.TextBox BoldDateDay_textBox;
        private System.Windows.Forms.Button BoldDate_button;
        private System.Windows.Forms.Label BoldDateDay_label;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.TextBox BoldDateYear_textBox;
        private System.Windows.Forms.TextBox BoldDateMonth_textBox;
        private System.Windows.Forms.Label BoldDateYear_label;
        private System.Windows.Forms.Label BoldDateMonth_label;
        private System.Windows.Forms.Label ChoiceFormat_label;
        private System.Windows.Forms.RadioButton TimeFormat_radioButton;
        private System.Windows.Forms.RadioButton ShortFormat_radioButton;
        private System.Windows.Forms.RadioButton LongFormat_radioButton;
        private System.Windows.Forms.Label ChosenDate_label;
    }
}