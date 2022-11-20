
namespace MdiApplication
{
    partial class ChildForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChildTextBox = new System.Windows.Forms.RichTextBox();
            this.ChildWindowMenu = new System.Windows.Forms.MenuStrip();
            this.ТoggleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChildWindowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildTextBox
            // 
            this.ChildTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildTextBox.Location = new System.Drawing.Point(0, 24);
            this.ChildTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChildTextBox.Name = "ChildTextBox";
            this.ChildTextBox.Size = new System.Drawing.Size(700, 314);
            this.ChildTextBox.TabIndex = 0;
            this.ChildTextBox.Text = "";
            // 
            // ChildWindowMenu
            // 
            this.ChildWindowMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ChildWindowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ТoggleMenuItem});
            this.ChildWindowMenu.Location = new System.Drawing.Point(0, 0);
            this.ChildWindowMenu.Name = "ChildWindowMenu";
            this.ChildWindowMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.ChildWindowMenu.Size = new System.Drawing.Size(700, 24);
            this.ChildWindowMenu.TabIndex = 1;
            this.ChildWindowMenu.Text = "menuStrip1";
            // 
            // ТoggleMenuItem
            // 
            this.ТoggleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatToolStripMenuItem1});
            this.ТoggleMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ТoggleMenuItem.MergeIndex = 1;
            this.ТoggleMenuItem.Name = "ТoggleMenuItem";
            this.ТoggleMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ТoggleMenuItem.Text = "F&ormat";
            this.ТoggleMenuItem.Click += new System.EventHandler(this.FormatMenuItem_Click);
            // 
            // formatToolStripMenuItem1
            // 
            this.formatToolStripMenuItem1.Name = "formatToolStripMenuItem1";
            this.formatToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.formatToolStripMenuItem1.Text = "&Toggle Foreground";
            this.formatToolStripMenuItem1.Click += new System.EventHandler(this.formatToolStripMenuItem1_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.ChildTextBox);
            this.Controls.Add(this.ChildWindowMenu);
            this.MainMenuStrip = this.ChildWindowMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChildForm";
            this.Text = "Child Form";
            this.ChildWindowMenu.ResumeLayout(false);
            this.ChildWindowMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ChildTextBox;
        private System.Windows.Forms.MenuStrip ChildWindowMenu;
        private System.Windows.Forms.ToolStripMenuItem ТoggleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem1;
    }
}