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
            this.rtbCommandPrompt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // flpData
            // 
            this.flpData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpData.Location = new System.Drawing.Point(-2, -2);
            this.flpData.Name = "flpData";
            this.flpData.Size = new System.Drawing.Size(172, 454);
            this.flpData.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpData;
        private System.Windows.Forms.RichTextBox rtbCommandPrompt;
    }
}