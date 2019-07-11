using System;

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
            this.clbDll = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fldNugetPath = new NugetPackager.FolderDialog();
            this.fldDllPath = new NugetPackager.FolderDialog();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1382, 64);
            this.btnRun.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(250, 62);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtLog
            // 
            this.txtLog.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtLog.Location = new System.Drawing.Point(660, 252);
            this.txtLog.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtLog.Size = new System.Drawing.Size(976, 634);
            this.txtLog.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Messages";
            // 
            // clbDll
            // 
            this.clbDll.CheckOnClick = true;
            this.clbDll.FormattingEnabled = true;
            this.clbDll.Location = new System.Drawing.Point(42, 252);
            this.clbDll.Margin = new System.Windows.Forms.Padding(6);
            this.clbDll.Name = "clbDll";
            this.clbDll.Size = new System.Drawing.Size(602, 634);
            this.clbDll.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "DLL";
            // 
            // fldNugetPath
            // 
            this.fldNugetPath.Label = "Nuget Path";
            this.fldNugetPath.Location = new System.Drawing.Point(42, 103);
            this.fldNugetPath.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.fldNugetPath.Name = "fldNugetPath";
            this.fldNugetPath.Path = "";
            this.fldNugetPath.Size = new System.Drawing.Size(1336, 50);
            this.fldNugetPath.TabIndex = 8;
            // 
            // fldDllPath
            // 
            this.fldDllPath.Label = "Dll Path";
            this.fldDllPath.Location = new System.Drawing.Point(42, 43);
            this.fldDllPath.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.fldDllPath.Name = "fldDllPath";
            this.fldDllPath.Path = "";
            this.fldDllPath.Size = new System.Drawing.Size(1336, 50);
            this.fldDllPath.TabIndex = 7;
            this.fldDllPath.OnSelectFolder += new NugetPackager.FolderDialog.OnSelectFolderHandler(this.FldDllPath_OnSelectFolder);
            // 
            // FrmNugetPackager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 925);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbDll);
            this.Controls.Add(this.fldNugetPath);
            this.Controls.Add(this.fldDllPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnRun);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmNugetPackager";
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
        private System.Windows.Forms.CheckedListBox clbDll;
        private System.Windows.Forms.Label label1;
    }
}

