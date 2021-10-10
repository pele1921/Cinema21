namespace eKino_UI.Zanr
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
            this.noviZanrButton = new System.Windows.Forms.Button();
            this.izmijeniZanrButton = new System.Windows.Forms.Button();
            this.obrisiZanrButton = new System.Windows.Forms.Button();
            this.zanroviDataGridView = new System.Windows.Forms.DataGridView();
            this.zanrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanroviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zanroviDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanroviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noviZanrButton
            // 
            this.noviZanrButton.Location = new System.Drawing.Point(82, 21);
            this.noviZanrButton.Name = "noviZanrButton";
            this.noviZanrButton.Size = new System.Drawing.Size(115, 31);
            this.noviZanrButton.TabIndex = 2;
            this.noviZanrButton.Text = "Novi žanr";
            this.noviZanrButton.UseVisualStyleBackColor = true;
            this.noviZanrButton.Click += new System.EventHandler(this.noviZanrButton_Click);
            // 
            // izmijeniZanrButton
            // 
            this.izmijeniZanrButton.Location = new System.Drawing.Point(203, 21);
            this.izmijeniZanrButton.Name = "izmijeniZanrButton";
            this.izmijeniZanrButton.Size = new System.Drawing.Size(115, 31);
            this.izmijeniZanrButton.TabIndex = 3;
            this.izmijeniZanrButton.Text = "Izmijeni žanr";
            this.izmijeniZanrButton.UseVisualStyleBackColor = true;
            this.izmijeniZanrButton.Click += new System.EventHandler(this.izmijeniZanrButton_Click);
            // 
            // obrisiZanrButton
            // 
            this.obrisiZanrButton.Location = new System.Drawing.Point(324, 21);
            this.obrisiZanrButton.Name = "obrisiZanrButton";
            this.obrisiZanrButton.Size = new System.Drawing.Size(115, 31);
            this.obrisiZanrButton.TabIndex = 4;
            this.obrisiZanrButton.Text = "Obriši žanr";
            this.obrisiZanrButton.UseVisualStyleBackColor = true;
            this.obrisiZanrButton.Click += new System.EventHandler(this.obrisiZanrButton_Click);
            // 
            // zanroviDataGridView
            // 
            this.zanroviDataGridView.AutoGenerateColumns = false;
            this.zanroviDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zanroviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zanroviDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zanrIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn});
            this.zanroviDataGridView.DataSource = this.zanroviBindingSource;
            this.zanroviDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zanroviDataGridView.Location = new System.Drawing.Point(0, 65);
            this.zanroviDataGridView.Name = "zanroviDataGridView";
            this.zanroviDataGridView.RowTemplate.Height = 24;
            this.zanroviDataGridView.Size = new System.Drawing.Size(521, 447);
            this.zanroviDataGridView.TabIndex = 1;
            // 
            // zanrIDDataGridViewTextBoxColumn
            // 
            this.zanrIDDataGridViewTextBoxColumn.DataPropertyName = "ZanrID";
            this.zanrIDDataGridViewTextBoxColumn.HeaderText = "ZanrID";
            this.zanrIDDataGridViewTextBoxColumn.Name = "zanrIDDataGridViewTextBoxColumn";
            this.zanrIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.zanrIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zanroviBindingSource
            // 
            this.zanroviBindingSource.DataSource = typeof(eKino_API.Models.Zanrovi);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 512);
            this.Controls.Add(this.obrisiZanrButton);
            this.Controls.Add(this.izmijeniZanrButton);
            this.Controls.Add(this.noviZanrButton);
            this.Controls.Add(this.zanroviDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popis žanrova";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zanroviDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanroviBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button noviZanrButton;
        private System.Windows.Forms.Button izmijeniZanrButton;
        private System.Windows.Forms.Button obrisiZanrButton;
        private System.Windows.Forms.DataGridView zanroviDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zanroviBindingSource;
    }
}