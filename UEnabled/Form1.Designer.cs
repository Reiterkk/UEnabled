namespace UEnabled
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.LstLaender = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(188, 29);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 0;
            this.CmdLoeschen.Text = "Loeschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // LstLaender
            // 
            this.LstLaender.FormattingEnabled = true;
            this.LstLaender.ItemHeight = 15;
            this.LstLaender.Location = new System.Drawing.Point(12, 29);
            this.LstLaender.Name = "LstLaender";
            this.LstLaender.Size = new System.Drawing.Size(153, 184);
            this.LstLaender.TabIndex = 1;
            this.LstLaender.SelectedIndexChanged += new System.EventHandler(this.LstLaender_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstLaender);
            this.Controls.Add(this.CmdLoeschen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdLoeschen;
        private System.Windows.Forms.ListBox LstLaender;
    }
}

