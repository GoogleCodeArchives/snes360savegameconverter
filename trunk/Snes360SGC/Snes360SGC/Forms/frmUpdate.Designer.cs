namespace Snes360SGC.Forms
{
    partial class frmUpdate
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCheckForUpdates = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInstalledVersion = new System.Windows.Forms.TextBox();
            this.txtLatestVersion = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeLog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(338, 130);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.Location = new System.Drawing.Point(13, 130);
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.Size = new System.Drawing.Size(108, 23);
            this.btnCheckForUpdates.TabIndex = 1;
            this.btnCheckForUpdates.Text = "Check for &Updates";
            this.btnCheckForUpdates.UseVisualStyleBackColor = true;
            this.btnCheckForUpdates.Click += new System.EventHandler(this.btnCheckForUpdates_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Installed Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Latest Available:";
            // 
            // txtInstalledVersion
            // 
            this.txtInstalledVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstalledVersion.Location = new System.Drawing.Point(99, 25);
            this.txtInstalledVersion.Name = "txtInstalledVersion";
            this.txtInstalledVersion.ReadOnly = true;
            this.txtInstalledVersion.Size = new System.Drawing.Size(100, 13);
            this.txtInstalledVersion.TabIndex = 4;
            this.txtInstalledVersion.Text = "[version number]";
            this.txtInstalledVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLatestVersion
            // 
            this.txtLatestVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLatestVersion.Location = new System.Drawing.Point(99, 57);
            this.txtLatestVersion.Name = "txtLatestVersion";
            this.txtLatestVersion.ReadOnly = true;
            this.txtLatestVersion.Size = new System.Drawing.Size(100, 13);
            this.txtLatestVersion.TabIndex = 5;
            this.txtLatestVersion.Text = "[version number]";
            this.txtLatestVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(128, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLatestVersion);
            this.groupBox1.Controls.Add(this.txtInstalledVersion);
            this.groupBox1.Location = new System.Drawing.Point(115, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnChangeLog
            // 
            this.btnChangeLog.Enabled = false;
            this.btnChangeLog.Location = new System.Drawing.Point(210, 130);
            this.btnChangeLog.Name = "btnChangeLog";
            this.btnChangeLog.Size = new System.Drawing.Size(75, 23);
            this.btnChangeLog.TabIndex = 8;
            this.btnChangeLog.Text = "Change &Log";
            this.btnChangeLog.UseVisualStyleBackColor = true;
            this.btnChangeLog.Click += new System.EventHandler(this.btnChangeLog_Click);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 165);
            this.Controls.Add(this.btnChangeLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCheckForUpdates);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check For Updates";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCheckForUpdates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInstalledVersion;
        private System.Windows.Forms.TextBox txtLatestVersion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangeLog;
    }
}