﻿namespace FaceRecognizerProject
{
    partial class CameraSelector
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
            this.grpIpCam = new System.Windows.Forms.GroupBox();
            this.chcbResActive = new System.Windows.Forms.CheckBox();
            this.cmbresolution = new System.Windows.Forms.ComboBox();
            this.chcshowHide = new System.Windows.Forms.CheckBox();
            this.btnExampleIP = new System.Windows.Forms.Button();
            this.btnIpCamAddList = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.GrpIndex = new System.Windows.Forms.GroupBox();
            this.numupdownIndex = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpIpCam.SuspendLayout();
            this.GrpIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownIndex)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIpCam
            // 
            this.grpIpCam.Controls.Add(this.chcbResActive);
            this.grpIpCam.Controls.Add(this.cmbresolution);
            this.grpIpCam.Controls.Add(this.chcshowHide);
            this.grpIpCam.Controls.Add(this.btnExampleIP);
            this.grpIpCam.Controls.Add(this.btnIpCamAddList);
            this.grpIpCam.Controls.Add(this.btnSave);
            this.grpIpCam.Controls.Add(this.label3);
            this.grpIpCam.Controls.Add(this.txtIP);
            this.grpIpCam.Controls.Add(this.label2);
            this.grpIpCam.Controls.Add(this.label1);
            this.grpIpCam.Controls.Add(this.txtpwd);
            this.grpIpCam.Controls.Add(this.txtUsername);
            this.grpIpCam.ForeColor = System.Drawing.SystemColors.Window;
            this.grpIpCam.Location = new System.Drawing.Point(9, 63);
            this.grpIpCam.Name = "grpIpCam";
            this.grpIpCam.Size = new System.Drawing.Size(426, 235);
            this.grpIpCam.TabIndex = 1;
            this.grpIpCam.TabStop = false;
            this.grpIpCam.Text = "Ip Camera";
            // 
            // chcbResActive
            // 
            this.chcbResActive.AutoSize = true;
            this.chcbResActive.Location = new System.Drawing.Point(299, 64);
            this.chcbResActive.Name = "chcbResActive";
            this.chcbResActive.Size = new System.Drawing.Size(77, 17);
            this.chcbResActive.TabIndex = 9;
            this.chcbResActive.Text = "Res Active";
            this.chcbResActive.UseVisualStyleBackColor = true;
            this.chcbResActive.CheckedChanged += new System.EventHandler(this.chcbResActive_CheckedChanged);
            // 
            // cmbresolution
            // 
            this.cmbresolution.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbresolution.FormattingEnabled = true;
            this.cmbresolution.Items.AddRange(new object[] {
            "320x240",
            "640x480",
            "960x720"});
            this.cmbresolution.Location = new System.Drawing.Point(299, 91);
            this.cmbresolution.Name = "cmbresolution";
            this.cmbresolution.Size = new System.Drawing.Size(121, 20);
            this.cmbresolution.TabIndex = 8;
            this.cmbresolution.Visible = false;
            this.cmbresolution.SelectedIndexChanged += new System.EventHandler(this.cmbresolution_SelectedIndexChanged);
            // 
            // chcshowHide
            // 
            this.chcshowHide.AutoSize = true;
            this.chcshowHide.Location = new System.Drawing.Point(300, 133);
            this.chcshowHide.Name = "chcshowHide";
            this.chcshowHide.Size = new System.Drawing.Size(83, 17);
            this.chcshowHide.TabIndex = 7;
            this.chcshowHide.Text = "Show/Hide";
            this.chcshowHide.UseVisualStyleBackColor = true;
            this.chcshowHide.CheckedChanged += new System.EventHandler(this.chcshowHide_CheckedChanged);
            // 
            // btnExampleIP
            // 
            this.btnExampleIP.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExampleIP.FlatAppearance.BorderSize = 2;
            this.btnExampleIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExampleIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExampleIP.Location = new System.Drawing.Point(289, 175);
            this.btnExampleIP.Name = "btnExampleIP";
            this.btnExampleIP.Size = new System.Drawing.Size(119, 47);
            this.btnExampleIP.TabIndex = 6;
            this.btnExampleIP.Text = "LoadOldIp";
            this.btnExampleIP.UseVisualStyleBackColor = true;
            this.btnExampleIP.Click += new System.EventHandler(this.btnExampleIP_Click);
            // 
            // btnIpCamAddList
            // 
            this.btnIpCamAddList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(4)))));
            this.btnIpCamAddList.FlatAppearance.BorderSize = 2;
            this.btnIpCamAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIpCamAddList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIpCamAddList.Location = new System.Drawing.Point(150, 175);
            this.btnIpCamAddList.Name = "btnIpCamAddList";
            this.btnIpCamAddList.Size = new System.Drawing.Size(119, 47);
            this.btnIpCamAddList.TabIndex = 4;
            this.btnIpCamAddList.Text = "Add To List";
            this.btnIpCamAddList.UseVisualStyleBackColor = true;
            this.btnIpCamAddList.Click += new System.EventHandler(this.btnIpCamAddList_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(12, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 47);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIP.ForeColor = System.Drawing.Color.White;
            this.txtIP.Location = new System.Drawing.Point(60, 24);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(360, 29);
            this.txtIP.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pwd:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User:";
            // 
            // txtpwd
            // 
            this.txtpwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtpwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpwd.ForeColor = System.Drawing.Color.White;
            this.txtpwd.Location = new System.Drawing.Point(60, 130);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(233, 29);
            this.txtpwd.TabIndex = 2;
            this.txtpwd.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(60, 82);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(233, 29);
            this.txtUsername.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(204)))), ((int)(((byte)(48)))));
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(441, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 74);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GrpIndex
            // 
            this.GrpIndex.Controls.Add(this.numupdownIndex);
            this.GrpIndex.ForeColor = System.Drawing.SystemColors.Window;
            this.GrpIndex.Location = new System.Drawing.Point(441, 63);
            this.GrpIndex.Name = "GrpIndex";
            this.GrpIndex.Size = new System.Drawing.Size(136, 143);
            this.GrpIndex.TabIndex = 6;
            this.GrpIndex.TabStop = false;
            this.GrpIndex.Text = "Indexed";
            // 
            // numupdownIndex
            // 
            this.numupdownIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.numupdownIndex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numupdownIndex.ForeColor = System.Drawing.Color.White;
            this.numupdownIndex.Location = new System.Drawing.Point(16, 53);
            this.numupdownIndex.Name = "numupdownIndex";
            this.numupdownIndex.Size = new System.Drawing.Size(105, 29);
            this.numupdownIndex.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 46);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Event);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move_Event);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Event);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(4)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(530, -2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 46);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(199, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add Camera";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_Event);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move_Event);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_Event);
            // 
            // CameraSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(589, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrpIndex);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpIpCam);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CameraSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CameraSelector";
            this.Load += new System.EventHandler(this.CameraSelector_Load);
            this.grpIpCam.ResumeLayout(false);
            this.grpIpCam.PerformLayout();
            this.GrpIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numupdownIndex)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpIpCam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox GrpIndex;
        private System.Windows.Forms.NumericUpDown numupdownIndex;
        private System.Windows.Forms.Button btnIpCamAddList;
        private System.Windows.Forms.Button btnExampleIP;
        private System.Windows.Forms.CheckBox chcshowHide;
        private System.Windows.Forms.ComboBox cmbresolution;
        private System.Windows.Forms.CheckBox chcbResActive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
    }
}