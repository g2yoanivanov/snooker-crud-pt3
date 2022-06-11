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
            this.SuspendLayout();
            // 
            // btnCountries
            // 
            this.btnCountries.Location = new System.Drawing.Point(256, 136);
            this.btnCountries.Name = "btnCountries";
            this.btnCountries.Size = new System.Drawing.Size(86, 23);
            this.btnCountries.TabIndex = 0;
            this.btnCountries.Text = "Countries";
            this.btnCountries.UseVisualStyleBackColor = true;
            this.btnCountries.Click += new System.EventHandler(this.btnCountries_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Location = new System.Drawing.Point(412, 136);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(86, 23);
            this.btnPlayers.TabIndex = 1;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // btnTournaments
            // 
            this.btnTournaments.Location = new System.Drawing.Point(256, 253);
            this.btnTournaments.Name = "btnTournaments";
            this.btnTournaments.Size = new System.Drawing.Size(86, 23);
            this.btnTournaments.TabIndex = 2;
            this.btnTournaments.Text = "Tournaments";
            this.btnTournaments.UseVisualStyleBackColor = true;
            this.btnTournaments.Click += new System.EventHandler(this.btnTournaments_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(412, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTournaments);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.btnCountries);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCountries;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Button btnTournaments;
        private System.Windows.Forms.Button btnExit;
    }
}
