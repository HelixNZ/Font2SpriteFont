namespace Font2SpriteFont
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.styleSelection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.valueFontSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.fontSelection = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fontmapText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.spriteCols = new System.Windows.Forms.NumericUpDown();
            this.fillColorBox = new System.Windows.Forms.PictureBox();
            this.fillColorText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fontColorBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.valueImageWidth = new System.Windows.Forms.NumericUpDown();
            this.fontColorText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.spriteRows = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valueImageHeight = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueFontSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueImageWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueImageHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackgroundImage = global::Font2SpriteFont.Properties.Resources.tile;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(918, 650);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 650);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.styleSelection);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.valueFontSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fontSelection);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font";
            // 
            // styleSelection
            // 
            this.styleSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.styleSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.styleSelection.FormattingEnabled = true;
            this.styleSelection.Location = new System.Drawing.Point(48, 43);
            this.styleSelection.Name = "styleSelection";
            this.styleSelection.Size = new System.Drawing.Size(91, 21);
            this.styleSelection.TabIndex = 6;
            this.styleSelection.SelectedIndexChanged += new System.EventHandler(this.styleSelection_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Style:";
            // 
            // valueFontSize
            // 
            this.valueFontSize.DecimalPlaces = 1;
            this.valueFontSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.valueFontSize.Location = new System.Drawing.Point(181, 44);
            this.valueFontSize.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.valueFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.valueFontSize.Name = "valueFontSize";
            this.valueFontSize.Size = new System.Drawing.Size(59, 20);
            this.valueFontSize.TabIndex = 4;
            this.valueFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueFontSize.Value = new decimal(new int[] {
            155,
            0,
            0,
            65536});
            this.valueFontSize.ValueChanged += new System.EventHandler(this.valueFontSize_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Size:";
            // 
            // fontSelection
            // 
            this.fontSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fontSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fontSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontSelection.FormattingEnabled = true;
            this.fontSelection.Location = new System.Drawing.Point(3, 16);
            this.fontSelection.MaxDropDownItems = 10;
            this.fontSelection.Name = "fontSelection";
            this.fontSelection.Size = new System.Drawing.Size(238, 21);
            this.fontSelection.Sorted = true;
            this.fontSelection.TabIndex = 2;
            this.fontSelection.SelectedIndexChanged += new System.EventHandler(this.fontSelection_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fontmapText);
            this.groupBox2.Location = new System.Drawing.Point(3, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font Mapping";
            // 
            // fontmapText
            // 
            this.fontmapText.AcceptsReturn = true;
            this.fontmapText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontmapText.Location = new System.Drawing.Point(3, 16);
            this.fontmapText.Multiline = true;
            this.fontmapText.Name = "fontmapText";
            this.fontmapText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fontmapText.Size = new System.Drawing.Size(237, 129);
            this.fontmapText.TabIndex = 4;
            this.fontmapText.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ\r\nabcdefghijklmnopqrstuvwxyz\r\n0123456789";
            this.fontmapText.TextChanged += new System.EventHandler(this.fontmapText_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.spriteCols);
            this.groupBox3.Controls.Add(this.fillColorBox);
            this.groupBox3.Controls.Add(this.fillColorText);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.fontColorBox);
            this.groupBox3.Controls.Add(this.saveButton);
            this.groupBox3.Controls.Add(this.valueImageWidth);
            this.groupBox3.Controls.Add(this.fontColorText);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.spriteRows);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.valueImageHeight);
            this.groupBox3.Location = new System.Drawing.Point(3, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sprite Settings";
            // 
            // spriteCols
            // 
            this.spriteCols.Location = new System.Drawing.Point(163, 45);
            this.spriteCols.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spriteCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spriteCols.Name = "spriteCols";
            this.spriteCols.Size = new System.Drawing.Size(67, 20);
            this.spriteCols.TabIndex = 18;
            this.spriteCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spriteCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spriteCols.ValueChanged += new System.EventHandler(this.spriteCols_ValueChanged);
            // 
            // fillColorBox
            // 
            this.fillColorBox.BackColor = System.Drawing.Color.Black;
            this.fillColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fillColorBox.Location = new System.Drawing.Point(181, 97);
            this.fillColorBox.Name = "fillColorBox";
            this.fillColorBox.Size = new System.Drawing.Size(49, 20);
            this.fillColorBox.TabIndex = 16;
            this.fillColorBox.TabStop = false;
            this.fillColorBox.Click += new System.EventHandler(this.fillColorBox_Click);
            // 
            // fillColorText
            // 
            this.fillColorText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fillColorText.Location = new System.Drawing.Point(90, 97);
            this.fillColorText.MaxLength = 9;
            this.fillColorText.Name = "fillColorText";
            this.fillColorText.Size = new System.Drawing.Size(85, 20);
            this.fillColorText.TabIndex = 15;
            this.fillColorText.Text = "#FF000000";
            this.fillColorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fillColorText.TextChanged += new System.EventHandler(this.fillColorText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fill Color:";
            // 
            // fontColorBox
            // 
            this.fontColorBox.BackColor = System.Drawing.Color.White;
            this.fontColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontColorBox.Location = new System.Drawing.Point(181, 71);
            this.fontColorBox.Name = "fontColorBox";
            this.fontColorBox.Size = new System.Drawing.Size(49, 20);
            this.fontColorBox.TabIndex = 13;
            this.fontColorBox.TabStop = false;
            this.fontColorBox.Click += new System.EventHandler(this.fontColorBox_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(163, 123);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // valueImageWidth
            // 
            this.valueImageWidth.Increment = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.valueImageWidth.Location = new System.Drawing.Point(90, 19);
            this.valueImageWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.valueImageWidth.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.valueImageWidth.Name = "valueImageWidth";
            this.valueImageWidth.Size = new System.Drawing.Size(67, 20);
            this.valueImageWidth.TabIndex = 8;
            this.valueImageWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueImageWidth.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.valueImageWidth.ValueChanged += new System.EventHandler(this.valueImageWidth_ValueChanged);
            // 
            // fontColorText
            // 
            this.fontColorText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fontColorText.Location = new System.Drawing.Point(90, 71);
            this.fontColorText.MaxLength = 9;
            this.fontColorText.Name = "fontColorText";
            this.fontColorText.Size = new System.Drawing.Size(85, 20);
            this.fontColorText.TabIndex = 7;
            this.fontColorText.Text = "#FFFFFFFF";
            this.fontColorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fontColorText.TextChanged += new System.EventHandler(this.fontColor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Font Color:";
            // 
            // spriteRows
            // 
            this.spriteRows.Location = new System.Drawing.Point(90, 45);
            this.spriteRows.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spriteRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spriteRows.Name = "spriteRows";
            this.spriteRows.Size = new System.Drawing.Size(67, 20);
            this.spriteRows.TabIndex = 5;
            this.spriteRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spriteRows.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spriteRows.ValueChanged += new System.EventHandler(this.spriteRows_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rows/Cols:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Size:";
            // 
            // valueImageHeight
            // 
            this.valueImageHeight.Increment = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.valueImageHeight.Location = new System.Drawing.Point(163, 19);
            this.valueImageHeight.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.valueImageHeight.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.valueImageHeight.Name = "valueImageHeight";
            this.valueImageHeight.Size = new System.Drawing.Size(67, 20);
            this.valueImageHeight.TabIndex = 0;
            this.valueImageHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueImageHeight.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.valueImageHeight.ValueChanged += new System.EventHandler(this.valueImageHeight_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bmp";
            this.saveFileDialog1.FileName = "newfont.bmp";
            this.saveFileDialog1.Filter = "Bitmap *.bmp|*.bmp|PNG *.png|*.png|TIFF *.tiff|*.tiff|JPEG *.jpg|*.jpg|GIF *.gif|" +
    "*.gif";
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            this.saveFileDialog1.Title = "Save Image...";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Transparent;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 424);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 200);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Preview";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Font2SpriteFont.Properties.Resources.tile;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(77, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Show Grid";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 672);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Font to SpriteFont";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueFontSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueImageWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueImageHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox fontSelection;
        private System.Windows.Forms.TextBox fontmapText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown spriteRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown valueImageHeight;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox fontColorText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown valueFontSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown valueImageWidth;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox fontColorBox;
        private System.Windows.Forms.PictureBox fillColorBox;
        private System.Windows.Forms.TextBox fillColorText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox styleSelection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown spriteCols;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

