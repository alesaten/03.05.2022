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
        public int ProgressBarValue { get; set; }

        public Form1()
        {
            InitializeComponent();

            MainForm_timer.Interval = 200;
            
            ListViewForm_button.Click += ListViewForm_button_Click;
            TreeViewForm_button.Click += TreeViewForm_button_Click;
            DateTimeMonthCalendar_button.Click += DateTimeMonthCalendar_button_Click;
            MainForm_timer.Tick += MainForm_timer_Tick;
        }

        void MainForm_timer_Tick(object sender, EventArgs e)
        {
            MainForm_progressBar.PerformStep();
            ProgressBarValue = MainForm_progressBar.Value;
        }

        void ListViewForm_button_Click(object sender, EventArgs e)
        {
            //MainForm_timer.Start();

            ListViewForm ListView = new ListViewForm();
            ListView.Show();

            //if (ProgressBarValue == 100)
            {
                
            }

           //MainForm_progressBar.Value = 0;
        }

        void TreeViewForm_button_Click(object sender, EventArgs e)
        {
            TreeViewForm TreeView = new TreeViewForm();
            TreeView.Show();
        }

        void DateTimeMonthCalendar_button_Click(object sender, EventArgs e)
        {
            DateTimeMonthCalendarForm DateTimeMonthCalendar = new DateTimeMonthCalendarForm();
            DateTimeMonthCalendar.Show();
        }
    }
}
