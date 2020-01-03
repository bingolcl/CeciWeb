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
    public partial class ContactImage : Form
    {
        public ContactImage(Image i)
        {
            InitializeComponent();
            ptbContact.Image = i;
        }


    }
}
