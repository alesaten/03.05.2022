using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03._05._2022
{
    public partial class DateTimeMonthCalendarForm : Form
    {
        public DateTimeMonthCalendarForm()
        {
            InitializeComponent();

            MonthCalendar_panel.Visible = false;
            DateTimePicker_panel.Visible = false;

            MonthCalendar_radioButton.CheckedChanged += MonthCalendar_radioButton_CheckedChanged;
            DateTimePicker_radioButton.CheckedChanged += DateTimePicker_radioButton_CheckedChanged;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            LongFormat_radioButton.CheckedChanged += LongFormat_radioButton_CheckedChanged;
            ShortFormat_radioButton.CheckedChanged += ShortFormat_radioButton_CheckedChanged;
            TimeFormat_radioButton.CheckedChanged += TimeFormat_radioButton_CheckedChanged;
            BoldDate_button.Click += BoldDate_button_Click;
        }

        void MonthCalendar_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            MonthCalendar_panel.Visible = true;
            DateTimePicker_panel.Visible = false;
        }

        void DateTimePicker_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            MonthCalendar_panel.Visible = false;
            DateTimePicker_panel.Visible = true;
        }

        void BoldDate_button_Click(object sender, EventArgs e)
        {
            int BoldDateDay_textBoxValue = Convert.ToInt32(BoldDateDay_textBox.Text);
            int BoldDateMonth_textBoxValue = Convert.ToInt32(BoldDateMonth_textBox.Text);
            int BoldDateYear_textBoxValue = Convert.ToInt32(BoldDateYear_textBox.Text);

            Calendar.AddBoldedDate(new DateTime(BoldDateYear_textBoxValue, BoldDateMonth_textBoxValue, BoldDateDay_textBoxValue));
        }

        void LongFormat_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Long;
        }

        void ShortFormat_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Short;
        }

        void TimeFormat_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Time;
        }

        void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ChosenDate_label.Text = String.Format("Вы выбрали: {0}", dateTimePicker.Text);
        }
    }
}
