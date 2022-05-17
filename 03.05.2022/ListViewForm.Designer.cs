namespace _03._05._2022
{
    partial class ListViewForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Австралия", 0);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Великобритания", 1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Греция", 2);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Исландия", 3);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Норвегия", 4);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Россия", 5);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("США", 6);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewForm));
            this.Countries_listView = new System.Windows.Forms.ListView();
            this.Countriess_imageList = new System.Windows.Forms.ImageList(this.components);
            this.ChoiceListView_label = new System.Windows.Forms.Label();
            this.LargeIconView_radioButton = new System.Windows.Forms.RadioButton();
            this.ListView_radioButton = new System.Windows.Forms.RadioButton();
            this.SmallIconView_radioButton = new System.Windows.Forms.RadioButton();
            this.TileView_radioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Countries_listView
            // 
            this.Countries_listView.HideSelection = false;
            this.Countries_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.Countries_listView.LargeImageList = this.Countriess_imageList;
            this.Countries_listView.Location = new System.Drawing.Point(12, 12);
            this.Countries_listView.Name = "Countries_listView";
            this.Countries_listView.Size = new System.Drawing.Size(268, 97);
            this.Countries_listView.SmallImageList = this.Countriess_imageList;
            this.Countries_listView.TabIndex = 0;
            this.Countries_listView.UseCompatibleStateImageBehavior = false;
            // 
            // Countriess_imageList
            // 
            this.Countriess_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Countriess_imageList.ImageStream")));
            this.Countriess_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.Countriess_imageList.Images.SetKeyName(0, "au.jpg");
            this.Countriess_imageList.Images.SetKeyName(1, "uk.jpg");
            this.Countriess_imageList.Images.SetKeyName(2, "gr.jpg");
            this.Countriess_imageList.Images.SetKeyName(3, "is.jpg");
            this.Countriess_imageList.Images.SetKeyName(4, "no.jpg");
            this.Countriess_imageList.Images.SetKeyName(5, "ru.jpg");
            this.Countriess_imageList.Images.SetKeyName(6, "us.jpg");
            // 
            // ChoiceListView_label
            // 
            this.ChoiceListView_label.AutoSize = true;
            this.ChoiceListView_label.Location = new System.Drawing.Point(3, 0);
            this.ChoiceListView_label.Name = "ChoiceListView_label";
            this.ChoiceListView_label.Size = new System.Drawing.Size(169, 13);
            this.ChoiceListView_label.TabIndex = 1;
            this.ChoiceListView_label.Text = "Выберите способ отображения:";
            // 
            // LargeIconView_radioButton
            // 
            this.LargeIconView_radioButton.AutoSize = true;
            this.LargeIconView_radioButton.Location = new System.Drawing.Point(6, 62);
            this.LargeIconView_radioButton.Name = "LargeIconView_radioButton";
            this.LargeIconView_radioButton.Size = new System.Drawing.Size(107, 17);
            this.LargeIconView_radioButton.TabIndex = 3;
            this.LargeIconView_radioButton.TabStop = true;
            this.LargeIconView_radioButton.Text = "Крупные значки";
            this.LargeIconView_radioButton.UseVisualStyleBackColor = true;
            // 
            // ListView_radioButton
            // 
            this.ListView_radioButton.AutoSize = true;
            this.ListView_radioButton.Location = new System.Drawing.Point(6, 16);
            this.ListView_radioButton.Name = "ListView_radioButton";
            this.ListView_radioButton.Size = new System.Drawing.Size(62, 17);
            this.ListView_radioButton.TabIndex = 4;
            this.ListView_radioButton.TabStop = true;
            this.ListView_radioButton.Text = "Список";
            this.ListView_radioButton.UseVisualStyleBackColor = true;
            // 
            // SmallIconView_radioButton
            // 
            this.SmallIconView_radioButton.AutoSize = true;
            this.SmallIconView_radioButton.Location = new System.Drawing.Point(6, 85);
            this.SmallIconView_radioButton.Name = "SmallIconView_radioButton";
            this.SmallIconView_radioButton.Size = new System.Drawing.Size(102, 17);
            this.SmallIconView_radioButton.TabIndex = 5;
            this.SmallIconView_radioButton.TabStop = true;
            this.SmallIconView_radioButton.Text = "Мелкие значки";
            this.SmallIconView_radioButton.UseVisualStyleBackColor = true;
            // 
            // TileView_radioButton
            // 
            this.TileView_radioButton.AutoSize = true;
            this.TileView_radioButton.Location = new System.Drawing.Point(6, 39);
            this.TileView_radioButton.Name = "TileView_radioButton";
            this.TileView_radioButton.Size = new System.Drawing.Size(62, 17);
            this.TileView_radioButton.TabIndex = 6;
            this.TileView_radioButton.TabStop = true;
            this.TileView_radioButton.Text = "Плитка";
            this.TileView_radioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChoiceListView_label);
            this.panel1.Controls.Add(this.SmallIconView_radioButton);
            this.panel1.Controls.Add(this.TileView_radioButton);
            this.panel1.Controls.Add(this.LargeIconView_radioButton);
            this.panel1.Controls.Add(this.ListView_radioButton);
            this.panel1.Location = new System.Drawing.Point(12, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 113);
            this.panel1.TabIndex = 7;
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Countries_listView);
            this.Name = "ListViewForm";
            this.Text = "Страны";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Countries_listView;
        private System.Windows.Forms.ImageList Countriess_imageList;
        private System.Windows.Forms.Label ChoiceListView_label;
        private System.Windows.Forms.RadioButton LargeIconView_radioButton;
        private System.Windows.Forms.RadioButton ListView_radioButton;
        private System.Windows.Forms.RadioButton SmallIconView_radioButton;
        private System.Windows.Forms.RadioButton TileView_radioButton;
        private System.Windows.Forms.Panel panel1;
    }
}