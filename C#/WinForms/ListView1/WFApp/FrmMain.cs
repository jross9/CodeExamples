using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WFApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            this.lvItems.Items.Add("Item 1");
            this.lvItems.Items.Add("Item 2");
            this.lvItems.Items.Add("Item 3");
            this.lvItems.Items.Add("Item 4");
            this.lvItems.Items.Add("Item 5");
            this.lvItems.Items.Add("Item 6");
            this.lvItems.Items.Add("Item 7");
        }
    }
}
