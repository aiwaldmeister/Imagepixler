namespace ImagePixler
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Weiss",
            "#FFFFFF"}, -1);
            this.button_LoadImage = new System.Windows.Forms.Button();
            this.pictureBox_Display = new System.Windows.Forms.PictureBox();
            this.button_SaveImage = new System.Windows.Forms.Button();
            this.groupBox_Size = new System.Windows.Forms.GroupBox();
            this.textBox_Ratio = new System.Windows.Forms.TextBox();
            this.label_Ratio = new System.Windows.Forms.Label();
            this.label_Px = new System.Windows.Forms.Label();
            this.checkBoxRatio = new System.Windows.Forms.CheckBox();
            this.comboBoxWunschseite = new System.Windows.Forms.ComboBox();
            this.textBox_Wunschbreite = new System.Windows.Forms.TextBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Preview = new System.Windows.Forms.Button();
            this.groupBox_Color = new System.Windows.Forms.GroupBox();
            this.listView_Palette = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList_Palette = new System.Windows.Forms.ImageList(this.components);
            this.button_Color_savePalette = new System.Windows.Forms.Button();
            this.button_Color_loadPalette = new System.Windows.Forms.Button();
            this.checkBoxSize = new System.Windows.Forms.CheckBox();
            this.checkBoxColors = new System.Windows.Forms.CheckBox();
            this.button_Revert = new System.Windows.Forms.Button();
            this.openFileDialog_Picture = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_Picture = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_Palette = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_Palette = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog_Palette = new System.Windows.Forms.ColorDialog();
            this.contextMenu_Palette = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dieseFarbeÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dieseFarbeUmbenennenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dieseFarbeEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.neueFarbeHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_DisplayRatioCorrection = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Display)).BeginInit();
            this.groupBox_Size.SuspendLayout();
            this.groupBox_Color.SuspendLayout();
            this.contextMenu_Palette.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_LoadImage
            // 
            this.button_LoadImage.Location = new System.Drawing.Point(12, 12);
            this.button_LoadImage.Name = "button_LoadImage";
            this.button_LoadImage.Size = new System.Drawing.Size(95, 40);
            this.button_LoadImage.TabIndex = 0;
            this.button_LoadImage.Text = "Bild laden";
            this.button_LoadImage.UseVisualStyleBackColor = true;
            this.button_LoadImage.Click += new System.EventHandler(this.button_LoadImage_Click);
            // 
            // pictureBox_Display
            // 
            this.pictureBox_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Display.Location = new System.Drawing.Point(223, 8);
            this.pictureBox_Display.Name = "pictureBox_Display";
            this.pictureBox_Display.Size = new System.Drawing.Size(892, 742);
            this.pictureBox_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Display.TabIndex = 1;
            this.pictureBox_Display.TabStop = false;
            // 
            // button_SaveImage
            // 
            this.button_SaveImage.Location = new System.Drawing.Point(120, 12);
            this.button_SaveImage.Name = "button_SaveImage";
            this.button_SaveImage.Size = new System.Drawing.Size(95, 41);
            this.button_SaveImage.TabIndex = 2;
            this.button_SaveImage.Text = "Bild speichern als...";
            this.button_SaveImage.UseVisualStyleBackColor = true;
            // 
            // groupBox_Size
            // 
            this.groupBox_Size.Controls.Add(this.textBox_Ratio);
            this.groupBox_Size.Controls.Add(this.label_Ratio);
            this.groupBox_Size.Controls.Add(this.label_Px);
            this.groupBox_Size.Controls.Add(this.checkBoxRatio);
            this.groupBox_Size.Controls.Add(this.comboBoxWunschseite);
            this.groupBox_Size.Controls.Add(this.textBox_Wunschbreite);
            this.groupBox_Size.Location = new System.Drawing.Point(12, 79);
            this.groupBox_Size.Name = "groupBox_Size";
            this.groupBox_Size.Size = new System.Drawing.Size(203, 132);
            this.groupBox_Size.TabIndex = 3;
            this.groupBox_Size.TabStop = false;
            this.groupBox_Size.Text = "Größe ändern";
            // 
            // textBox_Ratio
            // 
            this.textBox_Ratio.Location = new System.Drawing.Point(141, 97);
            this.textBox_Ratio.Name = "textBox_Ratio";
            this.textBox_Ratio.Size = new System.Drawing.Size(34, 20);
            this.textBox_Ratio.TabIndex = 5;
            this.textBox_Ratio.Text = "0,6";
            // 
            // label_Ratio
            // 
            this.label_Ratio.AutoSize = true;
            this.label_Ratio.Location = new System.Drawing.Point(12, 100);
            this.label_Ratio.Name = "label_Ratio";
            this.label_Ratio.Size = new System.Drawing.Size(123, 13);
            this.label_Ratio.TabIndex = 6;
            this.label_Ratio.Text = "Maschenbreite / Höhe =";
            // 
            // label_Px
            // 
            this.label_Px.AutoSize = true;
            this.label_Px.Location = new System.Drawing.Point(156, 34);
            this.label_Px.Name = "label_Px";
            this.label_Px.Size = new System.Drawing.Size(35, 13);
            this.label_Px.TabIndex = 6;
            this.label_Px.Text = "(Pixel)";
            // 
            // checkBoxRatio
            // 
            this.checkBoxRatio.AutoSize = true;
            this.checkBoxRatio.Checked = true;
            this.checkBoxRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRatio.Location = new System.Drawing.Point(15, 74);
            this.checkBoxRatio.Name = "checkBoxRatio";
            this.checkBoxRatio.Size = new System.Drawing.Size(151, 17);
            this.checkBoxRatio.TabIndex = 5;
            this.checkBoxRatio.Text = "Seitenverhältnis korrigeren";
            this.checkBoxRatio.UseVisualStyleBackColor = true;
            this.checkBoxRatio.CheckedChanged += new System.EventHandler(this.checkBoxRatio_CheckedChanged);
            // 
            // comboBoxWunschseite
            // 
            this.comboBoxWunschseite.FormattingEnabled = true;
            this.comboBoxWunschseite.Items.AddRange(new object[] {
            "Wunschbreite",
            "Wunschhöhe"});
            this.comboBoxWunschseite.Location = new System.Drawing.Point(6, 30);
            this.comboBoxWunschseite.Name = "comboBoxWunschseite";
            this.comboBoxWunschseite.Size = new System.Drawing.Size(96, 21);
            this.comboBoxWunschseite.TabIndex = 1;
            this.comboBoxWunschseite.Text = "Wunschbreite";
            // 
            // textBox_Wunschbreite
            // 
            this.textBox_Wunschbreite.Location = new System.Drawing.Point(108, 31);
            this.textBox_Wunschbreite.Name = "textBox_Wunschbreite";
            this.textBox_Wunschbreite.Size = new System.Drawing.Size(42, 20);
            this.textBox_Wunschbreite.TabIndex = 2;
            this.textBox_Wunschbreite.Text = "100";
            // 
            // button_Apply
            // 
            this.button_Apply.Enabled = false;
            this.button_Apply.Location = new System.Drawing.Point(12, 635);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(203, 41);
            this.button_Apply.TabIndex = 1;
            this.button_Apply.Text = "Anwenden";
            this.button_Apply.UseVisualStyleBackColor = true;
            // 
            // button_Preview
            // 
            this.button_Preview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Preview.Location = new System.Drawing.Point(12, 588);
            this.button_Preview.Name = "button_Preview";
            this.button_Preview.Size = new System.Drawing.Size(203, 41);
            this.button_Preview.TabIndex = 0;
            this.button_Preview.Text = "Vorschau";
            this.button_Preview.UseVisualStyleBackColor = true;
            // 
            // groupBox_Color
            // 
            this.groupBox_Color.Controls.Add(this.listView_Palette);
            this.groupBox_Color.Controls.Add(this.button_Color_savePalette);
            this.groupBox_Color.Controls.Add(this.button_Color_loadPalette);
            this.groupBox_Color.Location = new System.Drawing.Point(12, 237);
            this.groupBox_Color.Name = "groupBox_Color";
            this.groupBox_Color.Size = new System.Drawing.Size(203, 345);
            this.groupBox_Color.TabIndex = 4;
            this.groupBox_Color.TabStop = false;
            this.groupBox_Color.Text = "Farben auf Palette reduzieren";
            // 
            // listView_Palette
            // 
            this.listView_Palette.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            listViewItem2.StateImageIndex = 0;
            this.listView_Palette.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView_Palette.LabelEdit = true;
            this.listView_Palette.LargeImageList = this.imageList_Palette;
            this.listView_Palette.Location = new System.Drawing.Point(6, 65);
            this.listView_Palette.Name = "listView_Palette";
            this.listView_Palette.Size = new System.Drawing.Size(185, 239);
            this.listView_Palette.TabIndex = 0;
            this.listView_Palette.UseCompatibleStateImageBehavior = false;
            this.listView_Palette.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Farbcode";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Farbcode";
            // 
            // imageList_Palette
            // 
            this.imageList_Palette.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList_Palette.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList_Palette.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button_Color_savePalette
            // 
            this.button_Color_savePalette.Location = new System.Drawing.Point(6, 310);
            this.button_Color_savePalette.Name = "button_Color_savePalette";
            this.button_Color_savePalette.Size = new System.Drawing.Size(185, 27);
            this.button_Color_savePalette.TabIndex = 0;
            this.button_Color_savePalette.Text = "Palette speichern";
            this.button_Color_savePalette.UseVisualStyleBackColor = true;
            this.button_Color_savePalette.Click += new System.EventHandler(this.button_Color_savePalette_Click);
            // 
            // button_Color_loadPalette
            // 
            this.button_Color_loadPalette.Location = new System.Drawing.Point(6, 32);
            this.button_Color_loadPalette.Name = "button_Color_loadPalette";
            this.button_Color_loadPalette.Size = new System.Drawing.Size(185, 27);
            this.button_Color_loadPalette.TabIndex = 0;
            this.button_Color_loadPalette.Text = "Palette laden";
            this.button_Color_loadPalette.UseVisualStyleBackColor = true;
            this.button_Color_loadPalette.Click += new System.EventHandler(this.button_Color_loadPalette_Click);
            // 
            // checkBoxSize
            // 
            this.checkBoxSize.AutoSize = true;
            this.checkBoxSize.Checked = true;
            this.checkBoxSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSize.Location = new System.Drawing.Point(201, 83);
            this.checkBoxSize.Name = "checkBoxSize";
            this.checkBoxSize.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSize.TabIndex = 5;
            this.checkBoxSize.UseVisualStyleBackColor = true;
            this.checkBoxSize.CheckedChanged += new System.EventHandler(this.checkBoxSize_CheckedChanged);
            // 
            // checkBoxColors
            // 
            this.checkBoxColors.AutoSize = true;
            this.checkBoxColors.Checked = true;
            this.checkBoxColors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxColors.Location = new System.Drawing.Point(201, 241);
            this.checkBoxColors.Name = "checkBoxColors";
            this.checkBoxColors.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColors.TabIndex = 5;
            this.checkBoxColors.UseVisualStyleBackColor = true;
            this.checkBoxColors.CheckedChanged += new System.EventHandler(this.checkBoxColors_CheckedChanged);
            // 
            // button_Revert
            // 
            this.button_Revert.Enabled = false;
            this.button_Revert.Location = new System.Drawing.Point(11, 682);
            this.button_Revert.Name = "button_Revert";
            this.button_Revert.Size = new System.Drawing.Size(203, 41);
            this.button_Revert.TabIndex = 1;
            this.button_Revert.Text = "Abbrechen";
            this.button_Revert.UseVisualStyleBackColor = true;
            // 
            // openFileDialog_Picture
            // 
            this.openFileDialog_Picture.FileName = "openFileDialog1";
            // 
            // openFileDialog_Palette
            // 
            this.openFileDialog_Palette.FileName = "openFileDialog1";
            // 
            // colorDialog_Palette
            // 
            this.colorDialog_Palette.AnyColor = true;
            this.colorDialog_Palette.FullOpen = true;
            // 
            // contextMenu_Palette
            // 
            this.contextMenu_Palette.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dieseFarbeÄndernToolStripMenuItem,
            this.dieseFarbeUmbenennenToolStripMenuItem,
            this.dieseFarbeEntfernenToolStripMenuItem,
            this.toolStripSeparator1,
            this.neueFarbeHinzufügenToolStripMenuItem});
            this.contextMenu_Palette.Name = "contextMenuStrip1";
            this.contextMenu_Palette.Size = new System.Drawing.Size(208, 98);
            // 
            // dieseFarbeÄndernToolStripMenuItem
            // 
            this.dieseFarbeÄndernToolStripMenuItem.Name = "dieseFarbeÄndernToolStripMenuItem";
            this.dieseFarbeÄndernToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.dieseFarbeÄndernToolStripMenuItem.Text = "diese Farbe ändern";
            this.dieseFarbeÄndernToolStripMenuItem.Click += new System.EventHandler(this.FarbeAendern);
            // 
            // dieseFarbeUmbenennenToolStripMenuItem
            // 
            this.dieseFarbeUmbenennenToolStripMenuItem.Name = "dieseFarbeUmbenennenToolStripMenuItem";
            this.dieseFarbeUmbenennenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.dieseFarbeUmbenennenToolStripMenuItem.Text = "diese Farbe umbenennen";
            this.dieseFarbeUmbenennenToolStripMenuItem.Click += new System.EventHandler(this.dieseFarbeUmbenennenToolStripMenuItem_Click);
            // 
            // dieseFarbeEntfernenToolStripMenuItem
            // 
            this.dieseFarbeEntfernenToolStripMenuItem.Name = "dieseFarbeEntfernenToolStripMenuItem";
            this.dieseFarbeEntfernenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.dieseFarbeEntfernenToolStripMenuItem.Text = "diese Farbe entfernen";
            this.dieseFarbeEntfernenToolStripMenuItem.Click += new System.EventHandler(this.dieseFarbeEntfernenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // neueFarbeHinzufügenToolStripMenuItem
            // 
            this.neueFarbeHinzufügenToolStripMenuItem.Name = "neueFarbeHinzufügenToolStripMenuItem";
            this.neueFarbeHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.neueFarbeHinzufügenToolStripMenuItem.Text = "neue Farbe hinzufügen";
            this.neueFarbeHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.neueFarbeHinzufügenToolStripMenuItem_Click);
            // 
            // checkBox_DisplayRatioCorrection
            // 
            this.checkBox_DisplayRatioCorrection.AutoSize = true;
            this.checkBox_DisplayRatioCorrection.Enabled = false;
            this.checkBox_DisplayRatioCorrection.Location = new System.Drawing.Point(12, 733);
            this.checkBox_DisplayRatioCorrection.Name = "checkBox_DisplayRatioCorrection";
            this.checkBox_DisplayRatioCorrection.Size = new System.Drawing.Size(212, 17);
            this.checkBox_DisplayRatioCorrection.TabIndex = 6;
            this.checkBox_DisplayRatioCorrection.Text = "Seitenverhältnis der Anzeige korrigieren";
            this.checkBox_DisplayRatioCorrection.UseVisualStyleBackColor = true;
            this.checkBox_DisplayRatioCorrection.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 762);
            this.Controls.Add(this.checkBoxColors);
            this.Controls.Add(this.checkBoxSize);
            this.Controls.Add(this.groupBox_Color);
            this.Controls.Add(this.groupBox_Size);
            this.Controls.Add(this.button_SaveImage);
            this.Controls.Add(this.pictureBox_Display);
            this.Controls.Add(this.button_LoadImage);
            this.Controls.Add(this.button_Revert);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.button_Preview);
            this.Controls.Add(this.checkBox_DisplayRatioCorrection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Display)).EndInit();
            this.groupBox_Size.ResumeLayout(false);
            this.groupBox_Size.PerformLayout();
            this.groupBox_Color.ResumeLayout(false);
            this.contextMenu_Palette.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LoadImage;
        private System.Windows.Forms.PictureBox pictureBox_Display;
        private System.Windows.Forms.Button button_SaveImage;
        private System.Windows.Forms.GroupBox groupBox_Size;
        private System.Windows.Forms.Label label_Px;
        private System.Windows.Forms.TextBox textBox_Ratio;
        private System.Windows.Forms.TextBox textBox_Wunschbreite;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Preview;
        private System.Windows.Forms.GroupBox groupBox_Color;
        private System.Windows.Forms.ListView listView_Palette;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox comboBoxWunschseite;
        private System.Windows.Forms.CheckBox checkBoxSize;
        private System.Windows.Forms.CheckBox checkBoxRatio;
        private System.Windows.Forms.CheckBox checkBoxColors;
        private System.Windows.Forms.Label label_Ratio;
        private System.Windows.Forms.Button button_Revert;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Picture;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Picture;
        private System.Windows.Forms.Button button_Color_loadPalette;
        private System.Windows.Forms.ImageList imageList_Palette;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Palette;
        private System.Windows.Forms.Button button_Color_savePalette;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Palette;
        public System.Windows.Forms.ColorDialog colorDialog_Palette;
        private System.Windows.Forms.ContextMenuStrip contextMenu_Palette;
        private System.Windows.Forms.ToolStripMenuItem dieseFarbeÄndernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dieseFarbeUmbenennenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dieseFarbeEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem neueFarbeHinzufügenToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_DisplayRatioCorrection;
    }
}

