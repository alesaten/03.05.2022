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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MainForm_timer.Interval = 200;
            MainForm_progressBar.Minimum = 0;
            MainForm_progressBar.Maximum = 100;
            MainForm_progressBar.Value = 0;


            ListViewForm_button.Click += ListViewForm_button_Click;
            TreeViewForm_button.Click += TreeViewForm_button_Click;
            DateTimeMonthCalendar_button.Click += DateTimeMonthCalendar_button_Click;
            MainForm_timer.Tick += MainForm_timer_Tick;
        }

        void MainForm_timer_Tick(object sender, EventArgs e)
        {
            do
                MainForm_progressBar.PerformStep();
            while (MainForm_progressBar.Value < 100);
        }

        void ListViewForm_button_Click(object sender, EventArgs e)
        {
            MainForm_timer.Start();
            MainForm_timer_Tick(sender, e);

            if (MainForm_progressBar.Value == 100)
            {
                ListViewForm ListView = new ListViewForm();
                ListView.Show();
            }

            MainForm_progressBar.Value = 0;
        }

        void TreeViewForm_button_Click(object sender, EventArgs e)
        {
            MainForm_timer.Start();
            MainForm_timer_Tick(sender, e);

            if (MainForm_progressBar.Value == 100)
            {
                TreeViewForm TreeView = new TreeViewForm();
                TreeView.Show();
            }

            MainForm_progressBar.Value = 0;
        }

        void DateTimeMonthCalendar_button_Click(object sender, EventArgs e)
        {
            MainForm_timer.Start();
            MainForm_timer_Tick(sender, e);

            if (MainForm_progressBar.Value == 100)
            {
                DateTimeMonthCalendarForm DateTimeMonthCalendar = new DateTimeMonthCalendarForm();
                DateTimeMonthCalendar.Show();
            }

            MainForm_progressBar.Value = 0;
        }
    }
}
