using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Font2SpriteFont
{
    public partial class Form1 : Form
    {
        private int previewRow = 0;
        private int previewCol = 0;
        private Bitmap theImage = new Bitmap(256, 256, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        private Bitmap thePreview = new Bitmap(64, 64, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        private string fontMapping = "ABCDEF0123456789#";

        public Form1()
        {
            InitializeComponent();
            
            //Add installed fonts to the list
            InstalledFontCollection fontsCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = fontsCollection.Families;

            foreach (FontFamily font in fontFamilies)
            {
                fontSelection.Items.Add(font.Name);
            }

            //Select the first font and delete the empty slot at 0
            fontSelection.SelectedIndex = 1;
            fontSelection.Items.RemoveAt(0);

            fontmapText.Text = fontMapping;

            //Force update of image
            UpdateImage();
        }

        private void ScaleCanvas()
        {
            pictureBox1.Size = theImage.Size;

            if (pictureBox1.Width < splitContainer1.Panel2.Width)
            {
                pictureBox1.Width = splitContainer1.Panel2.Width;
            }

            if (pictureBox1.Height < splitContainer1.Panel2.Height)
            {
                pictureBox1.Height = splitContainer1.Panel2.Height;
            }
        }

        private void UpdatePreview(Graphics _gInstance, Font _font, string _buffer, int _rowIndex = 1, int _colIndex = 1)
        {
            SizeF fontDimensions = GetLargestCharacter(_gInstance, _font, _buffer);

            //thePreview
            //Resize preview to suit
            float fPreviewWidth = fontDimensions.Width;
            float fPreviewHeight = fontDimensions.Height;
            SizeF fSpacing = CalculateSpacingValues(_gInstance, _font, _buffer);

            if ((int)fPreviewWidth != thePreview.Size.Width || (int)fPreviewHeight != thePreview.Size.Height)
            {
                thePreview.Dispose();
                thePreview = new Bitmap((int)fPreviewWidth, (int)fPreviewHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            }

            Graphics previewGraphics = Graphics.FromImage(thePreview);

            previewGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            previewGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            previewGraphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            previewGraphics.Clear(fillColorBox.BackColor);

            //Copy from main to preview
            previewGraphics.DrawImage(theImage, 0.0f, 0.0f, new RectangleF(fSpacing.Width * _rowIndex, fSpacing.Height * _colIndex, fPreviewWidth, fPreviewHeight), GraphicsUnit.Pixel);

            previewGraphics.Flush();
            pictureBox2.Image = thePreview;
        }

        private void UpdateImage()
        {
            //Resize image to suit
            if(valueImageWidth.Value != theImage.Size.Width || valueImageHeight.Value != theImage.Size.Height)
            {
                theImage.Dispose();
                theImage = new Bitmap((int)valueImageWidth.Value, (int)valueImageHeight.Value, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            }

            //Resize split container so we can fill the window/have auto-scrollbars
            ScaleCanvas();
            
            //Open a graphics instance
            Graphics gInstance = Graphics.FromImage(theImage);

            //Set Modes
            gInstance.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gInstance.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            gInstance.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            //Clear the background to desired colour
            gInstance.Clear(fillColorBox.BackColor);

            //Get font style
            FontStyle fontStyle = FontStyle.Regular;
            switch(styleSelection.SelectedItem)
            {
                case "Regular":
                    fontStyle = FontStyle.Regular;
                    break;
                case "Bold":
                    fontStyle = FontStyle.Bold;
                    break;
                case "Italic":
                    fontStyle = FontStyle.Italic;
                    break;
                case "Underline":
                    fontStyle = FontStyle.Underline;
                    break;
                case "Strikeout":
                    fontStyle = FontStyle.Strikeout;
                    break;
                default:
                    break;
            }

            //Get size of font
            Font theFont = new Font(fontSelection.Text, (float)valueFontSize.Value, fontStyle);
            SizeF fontDimensions = GetLargestCharacter(gInstance, theFont, fontMapping);
            SizeF fSpacing = CalculateSpacingValues(gInstance, theFont, fontMapping);

            //Draw the font map
            for(int i = 0; i < fontMapping.Length; ++i)
            {
                string strChar = fontMapping[i].ToString();
                float fOffset = fontDimensions.Width * 0.5f; //Shifts the first character half a width to put it on the canvas
                float fOX = fSpacing.Width * (float)(i % (int)spriteRows.Value);
                float fX = fOffset + fOX;
                float fY = fSpacing.Height * (float)Math.Floor((double)(i / (int)spriteRows.Value));

                SizeF characterSize = gInstance.MeasureString(strChar, theFont);
                fX -= characterSize.Width * 0.5f;

                gInstance.DrawString(strChar, theFont, new SolidBrush(fontColorBox.BackColor), fX, fY);
                if(checkBox1.Checked) gInstance.DrawRectangle(Pens.White, fOX, fY, fontDimensions.Width, fontDimensions.Height);
            }

            //Flush the new image
            gInstance.Flush();

            //Set image
            pictureBox1.Image = theImage;
        }

        private SizeF CalculateSpacingValues(Graphics _gInstance, Font _font, string _buffer)
        {
            SizeF returnValue = new SizeF(0.0f, 0.0f);
            SizeF fontDimensions = GetLargestCharacter(_gInstance, _font, _buffer);

            int iRows = (int)spriteRows.Value;
            int iCols = (int)spriteCols.Value;

            float fStringWidth = fontDimensions.Width * iRows; //Get the row length in pixels
            float fShrinkDelta = theImage.Width - fStringWidth; //Find out how much we under/overshoot the image width by
            float fAdjusted = (fShrinkDelta / iRows); //Divide the delta by number in row to get per-item offset
            
            returnValue.Width = fontDimensions.Width + fAdjusted;
            returnValue.Height = (theImage.Height / iCols);

            return (returnValue);
        }

        private SizeF GetLargestCharacter(Graphics _gInstance, Font _font, string _buffer = "")
        {
            SizeF returnVar = new SizeF(0.0f, 0.0f);

            if (_buffer.Length != 0)
            {
                for(int i = 0; i < _buffer.Length; ++i)
                {
                    SizeF charSize = _gInstance.MeasureString(_buffer[i].ToString(), _font);
                    if (returnVar.Width < charSize.Width) returnVar.Width = charSize.Width;
                    if (returnVar.Height < charSize.Height) returnVar.Height = charSize.Height;
                }
            }
            else
            {
                //Test entire font
                for(int i = 0; i < 128; ++i)
                {
                    SizeF charSize = _gInstance.MeasureString(char.ToString((char)i), _font);
                    if (returnVar.Width < charSize.Width) returnVar.Width = charSize.Width;
                    if (returnVar.Height < charSize.Height) returnVar.Height = charSize.Height;
                }
            }

            return(returnVar);
        }

        private void spriteRows_ValueChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void spriteCols_ValueChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void valueImageWidth_ValueChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void valueImageHeight_ValueChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void valueFontSize_ValueChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void fontSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check styles
            InstalledFontCollection fontsCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = fontsCollection.Families;

            bool canReg = fontFamilies[fontSelection.SelectedIndex].IsStyleAvailable(FontStyle.Regular);
            bool canBold = fontFamilies[fontSelection.SelectedIndex].IsStyleAvailable(FontStyle.Bold);
            bool canItalic = fontFamilies[fontSelection.SelectedIndex].IsStyleAvailable(FontStyle.Italic);
            bool canUnderline = fontFamilies[fontSelection.SelectedIndex].IsStyleAvailable(FontStyle.Underline);
            bool canStrike = fontFamilies[fontSelection.SelectedIndex].IsStyleAvailable(FontStyle.Strikeout);

            styleSelection.Items.Clear();
            if (canReg) styleSelection.Items.Add("Regular");
            if (canBold) styleSelection.Items.Add("Bold");
            if (canItalic) styleSelection.Items.Add("Italic");
            if (canUnderline) styleSelection.Items.Add("Underline");
            if (canStrike) styleSelection.Items.Add("Strikeout");
            styleSelection.SelectedIndex = 0;

            UpdateImage();
        }

        private void fontmapText_TextChanged(object sender, EventArgs e)
        {
            fontMapping = "";

            for(int i = 0; i < fontmapText.Text.Length; ++i)
            {
                if (fontmapText.Text[i] == '\r') continue;
                if (fontmapText.Text[i] == '\n') continue;
                fontMapping += fontmapText.Text[i];
            }

            UpdateImage();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ScaleCanvas();
        }

        private void fillColorText_TextChanged(object sender, EventArgs e)
        {
            //Check that we are a valid hex len
            if (fontColorText.Text.Length == 9)
            {
                //Attempt to get the color
                try
                {
                    ColorConverter colorconv = new ColorConverter();
                    fillColorBox.BackColor = (Color)colorconv.ConvertFromString(fillColorText.Text);
                }
                catch (Exception)
                {
                    //Ignore invalid code
                    fillColorBox.BackColor = Color.Black;
                }

                UpdateImage();
            }
        }

        private void fillColorBox_Click(object sender, EventArgs e)
        {
            //Show color dialog and fill textbox from that
            colorDialog1.ShowDialog();
            fillColorBox.BackColor = colorDialog1.Color;
            fillColorText.Text = "#" + colorDialog1.Color.A.ToString("X2") + colorDialog1.Color.R.ToString("X2") + colorDialog1.Color.G.ToString("X2") + colorDialog1.Color.B.ToString("X2");

            UpdateImage();
        }

        private void fontColor_TextChanged(object sender, EventArgs e)
        {
            //Check that we are a valid hex len
            if (fontColorText.Text.Length == 9)
            {
                //Attempt to get the color
                try
                {
                    ColorConverter colorconv = new ColorConverter();
                    fontColorBox.BackColor = (Color)colorconv.ConvertFromString(fontColorText.Text);
                }
                catch (Exception)
                {
                    //Ignore invalid code
                    fontColorBox.BackColor = Color.White;
                }

                UpdateImage();
            }
        }

        private void fontColorBox_Click(object sender, EventArgs e)
        {
            //Show color dialog and fill textbox from that
            colorDialog1.ShowDialog();
            fontColorBox.BackColor = colorDialog1.Color;
            fontColorText.Text = "#" + colorDialog1.Color.A.ToString("X2") + colorDialog1.Color.R.ToString("X2") + colorDialog1.Color.G.ToString("X2") + colorDialog1.Color.B.ToString("X2");

            UpdateImage();
        }

        private void styleSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;
            switch (styleSelection.SelectedItem)
            {
                case "Regular":
                    fontStyle = FontStyle.Regular;
                    break;
                case "Bold":
                    fontStyle = FontStyle.Bold;
                    break;
                case "Italic":
                    fontStyle = FontStyle.Italic;
                    break;
                case "Underline":
                    fontStyle = FontStyle.Underline;
                    break;
                case "Strikeout":
                    fontStyle = FontStyle.Strikeout;
                    break;
                default:
                    break;
            }
            
            Graphics gInstance = Graphics.FromImage(theImage);
            Font theFont = new Font(fontSelection.Text, (float)valueFontSize.Value, fontStyle);
            UpdatePreview(gInstance, theFont, fontMapping, previewRow, previewCol);

            ++previewRow;
            if(previewRow % (int)spriteRows.Value == 0) ++previewCol;
            previewRow %= (int)spriteRows.Value;
            previewCol %= (int)spriteCols.Value;

            if(previewRow + previewCol > fontMapping.Length)
            {
                previewRow = 0;
                previewCol = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "newfont";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Drawing.Imaging.ImageFormat desiredFormat = System.Drawing.Imaging.ImageFormat.Bmp;

            //Get output file format from filename extension
            switch(saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf('.')).ToLower())
            {
                case ".bmp":
                    desiredFormat = System.Drawing.Imaging.ImageFormat.Bmp;
                    break;
                case ".jpg":
                case ".jpeg":
                    desiredFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    break;
                case ".png":
                    desiredFormat = System.Drawing.Imaging.ImageFormat.Png;
                    break;
                case ".tiff":
                    desiredFormat = System.Drawing.Imaging.ImageFormat.Tiff;
                    break;
                case ".gif":
                    desiredFormat = System.Drawing.Imaging.ImageFormat.Gif;
                    break;
                default:
                    break;
            }

            //Save file
            theImage.Save(saveFileDialog1.FileName, desiredFormat);
        }
    }
}