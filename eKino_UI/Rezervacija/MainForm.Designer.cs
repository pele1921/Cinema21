namespace eKino_UI.Rezervacija
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
            this.aktivneRezervacije = new System.Windows.Forms.Button();
            this.procesiraneRezervacije = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aktivneRezervacije
            // 
            this.aktivneRezervacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aktivneRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktivneRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktivneRezervacije.Image = global::eKino_UI.Properties.Resources.read_icon;
            this.aktivneRezervacije.Location = new System.Drawing.Point(159, 164);
            this.aktivneRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.aktivneRezervacije.Name = "aktivneRezervacije";
            this.aktivneRezervacije.Size = new System.Drawing.Size(300, 227);
            this.aktivneRezervacije.TabIndex = 0;
            this.aktivneRezervacije.Text = "   Aktivne rezervacije";
            this.aktivneRezervacije.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aktivneRezervacije.UseVisualStyleBackColor = true;
            this.aktivneRezervacije.Click += new System.EventHandler(this.aktivneRezervacije_Click);
            // 
            // procesiraneRezervacije
            // 
            this.procesiraneRezervacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.procesiraneRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.procesiraneRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesiraneRezervacije.Image = global::eKino_UI.Properties.Resources.read_icon;
            this.procesiraneRezervacije.Location = new System.Drawing.Point(523, 162);
            this.procesiraneRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.procesiraneRezervacije.Name = "procesiraneRezervacije";
            this.procesiraneRezervacije.Size = new System.Drawing.Size(300, 227);
            this.procesiraneRezervacije.TabIndex = 1;
            this.procesiraneRezervacije.Text = "   Procesirane rezervacije";
            this.procesiraneRezervacije.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.procesiraneRezervacije.UseVisualStyleBackColor = true;
            this.procesiraneRezervacije.Click += new System.EventHandler(this.procesiraneRezervacije_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.procesiraneRezervacije);
            this.Controls.Add(this.aktivneRezervacije);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aktivneRezervacije;
        private System.Windows.Forms.Button procesiraneRezervacije;
    }
}