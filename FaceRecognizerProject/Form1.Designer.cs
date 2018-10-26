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
            this.imageBLiveCamera = new Emgu.CV.UI.ImageBox();
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiwebcam = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.ıpCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiaddCamera = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageBLiveCamera)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpbAutoCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdautocapturems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gruopTrained.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBLiveCamera
            // 
            this.imageBLiveCamera.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBLiveCamera.Location = new System.Drawing.Point(12, 56);
            this.imageBLiveCamera.Name = "imageBLiveCamera";
            this.imageBLiveCamera.Size = new System.Drawing.Size(708, 640);
            this.imageBLiveCamera.TabIndex = 2;
            this.imageBLiveCamera.TabStop = false;
            // 
            // timerCameraFramer
            // 
            this.timerCameraFramer.Interval = 1;
            this.timerCameraFramer.Tick += new System.EventHandler(this.timerCameraFramer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(640, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "FPS:0";
            // 
            // btnTrain
            // 
            this.btnTrain.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrain.Location = new System.Drawing.Point(21, 21);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(82, 67);
            this.btnTrain.TabIndex = 4;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(752, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 203);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture Image";
            // 
            // lblCapturingInfo
            // 
            this.lblCapturingInfo.AutoSize = true;
            this.lblCapturingInfo.Location = new System.Drawing.Point(18, 176);
            this.lblCapturingInfo.Name = "lblCapturingInfo";
            this.lblCapturingInfo.Size = new System.Drawing.Size(96, 17);
            this.lblCapturingInfo.TabIndex = 7;
            this.lblCapturingInfo.Text = "Capturing Info";
            // 
            // grpbAutoCapture
            // 
            this.grpbAutoCapture.Controls.Add(this.numupdautocapturems);
            this.grpbAutoCapture.Location = new System.Drawing.Point(159, 119);
            this.grpbAutoCapture.Name = "grpbAutoCapture";
            this.grpbAutoCapture.Size = new System.Drawing.Size(131, 50);
            this.grpbAutoCapture.TabIndex = 9;
            this.grpbAutoCapture.TabStop = false;
            this.grpbAutoCapture.Text = "Every ms";
            this.grpbAutoCapture.Visible = false;
            // 
            // numupdautocapturems
            // 
            this.numupdautocapturems.Location = new System.Drawing.Point(3, 18);
            this.numupdautocapturems.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numupdautocapturems.Name = "numupdautocapturems";
            this.numupdautocapturems.Size = new System.Drawing.Size(120, 22);
            this.numupdautocapturems.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Person Name";
            // 
            // chcBautoCapture
            // 
            this.chcBautoCapture.AutoSize = true;
            this.chcBautoCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcBautoCapture.Location = new System.Drawing.Point(160, 97);
            this.chcBautoCapture.Name = "chcBautoCapture";
            this.chcBautoCapture.Size = new System.Drawing.Size(124, 24);
            this.chcBautoCapture.TabIndex = 7;
            this.chcBautoCapture.Text = "AutoCapture";
            this.chcBautoCapture.UseVisualStyleBackColor = true;
            this.chcBautoCapture.CheckedChanged += new System.EventHandler(this.chcBautoCapture_CheckedChanged);
            // 
            // btnCapture
            // 
            this.btnCapture.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCapture.Location = new System.Drawing.Point(14, 97);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(140, 72);
            this.btnCapture.TabIndex = 6;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // txtpersonname
            // 
            this.txtpersonname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonname.Location = new System.Drawing.Point(14, 61);
            this.txtpersonname.Name = "txtpersonname";
            this.txtpersonname.Size = new System.Drawing.Size(270, 30);
            this.txtpersonname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gruopTrained);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnTrain);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(752, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 94);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recognizer";
            // 
            // gruopTrained
            // 
            this.gruopTrained.Controls.Add(this.rbfalse);
            this.gruopTrained.Controls.Add(this.rbtrue);
            this.gruopTrained.Enabled = false;
            this.gruopTrained.Location = new System.Drawing.Point(207, 15);
            this.gruopTrained.Name = "gruopTrained";
            this.gruopTrained.Size = new System.Drawing.Size(89, 73);
            this.gruopTrained.TabIndex = 6;
            this.gruopTrained.TabStop = false;
            this.gruopTrained.Text = "Trained";
            // 
            // rbfalse
            // 
            this.rbfalse.AutoSize = true;
            this.rbfalse.Location = new System.Drawing.Point(6, 46);
            this.rbfalse.Name = "rbfalse";
            this.rbfalse.Size = new System.Drawing.Size(59, 21);
            this.rbfalse.TabIndex = 1;
            this.rbfalse.TabStop = true;
            this.rbfalse.Text = "false";
            this.rbfalse.UseVisualStyleBackColor = true;
            this.rbfalse.CheckedChanged += new System.EventHandler(this.radioButtonTrainedInfo_Checked);
            // 
            // rbtrue
            // 
            this.rbtrue.AutoSize = true;
            this.rbtrue.Location = new System.Drawing.Point(6, 22);
            this.rbtrue.Name = "rbtrue";
            this.rbtrue.Size = new System.Drawing.Size(54, 21);
            this.rbtrue.TabIndex = 0;
            this.rbtrue.TabStop = true;
            this.rbtrue.Text = "true";
            this.rbtrue.UseVisualStyleBackColor = true;
            this.rbtrue.CheckedChanged += new System.EventHandler(this.radioButtonTrainedInfo_Checked);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoad.Location = new System.Drawing.Point(109, 21);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 67);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(766, 405);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 132);
            this.listBox1.TabIndex = 7;
            this.listBox1.Visible = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1114, 28);
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
            this.tsmiwebcam.Size = new System.Drawing.Size(152, 26);
            this.tsmiwebcam.Text = "Webcam";
            this.tsmiwebcam.Click += new System.EventHandler(this.tsmiwebcam_Click);
            // 
            // tsmiIndex
            // 
            this.tsmiIndex.Name = "tsmiIndex";
            this.tsmiIndex.Size = new System.Drawing.Size(152, 26);
            this.tsmiIndex.Text = "Index";
            this.tsmiIndex.Click += new System.EventHandler(this.tsmiIndex_Click);
            // 
            // ıpCameraToolStripMenuItem
            // 
            this.ıpCameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiaddCamera});
            this.ıpCameraToolStripMenuItem.Name = "ıpCameraToolStripMenuItem";
            this.ıpCameraToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ıpCameraToolStripMenuItem.Text = "Ip Camera";
            // 
            // tsmiaddCamera
            // 
            this.tsmiaddCamera.Name = "tsmiaddCamera";
            this.tsmiaddCamera.Size = new System.Drawing.Size(167, 26);
            this.tsmiaddCamera.Text = "Add Camera";
            this.tsmiaddCamera.Click += new System.EventHandler(this.tsmiaddCamera_Click);
            // 
            // frmfacerec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 719);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBLiveCamera);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmfacerec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Detection and Recognition";
            this.Load += new System.EventHandler(this.frmfacerec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBLiveCamera)).EndInit();
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

        private Emgu.CV.UI.ImageBox imageBLiveCamera;
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiwebcam;
        private System.Windows.Forms.ToolStripMenuItem tsmiIndex;
        private System.Windows.Forms.ToolStripMenuItem ıpCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiaddCamera;
    }
}

