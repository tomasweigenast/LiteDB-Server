﻿namespace LiteDB.Studio.Forms
{
    partial class ConnectionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTypeShared = new System.Windows.Forms.RadioButton();
            this.radTypeExclusive = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnOpen = new System.Windows.Forms.Button();
            this.chkUTC = new System.Windows.Forms.CheckBox();
            this.txtLimitSize = new System.Windows.Forms.TextBox();
            this.txtInitialSize = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.chkReadonly = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTypeShared);
            this.groupBox1.Controls.Add(this.radTypeExclusive);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 60);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Mode";
            // 
            // radTypeShared
            // 
            this.radTypeShared.AutoSize = true;
            this.radTypeShared.Location = new System.Drawing.Point(128, 25);
            this.radTypeShared.Name = "radTypeShared";
            this.radTypeShared.Size = new System.Drawing.Size(61, 19);
            this.radTypeShared.TabIndex = 10;
            this.radTypeShared.Text = "Shared";
            this.toolTip.SetToolTip(this.radTypeShared, "Open datafile in shared mode.\r\n- Support multiple connections (but only one execu" +
        "tion at time).\r\n- Support multple threads per connection");
            this.radTypeShared.UseVisualStyleBackColor = true;
            // 
            // radTypeExclusive
            // 
            this.radTypeExclusive.AutoSize = true;
            this.radTypeExclusive.Checked = true;
            this.radTypeExclusive.Location = new System.Drawing.Point(30, 25);
            this.radTypeExclusive.Name = "radTypeExclusive";
            this.radTypeExclusive.Size = new System.Drawing.Size(72, 19);
            this.radTypeExclusive.TabIndex = 9;
            this.radTypeExclusive.TabStop = true;
            this.radTypeExclusive.Text = "Exclusive";
            this.toolTip.SetToolTip(this.radTypeExclusive, "Open datafile in exclusive mode.\r\n- Support only this single connection\r\n- Suppor" +
        "t multple threads in this connection");
            this.radTypeExclusive.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Image = global::LiteDB.Studio.Properties.Resources.database_connect;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(454, 290);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOK.Size = new System.Drawing.Size(127, 38);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Connect";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::LiteDB.Studio.Properties.Resources.folder_explore;
            this.btnOpen.Location = new System.Drawing.Point(527, 25);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(28, 27);
            this.btnOpen.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnOpen, "Open existing datafile");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // chkUTC
            // 
            this.chkUTC.AutoSize = true;
            this.chkUTC.Location = new System.Drawing.Point(257, 30);
            this.chkUTC.Name = "chkUTC";
            this.chkUTC.Size = new System.Drawing.Size(75, 19);
            this.chkUTC.TabIndex = 26;
            this.chkUTC.Text = "UTC Date";
            this.toolTip.SetToolTip(this.chkUTC, "When deserialize BSON document from datafile, use UTC converstion (default is con" +
        "vert date into Local time)");
            this.chkUTC.UseVisualStyleBackColor = true;
            // 
            // txtLimitSize
            // 
            this.txtLimitSize.Location = new System.Drawing.Point(151, 86);
            this.txtLimitSize.Name = "txtLimitSize";
            this.txtLimitSize.Size = new System.Drawing.Size(70, 23);
            this.txtLimitSize.TabIndex = 25;
            this.txtLimitSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInitialSize
            // 
            this.txtInitialSize.Location = new System.Drawing.Point(151, 57);
            this.txtInitialSize.Name = "txtInitialSize";
            this.txtInitialSize.Size = new System.Drawing.Size(70, 23);
            this.txtInitialSize.TabIndex = 24;
            this.txtInitialSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.txtFilename);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 72);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filename";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(19, 28);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(502, 23);
            this.txtFilename.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimeout);
            this.groupBox3.Controls.Add(this.txtLimitSize);
            this.groupBox3.Controls.Add(this.txtInitialSize);
            this.groupBox3.Controls.Add(this.chkReadonly);
            this.groupBox3.Controls.Add(this.chkUTC);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 122);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(151, 28);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(70, 23);
            this.txtTimeout.TabIndex = 23;
            this.txtTimeout.Text = "00:01:00";
            this.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkReadonly
            // 
            this.chkReadonly.AutoSize = true;
            this.chkReadonly.Location = new System.Drawing.Point(257, 59);
            this.chkReadonly.Name = "chkReadonly";
            this.chkReadonly.Size = new System.Drawing.Size(78, 19);
            this.chkReadonly.TabIndex = 27;
            this.chkReadonly.Text = "Read only";
            this.chkReadonly.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Limit Size (MB):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Initial Size (MB):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Timeout (seconds):";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 340);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTypeShared;
        private System.Windows.Forms.RadioButton radTypeExclusive;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.TextBox txtLimitSize;
        private System.Windows.Forms.TextBox txtInitialSize;
        private System.Windows.Forms.CheckBox chkReadonly;
        private System.Windows.Forms.CheckBox chkUTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}