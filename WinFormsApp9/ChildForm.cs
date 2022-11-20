using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void formatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ТoggleMenuItem.Checked)
            {
                ТoggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = Color.Black;
            }
            else
            {
                ТoggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = Color.Blue;
            }
        }

        private void FormatMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
