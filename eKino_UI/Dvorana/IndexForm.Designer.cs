namespace eKino_UI.Dvorana
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
            this.dvoraneGrid = new System.Windows.Forms.DataGridView();
            this.dvoranaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvoraneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivDvoraneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.izmjeniButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvoraneGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvoraneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dvoraneGrid
            // 
            this.dvoraneGrid.AllowUserToDeleteRows = false;
            this.dvoraneGrid.AllowUserToResizeColumns = false;
            this.dvoraneGrid.AllowUserToResizeRows = false;
            this.dvoraneGrid.AutoGenerateColumns = false;
            this.dvoraneGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvoraneGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvoraneGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvoranaIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kapacitetDataGridViewTextBoxColumn});
            this.dvoraneGrid.DataSource = this.dvoraneBindingSource;
            this.dvoraneGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvoraneGrid.Location = new System.Drawing.Point(0, 78);
            this.dvoraneGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvoraneGrid.Name = "dvoraneGrid";
            this.dvoraneGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvoraneGrid.Size = new System.Drawing.Size(1094, 496);
            this.dvoraneGrid.TabIndex = 0;
            // 
            // dvoranaIDDataGridViewTextBoxColumn
            // 
            this.dvoranaIDDataGridViewTextBoxColumn.DataPropertyName = "DvoranaID";
            this.dvoranaIDDataGridViewTextBoxColumn.HeaderText = "DvoranaID";
            this.dvoranaIDDataGridViewTextBoxColumn.Name = "dvoranaIDDataGridViewTextBoxColumn";
            this.dvoranaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dvoranaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dvoranaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kapacitetDataGridViewTextBoxColumn
            // 
            this.kapacitetDataGridViewTextBoxColumn.DataPropertyName = "Kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.HeaderText = "Kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.Name = "kapacitetDataGridViewTextBoxColumn";
            this.kapacitetDataGridViewTextBoxColumn.ReadOnly = true;
            this.kapacitetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dvoraneBindingSource
            // 
            this.dvoraneBindingSource.DataSource = typeof(eKino_API.Models.Dvorane);
            // 
            // nazivDvoraneTextBox
            // 
            this.nazivDvoraneTextBox.Location = new System.Drawing.Point(129, 18);
            this.nazivDvoraneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nazivDvoraneTextBox.Name = "nazivDvoraneTextBox";
            this.nazivDvoraneTextBox.Size = new System.Drawing.Size(325, 22);
            this.nazivDvoraneTextBox.TabIndex = 1;
            this.nazivDvoraneTextBox.TextChanged += new System.EventHandler(this.nazivDvoraneTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv dvorane: ";
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(977, 16);
            this.obrisiButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(100, 28);
            this.obrisiButton.TabIndex = 3;
            this.obrisiButton.Text = "Obriši dvoranu";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // izmjeniButton
            // 
            this.izmjeniButton.Location = new System.Drawing.Point(869, 16);
            this.izmjeniButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izmjeniButton.Name = "izmjeniButton";
            this.izmjeniButton.Size = new System.Drawing.Size(100, 28);
            this.izmjeniButton.TabIndex = 4;
            this.izmjeniButton.Text = "Izmjeni dvoranu";
            this.izmjeniButton.UseVisualStyleBackColor = true;
            this.izmjeniButton.Click += new System.EventHandler(this.izmjeniButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(739, 16);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(123, 28);
            this.dodajButton.TabIndex = 5;
            this.dodajButton.Text = "Dodaj dvoranu";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 574);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.izmjeniButton);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazivDvoraneTextBox);
            this.Controls.Add(this.dvoraneGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis dvorana";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvoraneGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvoraneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvoraneGrid;
        private System.Windows.Forms.TextBox nazivDvoraneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dvoraneBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvoranaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.Button izmjeniButton;
        private System.Windows.Forms.Button dodajButton;
    }
}