namespace eKino_UI.Clan
{
    partial class MainForm
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
            this.clanoviGrid = new System.Windows.Forms.DataGridView();
            this.clanoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRegistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clanoviGrid
            // 
            this.clanoviGrid.AllowUserToOrderColumns = true;
            this.clanoviGrid.AllowUserToResizeColumns = false;
            this.clanoviGrid.AllowUserToResizeRows = false;
            this.clanoviGrid.AutoGenerateColumns = false;
            this.clanoviGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clanoviGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clanoviGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clanIDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.datumRegistracijeDataGridViewTextBoxColumn,
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.clanoviGrid.DataSource = this.clanoviBindingSource;
            this.clanoviGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clanoviGrid.Location = new System.Drawing.Point(0, 63);
            this.clanoviGrid.Name = "clanoviGrid";
            this.clanoviGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clanoviGrid.Size = new System.Drawing.Size(905, 403);
            this.clanoviGrid.TabIndex = 0;
            this.clanoviGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clanoviGrid_CellContentClick);
            this.clanoviGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clanoviGrid_CellDoubleClick);
            // 
            // clanoviBindingSource
            // 
            this.clanoviBindingSource.DataSource = typeof(eKino_API.Models.Clanovi);
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(102, 16);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(152, 20);
            this.korisnickoImeTextBox.TabIndex = 1;
            this.korisnickoImeTextBox.TextChanged += new System.EventHandler(this.korisnickoImeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime: ";
            // 
            // clanIDDataGridViewTextBoxColumn
            // 
            this.clanIDDataGridViewTextBoxColumn.DataPropertyName = "ClanID";
            this.clanIDDataGridViewTextBoxColumn.HeaderText = "ClanID";
            this.clanIDDataGridViewTextBoxColumn.Name = "clanIDDataGridViewTextBoxColumn";
            this.clanIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // datumRegistracijeDataGridViewTextBoxColumn
            // 
            this.datumRegistracijeDataGridViewTextBoxColumn.DataPropertyName = "DatumRegistracije";
            this.datumRegistracijeDataGridViewTextBoxColumn.HeaderText = "DatumRegistracije";
            this.datumRegistracijeDataGridViewTextBoxColumn.Name = "datumRegistracijeDataGridViewTextBoxColumn";
            this.datumRegistracijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumRegistracijeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            this.korisnickoImeDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnickoImeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Controls.Add(this.clanoviGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis članova";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clanoviGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clanoviGrid;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource clanoviBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRegistracijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}