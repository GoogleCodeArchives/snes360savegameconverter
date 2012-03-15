namespace Snes360SGC.Forms
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUpdateOnBoot = new System.Windows.Forms.CheckBox();
            this.btnBrowseTmpDir = new System.Windows.Forms.Button();
            this.txtTmpDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUpdateOnBoot);
            this.groupBox1.Controls.Add(this.btnBrowseTmpDir);
            this.groupBox1.Controls.Add(this.txtTmpDirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkUpdateOnBoot
            // 
            this.chkUpdateOnBoot.AutoSize = true;
            this.chkUpdateOnBoot.Location = new System.Drawing.Point(270, 104);
            this.chkUpdateOnBoot.Name = "chkUpdateOnBoot";
            this.chkUpdateOnBoot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUpdateOnBoot.Size = new System.Drawing.Size(103, 17);
            this.chkUpdateOnBoot.TabIndex = 4;
            this.chkUpdateOnBoot.Text = "Update On Boot";
            this.chkUpdateOnBoot.UseVisualStyleBackColor = true;
            this.chkUpdateOnBoot.CheckedChanged += new System.EventHandler(this.chkUpdateOnBoot_CheckedChanged);
            // 
            // btnBrowseTmpDir
            // 
            this.btnBrowseTmpDir.Location = new System.Drawing.Point(349, 36);
            this.btnBrowseTmpDir.Name = "btnBrowseTmpDir";
            this.btnBrowseTmpDir.Size = new System.Drawing.Size(24, 23);
            this.btnBrowseTmpDir.TabIndex = 2;
            this.btnBrowseTmpDir.Text = "...";
            this.btnBrowseTmpDir.UseVisualStyleBackColor = true;
            // 
            // txtTmpDirectory
            // 
            this.txtTmpDirectory.Location = new System.Drawing.Point(92, 38);
            this.txtTmpDirectory.Name = "txtTmpDirectory";
            this.txtTmpDirectory.Size = new System.Drawing.Size(251, 20);
            this.txtTmpDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temp Directory:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(397, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(398, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(397, 51);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(397, 117);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(75, 23);
            this.btnDefaults.TabIndex = 4;
            this.btnDefaults.Text = "&Defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 177);
            this.Controls.Add(this.btnDefaults);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Button btnBrowseTmpDir;
        private System.Windows.Forms.TextBox txtTmpDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUpdateOnBoot;
    }
}