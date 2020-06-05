namespace ThesaurusAdministrator
{
    partial class AdminConsole
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
            this.flpData = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDatabase = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbCommandPrompt = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.lblSrc = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.flpData.SuspendLayout();
            this.pnlDatabase.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpData
            // 
            this.flpData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpData.Controls.Add(this.pnlDatabase);
            this.flpData.Controls.Add(this.panel1);
            this.flpData.Location = new System.Drawing.Point(-2, -2);
            this.flpData.Name = "flpData";
            this.flpData.Size = new System.Drawing.Size(172, 454);
            this.flpData.TabIndex = 0;
            // 
            // pnlDatabase
            // 
            this.pnlDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatabase.Controls.Add(this.lblStatus);
            this.pnlDatabase.Controls.Add(this.lblUser);
            this.pnlDatabase.Controls.Add(this.lblIP);
            this.pnlDatabase.Controls.Add(this.label4);
            this.pnlDatabase.Controls.Add(this.label3);
            this.pnlDatabase.Controls.Add(this.label2);
            this.pnlDatabase.Controls.Add(this.label1);
            this.pnlDatabase.Location = new System.Drawing.Point(10, 10);
            this.pnlDatabase.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDatabase.Name = "pnlDatabase";
            this.pnlDatabase.Size = new System.Drawing.Size(152, 100);
            this.pnlDatabase.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatus.Location = new System.Drawing.Point(54, 78);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(23, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "null";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUser.Location = new System.Drawing.Point(54, 55);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(23, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "null";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblIP.Location = new System.Drawing.Point(54, 32);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(23, 13);
            this.lblIP.TabIndex = 4;
            this.lblIP.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "User :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database :";
            // 
            // rtbCommandPrompt
            // 
            this.rtbCommandPrompt.BackColor = System.Drawing.Color.Black;
            this.rtbCommandPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCommandPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCommandPrompt.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbCommandPrompt.Location = new System.Drawing.Point(186, 12);
            this.rtbCommandPrompt.Name = "rtbCommandPrompt";
            this.rtbCommandPrompt.Size = new System.Drawing.Size(602, 426);
            this.rtbCommandPrompt.TabIndex = 1;
            this.rtbCommandPrompt.Text = "";
            this.rtbCommandPrompt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RtbCommandPrompt_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblStatus2);
            this.panel1.Controls.Add(this.lblSrc);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Location = new System.Drawing.Point(10, 130);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 100);
            this.panel1.TabIndex = 7;
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatus2.Location = new System.Drawing.Point(54, 78);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(23, 13);
            this.lblStatus2.TabIndex = 6;
            this.lblStatus2.Text = "null";
            // 
            // lblSrc
            // 
            this.lblSrc.AutoSize = true;
            this.lblSrc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSrc.Location = new System.Drawing.Point(54, 55);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(23, 13);
            this.lblSrc.TabIndex = 5;
            this.lblSrc.Text = "null";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCount.Location = new System.Drawing.Point(54, 32);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(23, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(3, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Source :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(3, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Status :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(3, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Count :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl.Location = new System.Drawing.Point(3, 6);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(43, 16);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Files :";
            // 
            // AdminConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbCommandPrompt);
            this.Controls.Add(this.flpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminConsole";
            this.ShowIcon = false;
            this.Text = "AdminConsole";
            this.flpData.ResumeLayout(false);
            this.pnlDatabase.ResumeLayout(false);
            this.pnlDatabase.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpData;
        private System.Windows.Forms.RichTextBox rtbCommandPrompt;
        private System.Windows.Forms.Panel pnlDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblStatus2;
        public System.Windows.Forms.Label lblSrc;
        public System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl;
    }
}