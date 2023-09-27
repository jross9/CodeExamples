using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WFApp
{
    public partial class DlgItem : Form
    {
        public string TxtItem { get { return txtItem.Text; } } 

        public DlgItem()
        {
            InitializeComponent();
        }
    }
}
