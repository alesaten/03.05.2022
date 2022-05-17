namespace _03._05._2022
{
    partial class TreeViewForm
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
            this.Continents_treeView = new System.Windows.Forms.TreeView();
            this.Collapse_button = new System.Windows.Forms.Button();
            this.Expand_button = new System.Windows.Forms.Button();
            this.ExpandAll_button = new System.Windows.Forms.Button();
            this.AddCheckBox_checkBox = new System.Windows.Forms.CheckBox();
            this.Continents_imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // Continents_treeView
            // 
            this.Continents_treeView.Location = new System.Drawing.Point(12, 12);
            this.Continents_treeView.Name = "Continents_treeView";
            this.Continents_treeView.Size = new System.Drawing.Size(308, 185);
            this.Continents_treeView.TabIndex = 0;
            // 
            // Collapse_button
            // 
            this.Collapse_button.Location = new System.Drawing.Point(174, 203);
            this.Collapse_button.Name = "Collapse_button";
            this.Collapse_button.Size = new System.Drawing.Size(146, 23);
            this.Collapse_button.TabIndex = 2;
            this.Collapse_button.Text = "Скрыть узел";
            this.Collapse_button.UseVisualStyleBackColor = true;
            // 
            // Expand_button
            // 
            this.Expand_button.Location = new System.Drawing.Point(12, 203);
            this.Expand_button.Name = "Expand_button";
            this.Expand_button.Size = new System.Drawing.Size(146, 23);
            this.Expand_button.TabIndex = 3;
            this.Expand_button.Text = "Раскрыть узел";
            this.Expand_button.UseVisualStyleBackColor = true;
            // 
            // ExpandAll_button
            // 
            this.ExpandAll_button.Location = new System.Drawing.Point(12, 232);
            this.ExpandAll_button.Name = "ExpandAll_button";
            this.ExpandAll_button.Size = new System.Drawing.Size(308, 23);
            this.ExpandAll_button.TabIndex = 4;
            this.ExpandAll_button.Text = "Раскрыть узел и подузлы";
            this.ExpandAll_button.UseVisualStyleBackColor = true;
            // 
            // AddCheckBox_checkBox
            // 
            this.AddCheckBox_checkBox.AutoSize = true;
            this.AddCheckBox_checkBox.Location = new System.Drawing.Point(12, 261);
            this.AddCheckBox_checkBox.Name = "AddCheckBox_checkBox";
            this.AddCheckBox_checkBox.Size = new System.Drawing.Size(118, 17);
            this.AddCheckBox_checkBox.TabIndex = 5;
            this.AddCheckBox_checkBox.Text = "Чекбоксы у узлов";
            this.AddCheckBox_checkBox.UseVisualStyleBackColor = true;
            // 
            // Continents_imageList
            // 
            this.Continents_imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Continents_imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.Continents_imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TreeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 288);
            this.Controls.Add(this.AddCheckBox_checkBox);
            this.Controls.Add(this.ExpandAll_button);
            this.Controls.Add(this.Expand_button);
            this.Controls.Add(this.Collapse_button);
            this.Controls.Add(this.Continents_treeView);
            this.Name = "TreeViewForm";
            this.Text = "Континенты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView Continents_treeView;
        private System.Windows.Forms.Button Collapse_button;
        private System.Windows.Forms.Button Expand_button;
        private System.Windows.Forms.Button ExpandAll_button;
        private System.Windows.Forms.CheckBox AddCheckBox_checkBox;
        private System.Windows.Forms.ImageList Continents_imageList;
    }
}