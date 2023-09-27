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

            this.lvItems.SelectedIndices.Add(0);
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
        }

        private void lvItems_MouseDoubleClick(object sender, MouseEventArgs e) 
        {
            MessageBox.Show("You Double Clicked: " + this.lvItems.SelectedItems[0].Text, "Message!");
        }

        private void ctxMenuDeleteItem_Click(object sender, EventArgs e) 
        {
            this.DeleteSelectedItem();
        }

        private void DeleteSelectedItem() 
        {
            if (this.lvItems.SelectedIndices.Count == 1)
            {
                int selectIdx = this.lvItems.SelectedIndices[0];

                this.lvItems.Items.RemoveAt(selectIdx);

                if (this.lvItems.Items.Count != 0)
                    if (this.lvItems.Items.Count == selectIdx)
                        this.lvItems.SelectedIndices.Add(selectIdx - 1);
                    else
                        this.lvItems.SelectedIndices.Add(selectIdx);
            }
        }

        private void ctxMnuAddItem_Click(object sender, EventArgs e) 
        {
            this.AddItemAboveSelected();
        }

        private void AddItemAboveSelected() 
        {
            DlgItem dlg = new DlgItem();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK && !string.IsNullOrEmpty(dlg.TxtItem))
            {
                if (this.lvItems.Items.Count == 0)
                {
                    this.lvItems.Items.Add(dlg.TxtItem);
                    this.lvItems.SelectedIndices.Add(0);
                }
                else
                    this.lvItems.Items.Insert(this.lvItems.SelectedIndices[0], dlg.TxtItem);
            }
        }

        private void lvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                this.AddItemAboveSelected();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                this.DeleteSelectedItem();
            }
        }
    }
}
