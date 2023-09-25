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

            for (int i = 1; i < 50; i++)
            {
                this.lvItems.Items.Add("Item " + i);
            }
        }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

            this.lvItems.Columns[0].Width = lvItems.Width - SystemInformation.VerticalScrollBarWidth - 5;
        }

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

			this.lvItems.Columns[0].Width = lvItems.Width - SystemInformation.VerticalScrollBarWidth - 5;
		}
	}
}
