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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbCommandPrompt = new System.Windows.Forms.RichTextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.flpData.SuspendLayout();
            this.pnlDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpData
            // 
            this.flpData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpData.Controls.Add(this.pnlDatabase);
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
    }
}