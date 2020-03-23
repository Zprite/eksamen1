namespace eksamensoppgaver
{
    partial class FormKunnskapstest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKunnskapstest));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSpill = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelHighscore = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonNesteLyd = new System.Windows.Forms.Button();
            this.pictureBoxValthorn = new System.Windows.Forms.PictureBox();
            this.pictureBoxObo = new System.Windows.Forms.PictureBox();
            this.pictureBoxKlarinett = new System.Windows.Forms.PictureBox();
            this.pictureBoxFløyte = new System.Windows.Forms.PictureBox();
            this.pictureBoxFagott = new System.Windows.Forms.PictureBox();
            this.labelAntallForsøk = new System.Windows.Forms.Label();
            this.labelAntallRiktige = new System.Windows.Forms.Label();
            this.labelResultat = new System.Windows.Forms.Label();
            this.labelGratulerer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValthorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlarinett)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFløyte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFagott)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fagott";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fløyte";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Klarinett";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Obo";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valthorn";
            this.label5.Visible = false;
            // 
            // buttonSpill
            // 
            this.buttonSpill.Location = new System.Drawing.Point(50, 109);
            this.buttonSpill.Name = "buttonSpill";
            this.buttonSpill.Size = new System.Drawing.Size(624, 54);
            this.buttonSpill.TabIndex = 10;
            this.buttonSpill.Text = "SPEL";
            this.buttonSpill.UseVisualStyleBackColor = true;
            this.buttonSpill.Click += new System.EventHandler(this.buttonSpill_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelGratulerer);
            this.groupBox1.Controls.Add(this.labelResultat);
            this.groupBox1.Location = new System.Drawing.Point(50, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 114);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultat";
            this.groupBox1.Visible = false;
            // 
            // labelHighscore
            // 
            this.labelHighscore.AutoSize = true;
            this.labelHighscore.Location = new System.Drawing.Point(56, 460);
            this.labelHighscore.Name = "labelHighscore";
            this.labelHighscore.Size = new System.Drawing.Size(61, 13);
            this.labelHighscore.TabIndex = 12;
            this.labelHighscore.Text = "Highscore: ";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(304, 369);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(372, 45);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            // 
            // buttonNesteLyd
            // 
            this.buttonNesteLyd.Enabled = false;
            this.buttonNesteLyd.Location = new System.Drawing.Point(50, 369);
            this.buttonNesteLyd.Name = "buttonNesteLyd";
            this.buttonNesteLyd.Size = new System.Drawing.Size(236, 45);
            this.buttonNesteLyd.TabIndex = 14;
            this.buttonNesteLyd.Text = "Tilfeldig lyd";
            this.buttonNesteLyd.UseVisualStyleBackColor = true;
            this.buttonNesteLyd.Click += new System.EventHandler(this.buttonNesteLyd_Click);
            // 
            // pictureBoxValthorn
            // 
            this.pictureBoxValthorn.Image = global::eksamensoppgaver.Properties.Resources.valthorn1;
            this.pictureBoxValthorn.Location = new System.Drawing.Point(554, 180);
            this.pictureBoxValthorn.Name = "pictureBoxValthorn";
            this.pictureBoxValthorn.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxValthorn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxValthorn.TabIndex = 4;
            this.pictureBoxValthorn.TabStop = false;
            this.pictureBoxValthorn.Visible = false;
            this.pictureBoxValthorn.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pictureBoxObo
            // 
            this.pictureBoxObo.Image = global::eksamensoppgaver.Properties.Resources.obo1;
            this.pictureBoxObo.Location = new System.Drawing.Point(428, 180);
            this.pictureBoxObo.Name = "pictureBoxObo";
            this.pictureBoxObo.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxObo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxObo.TabIndex = 3;
            this.pictureBoxObo.TabStop = false;
            this.pictureBoxObo.Visible = false;
            this.pictureBoxObo.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pictureBoxKlarinett
            // 
            this.pictureBoxKlarinett.Image = global::eksamensoppgaver.Properties.Resources.klarinett1;
            this.pictureBoxKlarinett.Location = new System.Drawing.Point(302, 180);
            this.pictureBoxKlarinett.Name = "pictureBoxKlarinett";
            this.pictureBoxKlarinett.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxKlarinett.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKlarinett.TabIndex = 2;
            this.pictureBoxKlarinett.TabStop = false;
            this.pictureBoxKlarinett.Visible = false;
            this.pictureBoxKlarinett.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pictureBoxFløyte
            // 
            this.pictureBoxFløyte.Image = global::eksamensoppgaver.Properties.Resources.floyte;
            this.pictureBoxFløyte.Location = new System.Drawing.Point(176, 180);
            this.pictureBoxFløyte.Name = "pictureBoxFløyte";
            this.pictureBoxFløyte.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxFløyte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFløyte.TabIndex = 1;
            this.pictureBoxFløyte.TabStop = false;
            this.pictureBoxFløyte.Visible = false;
            this.pictureBoxFløyte.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pictureBoxFagott
            // 
            this.pictureBoxFagott.Image = global::eksamensoppgaver.Properties.Resources.fagott;
            this.pictureBoxFagott.Location = new System.Drawing.Point(50, 180);
            this.pictureBoxFagott.Name = "pictureBoxFagott";
            this.pictureBoxFagott.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxFagott.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFagott.TabIndex = 0;
            this.pictureBoxFagott.TabStop = false;
            this.pictureBoxFagott.Visible = false;
            this.pictureBoxFagott.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // labelAntallForsøk
            // 
            this.labelAntallForsøk.AutoSize = true;
            this.labelAntallForsøk.Location = new System.Drawing.Point(47, 353);
            this.labelAntallForsøk.Name = "labelAntallForsøk";
            this.labelAntallForsøk.Size = new System.Drawing.Size(57, 13);
            this.labelAntallForsøk.TabIndex = 15;
            this.labelAntallForsøk.Text = "Forsøk nr: ";
            // 
            // labelAntallRiktige
            // 
            this.labelAntallRiktige.AutoSize = true;
            this.labelAntallRiktige.Location = new System.Drawing.Point(50, 337);
            this.labelAntallRiktige.Name = "labelAntallRiktige";
            this.labelAntallRiktige.Size = new System.Drawing.Size(61, 13);
            this.labelAntallRiktige.TabIndex = 16;
            this.labelAntallRiktige.Text = "(0/5) riktige";
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Location = new System.Drawing.Point(6, 72);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(120, 13);
            this.labelResultat.TabIndex = 0;
            this.labelResultat.Text = "Antall forsøk  + highskår";
            // 
            // labelGratulerer
            // 
            this.labelGratulerer.AutoSize = true;
            this.labelGratulerer.Location = new System.Drawing.Point(6, 34);
            this.labelGratulerer.Name = "labelGratulerer";
            this.labelGratulerer.Size = new System.Drawing.Size(38, 13);
            this.labelGratulerer.TabIndex = 1;
            this.labelGratulerer.Text = "Fullført";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(414, 55);
            this.label7.TabIndex = 17;
            this.label7.Text = "Gjett instrumentet!";
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(663, 744);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(31, 23);
            this.axWindowsMediaPlayer2.TabIndex = 18;
            this.axWindowsMediaPlayer2.Visible = false;
            // 
            // FormKunnskapstest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 801);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelAntallRiktige);
            this.Controls.Add(this.labelAntallForsøk);
            this.Controls.Add(this.buttonNesteLyd);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.labelHighscore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSpill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxValthorn);
            this.Controls.Add(this.pictureBoxObo);
            this.Controls.Add(this.pictureBoxKlarinett);
            this.Controls.Add(this.pictureBoxFløyte);
            this.Controls.Add(this.pictureBoxFagott);
            this.Name = "FormKunnskapstest";
            this.Text = "FormKunnskapstest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValthorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlarinett)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFløyte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFagott)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFagott;
        private System.Windows.Forms.PictureBox pictureBoxFløyte;
        private System.Windows.Forms.PictureBox pictureBoxKlarinett;
        private System.Windows.Forms.PictureBox pictureBoxObo;
        private System.Windows.Forms.PictureBox pictureBoxValthorn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSpill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelHighscore;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonNesteLyd;
        private System.Windows.Forms.Label labelAntallForsøk;
        private System.Windows.Forms.Label labelAntallRiktige;
        private System.Windows.Forms.Label labelGratulerer;
        private System.Windows.Forms.Label labelResultat;
        private System.Windows.Forms.Label label7;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
    }
}