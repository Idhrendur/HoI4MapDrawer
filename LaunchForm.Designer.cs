﻿namespace ProvinceMapper
{
    partial class LaunchForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbSourceMapFolder = new System.Windows.Forms.TextBox();
			this.btnBegin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblStatus = new System.Windows.Forms.Label();
			this.tbSaveLocation = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.FolderBrowse = new System.Windows.Forms.Button();
			this.saveBrowse = new System.Windows.Forms.Button();
			this.DocsFolderButton = new System.Windows.Forms.Button();
			this.modFolder = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "HoI4 Folder";
			// 
			// tbSourceMapFolder
			// 
			this.tbSourceMapFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSourceMapFolder.Location = new System.Drawing.Point(105, 9);
			this.tbSourceMapFolder.Name = "tbSourceMapFolder";
			this.tbSourceMapFolder.Size = new System.Drawing.Size(476, 20);
			this.tbSourceMapFolder.TabIndex = 1;
			this.tbSourceMapFolder.Text = "D:\\SteamLibrary\\SteamApps\\common\\Hearts of Iron IV";
			// 
			// btnBegin
			// 
			this.btnBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBegin.Location = new System.Drawing.Point(601, 126);
			this.btnBegin.Name = "btnBegin";
			this.btnBegin.Size = new System.Drawing.Size(61, 23);
			this.btnBegin.TabIndex = 8;
			this.btnBegin.Text = "Begin";
			this.btnBegin.UseVisualStyleBackColor = true;
			this.btnBegin.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(13, 126);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(61, 23);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(13, 90);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(649, 23);
			this.progressBar1.TabIndex = 12;
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(79, 131);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(47, 13);
			this.lblStatus.TabIndex = 13;
			this.lblStatus.Text = "Ready...";
			// 
			// tbSaveLocation
			// 
			this.tbSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSaveLocation.Location = new System.Drawing.Point(105, 61);
			this.tbSaveLocation.Name = "tbSaveLocation";
			this.tbSaveLocation.Size = new System.Drawing.Size(476, 20);
			this.tbSaveLocation.TabIndex = 15;
			this.tbSaveLocation.Text = "C:\\Users\\Stephen\\Documents\\Paradox Interactive\\Hearts of Iron IV\\save games";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "HoI4 Save";
			// 
			// FolderBrowse
			// 
			this.FolderBrowse.Location = new System.Drawing.Point(587, 6);
			this.FolderBrowse.Name = "FolderBrowse";
			this.FolderBrowse.Size = new System.Drawing.Size(75, 23);
			this.FolderBrowse.TabIndex = 16;
			this.FolderBrowse.Text = "Browse";
			this.FolderBrowse.UseVisualStyleBackColor = true;
			this.FolderBrowse.Click += new System.EventHandler(this.FolderBrowse_Click);
			// 
			// saveBrowse
			// 
			this.saveBrowse.Location = new System.Drawing.Point(587, 61);
			this.saveBrowse.Name = "saveBrowse";
			this.saveBrowse.Size = new System.Drawing.Size(75, 23);
			this.saveBrowse.TabIndex = 17;
			this.saveBrowse.Text = "Browse";
			this.saveBrowse.UseVisualStyleBackColor = true;
			this.saveBrowse.Click += new System.EventHandler(this.saveBrowse_Click);
			// 
			// DocsFolderButton
			// 
			this.DocsFolderButton.Location = new System.Drawing.Point(587, 32);
			this.DocsFolderButton.Name = "DocsFolderButton";
			this.DocsFolderButton.Size = new System.Drawing.Size(75, 23);
			this.DocsFolderButton.TabIndex = 20;
			this.DocsFolderButton.Text = "Browse";
			this.DocsFolderButton.UseVisualStyleBackColor = true;
			this.DocsFolderButton.Click += new System.EventHandler(this.DocsFolderButton_Click);
			// 
			// modFolder
			// 
			this.modFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.modFolder.Location = new System.Drawing.Point(105, 35);
			this.modFolder.Name = "modFolder";
			this.modFolder.Size = new System.Drawing.Size(476, 20);
			this.modFolder.TabIndex = 19;
			this.modFolder.Text = "D:\\SteamLibrary\\SteamApps\\common\\Hearts of Iron IV";
			this.modFolder.TextChanged += new System.EventHandler(this.ModFolderTextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "HoI4 Mod Folder";
			// 
			// LaunchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 157);
			this.Controls.Add(this.DocsFolderButton);
			this.Controls.Add(this.modFolder);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.saveBrowse);
			this.Controls.Add(this.FolderBrowse);
			this.Controls.Add(this.tbSaveLocation);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnBegin);
			this.Controls.Add(this.tbSourceMapFolder);
			this.Controls.Add(this.label1);
			this.Name = "LaunchForm";
			this.Text = "Province Mapper Setup";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSourceMapFolder;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbSaveLocation;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button FolderBrowse;
		private System.Windows.Forms.Button saveBrowse;
		private System.Windows.Forms.Button DocsFolderButton;
		private System.Windows.Forms.TextBox modFolder;
		private System.Windows.Forms.Label label3;
	}
}

