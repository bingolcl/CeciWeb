using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class frmImageBox : Form
    {
        public frmImageBox(Image i)
        {
            InitializeComponent();            
            ptbContact.Image = LoadImage( i, this);
        }

        private Bitmap LoadImage(Image i, Form f)
        {
            var maxSize = Screen.PrimaryScreen.WorkingArea.Size;
            var bitMap = new Bitmap(i);
            if (i.Width > maxSize.Width && i.Height > maxSize.Height)
            {
                bitMap = ImageHelper.ResizeImage(bitMap, maxSize.Width, maxSize.Height);
                this.Size = maxSize;
            }
            else
            {
                if (i.Width > maxSize.Width)
                {
                    bitMap = ImageHelper.ResizeImage(bitMap, maxSize.Width, i.Height);
                    this.Width = maxSize.Width;
                }
                else
                {
                    this.Width = i.Width;
                }
                if (i.Height > maxSize.Height)
                {
                    bitMap = ImageHelper.ResizeImage(bitMap, i.Width, maxSize.Height);
                    this.Height = maxSize.Height;
                }
                else
                {
                    this.Height = i.Height;
                }
            }
            return bitMap;
        }

    }
}
