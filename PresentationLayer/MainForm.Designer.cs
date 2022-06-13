namespace PresentationLayer
{
    partial class MainForm
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
            this.btnCountries = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.btnTournaments = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCountries
            // 
            this.btnCountries.BackColor = System.Drawing.Color.DarkRed;
            this.btnCountries.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCountries.ForeColor = System.Drawing.Color.Lavender;
            this.btnCountries.Location = new System.Drawing.Point(207, 314);
            this.btnCountries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCountries.Name = "btnCountries";
            this.btnCountries.Size = new System.Drawing.Size(123, 76);
            this.btnCountries.TabIndex = 0;
            this.btnCountries.Text = "Countries";
            this.btnCountries.UseVisualStyleBackColor = false;
            this.btnCountries.Click += new System.EventHandler(this.btnCountries_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.BackColor = System.Drawing.Color.DarkRed;
            this.btnPlayers.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnPlayers.ForeColor = System.Drawing.Color.Lavender;
            this.btnPlayers.Location = new System.Drawing.Point(381, 314);
            this.btnPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(123, 76);
            this.btnPlayers.TabIndex = 1;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = false;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // btnTournaments
            // 
            this.btnTournaments.BackColor = System.Drawing.Color.DarkRed;
            this.btnTournaments.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnTournaments.ForeColor = System.Drawing.Color.Lavender;
            this.btnTournaments.Location = new System.Drawing.Point(560, 314);
            this.btnTournaments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTournaments.Name = "btnTournaments";
            this.btnTournaments.Size = new System.Drawing.Size(123, 76);
            this.btnTournaments.TabIndex = 2;
            this.btnTournaments.Text = "Tournaments";
            this.btnTournaments.UseVisualStyleBackColor = false;
            this.btnTournaments.Click += new System.EventHandler(this.btnTournaments_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Lavender;
            this.btnExit.Location = new System.Drawing.Point(780, 521);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 53);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(155, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Snooker Tournaments";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTournaments);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.btnCountries);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCountries;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Button btnTournaments;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}
