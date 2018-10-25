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
            this.txtpersonname = new System.Windows.Forms.TextBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.chcBautoCapture = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpbAutoCapture = new System.Windows.Forms.GroupBox();
            this.numupdautocapturems = new System.Windows.Forms.NumericUpDown();
            this.lblCapturingInfo = new System.Windows.Forms.Label();
            this.gruopTrained = new System.Windows.Forms.GroupBox();
            this.rbtrue = new System.Windows.Forms.RadioButton();
            this.rbfalse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageBLiveCamera)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpbAutoCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdautocapturems)).BeginInit();
            this.gruopTrained.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBLiveCamera
            // 
            this.imageBLiveCamera.Location = new System.Drawing.Point(12, 12);
            this.imageBLiveCamera.Name = "imageBLiveCamera";
            this.imageBLiveCamera.Size = new System.Drawing.Size(640, 640);
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
            this.label1.Location = new System.Drawing.Point(1056, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(669, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 203);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture Image";
            // 
            // txtpersonname
            // 
            this.txtpersonname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonname.Location = new System.Drawing.Point(14, 61);
            this.txtpersonname.Name = "txtpersonname";
            this.txtpersonname.Size = new System.Drawing.Size(270, 30);
            this.txtpersonname.TabIndex = 0;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gruopTrained);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnTrain);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(669, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 94);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recognizer";
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
            // lblCapturingInfo
            // 
            this.lblCapturingInfo.AutoSize = true;
            this.lblCapturingInfo.Location = new System.Drawing.Point(18, 176);
            this.lblCapturingInfo.Name = "lblCapturingInfo";
            this.lblCapturingInfo.Size = new System.Drawing.Size(96, 17);
            this.lblCapturingInfo.TabIndex = 7;
            this.lblCapturingInfo.Text = "Capturing Info";
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
            // frmfacerec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 677);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBLiveCamera);
            this.Name = "frmfacerec";
            this.Text = "Face Detection and Recognition";
            this.Load += new System.EventHandler(this.frmfacerec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBLiveCamera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpbAutoCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numupdautocapturems)).EndInit();
            this.gruopTrained.ResumeLayout(false);
            this.gruopTrained.PerformLayout();
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
    }
}

