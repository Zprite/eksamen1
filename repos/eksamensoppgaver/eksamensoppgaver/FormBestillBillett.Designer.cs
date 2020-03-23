namespace eksamensoppgaver
{
    partial class FormBestillBillett
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Dato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tidspunkt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Arrangement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numericUpDownVoksne = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBarn = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValgtArrangement = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxUtskrift = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelPris = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVoksne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBarn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxUtskrift.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dato,
            this.Tidspunkt,
            this.Arrangement,
            this.Info});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1135, 232);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Dato
            // 
            this.Dato.Text = "Dato";
            this.Dato.Width = 100;
            // 
            // Tidspunkt
            // 
            this.Tidspunkt.Text = "Tidspunkt";
            this.Tidspunkt.Width = 100;
            // 
            // Arrangement
            // 
            this.Arrangement.Text = "Arrangement";
            this.Arrangement.Width = 500;
            // 
            // Info
            // 
            this.Info.Text = "Info";
            this.Info.Width = 1000;
            // 
            // numericUpDownVoksne
            // 
            this.numericUpDownVoksne.Location = new System.Drawing.Point(25, 137);
            this.numericUpDownVoksne.Name = "numericUpDownVoksne";
            this.numericUpDownVoksne.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownVoksne.TabIndex = 1;
            // 
            // numericUpDownBarn
            // 
            this.numericUpDownBarn.Location = new System.Drawing.Point(248, 137);
            this.numericUpDownBarn.Name = "numericUpDownBarn";
            this.numericUpDownBarn.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBarn.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bestill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelValgtArrangement);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownVoksne);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericUpDownBarn);
            this.groupBox1.Location = new System.Drawing.Point(12, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 339);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bestilling";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valt arrangement:";
            // 
            // labelValgtArrangement
            // 
            this.labelValgtArrangement.AutoSize = true;
            this.labelValgtArrangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValgtArrangement.Location = new System.Drawing.Point(21, 79);
            this.labelValgtArrangement.Name = "labelValgtArrangement";
            this.labelValgtArrangement.Size = new System.Drawing.Size(182, 20);
            this.labelValgtArrangement.TabIndex = 5;
            this.labelValgtArrangement.Text = "Vel eit arrangement fyrst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Antall voksne:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Antall barn:";
            // 
            // groupBoxUtskrift
            // 
            this.groupBoxUtskrift.Controls.Add(this.labelPris);
            this.groupBoxUtskrift.Controls.Add(this.labelInfo);
            this.groupBoxUtskrift.Location = new System.Drawing.Point(534, 289);
            this.groupBoxUtskrift.Name = "groupBoxUtskrift";
            this.groupBoxUtskrift.Size = new System.Drawing.Size(613, 339);
            this.groupBoxUtskrift.TabIndex = 5;
            this.groupBoxUtskrift.TabStop = false;
            this.groupBoxUtskrift.Text = "Utskrift";
            this.groupBoxUtskrift.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(19, 45);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(45, 16);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "label2";
            // 
            // labelPris
            // 
            this.labelPris.AutoSize = true;
            this.labelPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPris.Location = new System.Drawing.Point(19, 94);
            this.labelPris.Name = "labelPris";
            this.labelPris.Size = new System.Drawing.Size(51, 20);
            this.labelPris.TabIndex = 1;
            this.labelPris.Text = "label5";
            // 
            // FormBestillBillett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 686);
            this.Controls.Add(this.groupBoxUtskrift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "FormBestillBillett";
            this.Text = "FormBestillBillett";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVoksne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBarn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxUtskrift.ResumeLayout(false);
            this.groupBoxUtskrift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Dato;
        private System.Windows.Forms.ColumnHeader Tidspunkt;
        private System.Windows.Forms.ColumnHeader Arrangement;
        private System.Windows.Forms.ColumnHeader Info;
        private System.Windows.Forms.NumericUpDown numericUpDownVoksne;
        private System.Windows.Forms.NumericUpDown numericUpDownBarn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelValgtArrangement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxUtskrift;
        private System.Windows.Forms.Label labelPris;
        private System.Windows.Forms.Label labelInfo;
    }
}