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

            for (int i = 1; i <= 50; i++)
            {
                this.lvItems.Items.Add("Item " + i);
            }

            this.lblMsg.Text = "";
        }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

            this.ResizeControls();
        }

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

            this.ResizeControls();
        }

        private void ResizeControls()
        {
            this.lvItems.Columns[0].Width = this.lvItems.Width - SystemInformation.VerticalScrollBarWidth - 5;
            this.lvItems.Height = this.ClientSize.Height - this.lblMsg.Height;
        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvItems.SelectedItems.Count != 0)
            {
                this.lblMsg.Text = this.lvItems.SelectedItems[0].Text;
                this.lblMsg.Tag = this.lvItems.SelectedIndices[0];
            }
        }

        private void lvItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You Double Clicked: " + this.lvItems.SelectedItems[0].Text, "Message!");
        }

        private void lblMsg_DoubleClick(object sender, EventArgs e)
        {
            int idx = (int)this.lblMsg.Tag;
            MessageBox.Show("You Double Clicked: " + this.lvItems.Items[idx].Text, "Message!");
            // this.lvItems.Items.RemoveAt(idx);
        }
    }
}
