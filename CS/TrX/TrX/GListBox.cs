using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace TrX
{
    // GListBoxItem class 
    public class GListBoxItem
    {
        private string _myText;
        private string _myImageIndex;
        // properties 
        public string Text
        {
            get
            {
                return _myText;
            }
            set
            {
                _myText = value;
            }
        }
        public string ImageName
        {
            get
            {
                return _myImageIndex;
            }
            set
            {
                _myImageIndex = value;
            }
        }
        //constructor
        public GListBoxItem(string sText, string sImageName)
        {
            _myText = sText;
            _myImageIndex = sImageName;
        }
        public GListBoxItem(string sText): this(sText, ""){}
        public GListBoxItem(): this(""){}
        public override string ToString()
        {
            return _myText;
        }
    }//End of GListBoxItem class

    // GListBox class 
    public class GListBox : ListBox
    {
        private string _myImagePath;
        private int _imageWidth;
        public string ImagesPath
        {
            get {return _myImagePath;}
            set {_myImagePath = value;}
        }
        public int ImageWidth
        {
            get
            {
                return _imageWidth;
            }
            set
            {
                _imageWidth = value;
            }
        }
        public GListBox()
        {
            // Set owner draw mode
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.ItemHeight = 12;
            this.ImageWidth = 66;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            GListBoxItem item;
            Rectangle bounds = e.Bounds;
            Graphics gdc = e.Graphics;
            try
            {
                item = (GListBoxItem)Items[e.Index];
                if (!item.ImageName.Equals(string.Empty))
                {
                    gdc.DrawImage(new Bitmap(this.ImagesPath + item.ImageName), bounds);
                    //ImagesPath.Draw(e.Graphics, bounds.Left, bounds.Top, item.ImageName);
                    gdc.DrawString(item.Text, e.Font, new SolidBrush(e.ForeColor),
                        bounds.Left + this.ImageWidth, bounds.Top);
                }
                else
                {
                    gdc.DrawString(item.Text, e.Font, new SolidBrush(e.ForeColor),
                        bounds.Left, bounds.Top);
                }
            }
            catch
            {
                if (e.Index != -1)
                {
                    gdc.DrawString(Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), bounds.Left, bounds.Top);
                }
                else
                {
                    gdc.DrawString(Text, e.Font, new SolidBrush(e.ForeColor), bounds.Left, bounds.Top);
                }
            }
            base.OnDrawItem(e);
        }

        internal void ShowItems(List<GListBoxItem> glbiItems)
        {
            this.Items.Clear();
            //this.Items.AddRange(glbiItems.ToArray());
            foreach (GListBoxItem glbiCur in glbiItems)
                this.Items.Add(glbiCur.Text);
        }
    }//End of GListBox class
}
