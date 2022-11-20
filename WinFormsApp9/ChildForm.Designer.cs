
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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChildWindowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildTextBox
            // 
            this.ChildTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildTextBox.Location = new System.Drawing.Point(0, 24);
            this.ChildTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChildTextBox.Name = "ChildTextBox";
            this.ChildTextBox.Size = new System.Drawing.Size(747, 348);
            this.ChildTextBox.TabIndex = 0;
            this.ChildTextBox.Text = "";
            // 
            // ChildWindowMenu
            // 
            this.ChildWindowMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ChildWindowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ТoggleMenuItem,
            this.editToolStripMenuItem});
            this.ChildWindowMenu.Location = new System.Drawing.Point(0, 0);
            this.ChildWindowMenu.Name = "ChildWindowMenu";
            this.ChildWindowMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.ChildWindowMenu.Size = new System.Drawing.Size(747, 24);
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
            this.formatToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.formatToolStripMenuItem1.Text = "&Toggle Foreground";
            this.formatToolStripMenuItem1.Click += new System.EventHandler(this.formatToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.pastToolStripMenuItem,
            this.selectToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "&Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // pastToolStripMenuItem
            // 
            this.pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            this.pastToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pastToolStripMenuItem.Text = "&Past";
            this.pastToolStripMenuItem.Click += new System.EventHandler(this.pastToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectToolStripMenuItem.Text = "&Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 372);
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
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem ТoggleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
    }
}