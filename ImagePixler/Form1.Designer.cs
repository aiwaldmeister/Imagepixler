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
            this.button_Size_Apply = new System.Windows.Forms.Button();
            this.groupBox_Color = new System.Windows.Forms.GroupBox();
            this.label_Dithering = new System.Windows.Forms.Label();
            this.label_Palette_Tolerance = new System.Windows.Forms.Label();
            this.label_Palette_colorCount = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listView_Palette = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList_Palette = new System.Windows.Forms.ImageList(this.components);
            this.button_Palette_generatefromImage = new System.Windows.Forms.Button();
            this.button_Color_savePalette = new System.Windows.Forms.Button();
            this.button_Color_loadPalette = new System.Windows.Forms.Button();
            this.button_Palette_Apply = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
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
            this.button_ResetImage = new System.Windows.Forms.Button();
            this.button_loadRandomImage = new System.Windows.Forms.Button();
            this.button_resizeAndreduce = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer_continueAutomode = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Display)).BeginInit();
            this.groupBox_Size.SuspendLayout();
            this.groupBox_Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenu_Palette.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_LoadImage
            // 
            this.button_LoadImage.Location = new System.Drawing.Point(12, 12);
            this.button_LoadImage.Name = "button_LoadImage";
            this.button_LoadImage.Size = new System.Drawing.Size(143, 24);
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
            this.pictureBox_Display.Size = new System.Drawing.Size(1441, 909);
            this.pictureBox_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Display.TabIndex = 1;
            this.pictureBox_Display.TabStop = false;
            // 
            // button_SaveImage
            // 
            this.button_SaveImage.Enabled = false;
            this.button_SaveImage.Location = new System.Drawing.Point(12, 132);
            this.button_SaveImage.Name = "button_SaveImage";
            this.button_SaveImage.Size = new System.Drawing.Size(203, 25);
            this.button_SaveImage.TabIndex = 2;
            this.button_SaveImage.Text = "Bild speichern als...";
            this.button_SaveImage.UseVisualStyleBackColor = true;
            this.button_SaveImage.Click += new System.EventHandler(this.button_SaveImage_Click);
            // 
            // groupBox_Size
            // 
            this.groupBox_Size.Controls.Add(this.textBox_Ratio);
            this.groupBox_Size.Controls.Add(this.label_Ratio);
            this.groupBox_Size.Controls.Add(this.label_Px);
            this.groupBox_Size.Controls.Add(this.checkBoxRatio);
            this.groupBox_Size.Controls.Add(this.comboBoxWunschseite);
            this.groupBox_Size.Controls.Add(this.textBox_Wunschbreite);
            this.groupBox_Size.Controls.Add(this.button_Size_Apply);
            this.groupBox_Size.Location = new System.Drawing.Point(12, 180);
            this.groupBox_Size.Name = "groupBox_Size";
            this.groupBox_Size.Size = new System.Drawing.Size(203, 172);
            this.groupBox_Size.TabIndex = 3;
            this.groupBox_Size.TabStop = false;
            this.groupBox_Size.Text = "Größe";
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
            "kürzere Seite",
            "Breite",
            "Höhe"});
            this.comboBoxWunschseite.Location = new System.Drawing.Point(6, 30);
            this.comboBoxWunschseite.Name = "comboBoxWunschseite";
            this.comboBoxWunschseite.Size = new System.Drawing.Size(96, 21);
            this.comboBoxWunschseite.TabIndex = 1;
            this.comboBoxWunschseite.Text = "kürzere Seite";
            // 
            // textBox_Wunschbreite
            // 
            this.textBox_Wunschbreite.Location = new System.Drawing.Point(108, 31);
            this.textBox_Wunschbreite.Name = "textBox_Wunschbreite";
            this.textBox_Wunschbreite.Size = new System.Drawing.Size(42, 20);
            this.textBox_Wunschbreite.TabIndex = 2;
            this.textBox_Wunschbreite.Text = "200";
            // 
            // button_Size_Apply
            // 
            this.button_Size_Apply.BackColor = System.Drawing.SystemColors.Control;
            this.button_Size_Apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Size_Apply.Location = new System.Drawing.Point(6, 133);
            this.button_Size_Apply.Name = "button_Size_Apply";
            this.button_Size_Apply.Size = new System.Drawing.Size(185, 33);
            this.button_Size_Apply.TabIndex = 0;
            this.button_Size_Apply.Text = "Bildgröße ändern";
            this.button_Size_Apply.UseVisualStyleBackColor = false;
            this.button_Size_Apply.Click += new System.EventHandler(this.button_Size_Apply_Click);
            // 
            // groupBox_Color
            // 
            this.groupBox_Color.Controls.Add(this.label_Dithering);
            this.groupBox_Color.Controls.Add(this.label_Palette_Tolerance);
            this.groupBox_Color.Controls.Add(this.label_Palette_colorCount);
            this.groupBox_Color.Controls.Add(this.numericUpDown1);
            this.groupBox_Color.Controls.Add(this.listView_Palette);
            this.groupBox_Color.Controls.Add(this.button_Palette_generatefromImage);
            this.groupBox_Color.Controls.Add(this.button_Color_savePalette);
            this.groupBox_Color.Controls.Add(this.button_Color_loadPalette);
            this.groupBox_Color.Controls.Add(this.button_Palette_Apply);
            this.groupBox_Color.Controls.Add(this.trackBar1);
            this.groupBox_Color.Location = new System.Drawing.Point(12, 380);
            this.groupBox_Color.Name = "groupBox_Color";
            this.groupBox_Color.Size = new System.Drawing.Size(203, 537);
            this.groupBox_Color.TabIndex = 4;
            this.groupBox_Color.TabStop = false;
            this.groupBox_Color.Text = "Farbpalette";
            // 
            // label_Dithering
            // 
            this.label_Dithering.AutoSize = true;
            this.label_Dithering.Location = new System.Drawing.Point(6, 507);
            this.label_Dithering.Name = "label_Dithering";
            this.label_Dithering.Size = new System.Drawing.Size(52, 13);
            this.label_Dithering.TabIndex = 12;
            this.label_Dithering.Text = "Dithering:";
            // 
            // label_Palette_Tolerance
            // 
            this.label_Palette_Tolerance.AutoSize = true;
            this.label_Palette_Tolerance.Location = new System.Drawing.Point(33, 104);
            this.label_Palette_Tolerance.Name = "label_Palette_Tolerance";
            this.label_Palette_Tolerance.Size = new System.Drawing.Size(68, 13);
            this.label_Palette_Tolerance.TabIndex = 7;
            this.label_Palette_Tolerance.Text = "max. Farben:";
            // 
            // label_Palette_colorCount
            // 
            this.label_Palette_colorCount.AutoSize = true;
            this.label_Palette_colorCount.Location = new System.Drawing.Point(6, 179);
            this.label_Palette_colorCount.Name = "label_Palette_colorCount";
            this.label_Palette_colorCount.Size = new System.Drawing.Size(52, 13);
            this.label_Palette_colorCount.TabIndex = 7;
            this.label_Palette_colorCount.Text = "Farben: 1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(101, 102);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
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
            this.listView_Palette.Location = new System.Drawing.Point(6, 195);
            this.listView_Palette.Name = "listView_Palette";
            this.listView_Palette.Size = new System.Drawing.Size(185, 250);
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
            // button_Palette_generatefromImage
            // 
            this.button_Palette_generatefromImage.Location = new System.Drawing.Point(6, 66);
            this.button_Palette_generatefromImage.Name = "button_Palette_generatefromImage";
            this.button_Palette_generatefromImage.Size = new System.Drawing.Size(185, 32);
            this.button_Palette_generatefromImage.TabIndex = 7;
            this.button_Palette_generatefromImage.Text = "Palette aus Bild generieren";
            this.button_Palette_generatefromImage.UseVisualStyleBackColor = true;
            this.button_Palette_generatefromImage.Click += new System.EventHandler(this.button_Palette_generatefromImage_Click);
            // 
            // button_Color_savePalette
            // 
            this.button_Color_savePalette.Location = new System.Drawing.Point(6, 137);
            this.button_Color_savePalette.Name = "button_Color_savePalette";
            this.button_Color_savePalette.Size = new System.Drawing.Size(185, 27);
            this.button_Color_savePalette.TabIndex = 0;
            this.button_Color_savePalette.Text = "Palette als Datei speichern";
            this.button_Color_savePalette.UseVisualStyleBackColor = true;
            this.button_Color_savePalette.Click += new System.EventHandler(this.button_Color_savePalette_Click);
            // 
            // button_Color_loadPalette
            // 
            this.button_Color_loadPalette.Location = new System.Drawing.Point(6, 28);
            this.button_Color_loadPalette.Name = "button_Color_loadPalette";
            this.button_Color_loadPalette.Size = new System.Drawing.Size(185, 32);
            this.button_Color_loadPalette.TabIndex = 0;
            this.button_Color_loadPalette.Text = "Palette aus Datei laden";
            this.button_Color_loadPalette.UseVisualStyleBackColor = true;
            this.button_Color_loadPalette.Click += new System.EventHandler(this.button_Color_loadPalette_Click);
            // 
            // button_Palette_Apply
            // 
            this.button_Palette_Apply.BackColor = System.Drawing.SystemColors.Control;
            this.button_Palette_Apply.Location = new System.Drawing.Point(6, 451);
            this.button_Palette_Apply.Name = "button_Palette_Apply";
            this.button_Palette_Apply.Size = new System.Drawing.Size(185, 33);
            this.button_Palette_Apply.TabIndex = 1;
            this.button_Palette_Apply.Text = "Bildfarben auf Palette reduzieren";
            this.button_Palette_Apply.UseVisualStyleBackColor = false;
            this.button_Palette_Apply.Click += new System.EventHandler(this.button_Palette_Apply_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(59, 500);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(132, 24);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 12;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
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
            this.checkBox_DisplayRatioCorrection.Location = new System.Drawing.Point(48, 71);
            this.checkBox_DisplayRatioCorrection.Name = "checkBox_DisplayRatioCorrection";
            this.checkBox_DisplayRatioCorrection.Size = new System.Drawing.Size(112, 17);
            this.checkBox_DisplayRatioCorrection.TabIndex = 6;
            this.checkBox_DisplayRatioCorrection.Text = "Original ist verzerrt";
            this.checkBox_DisplayRatioCorrection.UseVisualStyleBackColor = true;
            // 
            // button_ResetImage
            // 
            this.button_ResetImage.Location = new System.Drawing.Point(161, 12);
            this.button_ResetImage.Name = "button_ResetImage";
            this.button_ResetImage.Size = new System.Drawing.Size(54, 53);
            this.button_ResetImage.TabIndex = 7;
            this.button_ResetImage.Text = "Bild neu laden";
            this.button_ResetImage.UseVisualStyleBackColor = true;
            this.button_ResetImage.Click += new System.EventHandler(this.button_ResetImage_Click);
            // 
            // button_loadRandomImage
            // 
            this.button_loadRandomImage.Location = new System.Drawing.Point(12, 42);
            this.button_loadRandomImage.Name = "button_loadRandomImage";
            this.button_loadRandomImage.Size = new System.Drawing.Size(143, 23);
            this.button_loadRandomImage.TabIndex = 8;
            this.button_loadRandomImage.Text = "zufälliges Bild";
            this.button_loadRandomImage.UseVisualStyleBackColor = true;
            this.button_loadRandomImage.Click += new System.EventHandler(this.button_loadRandomImage_Click);
            // 
            // button_resizeAndreduce
            // 
            this.button_resizeAndreduce.BackColor = System.Drawing.Color.SkyBlue;
            this.button_resizeAndreduce.Location = new System.Drawing.Point(12, 94);
            this.button_resizeAndreduce.Name = "button_resizeAndreduce";
            this.button_resizeAndreduce.Size = new System.Drawing.Size(203, 32);
            this.button_resizeAndreduce.TabIndex = 9;
            this.button_resizeAndreduce.Text = "Pixelbild Erzeugen";
            this.button_resizeAndreduce.UseVisualStyleBackColor = false;
            this.button_resizeAndreduce.Click += new System.EventHandler(this.button_resizeAndreduce_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(223, 900);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1441, 17);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Visible = false;
            // 
            // timer_continueAutomode
            // 
            this.timer_continueAutomode.Tick += new System.EventHandler(this.timer_continueAutomode_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 927);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_resizeAndreduce);
            this.Controls.Add(this.button_loadRandomImage);
            this.Controls.Add(this.button_ResetImage);
            this.Controls.Add(this.groupBox_Color);
            this.Controls.Add(this.groupBox_Size);
            this.Controls.Add(this.button_SaveImage);
            this.Controls.Add(this.button_LoadImage);
            this.Controls.Add(this.pictureBox_Display);
            this.Controls.Add(this.checkBox_DisplayRatioCorrection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagePixler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Display)).EndInit();
            this.groupBox_Size.ResumeLayout(false);
            this.groupBox_Size.PerformLayout();
            this.groupBox_Color.ResumeLayout(false);
            this.groupBox_Color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.Button button_Size_Apply;
        private System.Windows.Forms.GroupBox groupBox_Color;
        private System.Windows.Forms.ListView listView_Palette;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox comboBoxWunschseite;
        private System.Windows.Forms.CheckBox checkBoxRatio;
        private System.Windows.Forms.Label label_Ratio;
        private System.Windows.Forms.Button button_Palette_Apply;
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
        private System.Windows.Forms.Button button_Palette_generatefromImage;
        private System.Windows.Forms.Label label_Palette_colorCount;
        private System.Windows.Forms.Label label_Palette_Tolerance;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_ResetImage;
        private System.Windows.Forms.Button button_loadRandomImage;
        private System.Windows.Forms.Button button_resizeAndreduce;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer_continueAutomode;
        private System.Windows.Forms.Label label_Dithering;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

