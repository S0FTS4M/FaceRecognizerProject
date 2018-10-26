namespace FaceRecognizerProject
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
            this.grpIpCam.SuspendLayout();
            this.GrpIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIpCam
            // 
            this.grpIpCam.Controls.Add(this.btnIpCamAddList);
            this.grpIpCam.Controls.Add(this.btnSave);
            this.grpIpCam.Controls.Add(this.label3);
            this.grpIpCam.Controls.Add(this.txtIP);
            this.grpIpCam.Controls.Add(this.label2);
            this.grpIpCam.Controls.Add(this.label1);
            this.grpIpCam.Controls.Add(this.txtpwd);
            this.grpIpCam.Controls.Add(this.txtUsername);
            this.grpIpCam.Location = new System.Drawing.Point(12, 12);
            this.grpIpCam.Name = "grpIpCam";
            this.grpIpCam.Size = new System.Drawing.Size(298, 221);
            this.grpIpCam.TabIndex = 1;
            this.grpIpCam.TabStop = false;
            this.grpIpCam.Text = "Ip Camera";
            // 
            // btnIpCamAddList
            // 
            this.btnIpCamAddList.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnIpCamAddList.FlatAppearance.BorderSize = 2;
            this.btnIpCamAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIpCamAddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIpCamAddList.Location = new System.Drawing.Point(132, 164);
            this.btnIpCamAddList.Name = "btnIpCamAddList";
            this.btnIpCamAddList.Size = new System.Drawing.Size(132, 44);
            this.btnIpCamAddList.TabIndex = 4;
            this.btnIpCamAddList.Text = "Add To List";
            this.btnIpCamAddList.UseVisualStyleBackColor = true;
            this.btnIpCamAddList.Click += new System.EventHandler(this.btnIpCamAddList_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(29, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 44);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIP.Location = new System.Drawing.Point(66, 32);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(185, 30);
            this.txtIP.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pwd:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User:";
            // 
            // txtpwd
            // 
            this.txtpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpwd.Location = new System.Drawing.Point(66, 122);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(185, 30);
            this.txtpwd.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.Location = new System.Drawing.Point(66, 77);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(185, 30);
            this.txtUsername.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(316, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 70);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GrpIndex
            // 
            this.GrpIndex.Controls.Add(this.numupdownIndex);
            this.GrpIndex.Location = new System.Drawing.Point(316, 12);
            this.GrpIndex.Name = "GrpIndex";
            this.GrpIndex.Size = new System.Drawing.Size(156, 135);
            this.GrpIndex.TabIndex = 6;
            this.GrpIndex.TabStop = false;
            this.GrpIndex.Text = "Indexed";
            // 
            // numupdownIndex
            // 
            this.numupdownIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numupdownIndex.Location = new System.Drawing.Point(18, 50);
            this.numupdownIndex.Name = "numupdownIndex";
            this.numupdownIndex.Size = new System.Drawing.Size(120, 38);
            this.numupdownIndex.TabIndex = 0;
            // 
            // CameraSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 268);
            this.Controls.Add(this.GrpIndex);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpIpCam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CameraSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CameraSelector";
            this.grpIpCam.ResumeLayout(false);
            this.grpIpCam.PerformLayout();
            this.GrpIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numupdownIndex)).EndInit();
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
    }
}