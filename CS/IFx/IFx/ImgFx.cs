#region Includes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion

namespace ASquigglyTwist
{
    namespace IFx
    {
        #region ImgFx
        public partial class ImgFx : Form
        {
            #region Skeleton
            int Ht, Wth;
            int ored, ogrin, oblue;
            int ired, igrin, iblue;
            int enh, thresh;
            int timerss;
            Mode crent;
            string[] _AsciiChars = { "#", "/", "@", "%", "+", "*", ":", "-", "1", "l", "|", "$" };
            string _content;
            Image resImg;
            Bitmap bmp;
            Color tcol;
            DialogResult UIRes;
            InputBox iBox;

            #region ImgFx Page
            public ImgFx()
            {
                InitializeComponent();
                _content = "";
                oDlg0.FileName = "";
                sDlg0.FileName = "";
                sDlg1.FileName = "";
                iBox = new InputBox(this);
                crent = Mode.Resize;
            }
            #endregion
            #endregion

            #region Supporters
            #region Notifications
            internal void OnContentCreated()
            {
                browserMain.DocumentText = "<pre>" + "<Font size=0>" + _content + "</Font></pre>";
                browserMain.BringToFront();
            }

            internal void OnImageSelected()
            {
                picOriginal.Image = Image.FromFile(lblPath.Text);
                picPreview.Image = Image.FromFile(lblPath.Text);
                lblSize.Text = picPreview.Image.Size.ToString();
            }
            #endregion

            #region Sepia Tone
            private void Sepiaze(Bitmap bitmap)
            {
                bmp = new Bitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        tcol = bitmap.GetPixel(i, j);
                        ired = tcol.R;
                        igrin = tcol.G;
                        iblue = tcol.B;
                        ored = (int)((ired * 0.393) + (igrin * 0.769) + (iblue * 0.189));
                        if (ored > 255)
                            ored = 255;
                        ogrin = (int)((ired * 0.349) + (igrin * 0.686) + (iblue * 0.168));
                        if (ogrin > 255)
                            ogrin = 255;
                        oblue = (int)((ired * 0.272) + (igrin * 0.534) + (iblue * 0.131));
                        if (oblue > 255)
                            oblue = 255;
                        tcol = Color.FromArgb(ored, ogrin, oblue);
                        bmp.SetPixel(i, j, tcol);
                    }
                }
                picPreview.Image = bmp;
            }
            #endregion

            #region Pencil Sketch
            private void Pencilize(Bitmap bitmap)
            {
                int pre0, pre1;
                pre0 = pre1 = -1;
                bmp = new Bitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        tcol = bitmap.GetPixel(i, j);
                        ired = tcol.R;
                        igrin = tcol.G;
                        iblue = tcol.B;
                        ored = ((2 * ired) + igrin + iblue) / 4;
                        ogrin = ((2 * igrin) + ired + iblue) / 4;
                        oblue = ((2 * iblue) + igrin + ired) / 4;
                        ored = ored + ogrin + oblue;
                        ored /= 3;

                        if (ored < 32)
                            ored = 0;
                        else if (ored < 64)
                            ored = 31;
                        else if (ored < 96)
                            ored = 63;
                        else if (ored < 128)
                            ored = 95;
                        else if (ored < 160)
                            ored = 127;
                        else if (ored < 192)
                            ored = 162;
                        else if (ored < 224)
                            ored = 194;
                        else
                            ored = 255;

                        if ((pre0 == pre1) && (pre0 == ored))
                            ored = 255;
                        else if (pre0 < 0)
                            pre0 = ored;
                        else if (pre1 < 0)
                            pre1 = ored;
                        else
                        {
                            pre0 = pre1;
                            pre1 = ored;
                        }
                        tcol = Color.FromArgb(ored, ored, ored);
                        bmp.SetPixel(i, j, tcol);
                    }
                }
                picPreview.Image = bmp;
            }
            #endregion

            #region Solar Panel
            internal void Solarize(Bitmap bitmap)
            {
                bmp = new Bitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        tcol = bitmap.GetPixel(i, j);
                        ired = tcol.R;
                        igrin = tcol.G;
                        iblue = tcol.B;
                        ored = ((2 * ired) + igrin + iblue) / 4;
                        ogrin = ((2 * igrin) + ired + iblue) / 4;
                        oblue = ((2 * iblue) + igrin + ired) / 4;
                        ored = ored + ogrin + oblue;
                        ored /= 3;

                        if (ored < 50)
                            ored = 0;
                        else if (ored < 110)
                            ored = 60;
                        else if (ored < 180)
                            ored = 130;
                        else if (ored < 220)
                            ored = 200;
                        else
                            ored = 255;

                        tcol = Color.FromArgb(ored, ored, ored);
                        bmp.SetPixel(i, j, tcol);
                    }
                }
                picPreview.Image = bmp;
            }
            #endregion

            #region Negative
            private void Negate(Bitmap bitmap)
            {
                bmp = new Bitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        tcol = bitmap.GetPixel(i, j);
                        ired = tcol.R;
                        igrin = tcol.G;
                        iblue = tcol.B;
                        ored = 255 - ired;
                        ogrin = 255 - igrin;
                        oblue = 255 - iblue;
                        tcol = Color.FromArgb(ored, ogrin, oblue);
                        bmp.SetPixel(i, j, tcol);
                    }
                }
                picPreview.Image = bmp;
            }
            #endregion

            #region RED Enhancement
            private void Reddish(Bitmap bitmap)
            {
                bmp = new Bitmap(bitmap.Width, bitmap.Height);
                enh = (int)spnEnhance.Value;
                thresh = (int)spnThreshold.Value;
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        tcol = bitmap.GetPixel(i, j);
                        ired = tcol.R;
                        ogrin = tcol.G;
                        oblue = tcol.B;
                        if (ired < thresh)
                            ored = ired;
                        else
                            ored = (ired + enh) % 255;
                        tcol = Color.FromArgb(ored, ogrin, oblue);
                        bmp.SetPixel(i, j, tcol);
                    }
                }
                picPreview.Image = bmp;
            }
            #endregion

            #region GREEN Enhancement
            private void Greenish(Bitmap bitmap)
            {
                bmp = new Bitmap(bitmap.Width, bitmap.Height);
                enh = (int)spnEnhance.Value;
                thresh = (int)spnThreshold.Value;
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        tcol = bitmap.GetPixel(i, j);
                        ored = tcol.R;
                        igrin = tcol.G;
                        oblue = tcol.B;
                        if (igrin < thresh)
                            ogrin = igrin;
                        else
                            ogrin = (igrin + enh) % 255;
                        tcol = Color.FromArgb(ored, ogrin, oblue);
                        bmp.SetPixel(i, j, tcol);
                    }
                }
                picPreview.Image = bmp;
            }
            #endregion

            #region BLUE Enhancement
            private void Bluish(Bitmap bitmap)
            {
                bmp = new Bitmap(bitmap.Width, bitmap.Height);
                enh = (int)spnEnhance.Value;
                thresh = (int)spnThreshold.Value;
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        tcol = bitmap.GetPixel(i, j);
                        ored = tcol.R;
                        ogrin = tcol.G;
                        iblue = tcol.B;
                        if (iblue < thresh)
                            oblue = iblue;
                        else
                            oblue = (iblue + enh) % 255;
                        tcol = Color.FromArgb(ored, ogrin, oblue);
                        bmp.SetPixel(i, j, tcol);
                    }
                }
                picPreview.Image = bmp;
            }
            #endregion

            #region Gray Scale
            private void Grayish(Bitmap bitmap)
            {
                bmp = new Bitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        tcol = bitmap.GetPixel(i, j);
                        ired = tcol.R;
                        igrin = tcol.G;
                        iblue = tcol.B;
                        ored = ((2 * ired) + igrin + iblue) / 4;
                        ogrin = ((2 * igrin) + ired + iblue) / 4;
                        oblue = ((2 * iblue) + igrin + ired) / 4;
                        ored = ored + ogrin + oblue;
                        ogrin = oblue = ored = ored / 3;
                        tcol = Color.FromArgb(ored, ogrin, oblue);
                        bmp.SetPixel(i, j, tcol);
                    }
                }
                picPreview.Image = bmp;
            }
            #endregion

            #region Resizing
            /// <summary>
            /// Resizes the specified Image object
            /// </summary>
            /// <param name="inputBitmap">
            /// The input Bitmap object to be re-sized
            /// </param>
            /// <param name="asciiWidth">
            /// Width of the re-sized Image
            /// </param>
            /// <returns>
            /// A Bitmap object
            /// </returns>
            private Bitmap GetReSizedBitmap(Bitmap inputBitmap, int Wdth)
            {
                if (inputBitmap != null)
                {
                    Wth = Wdth;
                    Ht = (int)Math.Ceiling((double)inputBitmap.Height * Wdth / inputBitmap.Width);
                    Bitmap result = new Bitmap(Wdth, Ht);
                    Graphics g = Graphics.FromImage((System.Drawing.Image)result);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(inputBitmap, 0, 0, Wdth, Ht);
                    g.Dispose();
                    resImg = result;
                    return result;
                }
                else
                    return null;
            }
            #endregion

            #region Open Bitmap
            private Bitmap GetBitmap()
            {
                if (File.Exists(lblPath.Text))
                {
                    return new Bitmap(lblPath.Text);
                }
                else
                    return null;
            }
            #endregion

            #region ASCII Art
            /// <summary>
            /// Compares Two Color objects component by component (i.e., R, G, B and A)
            /// </summary>
            /// <param name="one">The first Color object</param>
            /// <param name="two">The second Color object</param>
            /// <returns>True if all values match.  False otherwise</returns>
            internal bool ColorComp(Color one, Color two)
            {
                if (one.R == two.R)
                {
                    if (one.G == two.G)
                    {
                        if (one.B == two.B)
                        {
                            if (one.A == two.A)
                                return true;
                        }
                    }
                }
                return false;
            }

            #region Deprecated ASCII Art
            /// <summary>
            /// Performs the "ASCII Conversion" operation
            /// </summary>
            /// <param name="image">
            /// The Image object to be converted
            /// </param>
            /// <returns>
            /// Returns a string representation of the ASCII art of specified Image
            /// </returns>
            /*
            private string ASCIIArt(Bitmap image)
            {
                if (image != null)
                {
                    Boolean toggle = false;
                    StringBuilder sb = new StringBuilder();
                    System.Drawing.Color pixelColor, grayColor;
                    int red, green, blue, index, tempi;
                    for (int h = 0; h < image.Height; h++)
                    {
                        for (int w = 0; w < image.Width; w++)
                        {
                            pixelColor = image.GetPixel(w, h);
                            red = ((2 * pixelColor.R) + pixelColor.G + pixelColor.B) / 4;
                            green = ((2 * pixelColor.G) + pixelColor.R + pixelColor.B) / 4;
                            blue = ((2 * pixelColor.B) + pixelColor.G + pixelColor.R) / 4;
                            red = red + green + blue;
                            green = blue = red = red / 3;
                            grayColor = System.Drawing.Color.FromArgb(red, green, blue);
                            if (!toggle)
                            {
                                StringBuilder tmp = new StringBuilder("#");
                                index = (grayColor.R * (_AsciiChars.Length)) / 255;
                                index %= _AsciiChars.Length;
                                tempi = (int)pixelColor.R;
                                tmp.Append(Convert.ToString(tempi, 16));
                                tempi = (int)pixelColor.G;
                                tmp.Append(Convert.ToString(tempi, 16));
                                tempi = (int)pixelColor.B;
                                tmp.Append(Convert.ToString(tempi, 16));
                                tmp.Append(">");
                                sb.Append("<Font Color=");
                                sb.Append(tmp.ToString());
                                sb.Append(_AsciiChars[index]);
                                sb.Append("</Font>");
                            }
                        }
                        if (!toggle)
                        {
                            sb.Append("<BR>");
                            toggle = true;
                        }
                        else
                        {
                            toggle = false;
                        }
                    }
                    sb.Append("</pre></body></html>");
                    return sb.ToString();
                }
                else
                    return string.Empty;
            }*/
            #endregion

            /// <summary>
            /// Performs the "ASCII Conversion" operation in an Improved method
            /// </summary>
            /// <param name="image">
            /// The Image object to be converted
            /// </param>
            /// <returns>
            /// Returns a string containing the ASCII art of specified Image
            /// </returns>
            private string ASCIIArt(Bitmap image)
            {
                if (image != null)
                {
                    Boolean toggle = false;
                    Boolean closing = true, openfonttag = false;
                    StringBuilder sb = new StringBuilder();
                    System.Drawing.Color pixelColor, grayColor, prevColor;
                    int red, green, blue, index, tempi;
                    prevColor = Color.Black;
                    for (int h = 0; h < image.Height; h++)
                    {
                        for (int w = 0; w < image.Width; w++)
                        {
                            pixelColor = image.GetPixel(w, h);
                            red = ((2 * pixelColor.R) + pixelColor.G + pixelColor.B) / 4;
                            green = ((2 * pixelColor.G) + pixelColor.R + pixelColor.B) / 4;
                            blue = ((2 * pixelColor.B) + pixelColor.G + pixelColor.R) / 4;
                            red = red + green + blue;
                            green = blue = red = red / 3;
                            grayColor = System.Drawing.Color.FromArgb(red, green, blue);
                            if (!toggle)
                            {
                                index = (grayColor.R * (_AsciiChars.Length)) / 255;
                                index %= _AsciiChars.Length;
                                if (!openfonttag)
                                {
                                    StringBuilder tmp = new StringBuilder("#");
                                    tempi = (int)pixelColor.R;
                                    if (tempi < 10)
                                        tmp.Append("0");
                                    tmp.Append(Convert.ToString(tempi, 16));
                                    tempi = (int)pixelColor.G;
                                    if (tempi < 10)
                                        tmp.Append("0");
                                    tmp.Append(Convert.ToString(tempi, 16));
                                    tempi = (int)pixelColor.B;
                                    if (tempi < 10)
                                        tmp.Append("0");
                                    tmp.Append(Convert.ToString(tempi, 16));
                                    tmp.Append(">");
                                    sb.Append("<Font Color=");
                                    sb.Append(tmp.ToString());
                                    openfonttag = true;
                                }
                                sb.Append(_AsciiChars[index]);
                                if (openfonttag)
                                {
                                    if (ColorComp(prevColor, pixelColor))
                                        closing = false;
                                    else
                                        closing = true;
                                }
                                else
                                {
                                    openfonttag = false;
                                    closing = true;
                                }
                                if (closing)
                                {
                                    sb.Append("</Font>");
                                    openfonttag = false;
                                }
                                prevColor = pixelColor;
                            }
                        }
                        if (!toggle)
                        {
                            sb.Append("<BR>");
                            toggle = true;
                        }
                        else
                        {
                            toggle = false;
                        }
                    }
                    sb.Append("</h6></pre></body></html>");
                    return sb.ToString();
                }
                else
                    return string.Empty;
            }
            #endregion

            #region Save ASCII Art
            internal void SaveASCII()
            {
                UIRes = sDlg0.ShowDialog();
                if (UIRes == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sDlg0.FileName);
                    sw.Write(_content);
                    sw.Flush();
                    sw.Close();
                    lblStatus.Text = "Save Successful";
                }
                else
                    lblStatus.Text = "Save Failed";
            }
            #endregion

            #region Save Image
            private void SaveImage()
            {
                UIRes = sDlg1.ShowDialog();
                if (UIRes == DialogResult.OK)
                {
                    switch (sDlg1.FilterIndex)
                    {
                        case 1:
                            picPreview.Image.Save(sDlg1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case 2:
                            picPreview.Image.Save(sDlg1.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                        case 3:
                            picPreview.Image.Save(sDlg1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case 4:
                            picPreview.Image.Save(sDlg1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                    }
                    lblStatus.Text = "Save Successful";
                }
                else
                {
                    lblStatus.Text = "Save Failed";
                }
            }
            #endregion
            #endregion

            #region Event Handling

            #region Image Enlargement
            private void Image_DoubleClick(object sender, EventArgs e)
            {
                if (((PictureBox)sender).Dock == DockStyle.Fill)
                {
                    ((PictureBox)sender).Dock = DockStyle.None;
                }
                else
                {
                    ((PictureBox)sender).Dock = DockStyle.Fill;
                    ((PictureBox)sender).BringToFront();
                }
            }
            #endregion

            #region Button Triggers
            private void btnClose_Click(object sender, EventArgs e)
            {
                lblStatus.Text = "Exiting";
                this.Close();
            }

            private void btnBrowse_Click(object sender, EventArgs e)
            {
                UIRes = oDlg0.ShowDialog();
                if (UIRes == DialogResult.OK)
                {
                    if (File.Exists(oDlg0.FileName))
                    {
                        lblPath.Text = oDlg0.FileName;
                        lblStatus.Text = "Image selected";
                        OnImageSelected();
                    }
                    else
                        lblStatus.Text = "Image not Selected";
                }
            }

            private void btnConvert_Click(object sender, EventArgs e)
            {
                lblStatus.Text = lblMode.Text + " Conversion Initiated";
                timerss = System.Environment.TickCount;
                this.Enabled = false;
                switch (crent)
                {
                    case Mode.ASCIIArt:
                        _content = "<html><head><title>ASCII Art</title><style type=\"text/css\"><!--   body {font-size:100%;}  h6 {font-size:0.15em; font-family:\"Lucida Console\", Times, serif;}   --></style></head><body><h6><pre>";
                        _content += ASCIIArt(GetBitmap());
                        browserMain.DocumentText = _content;
                        break;
                    case Mode.BLUE:
                        Bluish(GetBitmap());
                        break;
                    case Mode.GrayScale:
                        Grayish(GetBitmap());
                        break;
                    case Mode.GREEN:
                        Greenish(GetBitmap());
                        break;
                    case Mode.Negative:
                        Negate(GetBitmap());
                        break;
                    case Mode.PencilSketch:
                        Pencilize(GetBitmap());
                        break;
                    case Mode.RED:
                        Reddish(GetBitmap());
                        break;
                    case Mode.Resize:
                        picPreview.Image = GetReSizedBitmap(GetBitmap(), track.Value);
                        break;
                    case Mode.Sepia:
                        Sepiaze(GetBitmap());
                        break;
                    case Mode.Solarize:
                        Solarize(GetBitmap());
                        break;
                }
                timerss = System.Environment.TickCount - timerss;
                GC.GetTotalMemory(true);
                GC.Collect();
                this.Enabled = true;
                lblTimer.Text = String.Format("{0:0,0.000}", (((float)timerss) / 1000)) + "\r\nSeconds";
                lblStatus.Text = "Conversion Completed";
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                switch (crent)
                {
                    case Mode.ASCIIArt:
                        SaveASCII();
                        break;
                    case Mode.BLUE:
                    case Mode.GrayScale:
                    case Mode.GREEN:
                    case Mode.Negative:
                    case Mode.PencilSketch:
                    case Mode.RED:
                    case Mode.Resize:
                    case Mode.Sepia:
                    case Mode.Solarize:
                        SaveImage();
                        break;
                }
            }
            #endregion

            #region Mode Selection
            private void rdoResize_CheckedChanged(object sender, EventArgs e)
            {
                if (rdoResize.Checked)
                {
                    track.Enabled = true;
                    track.Value = 100;
                    lblMode.Text = "Resize";
                    crent = Mode.Resize;
                    spnEnhance.Enabled = false;
                }
                else
                    track.Enabled = false;
            }

            private void rdoASCIIArt_CheckedChanged(object sender, EventArgs e)
            {
                if (rdoASCIIArt.Checked)
                {
                    browserMain.BringToFront();
                    track.Enabled = true;
                    track.Value = 100;
                    lblMode.Text = "ASCIIArt";
                    crent = Mode.ASCIIArt;
                    spnEnhance.Enabled = false;
                }
                else
                {
                    track.Enabled = false;
                    picPreview.BringToFront();
                }
            }

            private void rdoPencilSketch_CheckedChanged(object sender, EventArgs e)
            {
                if (rdoPencilSketch.Checked)
                {
                    lblMode.Text = "PencilSketch";
                    crent = Mode.PencilSketch;
                    spnEnhance.Enabled = false;
                }
            }

            private void rdoSepia_CheckedChanged(object sender, EventArgs e)
            {
                if (rdoSepia.Checked)
                {
                    lblMode.Text = "Sepia";
                    crent = Mode.Sepia;
                    spnEnhance.Enabled = false;
                }
            }

            private void rdoNegative_CheckedChanged(object sender, EventArgs e)
            {
                if (rdoNegative.Checked)
                {
                    lblMode.Text = "Negative";
                    crent = Mode.Negative;
                    spnEnhance.Enabled = false;
                }
            }

            private void rdoGrayScale_CheckedChanged(object sender, EventArgs e)
            {
                if (rdoGrayScale.Checked)
                {
                    lblMode.Text = "GrayScale";
                    crent = Mode.GrayScale;
                    spnEnhance.Enabled = false;
                }
            }

            private void rdoRed_CheckedChanged(object sender, EventArgs e)
            {
                if (rdoRed.Checked)
                {
                    lblMode.Text = "RED";
                    crent = Mode.RED;
                    spnEnhance.Enabled = true;
                }
            }

            private void rdoGreen_CheckedChanged(object sender, EventArgs e)
            {
                if (rdoGreen.Checked)
                {
                    lblMode.Text = "GREEN";
                    crent = Mode.GREEN;
                    spnEnhance.Enabled = true;
                }
            }

            private void rdoBlue_CheckedChanged(object sender, EventArgs e)
            {
                if (rdoBlue.Checked)
                {
                    lblMode.Text = "BLUE";
                    crent = Mode.BLUE;
                    spnEnhance.Enabled = true;
                }
            }

            private void rdoSolar_CheckedChanged(object sender, EventArgs e)
            {
                if (rdoSolar.Checked)
                {
                    lblMode.Text = "Solarize";
                    crent = Mode.Solarize;
                    spnEnhance.Enabled = false;
                }
            }
            #endregion

            #region Label Actions
            private void lblPreview_Click(object sender, EventArgs e)
            {
                if (crent == Mode.ASCIIArt)
                {
                    browserMain.Dock = DockStyle.Top;
                    browserMain.BringToFront();
                }
            }

            private void lblPath_Click(object sender, EventArgs e)
            {
                browserMain.Dock = DockStyle.None;
                Clipboard.SetData(DataFormats.Text, lblPath.Text);
            }

            private void lblTVal_Click(object sender, EventArgs e)
            {
                UIRes = iBox.ShowDialog();
                if (UIRes == DialogResult.OK)
                {
                    track.Value = (int)iBox.SizeValue;
                }
            }
            #endregion

            private void track_ValueChanged(object sender, EventArgs e)
            {
                lblVal.Text = track.Value.ToString();
            }

            private void spnEnhance_EnabledChanged(object sender, EventArgs e)
            {
                spnThreshold.Enabled = spnEnhance.Enabled;
            }
            #endregion
        }
        #endregion

        #region Modes
        public enum Mode
        {
            ASCIIArt = 0,
            GrayScale = 1,
            PencilSketch = 2,
            Sepia = 3,
            Negative = 4,
            Resize = 5,
            RED = 6,
            GREEN = 7,
            BLUE = 8,
            Solarize = 9
        }
        #endregion
    }
}