namespace eKino_UI.Film
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
            this.filmoviDataGridView = new System.Windows.Forms.DataGridView();
            this.filmoviResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.traziInput = new System.Windows.Forms.TextBox();
            this.traziButton = new System.Windows.Forms.Button();
            this.dodajFilmButton = new System.Windows.Forms.Button();
            this.izmijeniFilmButton = new System.Windows.Forms.Button();
            this.obrisiFilmButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zanroviList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filmIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvorniNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.filmoviDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmoviResultBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filmoviDataGridView
            // 
            this.filmoviDataGridView.AutoGenerateColumns = false;
            this.filmoviDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filmoviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmoviDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.izvorniNazivDataGridViewTextBoxColumn,
            this.godinaIzdavanjaDataGridViewTextBoxColumn,
            this.trajanjeDataGridViewTextBoxColumn});
            this.filmoviDataGridView.DataSource = this.filmoviResultBindingSource;
            this.filmoviDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filmoviDataGridView.Location = new System.Drawing.Point(0, 154);
            this.filmoviDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filmoviDataGridView.MultiSelect = false;
            this.filmoviDataGridView.Name = "filmoviDataGridView";
            this.filmoviDataGridView.ReadOnly = true;
            this.filmoviDataGridView.RowTemplate.Height = 24;
            this.filmoviDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filmoviDataGridView.Size = new System.Drawing.Size(1077, 508);
            this.filmoviDataGridView.TabIndex = 0;
            // 
            // filmoviResultBindingSource
            // 
            this.filmoviResultBindingSource.DataSource = typeof(eKino_API.Models.Filmovi_Result);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite naziv:";
            // 
            // traziInput
            // 
            this.traziInput.Location = new System.Drawing.Point(119, 27);
            this.traziInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.traziInput.Name = "traziInput";
            this.traziInput.Size = new System.Drawing.Size(340, 22);
            this.traziInput.TabIndex = 2;
            // 
            // traziButton
            // 
            this.traziButton.Location = new System.Drawing.Point(465, 25);
            this.traziButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.traziButton.Name = "traziButton";
            this.traziButton.Size = new System.Drawing.Size(89, 30);
            this.traziButton.TabIndex = 7;
            this.traziButton.Text = "Traži";
            this.traziButton.UseVisualStyleBackColor = true;
            this.traziButton.Click += new System.EventHandler(this.traziButton_Click);
            // 
            // dodajFilmButton
            // 
            this.dodajFilmButton.Location = new System.Drawing.Point(789, 34);
            this.dodajFilmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajFilmButton.Name = "dodajFilmButton";
            this.dodajFilmButton.Size = new System.Drawing.Size(89, 33);
            this.dodajFilmButton.TabIndex = 8;
            this.dodajFilmButton.Text = "Dodaj film";
            this.dodajFilmButton.UseVisualStyleBackColor = true;
            this.dodajFilmButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // izmijeniFilmButton
            // 
            this.izmijeniFilmButton.Location = new System.Drawing.Point(884, 34);
            this.izmijeniFilmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.izmijeniFilmButton.Name = "izmijeniFilmButton";
            this.izmijeniFilmButton.Size = new System.Drawing.Size(89, 33);
            this.izmijeniFilmButton.TabIndex = 9;
            this.izmijeniFilmButton.Text = "Izmijeni film";
            this.izmijeniFilmButton.UseVisualStyleBackColor = true;
            this.izmijeniFilmButton.Click += new System.EventHandler(this.izmijeniFilmButton_Click);
            // 
            // obrisiFilmButton
            // 
            this.obrisiFilmButton.Location = new System.Drawing.Point(979, 34);
            this.obrisiFilmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obrisiFilmButton.Name = "obrisiFilmButton";
            this.obrisiFilmButton.Size = new System.Drawing.Size(89, 33);
            this.obrisiFilmButton.TabIndex = 10;
            this.obrisiFilmButton.Text = "Obriši film";
            this.obrisiFilmButton.UseVisualStyleBackColor = true;
            this.obrisiFilmButton.Click += new System.EventHandler(this.obrisiFilmButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zanroviList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.traziInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.traziButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(565, 112);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // zanroviList
            // 
            this.zanroviList.FormattingEnabled = true;
            this.zanroviList.Location = new System.Drawing.Point(119, 66);
            this.zanroviList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zanroviList.Name = "zanroviList";
            this.zanroviList.Size = new System.Drawing.Size(151, 24);
            this.zanroviList.TabIndex = 9;
            this.zanroviList.SelectionChangeCommitted += new System.EventHandler(this.zanroviList_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Odaberite žanr:";
            // 
            // filmIDDataGridViewTextBoxColumn
            // 
            this.filmIDDataGridViewTextBoxColumn.DataPropertyName = "FilmID";
            this.filmIDDataGridViewTextBoxColumn.HeaderText = "FilmID";
            this.filmIDDataGridViewTextBoxColumn.Name = "filmIDDataGridViewTextBoxColumn";
            this.filmIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.filmIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izvorniNazivDataGridViewTextBoxColumn
            // 
            this.izvorniNazivDataGridViewTextBoxColumn.DataPropertyName = "IzvorniNaziv";
            this.izvorniNazivDataGridViewTextBoxColumn.HeaderText = "IzvorniNaziv";
            this.izvorniNazivDataGridViewTextBoxColumn.Name = "izvorniNazivDataGridViewTextBoxColumn";
            this.izvorniNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godinaIzdavanjaDataGridViewTextBoxColumn
            // 
            this.godinaIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "GodinaIzdavanja";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.HeaderText = "GodinaIzdavanja";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.Name = "godinaIzdavanjaDataGridViewTextBoxColumn";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            this.trajanjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.obrisiFilmButton);
            this.Controls.Add(this.izmijeniFilmButton);
            this.Controls.Add(this.dodajFilmButton);
            this.Controls.Add(this.filmoviDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popis filmova";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmoviDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmoviResultBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView filmoviDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox traziInput;
        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.Button dodajFilmButton;
        private System.Windows.Forms.Button izmijeniFilmButton;
        private System.Windows.Forms.Button obrisiFilmButton;
        private System.Windows.Forms.BindingSource filmoviResultBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox zanroviList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izvorniNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
    }
}