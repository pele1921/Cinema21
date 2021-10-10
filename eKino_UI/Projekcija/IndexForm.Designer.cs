namespace eKino_UI.Projekcija
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
            this.projekcijeDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.traziInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.novaProjekcijaButton = new System.Windows.Forms.Button();
            this.izmijeniProjekcijuButton = new System.Windows.Forms.Button();
            this.obrisiProjekcijuButton = new System.Windows.Forms.Button();
            this.projekcijeResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekcijaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstauslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvoranaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumProjekcijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projekcijeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projekcijeResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projekcijeDataGridView
            // 
            this.projekcijeDataGridView.AutoGenerateColumns = false;
            this.projekcijeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projekcijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projekcijeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projekcijaIDDataGridViewTextBoxColumn,
            this.filmDataGridViewTextBoxColumn,
            this.vrstauslugeDataGridViewTextBoxColumn,
            this.dvoranaDataGridViewTextBoxColumn,
            this.datumProjekcijeDataGridViewTextBoxColumn});
            this.projekcijeDataGridView.DataSource = this.projekcijeResultBindingSource;
            this.projekcijeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projekcijeDataGridView.Location = new System.Drawing.Point(0, 151);
            this.projekcijeDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.projekcijeDataGridView.MultiSelect = false;
            this.projekcijeDataGridView.Name = "projekcijeDataGridView";
            this.projekcijeDataGridView.ReadOnly = true;
            this.projekcijeDataGridView.RowTemplate.Height = 24;
            this.projekcijeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projekcijeDataGridView.Size = new System.Drawing.Size(848, 423);
            this.projekcijeDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite naziv filma:";
            // 
            // traziInput
            // 
            this.traziInput.Location = new System.Drawing.Point(144, 38);
            this.traziInput.Margin = new System.Windows.Forms.Padding(2);
            this.traziInput.Name = "traziInput";
            this.traziInput.Size = new System.Drawing.Size(247, 20);
            this.traziInput.TabIndex = 2;
            this.traziInput.TextChanged += new System.EventHandler(this.traziInput_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.traziInput);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(471, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datum prikazivanja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // novaProjekcijaButton
            // 
            this.novaProjekcijaButton.Location = new System.Drawing.Point(514, 42);
            this.novaProjekcijaButton.Margin = new System.Windows.Forms.Padding(2);
            this.novaProjekcijaButton.Name = "novaProjekcijaButton";
            this.novaProjekcijaButton.Size = new System.Drawing.Size(105, 30);
            this.novaProjekcijaButton.TabIndex = 9;
            this.novaProjekcijaButton.Text = "Nova projekcija";
            this.novaProjekcijaButton.UseVisualStyleBackColor = true;
            this.novaProjekcijaButton.Click += new System.EventHandler(this.novaProjekcijaButton_Click);
            // 
            // izmijeniProjekcijuButton
            // 
            this.izmijeniProjekcijuButton.Location = new System.Drawing.Point(623, 42);
            this.izmijeniProjekcijuButton.Margin = new System.Windows.Forms.Padding(2);
            this.izmijeniProjekcijuButton.Name = "izmijeniProjekcijuButton";
            this.izmijeniProjekcijuButton.Size = new System.Drawing.Size(105, 30);
            this.izmijeniProjekcijuButton.TabIndex = 12;
            this.izmijeniProjekcijuButton.Text = "Izmijeni projekciju";
            this.izmijeniProjekcijuButton.UseVisualStyleBackColor = true;
            this.izmijeniProjekcijuButton.Click += new System.EventHandler(this.izmijeniProjekcijuButton_Click);
            // 
            // obrisiProjekcijuButton
            // 
            this.obrisiProjekcijuButton.Location = new System.Drawing.Point(730, 42);
            this.obrisiProjekcijuButton.Margin = new System.Windows.Forms.Padding(2);
            this.obrisiProjekcijuButton.Name = "obrisiProjekcijuButton";
            this.obrisiProjekcijuButton.Size = new System.Drawing.Size(105, 30);
            this.obrisiProjekcijuButton.TabIndex = 13;
            this.obrisiProjekcijuButton.Text = "Obriši projekciju";
            this.obrisiProjekcijuButton.UseVisualStyleBackColor = true;
            this.obrisiProjekcijuButton.Click += new System.EventHandler(this.obrisiProjekcijuButton_Click);
            // 
            // projekcijeResultBindingSource
            // 
            this.projekcijeResultBindingSource.DataSource = typeof(eKino_API.Models.Projekcije_Result);
            // 
            // projekcijaIDDataGridViewTextBoxColumn
            // 
            this.projekcijaIDDataGridViewTextBoxColumn.DataPropertyName = "ProjekcijaID";
            this.projekcijaIDDataGridViewTextBoxColumn.HeaderText = "ProjekcijaID";
            this.projekcijaIDDataGridViewTextBoxColumn.Name = "projekcijaIDDataGridViewTextBoxColumn";
            this.projekcijaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.projekcijaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // filmDataGridViewTextBoxColumn
            // 
            this.filmDataGridViewTextBoxColumn.DataPropertyName = "Film";
            this.filmDataGridViewTextBoxColumn.HeaderText = "Film";
            this.filmDataGridViewTextBoxColumn.Name = "filmDataGridViewTextBoxColumn";
            this.filmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstauslugeDataGridViewTextBoxColumn
            // 
            this.vrstauslugeDataGridViewTextBoxColumn.DataPropertyName = "Vrsta_usluge";
            this.vrstauslugeDataGridViewTextBoxColumn.HeaderText = "Vrsta_usluge";
            this.vrstauslugeDataGridViewTextBoxColumn.Name = "vrstauslugeDataGridViewTextBoxColumn";
            this.vrstauslugeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstauslugeDataGridViewTextBoxColumn.Visible = false;
            // 
            // dvoranaDataGridViewTextBoxColumn
            // 
            this.dvoranaDataGridViewTextBoxColumn.DataPropertyName = "Dvorana";
            this.dvoranaDataGridViewTextBoxColumn.HeaderText = "Dvorana";
            this.dvoranaDataGridViewTextBoxColumn.Name = "dvoranaDataGridViewTextBoxColumn";
            this.dvoranaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumProjekcijeDataGridViewTextBoxColumn
            // 
            this.datumProjekcijeDataGridViewTextBoxColumn.DataPropertyName = "DatumProjekcije";
            this.datumProjekcijeDataGridViewTextBoxColumn.HeaderText = "DatumProjekcije";
            this.datumProjekcijeDataGridViewTextBoxColumn.Name = "datumProjekcijeDataGridViewTextBoxColumn";
            this.datumProjekcijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 574);
            this.Controls.Add(this.obrisiProjekcijuButton);
            this.Controls.Add(this.izmijeniProjekcijuButton);
            this.Controls.Add(this.novaProjekcijaButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projekcijeDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popis projekcija";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projekcijeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projekcijeResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView projekcijeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox traziInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button novaProjekcijaButton;
        private System.Windows.Forms.Button izmijeniProjekcijuButton;
        private System.Windows.Forms.Button obrisiProjekcijuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource projekcijeResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn projekcijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstauslugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvoranaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumProjekcijeDataGridViewTextBoxColumn;
    }
}