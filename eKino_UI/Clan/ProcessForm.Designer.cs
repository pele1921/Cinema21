namespace eKino_UI.Clan
{
    partial class ProcessForm
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
            this.rezervacijeGrid = new System.Windows.Forms.DataGridView();
            this.ulaznicaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivFilmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeRezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvoranaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sjedaloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espRezervacijeGetKarteResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.iznosTextBox = new System.Windows.Forms.TextBox();
            this.procesirajButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.odustaniButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espRezervacijeGetKarteResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rezervacijeGrid
            // 
            this.rezervacijeGrid.AutoGenerateColumns = false;
            this.rezervacijeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rezervacijeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervacijeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ulaznicaIDDataGridViewTextBoxColumn,
            this.nazivFilmaDataGridViewTextBoxColumn,
            this.zanrDataGridViewTextBoxColumn,
            this.vrijemeRezervacijeDataGridViewTextBoxColumn,
            this.dvoranaDataGridViewTextBoxColumn,
            this.sjedaloDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.rezervacijeGrid.DataSource = this.espRezervacijeGetKarteResultBindingSource;
            this.rezervacijeGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rezervacijeGrid.Location = new System.Drawing.Point(0, 83);
            this.rezervacijeGrid.MultiSelect = false;
            this.rezervacijeGrid.Name = "rezervacijeGrid";
            this.rezervacijeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rezervacijeGrid.Size = new System.Drawing.Size(788, 201);
            this.rezervacijeGrid.TabIndex = 0;
            // 
            // ulaznicaIDDataGridViewTextBoxColumn
            // 
            this.ulaznicaIDDataGridViewTextBoxColumn.DataPropertyName = "UlaznicaID";
            this.ulaznicaIDDataGridViewTextBoxColumn.HeaderText = "UlaznicaID";
            this.ulaznicaIDDataGridViewTextBoxColumn.Name = "ulaznicaIDDataGridViewTextBoxColumn";
            this.ulaznicaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ulaznicaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ulaznicaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivFilmaDataGridViewTextBoxColumn
            // 
            this.nazivFilmaDataGridViewTextBoxColumn.DataPropertyName = "Naziv_Filma";
            this.nazivFilmaDataGridViewTextBoxColumn.HeaderText = "Naziv Filma";
            this.nazivFilmaDataGridViewTextBoxColumn.Name = "nazivFilmaDataGridViewTextBoxColumn";
            this.nazivFilmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivFilmaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // zanrDataGridViewTextBoxColumn
            // 
            this.zanrDataGridViewTextBoxColumn.DataPropertyName = "Zanr";
            this.zanrDataGridViewTextBoxColumn.HeaderText = "Zanr";
            this.zanrDataGridViewTextBoxColumn.Name = "zanrDataGridViewTextBoxColumn";
            this.zanrDataGridViewTextBoxColumn.ReadOnly = true;
            this.zanrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // vrijemeRezervacijeDataGridViewTextBoxColumn
            // 
            this.vrijemeRezervacijeDataGridViewTextBoxColumn.DataPropertyName = "Vrijeme_Rezervacije";
            this.vrijemeRezervacijeDataGridViewTextBoxColumn.HeaderText = "Vrijeme Rezervacije";
            this.vrijemeRezervacijeDataGridViewTextBoxColumn.Name = "vrijemeRezervacijeDataGridViewTextBoxColumn";
            this.vrijemeRezervacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrijemeRezervacijeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dvoranaDataGridViewTextBoxColumn
            // 
            this.dvoranaDataGridViewTextBoxColumn.DataPropertyName = "Dvorana";
            this.dvoranaDataGridViewTextBoxColumn.HeaderText = "Dvorana";
            this.dvoranaDataGridViewTextBoxColumn.Name = "dvoranaDataGridViewTextBoxColumn";
            this.dvoranaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dvoranaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sjedaloDataGridViewTextBoxColumn
            // 
            this.sjedaloDataGridViewTextBoxColumn.DataPropertyName = "Sjedalo";
            this.sjedaloDataGridViewTextBoxColumn.HeaderText = "Sjedalo";
            this.sjedaloDataGridViewTextBoxColumn.Name = "sjedaloDataGridViewTextBoxColumn";
            this.sjedaloDataGridViewTextBoxColumn.ReadOnly = true;
            this.sjedaloDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomenaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.napomenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // espRezervacijeGetKarteResultBindingSource
            // 
            this.espRezervacijeGetKarteResultBindingSource.DataSource = typeof(eKino_API.Models.esp_Rezervacije_GetKarte_Result);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisničko ime: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ukupan iznos: ";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(136, 16);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.ReadOnly = true;
            this.imeTextBox.Size = new System.Drawing.Size(113, 20);
            this.imeTextBox.TabIndex = 3;
            // 
            // iznosTextBox
            // 
            this.iznosTextBox.Location = new System.Drawing.Point(136, 47);
            this.iznosTextBox.Name = "iznosTextBox";
            this.iznosTextBox.ReadOnly = true;
            this.iznosTextBox.Size = new System.Drawing.Size(113, 20);
            this.iznosTextBox.TabIndex = 4;
            // 
            // procesirajButton
            // 
            this.procesirajButton.Location = new System.Drawing.Point(693, 54);
            this.procesirajButton.Name = "procesirajButton";
            this.procesirajButton.Size = new System.Drawing.Size(75, 23);
            this.procesirajButton.TabIndex = 5;
            this.procesirajButton.Text = "Procesiraj";
            this.procesirajButton.UseVisualStyleBackColor = true;
            this.procesirajButton.Click += new System.EventHandler(this.procesirajButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(792, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(10, 20);
            this.idTextBox.TabIndex = 6;
            this.idTextBox.Visible = false;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(603, 54);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 7;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 284);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.procesirajButton);
            this.Controls.Add(this.iznosTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rezervacijeGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesiranje rezervacija";
            this.Load += new System.EventHandler(this.ProcessForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espRezervacijeGetKarteResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rezervacijeGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox iznosTextBox;
        private System.Windows.Forms.Button procesirajButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource espRezervacijeGetKarteResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulaznicaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivFilmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeRezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvoranaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjedaloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button odustaniButton;
    }
}