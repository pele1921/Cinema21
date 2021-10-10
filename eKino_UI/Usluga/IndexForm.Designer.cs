namespace eKino_UI.Usluga
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
            this.uslugeGrid = new System.Windows.Forms.DataGridView();
            this.uslugaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.obrisiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uslugeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uslugeGrid
            // 
            this.uslugeGrid.AutoGenerateColumns = false;
            this.uslugeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uslugeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uslugeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uslugaIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.uslugeGrid.DataSource = this.uslugeBindingSource;
            this.uslugeGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uslugeGrid.Location = new System.Drawing.Point(0, 102);
            this.uslugeGrid.Margin = new System.Windows.Forms.Padding(4);
            this.uslugeGrid.MultiSelect = false;
            this.uslugeGrid.Name = "uslugeGrid";
            this.uslugeGrid.ReadOnly = true;
            this.uslugeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uslugeGrid.Size = new System.Drawing.Size(889, 294);
            this.uslugeGrid.TabIndex = 0;
            // 
            // uslugaIDDataGridViewTextBoxColumn
            // 
            this.uslugaIDDataGridViewTextBoxColumn.DataPropertyName = "UslugaID";
            this.uslugaIDDataGridViewTextBoxColumn.HeaderText = "UslugaID";
            this.uslugaIDDataGridViewTextBoxColumn.Name = "uslugaIDDataGridViewTextBoxColumn";
            this.uslugaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uslugaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // uslugeBindingSource
            // 
            this.uslugeBindingSource.DataSource = typeof(eKino_API.Models.Usluge);
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(131, 20);
            this.nazivTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(191, 22);
            this.nazivTextBox.TabIndex = 1;
            this.nazivTextBox.TextChanged += new System.EventHandler(this.nazivTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv usluge:";
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(753, 23);
            this.obrisiButton.Margin = new System.Windows.Forms.Padding(4);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(100, 28);
            this.obrisiButton.TabIndex = 3;
            this.obrisiButton.Text = "Obriši";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 396);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.uslugeGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popis usluga";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uslugeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uslugeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn uslugaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uslugeBindingSource;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button obrisiButton;
    }
}