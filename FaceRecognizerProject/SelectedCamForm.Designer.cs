namespace FaceRecognizerProject
{
    partial class SelectedCamForm
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
            this.grid1 = new FaceRecognizerProject.Grid();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.BackColor = System.Drawing.SystemColors.Control;
            this.grid1.ControlType = FaceRecognizerProject.ControlType.ImageBox;
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(800, 640);
            this.grid1.TabIndex = 0;
            // 
            // SelectedCamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.grid1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectedCamForm";
            this.Text = "SelectedCamForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Grid grid1;
    }
}