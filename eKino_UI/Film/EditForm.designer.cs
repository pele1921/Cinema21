namespace eKino_UI.Film
{
    partial class EditForm
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
            this.zanroviList = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.godinaIzdavanjaInput = new System.Windows.Forms.MaskedTextBox();
            this.slikaPictureBox = new System.Windows.Forms.PictureBox();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.spremiButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.trailerInput = new System.Windows.Forms.TextBox();
            this.opisInput = new System.Windows.Forms.RichTextBox();
            this.trajanjeInput = new System.Windows.Forms.NumericUpDown();
            this.izvorniNazivInput = new System.Windows.Forms.TextBox();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slikaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trajanjeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // zanroviList
            // 
            this.zanroviList.FormattingEnabled = true;
            this.zanroviList.Location = new System.Drawing.Point(149, 94);
            this.zanroviList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zanroviList.Name = "zanroviList";
            this.zanroviList.Size = new System.Drawing.Size(395, 106);
            this.zanroviList.TabIndex = 43;
            this.zanroviList.Validating += new System.ComponentModel.CancelEventHandler(this.zanroviList_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Žanr:";
            // 
            // godinaIzdavanjaInput
            // 
            this.godinaIzdavanjaInput.Location = new System.Drawing.Point(149, 231);
            this.godinaIzdavanjaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.godinaIzdavanjaInput.Mask = "0000";
            this.godinaIzdavanjaInput.Name = "godinaIzdavanjaInput";
            this.godinaIzdavanjaInput.Size = new System.Drawing.Size(61, 22);
            this.godinaIzdavanjaInput.TabIndex = 41;
            // 
            // slikaPictureBox
            // 
            this.slikaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slikaPictureBox.Location = new System.Drawing.Point(585, 18);
            this.slikaPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slikaPictureBox.Name = "slikaPictureBox";
            this.slikaPictureBox.Size = new System.Drawing.Size(220, 320);
            this.slikaPictureBox.TabIndex = 40;
            this.slikaPictureBox.TabStop = false;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(645, 700);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(77, 39);
            this.odustaniButton.TabIndex = 39;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(728, 700);
            this.spremiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(77, 39);
            this.spremiButton.TabIndex = 38;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(467, 633);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(77, 33);
            this.dodajButton.TabIndex = 37;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(149, 604);
            this.slikaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(395, 22);
            this.slikaInput.TabIndex = 36;
            this.slikaInput.Validating += new System.ComponentModel.CancelEventHandler(this.slikaInput_Validating);
            // 
            // trailerInput
            // 
            this.trailerInput.Location = new System.Drawing.Point(149, 562);
            this.trailerInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trailerInput.Name = "trailerInput";
            this.trailerInput.Size = new System.Drawing.Size(395, 22);
            this.trailerInput.TabIndex = 35;
            this.trailerInput.Validating += new System.ComponentModel.CancelEventHandler(this.opisInput_Validating);
            // 
            // opisInput
            // 
            this.opisInput.Location = new System.Drawing.Point(149, 308);
            this.opisInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opisInput.Name = "opisInput";
            this.opisInput.Size = new System.Drawing.Size(395, 238);
            this.opisInput.TabIndex = 34;
            this.opisInput.Text = "";
            this.opisInput.Validating += new System.ComponentModel.CancelEventHandler(this.opisInput_Validating);
            // 
            // trajanjeInput
            // 
            this.trajanjeInput.Location = new System.Drawing.Point(149, 270);
            this.trajanjeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trajanjeInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.trajanjeInput.Name = "trajanjeInput";
            this.trajanjeInput.Size = new System.Drawing.Size(61, 22);
            this.trajanjeInput.TabIndex = 33;
            // 
            // izvorniNazivInput
            // 
            this.izvorniNazivInput.Location = new System.Drawing.Point(149, 52);
            this.izvorniNazivInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.izvorniNazivInput.Name = "izvorniNazivInput";
            this.izvorniNazivInput.Size = new System.Drawing.Size(395, 22);
            this.izvorniNazivInput.TabIndex = 32;
            this.izvorniNazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.izvorniNazivInput_Validating);
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(149, 18);
            this.nazivInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(395, 22);
            this.nazivInput.TabIndex = 31;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Trailer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 607);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Slika:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Godina izdavanja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Trajanje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Izvorni naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Naziv:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 750);
            this.Controls.Add(this.zanroviList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.godinaIzdavanjaInput);
            this.Controls.Add(this.slikaPictureBox);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.trailerInput);
            this.Controls.Add(this.opisInput);
            this.Controls.Add(this.trajanjeInput);
            this.Controls.Add(this.izvorniNazivInput);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmijeni film";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slikaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trajanjeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox zanroviList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox godinaIzdavanjaInput;
        private System.Windows.Forms.PictureBox slikaPictureBox;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.TextBox trailerInput;
        private System.Windows.Forms.RichTextBox opisInput;
        private System.Windows.Forms.NumericUpDown trajanjeInput;
        private System.Windows.Forms.TextBox izvorniNazivInput;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}