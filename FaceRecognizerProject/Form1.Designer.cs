namespace FaceRecognizerProject
{
    partial class frmfacerec
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
            this.components = new System.ComponentModel.Container();
            this.timerCameraFramer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.folderBrowserTraininImages = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCapturingInfo = new System.Windows.Forms.Label();
            this.grpbAutoCapture = new System.Windows.Forms.GroupBox();
            this.numupdautocapturems = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chcBautoCapture = new System.Windows.Forms.CheckBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.txtpersonname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gruopTrained = new System.Windows.Forms.GroupBox();
            this.rbfalse = new System.Windows.Forms.RadioButton();
            this.rbtrue = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiwebcam = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.ıpCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiaddCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitrainingFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdFaceDetTraining = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpbAutoCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdautocapturems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gruopTrained.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCameraFramer
            // 
            this.timerCameraFramer.Interval = 1;
            this.timerCameraFramer.Tick += new System.EventHandler(this.timerCameraFramer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(801, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "FPS:0";
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTrain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrain.FlatAppearance.BorderSize = 2;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Location = new System.Drawing.Point(18, 22);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(72, 71);
            this.btnTrain.TabIndex = 4;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCapturingInfo);
            this.groupBox1.Controls.Add(this.grpbAutoCapture);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chcBautoCapture);
            this.groupBox1.Controls.Add(this.btnCapture);
            this.groupBox1.Controls.Add(this.txtpersonname);
            this.groupBox1.Location = new System.Drawing.Point(806, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 216);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture Image";
            // 
            // lblCapturingInfo
            // 
            this.lblCapturingInfo.AutoSize = true;
            this.lblCapturingInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCapturingInfo.Location = new System.Drawing.Point(16, 187);
            this.lblCapturingInfo.Name = "lblCapturingInfo";
            this.lblCapturingInfo.Size = new System.Drawing.Size(104, 20);
            this.lblCapturingInfo.TabIndex = 7;
            this.lblCapturingInfo.Text = "Capturing Info";
            // 
            // grpbAutoCapture
            // 
            this.grpbAutoCapture.Controls.Add(this.numupdautocapturems);
            this.grpbAutoCapture.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbAutoCapture.Location = new System.Drawing.Point(139, 126);
            this.grpbAutoCapture.Name = "grpbAutoCapture";
            this.grpbAutoCapture.Size = new System.Drawing.Size(115, 62);
            this.grpbAutoCapture.TabIndex = 9;
            this.grpbAutoCapture.TabStop = false;
            this.grpbAutoCapture.Text = "Every ms";
            this.grpbAutoCapture.Visible = false;
            // 
            // numupdautocapturems
            // 
            this.numupdautocapturems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numupdautocapturems.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numupdautocapturems.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numupdautocapturems.Location = new System.Drawing.Point(5, 22);
            this.numupdautocapturems.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numupdautocapturems.Name = "numupdautocapturems";
            this.numupdautocapturems.Size = new System.Drawing.Size(105, 30);
            this.numupdautocapturems.TabIndex = 0;
            this.numupdautocapturems.ThousandsSeparator = true;
            this.numupdautocapturems.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Person Name";
            // 
            // chcBautoCapture
            // 
            this.chcBautoCapture.AutoSize = true;
            this.chcBautoCapture.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcBautoCapture.Location = new System.Drawing.Point(140, 98);
            this.chcBautoCapture.Name = "chcBautoCapture";
            this.chcBautoCapture.Size = new System.Drawing.Size(130, 27);
            this.chcBautoCapture.TabIndex = 7;
            this.chcBautoCapture.Text = "AutoCapture";
            this.chcBautoCapture.UseVisualStyleBackColor = true;
            this.chcBautoCapture.CheckedChanged += new System.EventHandler(this.chcBautoCapture_CheckedChanged);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCapture.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCapture.FlatAppearance.BorderSize = 2;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.Location = new System.Drawing.Point(12, 103);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(122, 76);
            this.btnCapture.TabIndex = 6;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // txtpersonname
            // 
            this.txtpersonname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonname.Location = new System.Drawing.Point(12, 64);
            this.txtpersonname.Name = "txtpersonname";
            this.txtpersonname.Size = new System.Drawing.Size(237, 34);
            this.txtpersonname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gruopTrained);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnTrain);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(806, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recognizer";
            // 
            // gruopTrained
            // 
            this.gruopTrained.Controls.Add(this.rbfalse);
            this.gruopTrained.Controls.Add(this.rbtrue);
            this.gruopTrained.Enabled = false;
            this.gruopTrained.Location = new System.Drawing.Point(181, 16);
            this.gruopTrained.Name = "gruopTrained";
            this.gruopTrained.Size = new System.Drawing.Size(78, 78);
            this.gruopTrained.TabIndex = 6;
            this.gruopTrained.TabStop = false;
            this.gruopTrained.Text = "Trained";
            // 
            // rbfalse
            // 
            this.rbfalse.AutoSize = true;
            this.rbfalse.Location = new System.Drawing.Point(5, 49);
            this.rbfalse.Name = "rbfalse";
            this.rbfalse.Size = new System.Drawing.Size(57, 23);
            this.rbfalse.TabIndex = 1;
            this.rbfalse.TabStop = true;
            this.rbfalse.Text = "false";
            this.rbfalse.UseVisualStyleBackColor = true;
            this.rbfalse.CheckedChanged += new System.EventHandler(this.radioButtonTrainedInfo_Checked);
            // 
            // rbtrue
            // 
            this.rbtrue.AutoSize = true;
            this.rbtrue.Location = new System.Drawing.Point(5, 23);
            this.rbtrue.Name = "rbtrue";
            this.rbtrue.Size = new System.Drawing.Size(55, 23);
            this.rbtrue.TabIndex = 0;
            this.rbtrue.TabStop = true;
            this.rbtrue.Text = "true";
            this.rbtrue.UseVisualStyleBackColor = true;
            this.rbtrue.CheckedChanged += new System.EventHandler(this.radioButtonTrainedInfo_Checked);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoad.FlatAppearance.BorderSize = 2;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(95, 22);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(72, 71);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.tsmitrainingFile});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1095, 28);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiwebcam,
            this.tsmiIndex,
            this.ıpCameraToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // tsmiwebcam
            // 
            this.tsmiwebcam.Name = "tsmiwebcam";
            this.tsmiwebcam.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.tsmiwebcam.Size = new System.Drawing.Size(198, 26);
            this.tsmiwebcam.Text = "Webcam";
            this.tsmiwebcam.Click += new System.EventHandler(this.tsmiwebcam_Click);
            // 
            // tsmiIndex
            // 
            this.tsmiIndex.Name = "tsmiIndex";
            this.tsmiIndex.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiIndex.Size = new System.Drawing.Size(198, 26);
            this.tsmiIndex.Text = "Index";
            this.tsmiIndex.Click += new System.EventHandler(this.tsmiIndex_Click);
            // 
            // ıpCameraToolStripMenuItem
            // 
            this.ıpCameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiaddCamera});
            this.ıpCameraToolStripMenuItem.Name = "ıpCameraToolStripMenuItem";
            this.ıpCameraToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.ıpCameraToolStripMenuItem.Text = "Ip Camera";
            // 
            // tsmiaddCamera
            // 
            this.tsmiaddCamera.Name = "tsmiaddCamera";
            this.tsmiaddCamera.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tsmiaddCamera.Size = new System.Drawing.Size(213, 26);
            this.tsmiaddCamera.Text = "Add Camera";
            this.tsmiaddCamera.Click += new System.EventHandler(this.tsmiaddCamera_Click);
            // 
            // tsmitrainingFile
            // 
            this.tsmitrainingFile.Name = "tsmitrainingFile";
            this.tsmitrainingFile.Size = new System.Drawing.Size(101, 24);
            this.tsmitrainingFile.Text = "Training File";
            this.tsmitrainingFile.Click += new System.EventHandler(this.tsmitrainingFile_Click);
            // 
            // ofdFaceDetTraining
            // 
            this.ofdFaceDetTraining.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(881, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "FPS:0";
            // 
            // frmfacerec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 682);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmfacerec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Detection and Recognition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmfacerec_FormClosing);
            this.Load += new System.EventHandler(this.frmfacerec_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbAutoCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numupdautocapturems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gruopTrained.ResumeLayout(false);
            this.gruopTrained.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.Timer timerCameraFramer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserTraininImages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chcBautoCapture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.TextBox txtpersonname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox grpbAutoCapture;
        private System.Windows.Forms.NumericUpDown numupdautocapturems;
        private System.Windows.Forms.Label lblCapturingInfo;
        private System.Windows.Forms.GroupBox gruopTrained;
        private System.Windows.Forms.RadioButton rbfalse;
        private System.Windows.Forms.RadioButton rbtrue;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiwebcam;
        private System.Windows.Forms.ToolStripMenuItem tsmiIndex;
        private System.Windows.Forms.ToolStripMenuItem ıpCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiaddCamera;
        private System.Windows.Forms.ToolStripMenuItem tsmitrainingFile;
        private System.Windows.Forms.OpenFileDialog ofdFaceDetTraining;
        private System.Windows.Forms.Label label3;
    }
}

