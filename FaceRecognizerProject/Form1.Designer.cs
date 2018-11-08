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
            this.cmbRecognizer = new System.Windows.Forms.ComboBox();
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
            this.camPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbFoundPerson = new System.Windows.Forms.PictureBox();
            this.lblFoundPerson = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpbAutoCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdautocapturems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gruopTrained.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoundPerson)).BeginInit();
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1259, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "FPS:0";
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTrain.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTrain.FlatAppearance.BorderSize = 2;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Location = new System.Drawing.Point(20, 97);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(113, 92);
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1267, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(437, 280);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture Image";
            // 
            // lblCapturingInfo
            // 
            this.lblCapturingInfo.AutoSize = true;
            this.lblCapturingInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCapturingInfo.ForeColor = System.Drawing.Color.White;
            this.lblCapturingInfo.Location = new System.Drawing.Point(25, 242);
            this.lblCapturingInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCapturingInfo.Name = "lblCapturingInfo";
            this.lblCapturingInfo.Size = new System.Drawing.Size(104, 20);
            this.lblCapturingInfo.TabIndex = 7;
            this.lblCapturingInfo.Text = "Capturing Info";
            // 
            // grpbAutoCapture
            // 
            this.grpbAutoCapture.Controls.Add(this.numupdautocapturems);
            this.grpbAutoCapture.Enabled = false;
            this.grpbAutoCapture.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbAutoCapture.ForeColor = System.Drawing.Color.White;
            this.grpbAutoCapture.Location = new System.Drawing.Point(218, 153);
            this.grpbAutoCapture.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpbAutoCapture.Name = "grpbAutoCapture";
            this.grpbAutoCapture.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpbAutoCapture.Size = new System.Drawing.Size(181, 80);
            this.grpbAutoCapture.TabIndex = 9;
            this.grpbAutoCapture.TabStop = false;
            this.grpbAutoCapture.Text = "Max Pic Count";
            // 
            // numupdautocapturems
            // 
            this.numupdautocapturems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.numupdautocapturems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numupdautocapturems.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numupdautocapturems.ForeColor = System.Drawing.Color.White;
            this.numupdautocapturems.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numupdautocapturems.Location = new System.Drawing.Point(8, 28);
            this.numupdautocapturems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numupdautocapturems.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numupdautocapturems.Name = "numupdautocapturems";
            this.numupdautocapturems.Size = new System.Drawing.Size(165, 38);
            this.numupdautocapturems.TabIndex = 0;
            this.numupdautocapturems.ThousandsSeparator = true;
            this.numupdautocapturems.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Person Name";
            // 
            // chcBautoCapture
            // 
            this.chcBautoCapture.AutoSize = true;
            this.chcBautoCapture.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chcBautoCapture.ForeColor = System.Drawing.Color.White;
            this.chcBautoCapture.Location = new System.Drawing.Point(218, 117);
            this.chcBautoCapture.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chcBautoCapture.Name = "chcBautoCapture";
            this.chcBautoCapture.Size = new System.Drawing.Size(146, 32);
            this.chcBautoCapture.TabIndex = 7;
            this.chcBautoCapture.Text = "AutoCapture";
            this.chcBautoCapture.UseVisualStyleBackColor = true;
            this.chcBautoCapture.CheckedChanged += new System.EventHandler(this.chcBautoCapture_CheckedChanged);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCapture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(204)))), ((int)(((byte)(48)))));
            this.btnCapture.FlatAppearance.BorderSize = 2;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.Location = new System.Drawing.Point(19, 133);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(189, 100);
            this.btnCapture.TabIndex = 6;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // txtpersonname
            // 
            this.txtpersonname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtpersonname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonname.ForeColor = System.Drawing.Color.White;
            this.txtpersonname.Location = new System.Drawing.Point(20, 75);
            this.txtpersonname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpersonname.Name = "txtpersonname";
            this.txtpersonname.Size = new System.Drawing.Size(370, 34);
            this.txtpersonname.TabIndex = 0;
            this.txtpersonname.TextChanged += new System.EventHandler(this.txtpersonname_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbRecognizer);
            this.groupBox2.Controls.Add(this.gruopTrained);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnTrain);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1267, 378);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(435, 198);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recognizer";
            // 
            // cmbRecognizer
            // 
            this.cmbRecognizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cmbRecognizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRecognizer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRecognizer.ForeColor = System.Drawing.Color.White;
            this.cmbRecognizer.FormattingEnabled = true;
            this.cmbRecognizer.Items.AddRange(new object[] {
            "Eigen",
            "Fisher",
            "LBPH"});
            this.cmbRecognizer.Location = new System.Drawing.Point(22, 41);
            this.cmbRecognizer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbRecognizer.Name = "cmbRecognizer";
            this.cmbRecognizer.Size = new System.Drawing.Size(400, 39);
            this.cmbRecognizer.TabIndex = 7;
            this.cmbRecognizer.SelectedIndexChanged += new System.EventHandler(this.cmbRecognizer_SelectedIndexChanged);
            // 
            // gruopTrained
            // 
            this.gruopTrained.Controls.Add(this.rbfalse);
            this.gruopTrained.Controls.Add(this.rbtrue);
            this.gruopTrained.Enabled = false;
            this.gruopTrained.ForeColor = System.Drawing.Color.White;
            this.gruopTrained.Location = new System.Drawing.Point(277, 89);
            this.gruopTrained.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gruopTrained.Name = "gruopTrained";
            this.gruopTrained.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gruopTrained.Size = new System.Drawing.Size(148, 101);
            this.gruopTrained.TabIndex = 6;
            this.gruopTrained.TabStop = false;
            this.gruopTrained.Text = "Trained";
            // 
            // rbfalse
            // 
            this.rbfalse.AutoSize = true;
            this.rbfalse.ForeColor = System.Drawing.Color.White;
            this.rbfalse.Location = new System.Drawing.Point(8, 63);
            this.rbfalse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbfalse.Name = "rbfalse";
            this.rbfalse.Size = new System.Drawing.Size(65, 27);
            this.rbfalse.TabIndex = 1;
            this.rbfalse.TabStop = true;
            this.rbfalse.Text = "false";
            this.rbfalse.UseVisualStyleBackColor = true;
            this.rbfalse.CheckedChanged += new System.EventHandler(this.radioButtonTrainedInfo_Checked);
            // 
            // rbtrue
            // 
            this.rbtrue.AutoSize = true;
            this.rbtrue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtrue.ForeColor = System.Drawing.Color.White;
            this.rbtrue.Location = new System.Drawing.Point(8, 30);
            this.rbtrue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbtrue.Name = "rbtrue";
            this.rbtrue.Size = new System.Drawing.Size(62, 27);
            this.rbtrue.TabIndex = 0;
            this.rbtrue.TabStop = true;
            this.rbtrue.Text = "true";
            this.rbtrue.UseVisualStyleBackColor = true;
            this.rbtrue.CheckedChanged += new System.EventHandler(this.radioButtonTrainedInfo_Checked);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(4)))));
            this.btnLoad.FlatAppearance.BorderSize = 2;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(141, 97);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(113, 92);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.tsmitrainingFile});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(1721, 47);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Event);
            this.menuStrip2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move_Event);
            this.menuStrip2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Event);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiwebcam,
            this.tsmiIndex,
            this.ıpCameraToolStripMenuItem});
            this.cameraToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(81, 41);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // tsmiwebcam
            // 
            this.tsmiwebcam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tsmiwebcam.ForeColor = System.Drawing.Color.White;
            this.tsmiwebcam.Name = "tsmiwebcam";
            this.tsmiwebcam.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.tsmiwebcam.Size = new System.Drawing.Size(217, 28);
            this.tsmiwebcam.Text = "Webcam";
            this.tsmiwebcam.Click += new System.EventHandler(this.tsmiwebcam_Click);
            // 
            // tsmiIndex
            // 
            this.tsmiIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tsmiIndex.ForeColor = System.Drawing.Color.White;
            this.tsmiIndex.Name = "tsmiIndex";
            this.tsmiIndex.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiIndex.Size = new System.Drawing.Size(217, 28);
            this.tsmiIndex.Text = "Index";
            this.tsmiIndex.Click += new System.EventHandler(this.tsmiIndex_Click);
            // 
            // ıpCameraToolStripMenuItem
            // 
            this.ıpCameraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ıpCameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiaddCamera});
            this.ıpCameraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ıpCameraToolStripMenuItem.Name = "ıpCameraToolStripMenuItem";
            this.ıpCameraToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.ıpCameraToolStripMenuItem.Text = "Ip Camera";
            // 
            // tsmiaddCamera
            // 
            this.tsmiaddCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tsmiaddCamera.ForeColor = System.Drawing.Color.White;
            this.tsmiaddCamera.Name = "tsmiaddCamera";
            this.tsmiaddCamera.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tsmiaddCamera.Size = new System.Drawing.Size(235, 28);
            this.tsmiaddCamera.Text = "Add Camera";
            this.tsmiaddCamera.Click += new System.EventHandler(this.tsmiaddCamera_Click);
            // 
            // tsmitrainingFile
            // 
            this.tsmitrainingFile.ForeColor = System.Drawing.Color.Silver;
            this.tsmitrainingFile.Name = "tsmitrainingFile";
            this.tsmitrainingFile.Size = new System.Drawing.Size(113, 41);
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
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1384, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "FPS:0";
            // 
            // camPanel
            // 
            this.camPanel.Location = new System.Drawing.Point(0, 35);
            this.camPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.camPanel.Name = "camPanel";
            this.camPanel.Size = new System.Drawing.Size(1257, 844);
            this.camPanel.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(4)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1663, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 47);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1721, 47);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblMatch);
            this.panel2.Controls.Add(this.lblFoundPerson);
            this.panel2.Controls.Add(this.pbFoundPerson);
            this.panel2.Location = new System.Drawing.Point(1264, 584);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 295);
            this.panel2.TabIndex = 12;
            // 
            // pbFoundPerson
            // 
            this.pbFoundPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoundPerson.Location = new System.Drawing.Point(0, 0);
            this.pbFoundPerson.Name = "pbFoundPerson";
            this.pbFoundPerson.Size = new System.Drawing.Size(438, 293);
            this.pbFoundPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoundPerson.TabIndex = 0;
            this.pbFoundPerson.TabStop = false;
            // 
            // lblFoundPerson
            // 
            this.lblFoundPerson.AutoSize = true;
            this.lblFoundPerson.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFoundPerson.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundPerson.ForeColor = System.Drawing.Color.White;
            this.lblFoundPerson.Location = new System.Drawing.Point(0, 0);
            this.lblFoundPerson.Name = "lblFoundPerson";
            this.lblFoundPerson.Size = new System.Drawing.Size(122, 22);
            this.lblFoundPerson.TabIndex = 2;
            this.lblFoundPerson.Text = "Name : EMPTY";
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMatch.ForeColor = System.Drawing.Color.White;
            this.lblMatch.Location = new System.Drawing.Point(313, 0);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(125, 22);
            this.lblMatch.TabIndex = 3;
            this.lblMatch.Text = "[NO MATCH]";
            // 
            // frmfacerec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1721, 883);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.camPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmfacerec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Detection and Recognition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmfacerec_FormClosing);
            this.Load += new System.EventHandler(this.frmfacerec_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move_Event);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbAutoCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numupdautocapturems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gruopTrained.ResumeLayout(false);
            this.gruopTrained.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoundPerson)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbRecognizer;
        private System.Windows.Forms.Panel camPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFoundPerson;
        private System.Windows.Forms.PictureBox pbFoundPerson;
        private System.Windows.Forms.Label lblMatch;
    }
}

