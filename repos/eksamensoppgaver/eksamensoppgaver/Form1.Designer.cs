namespace eksamensoppgaver
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelInfoHeader = new System.Windows.Forms.Label();
            this.labelInfoText = new System.Windows.Forms.Label();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.pictureBoxÅpningstider = new System.Windows.Forms.PictureBox();
            this.pictureBoxPriser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBestillBillett = new System.Windows.Forms.Button();
            this.buttonKunnskapstest = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxÅpningstider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPriser)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelInfoHeader);
            this.groupBoxInfo.Controls.Add(this.labelInfoText);
            this.groupBoxInfo.Location = new System.Drawing.Point(161, 148);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(618, 285);
            this.groupBoxInfo.TabIndex = 3;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            this.groupBoxInfo.Visible = false;
            // 
            // labelInfoHeader
            // 
            this.labelInfoHeader.AutoSize = true;
            this.labelInfoHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoHeader.Location = new System.Drawing.Point(36, 37);
            this.labelInfoHeader.Name = "labelInfoHeader";
            this.labelInfoHeader.Size = new System.Drawing.Size(199, 39);
            this.labelInfoHeader.TabIndex = 4;
            this.labelInfoHeader.Text = "Informasjon";
            // 
            // labelInfoText
            // 
            this.labelInfoText.AutoSize = true;
            this.labelInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoText.Location = new System.Drawing.Point(55, 91);
            this.labelInfoText.Name = "labelInfoText";
            this.labelInfoText.Size = new System.Drawing.Size(100, 20);
            this.labelInfoText.TabIndex = 0;
            this.labelInfoText.Text = "labelInfoText";
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Image = global::eksamensoppgaver.Properties.Resources.informasjon;
            this.pictureBoxInfo.Location = new System.Drawing.Point(21, 185);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(87, 85);
            this.pictureBoxInfo.TabIndex = 1;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.MouseLeave += new System.EventHandler(this.pictureBoxInfo_MouseLeave);
            this.pictureBoxInfo.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBoxÅpningstider
            // 
            this.pictureBoxÅpningstider.Image = global::eksamensoppgaver.Properties.Resources.aapningstider;
            this.pictureBoxÅpningstider.Location = new System.Drawing.Point(21, 3);
            this.pictureBoxÅpningstider.Name = "pictureBoxÅpningstider";
            this.pictureBoxÅpningstider.Size = new System.Drawing.Size(87, 85);
            this.pictureBoxÅpningstider.TabIndex = 2;
            this.pictureBoxÅpningstider.TabStop = false;
            this.pictureBoxÅpningstider.MouseLeave += new System.EventHandler(this.pictureBoxInfo_MouseLeave);
            this.pictureBoxÅpningstider.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBoxPriser
            // 
            this.pictureBoxPriser.Image = global::eksamensoppgaver.Properties.Resources.priser;
            this.pictureBoxPriser.Location = new System.Drawing.Point(21, 94);
            this.pictureBoxPriser.Name = "pictureBoxPriser";
            this.pictureBoxPriser.Size = new System.Drawing.Size(87, 85);
            this.pictureBoxPriser.TabIndex = 3;
            this.pictureBoxPriser.TabStop = false;
            this.pictureBoxPriser.MouseLeave += new System.EventHandler(this.pictureBoxInfo_MouseLeave);
            this.pictureBoxPriser.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBoxInfo);
            this.panel1.Controls.Add(this.pictureBoxPriser);
            this.panel1.Controls.Add(this.pictureBoxÅpningstider);
            this.panel1.Location = new System.Drawing.Point(27, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 288);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(48, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1293, 83);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1049, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velkommen til Ringve musikkhistoriske museum";
            // 
            // buttonBestillBillett
            // 
            this.buttonBestillBillett.Location = new System.Drawing.Point(806, 148);
            this.buttonBestillBillett.Name = "buttonBestillBillett";
            this.buttonBestillBillett.Size = new System.Drawing.Size(535, 108);
            this.buttonBestillBillett.TabIndex = 0;
            this.buttonBestillBillett.Text = "Bestill billett";
            this.buttonBestillBillett.UseVisualStyleBackColor = true;
            this.buttonBestillBillett.Click += new System.EventHandler(this.buttonBestillBillett_Click);
            // 
            // buttonKunnskapstest
            // 
            this.buttonKunnskapstest.Location = new System.Drawing.Point(806, 325);
            this.buttonKunnskapstest.Name = "buttonKunnskapstest";
            this.buttonKunnskapstest.Size = new System.Drawing.Size(535, 111);
            this.buttonKunnskapstest.TabIndex = 1;
            this.buttonKunnskapstest.Text = "Kunnskapstest";
            this.buttonKunnskapstest.UseVisualStyleBackColor = true;
            this.buttonKunnskapstest.Click += new System.EventHandler(this.buttonKunnskapstest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 894);
            this.Controls.Add(this.buttonKunnskapstest);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonBestillBillett);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxÅpningstider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPriser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelInfoHeader;
        private System.Windows.Forms.Label labelInfoText;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.PictureBox pictureBoxÅpningstider;
        private System.Windows.Forms.PictureBox pictureBoxPriser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBestillBillett;
        private System.Windows.Forms.Button buttonKunnskapstest;
    }
}

