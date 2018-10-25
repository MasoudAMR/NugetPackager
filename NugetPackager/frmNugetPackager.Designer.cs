namespace NugetPackager
{
    partial class FrmNugetPackager
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
            this.btnRun = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fldDllPath = new NugetPackager.FolderDialog();
            this.fldNugetPath = new NugetPackager.FolderDialog();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(780, 53);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(141, 40);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(19, 159);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtLog.Size = new System.Drawing.Size(905, 420);
            this.txtLog.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Messages";
            // 
            // fldDllPath
            // 
            this.fldDllPath.Label = "Dll Path";
            this.fldDllPath.Location = new System.Drawing.Point(26, 39);
            this.fldDllPath.Name = "fldDllPath";
            this.fldDllPath.Path = "";
            this.fldDllPath.Size = new System.Drawing.Size(751, 33);
            this.fldDllPath.TabIndex = 7;
            // 
            // fldNugetPath
            // 
            this.fldNugetPath.Label = "Nuget Path";
            this.fldNugetPath.Location = new System.Drawing.Point(26, 78);
            this.fldNugetPath.Name = "fldNugetPath";
            this.fldNugetPath.Path = "";
            this.fldNugetPath.Size = new System.Drawing.Size(751, 33);
            this.fldNugetPath.TabIndex = 8;
            // 
            // frmNugetPackager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 591);
            this.Controls.Add(this.fldNugetPath);
            this.Controls.Add(this.fldDllPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnRun);
            this.Name = "frmNugetPackager";
            this.Text = "NugetPackager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label3;
        private FolderDialog fldDllPath;
        private FolderDialog fldNugetPath;
    }
}

