namespace PresentationLayer
{
    partial class TournamentsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.numPrize = new System.Windows.Forms.NumericUpDown();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.dgvTournaments = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTournaments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prize Pool";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(836, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Players";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(482, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tournaments";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Lavender;
            this.txtName.ForeColor = System.Drawing.Color.DarkRed;
            this.txtName.Location = new System.Drawing.Point(151, 98);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 27);
            this.txtName.TabIndex = 6;
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.Lavender;
            this.txtLocation.ForeColor = System.Drawing.Color.DarkRed;
            this.txtLocation.Location = new System.Drawing.Point(151, 143);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(121, 27);
            this.txtLocation.TabIndex = 7;
            // 
            // numPrize
            // 
            this.numPrize.BackColor = System.Drawing.Color.Lavender;
            this.numPrize.ForeColor = System.Drawing.Color.DarkRed;
            this.numPrize.Location = new System.Drawing.Point(151, 191);
            this.numPrize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPrize.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPrize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPrize.Name = "numPrize";
            this.numPrize.Size = new System.Drawing.Size(121, 27);
            this.numPrize.TabIndex = 8;
            this.numPrize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbPlayers
            // 
            this.lbPlayers.BackColor = System.Drawing.Color.Lavender;
            this.lbPlayers.ForeColor = System.Drawing.Color.DarkRed;
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 19;
            this.lbPlayers.Location = new System.Drawing.Point(836, 98);
            this.lbPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(154, 194);
            this.lbPlayers.TabIndex = 9;
            this.lbPlayers.SelectedValueChanged += new System.EventHandler(this.lbPlayers_SelectedValueChanged);
            // 
            // dgvTournaments
            // 
            this.dgvTournaments.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTournaments.GridColor = System.Drawing.Color.Lavender;
            this.dgvTournaments.Location = new System.Drawing.Point(399, 98);
            this.dgvTournaments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTournaments.Name = "dgvTournaments";
            this.dgvTournaments.RowHeadersWidth = 51;
            this.dgvTournaments.RowTemplate.Height = 25;
            this.dgvTournaments.Size = new System.Drawing.Size(353, 190);
            this.dgvTournaments.TabIndex = 11;
            this.dgvTournaments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTournaments_CellClick);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkRed;
            this.btnCreate.ForeColor = System.Drawing.Color.Lavender;
            this.btnCreate.Location = new System.Drawing.Point(33, 308);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 60);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.ForeColor = System.Drawing.Color.Lavender;
            this.btnUpdate.Location = new System.Drawing.Point(151, 308);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 60);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.ForeColor = System.Drawing.Color.Lavender;
            this.btnExit.Location = new System.Drawing.Point(151, 376);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 60);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.ForeColor = System.Drawing.Color.Lavender;
            this.btnDelete.Location = new System.Drawing.Point(518, 308);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 60);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdd.ForeColor = System.Drawing.Color.Lavender;
            this.btnAdd.Location = new System.Drawing.Point(863, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 60);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Player";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.ForeColor = System.Drawing.Color.Lavender;
            this.btnClear.Location = new System.Drawing.Point(33, 376);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 60);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TournamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1028, 570);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvTournaments);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.numPrize);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TournamentsForm";
            this.Text = "TournamentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numPrize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTournaments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.NumericUpDown numPrize;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.DataGridView dgvTournaments;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}