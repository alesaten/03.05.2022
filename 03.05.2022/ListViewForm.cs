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
    public partial class ListViewForm : Form
    {
        public ListViewForm()
        {
            InitializeComponent();

            ListView_radioButton.CheckedChanged += ListView_radioButton_CheckedChanged;
            TileView_radioButton.CheckedChanged += TileView_radioButton_CheckedChanged;
            LargeIconView_radioButton.CheckedChanged += LargeIconView_radioButton_CheckedChanged;
            SmallIconView_radioButton.CheckedChanged += SmallIconView_radioButton_CheckedChanged;
        }

        void ListView_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Countries_listView.View = View.List;
        }

        void TileView_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Countries_listView.View = View.Tile;
        }

        void LargeIconView_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Countries_listView.View = View.LargeIcon;
        }

        void SmallIconView_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Countries_listView.View = View.SmallIcon;
        }
    }
}
