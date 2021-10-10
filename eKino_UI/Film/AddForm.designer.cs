namespace eKino_UI.Film
{
    partial class AddForm
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
            this.filmOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.opisInput = new System.Windows.Forms.RichTextBox();
            this.trailerInput = new System.Windows.Forms.TextBox();
            this.izvorniNazivInput = new System.Windows.Forms.TextBox();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.slikaPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.godinaIzdavanjaInput = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zanroviList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.daljeButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.spremiButton = new System.Windows.Forms.Button();
            this.trajanjeInput = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // filmOpenFileDialog
            // 
            this.filmOpenFileDialog.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // opisInput
            // 
            this.opisInput.Location = new System.Drawing.Point(140, 304);
            this.opisInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opisInput.Name = "opisInput";
            this.opisInput.Size = new System.Drawing.Size(395, 238);
            this.opisInput.TabIndex = 13;
            this.opisInput.Text = "";
            this.opisInput.Validating += new System.ComponentModel.CancelEventHandler(this.opisInput_Validating);
            // 
            // trailerInput
            // 
            this.trailerInput.Location = new System.Drawing.Point(140, 558);
            this.trailerInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trailerInput.Name = "trailerInput";
            this.trailerInput.Size = new System.Drawing.Size(395, 22);
            this.trailerInput.TabIndex = 14;
            this.trailerInput.Validating += new System.ComponentModel.CancelEventHandler(this.trailerInput_Validating);
            // 
            // izvorniNazivInput
            // 
            this.izvorniNazivInput.Location = new System.Drawing.Point(140, 48);
            this.izvorniNazivInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.izvorniNazivInput.Name = "izvorniNazivInput";
            this.izvorniNazivInput.Size = new System.Drawing.Size(395, 22);
            this.izvorniNazivInput.TabIndex = 10;
            this.izvorniNazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.izvorniNazivInput_Validating);
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(140, 599);
            this.slikaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(395, 22);
            this.slikaInput.TabIndex = 15;
            this.slikaInput.Validating += new System.ComponentModel.CancelEventHandler(this.slikaInput_Validating);
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(140, 15);
            this.nazivInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(395, 22);
            this.nazivInput.TabIndex = 8;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(459, 628);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(77, 33);
            this.dodajButton.TabIndex = 16;
            this.dodajButton.Text = "...";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trailer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Slika:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Opis:";
            // 
            // slikaPictureBox
            // 
            this.slikaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slikaPictureBox.Location = new System.Drawing.Point(576, 15);
            this.slikaPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slikaPictureBox.Name = "slikaPictureBox";
            this.slikaPictureBox.Size = new System.Drawing.Size(220, 320);
            this.slikaPictureBox.TabIndex = 19;
            this.slikaPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Godina izdavanja:";
            // 
            // godinaIzdavanjaInput
            // 
            this.godinaIzdavanjaInput.Location = new System.Drawing.Point(140, 228);
            this.godinaIzdavanjaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.godinaIzdavanjaInput.Mask = "0000";
            this.godinaIzdavanjaInput.Name = "godinaIzdavanjaInput";
            this.godinaIzdavanjaInput.Size = new System.Drawing.Size(61, 22);
            this.godinaIzdavanjaInput.TabIndex = 20;
            this.godinaIzdavanjaInput.Validating += new System.ComponentModel.CancelEventHandler(this.godinaIzdavanjaInput_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trajanje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Žanr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izvorni naziv:";
            // 
            // zanroviList
            // 
            this.zanroviList.FormattingEnabled = true;
            this.zanroviList.Location = new System.Drawing.Point(140, 89);
            this.zanroviList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zanroviList.Name = "zanroviList";
            this.zanroviList.Size = new System.Drawing.Size(395, 106);
            this.zanroviList.TabIndex = 23;
            this.zanroviList.Validating += new System.ComponentModel.CancelEventHandler(this.zanroviList_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // daljeButton
            // 
            this.daljeButton.Location = new System.Drawing.Point(2091, 773);
            this.daljeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daljeButton.Name = "daljeButton";
            this.daljeButton.Size = new System.Drawing.Size(77, 39);
            this.daljeButton.TabIndex = 24;
            this.daljeButton.Text = "Dalje";
            this.daljeButton.UseVisualStyleBackColor = true;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(636, 706);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(77, 33);
            this.odustaniButton.TabIndex = 26;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(719, 706);
            this.spremiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(77, 33);
            this.spremiButton.TabIndex = 27;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // trajanjeInput
            // 
            this.trajanjeInput.Location = new System.Drawing.Point(140, 268);
            this.trajanjeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trajanjeInput.Mask = "000";
            this.trajanjeInput.Name = "trajanjeInput";
            this.trajanjeInput.Size = new System.Drawing.Size(61, 22);
            this.trajanjeInput.TabIndex = 28;
            this.trajanjeInput.Validating += new System.ComponentModel.CancelEventHandler(this.trajanjeInput_Validating);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 750);
            this.Controls.Add(this.trajanjeInput);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.daljeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zanroviList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opisInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trailerInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.izvorniNazivInput);
            this.Controls.Add(this.godinaIzdavanjaInput);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.slikaPictureBox);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novi Film";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog filmOpenFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button daljeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox zanroviList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox opisInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox trailerInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox izvorniNazivInput;
        private System.Windows.Forms.MaskedTextBox godinaIzdavanjaInput;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.PictureBox slikaPictureBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.MaskedTextBox trajanjeInput;
    }
}