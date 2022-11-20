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
        private String BufferText;
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



        public void Cut()
        {
            BufferText = ChildTextBox.SelectedText;
            ChildTextBox.SelectedText = "";
        }
        public void Copy()
        {
            BufferText = ChildTextBox.SelectedText;
        }
        public void Delete()
        {
            ChildTextBox.SelectedText = "";
            BufferText = "";
        }
        public void Paste()
        {
            ChildTextBox.SelectedText = BufferText;
        }
        public void SelectAll()
        {
            ChildTextBox.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }
    }
}
