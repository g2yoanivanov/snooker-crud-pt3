namespace PresentationLayer
{
    partial class PlayersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.numMatches = new System.Windows.Forms.NumericUpDown();
            this.numTournaments = new System.Windows.Forms.NumericUpDown();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.lbCountries = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTournaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Crimson;
            this.btnCreate.ForeColor = System.Drawing.Color.Indigo;
            this.btnCreate.Location = new System.Drawing.Point(80, 371);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 60);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.ForeColor = System.Drawing.Color.Indigo;
            this.btnUpdate.Location = new System.Drawing.Point(201, 371);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 60);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.ForeColor = System.Drawing.Color.Indigo;
            this.btnExit.Location = new System.Drawing.Point(144, 439);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 60);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.Color.Indigo;
            this.btnDelete.Location = new System.Drawing.Point(687, 371);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 60);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matches Played";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tournaments Won";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(201, 64);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(154, 27);
            this.txtFirstName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(682, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Players";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(201, 107);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(154, 27);
            this.txtLastName.TabIndex = 12;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(200, 148);
            this.numAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numAge.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(155, 27);
            this.numAge.TabIndex = 13;
            this.numAge.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numMatches
            // 
            this.numMatches.Location = new System.Drawing.Point(201, 242);
            this.numMatches.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMatches.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMatches.Name = "numMatches";
            this.numMatches.Size = new System.Drawing.Size(154, 27);
            this.numMatches.TabIndex = 14;
            // 
            // numTournaments
            // 
            this.numTournaments.Location = new System.Drawing.Point(201, 286);
            this.numTournaments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTournaments.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTournaments.Name = "numTournaments";
            this.numTournaments.Size = new System.Drawing.Size(154, 27);
            this.numTournaments.TabIndex = 15;
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(486, 86);
            this.dgvPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.RowHeadersWidth = 51;
            this.dgvPlayers.RowTemplate.Height = 25;
            this.dgvPlayers.Size = new System.Drawing.Size(496, 255);
            this.dgvPlayers.TabIndex = 17;
            this.dgvPlayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayers_CellClick);
            // 
            // lbCountries
            // 
            this.lbCountries.FormattingEnabled = true;
            this.lbCountries.ItemHeight = 19;
            this.lbCountries.Location = new System.Drawing.Point(200, 199);
            this.lbCountries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbCountries.Name = "lbCountries";
            this.lbCountries.Size = new System.Drawing.Size(154, 23);
            this.lbCountries.TabIndex = 18;
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1028, 570);
            this.Controls.Add(this.lbCountries);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.numTournaments);
            this.Controls.Add(this.numMatches);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlayersForm";
            this.Text = "Players Form";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTournaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.NumericUpDown numMatches;
        private System.Windows.Forms.NumericUpDown numTournaments;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.ListBox lbCountries;
    }
}