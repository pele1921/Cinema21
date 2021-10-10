namespace eKino_UI.Korisnik
{
    partial class IndexForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.traziInput = new System.Windows.Forms.TextBox();
            this.traziButton = new System.Windows.Forms.Button();
            this.izmijeniKorisnikButton = new System.Windows.Forms.Button();
            this.noviKorisnikButton = new System.Windows.Forms.Button();
            this.korisniciDataGridView = new System.Windows.Forms.DataGridView();
            this.korisnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.korisniciResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obrisiKorisnikaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite ime ili prezime:";
            // 
            // traziInput
            // 
            this.traziInput.Location = new System.Drawing.Point(135, 16);
            this.traziInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.traziInput.Name = "traziInput";
            this.traziInput.Size = new System.Drawing.Size(262, 20);
            this.traziInput.TabIndex = 1;
            // 
            // traziButton
            // 
            this.traziButton.Location = new System.Drawing.Point(400, 11);
            this.traziButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.traziButton.Name = "traziButton";
            this.traziButton.Size = new System.Drawing.Size(65, 28);
            this.traziButton.TabIndex = 2;
            this.traziButton.Text = "Traži";
            this.traziButton.UseVisualStyleBackColor = true;
            this.traziButton.Click += new System.EventHandler(this.traziButton_Click);
            // 
            // izmijeniKorisnikButton
            // 
            this.izmijeniKorisnikButton.Location = new System.Drawing.Point(622, 11);
            this.izmijeniKorisnikButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.izmijeniKorisnikButton.Name = "izmijeniKorisnikButton";
            this.izmijeniKorisnikButton.Size = new System.Drawing.Size(101, 28);
            this.izmijeniKorisnikButton.TabIndex = 4;
            this.izmijeniKorisnikButton.Text = "Izmijeni korisnika";
            this.izmijeniKorisnikButton.UseVisualStyleBackColor = true;
            this.izmijeniKorisnikButton.Click += new System.EventHandler(this.izmijeniKorisnikButton_Click);
            // 
            // noviKorisnikButton
            // 
            this.noviKorisnikButton.Location = new System.Drawing.Point(517, 11);
            this.noviKorisnikButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noviKorisnikButton.Name = "noviKorisnikButton";
            this.noviKorisnikButton.Size = new System.Drawing.Size(101, 28);
            this.noviKorisnikButton.TabIndex = 5;
            this.noviKorisnikButton.Text = "Novi korisnik";
            this.noviKorisnikButton.UseVisualStyleBackColor = true;
            this.noviKorisnikButton.Click += new System.EventHandler(this.noviKorisnikButton_Click);
            // 
            // korisniciDataGridView
            // 
            this.korisniciDataGridView.AutoGenerateColumns = false;
            this.korisniciDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.korisniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnikIDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.korisniciDataGridView.DataSource = this.korisniciResultBindingSource;
            this.korisniciDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.korisniciDataGridView.Location = new System.Drawing.Point(0, 63);
            this.korisniciDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.korisniciDataGridView.MultiSelect = false;
            this.korisniciDataGridView.Name = "korisniciDataGridView";
            this.korisniciDataGridView.ReadOnly = true;
            this.korisniciDataGridView.RowTemplate.Height = 24;
            this.korisniciDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.korisniciDataGridView.Size = new System.Drawing.Size(841, 403);
            this.korisniciDataGridView.TabIndex = 6;
            // 
            // korisnikIDDataGridViewTextBoxColumn
            // 
            this.korisnikIDDataGridViewTextBoxColumn.DataPropertyName = "KorisnikID";
            this.korisnikIDDataGridViewTextBoxColumn.HeaderText = "KorisnikID";
            this.korisnikIDDataGridViewTextBoxColumn.Name = "korisnikIDDataGridViewTextBoxColumn";
            this.korisnikIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            this.korisnickoImeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // korisniciResultBindingSource
            // 
            this.korisniciResultBindingSource.DataSource = typeof(eKino_API.Models.Korisnici_Result);
            // 
            // obrisiKorisnikaButton
            // 
            this.obrisiKorisnikaButton.Location = new System.Drawing.Point(728, 11);
            this.obrisiKorisnikaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.obrisiKorisnikaButton.Name = "obrisiKorisnikaButton";
            this.obrisiKorisnikaButton.Size = new System.Drawing.Size(101, 28);
            this.obrisiKorisnikaButton.TabIndex = 7;
            this.obrisiKorisnikaButton.Text = "Obriši korisnika";
            this.obrisiKorisnikaButton.UseVisualStyleBackColor = true;
            this.obrisiKorisnikaButton.Click += new System.EventHandler(this.obrisiKorisnikaButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 466);
            this.Controls.Add(this.obrisiKorisnikaButton);
            this.Controls.Add(this.korisniciDataGridView);
            this.Controls.Add(this.noviKorisnikButton);
            this.Controls.Add(this.izmijeniKorisnikButton);
            this.Controls.Add(this.traziButton);
            this.Controls.Add(this.traziInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popis korisnika";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox traziInput;
        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.Button izmijeniKorisnikButton;
        private System.Windows.Forms.Button noviKorisnikButton;
        private System.Windows.Forms.DataGridView korisniciDataGridView;
        private System.Windows.Forms.BindingSource korisniciResultBindingSource;
        private System.Windows.Forms.Button obrisiKorisnikaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}