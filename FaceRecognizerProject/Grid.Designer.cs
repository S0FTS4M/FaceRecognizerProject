namespace FaceRecognizerProject
{
    partial class Grid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMSCell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rotateTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNone = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem90 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem180 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem270 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMSCell.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMSCell
            // 
            this.contextMSCell.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMSCell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateTypeToolStripMenuItem});
            this.contextMSCell.Name = "contextMSCell";
            this.contextMSCell.Size = new System.Drawing.Size(154, 28);
            this.contextMSCell.Opening += new System.ComponentModel.CancelEventHandler(this.contextMSCell_Opening);
            // 
            // rotateTypeToolStripMenuItem
            // 
            this.rotateTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNone,
            this.menuItem90,
            this.menuItem180,
            this.menuItem270});
            this.rotateTypeToolStripMenuItem.Name = "rotateTypeToolStripMenuItem";
            this.rotateTypeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.rotateTypeToolStripMenuItem.Text = "RotateType";
            // 
            // menuItemNone
            // 
            this.menuItemNone.Name = "menuItemNone";
            this.menuItemNone.Size = new System.Drawing.Size(216, 26);
            this.menuItemNone.Text = "None";
            this.menuItemNone.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem90
            // 
            this.menuItem90.Name = "menuItem90";
            this.menuItem90.Size = new System.Drawing.Size(216, 26);
            this.menuItem90.Text = "90 Deg";
            this.menuItem90.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem180
            // 
            this.menuItem180.Name = "menuItem180";
            this.menuItem180.Size = new System.Drawing.Size(216, 26);
            this.menuItem180.Text = "180 Deg";
            this.menuItem180.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem270
            // 
            this.menuItem270.Name = "menuItem270";
            this.menuItem270.Size = new System.Drawing.Size(216, 26);
            this.menuItem270.Text = "270 Deg";
            this.menuItem270.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Grid";
            this.Size = new System.Drawing.Size(800, 640);
            this.contextMSCell.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMSCell;
        private System.Windows.Forms.ToolStripMenuItem rotateTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNone;
        private System.Windows.Forms.ToolStripMenuItem menuItem90;
        private System.Windows.Forms.ToolStripMenuItem menuItem180;
        private System.Windows.Forms.ToolStripMenuItem menuItem270;
    }
}
