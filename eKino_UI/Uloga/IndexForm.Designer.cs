namespace eKino_UI.Uloga
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
            this.ulogeGrid = new System.Windows.Forms.DataGridView();
            this.ulogaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisniciUlogeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obrisiButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ulogeGrid
            // 
            this.ulogeGrid.AutoGenerateColumns = false;
            this.ulogeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ulogeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ulogeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ulogaIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.korisniciUlogeDataGridViewTextBoxColumn});
            this.ulogeGrid.DataSource = this.ulogeBindingSource;
            this.ulogeGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ulogeGrid.Location = new System.Drawing.Point(0, 79);
            this.ulogeGrid.Name = "ulogeGrid";
            this.ulogeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ulogeGrid.Size = new System.Drawing.Size(625, 273);
            this.ulogeGrid.TabIndex = 0;
            // 
            // ulogaIDDataGridViewTextBoxColumn
            // 
            this.ulogaIDDataGridViewTextBoxColumn.DataPropertyName = "UlogaID";
            this.ulogaIDDataGridViewTextBoxColumn.HeaderText = "UlogaID";
            this.ulogaIDDataGridViewTextBoxColumn.Name = "ulogaIDDataGridViewTextBoxColumn";
            this.ulogaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // korisniciUlogeDataGridViewTextBoxColumn
            // 
            this.korisniciUlogeDataGridViewTextBoxColumn.DataPropertyName = "KorisniciUloge";
            this.korisniciUlogeDataGridViewTextBoxColumn.HeaderText = "KorisniciUloge";
            this.korisniciUlogeDataGridViewTextBoxColumn.Name = "korisniciUlogeDataGridViewTextBoxColumn";
            this.korisniciUlogeDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisniciUlogeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.korisniciUlogeDataGridViewTextBoxColumn.Visible = false;
            // 
            // ulogeBindingSource
            // 
            this.ulogeBindingSource.DataSource = typeof(eKino_API.Models.Uloge);
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(422, 32);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(95, 23);
            this.obrisiButton.TabIndex = 1;
            this.obrisiButton.Text = "Obriši";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(523, 32);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(90, 23);
            this.dodajButton.TabIndex = 2;
            this.dodajButton.Text = "Dodaj ulogu";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 352);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.ulogeGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis Uloga";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ulogeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ulogeGrid;
        private System.Windows.Forms.BindingSource ulogeBindingSource;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulogaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisniciUlogeDataGridViewTextBoxColumn;
    }
}