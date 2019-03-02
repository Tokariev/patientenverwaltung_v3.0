namespace Patientenverwaltung_v3._0
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSuchen = new System.Windows.Forms.TabPage();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabTermine = new System.Windows.Forms.TabPage();
            this.dateTimePickerVon = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBis = new System.Windows.Forms.DateTimePicker();
            this.buttonHeute = new System.Windows.Forms.Button();
            this.dataGridViewTermine = new System.Windows.Forms.DataGridView();
            this.tabPagePatient = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxSozNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabSuchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabTermine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermine)).BeginInit();
            this.tabPagePatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSuchen);
            this.tabControl.Controls.Add(this.tabTermine);
            this.tabControl.Controls.Add(this.tabPagePatient);
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(41, 26);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(922, 565);
            this.tabControl.TabIndex = 0;
            // 
            // tabSuchen
            // 
            this.tabSuchen.Controls.Add(this.buttonAddPatient);
            this.tabSuchen.Controls.Add(this.dataGridView1);
            this.tabSuchen.Location = new System.Drawing.Point(4, 29);
            this.tabSuchen.Name = "tabSuchen";
            this.tabSuchen.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuchen.Size = new System.Drawing.Size(914, 532);
            this.tabSuchen.TabIndex = 0;
            this.tabSuchen.Text = "Suchen";
            this.tabSuchen.UseVisualStyleBackColor = true;
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPatient.Location = new System.Drawing.Point(0, 445);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(83, 81);
            this.buttonAddPatient.TabIndex = 1;
            this.buttonAddPatient.Text = "+";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(914, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tabTermine
            // 
            this.tabTermine.Controls.Add(this.dateTimePickerVon);
            this.tabTermine.Controls.Add(this.dateTimePickerBis);
            this.tabTermine.Controls.Add(this.buttonHeute);
            this.tabTermine.Controls.Add(this.dataGridViewTermine);
            this.tabTermine.Location = new System.Drawing.Point(4, 29);
            this.tabTermine.Name = "tabTermine";
            this.tabTermine.Padding = new System.Windows.Forms.Padding(3);
            this.tabTermine.Size = new System.Drawing.Size(914, 532);
            this.tabTermine.TabIndex = 1;
            this.tabTermine.Text = "Termine";
            this.tabTermine.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerVon
            // 
            this.dateTimePickerVon.Location = new System.Drawing.Point(440, 69);
            this.dateTimePickerVon.Name = "dateTimePickerVon";
            this.dateTimePickerVon.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerVon.TabIndex = 3;
            // 
            // dateTimePickerBis
            // 
            this.dateTimePickerBis.Location = new System.Drawing.Point(708, 69);
            this.dateTimePickerBis.Name = "dateTimePickerBis";
            this.dateTimePickerBis.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerBis.TabIndex = 2;
            // 
            // buttonHeute
            // 
            this.buttonHeute.Location = new System.Drawing.Point(798, 458);
            this.buttonHeute.Name = "buttonHeute";
            this.buttonHeute.Size = new System.Drawing.Size(110, 68);
            this.buttonHeute.TabIndex = 1;
            this.buttonHeute.Text = "Heute";
            this.buttonHeute.UseVisualStyleBackColor = true;
            this.buttonHeute.Click += new System.EventHandler(this.buttonHeute_Click);
            // 
            // dataGridViewTermine
            // 
            this.dataGridViewTermine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTermine.Location = new System.Drawing.Point(3, 101);
            this.dataGridViewTermine.Name = "dataGridViewTermine";
            this.dataGridViewTermine.Size = new System.Drawing.Size(911, 351);
            this.dataGridViewTermine.TabIndex = 0;
            // 
            // tabPagePatient
            // 
            this.tabPagePatient.BackColor = System.Drawing.Color.Linen;
            this.tabPagePatient.Controls.Add(this.pictureBox1);
            this.tabPagePatient.Controls.Add(this.textBoxID);
            this.tabPagePatient.Controls.Add(this.labelId);
            this.tabPagePatient.Controls.Add(this.textBoxSozNr);
            this.tabPagePatient.Controls.Add(this.label3);
            this.tabPagePatient.Controls.Add(this.labelStatus);
            this.tabPagePatient.Controls.Add(this.textBoxVorname);
            this.tabPagePatient.Controls.Add(this.textBoxName);
            this.tabPagePatient.Controls.Add(this.buttonSpeichern);
            this.tabPagePatient.Controls.Add(this.label2);
            this.tabPagePatient.Controls.Add(this.label1);
            this.tabPagePatient.Location = new System.Drawing.Point(4, 29);
            this.tabPagePatient.Name = "tabPagePatient";
            this.tabPagePatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatient.Size = new System.Drawing.Size(914, 532);
            this.tabPagePatient.TabIndex = 2;
            this.tabPagePatient.Text = "Patient";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(743, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(165, 20);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(51, 26);
            this.textBoxID.TabIndex = 9;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(24, 26);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(33, 20);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "ID: ";
            // 
            // textBoxSozNr
            // 
            this.textBoxSozNr.Location = new System.Drawing.Point(165, 63);
            this.textBoxSozNr.Name = "textBoxSozNr";
            this.textBoxSozNr.Size = new System.Drawing.Size(195, 26);
            this.textBoxSozNr.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "SozNr: ";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(6, 506);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 20);
            this.labelStatus.TabIndex = 5;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(165, 141);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(195, 26);
            this.textBoxVorname.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(165, 103);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(789, 482);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(122, 47);
            this.buttonSpeichern.TabIndex = 2;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 615);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSuchen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabTermine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermine)).EndInit();
            this.tabPagePatient.ResumeLayout(false);
            this.tabPagePatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSuchen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabTermine;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.DataGridView dataGridViewTermine;
        private System.Windows.Forms.DateTimePicker dateTimePickerVon;
        private System.Windows.Forms.DateTimePicker dateTimePickerBis;
        private System.Windows.Forms.Button buttonHeute;
        private System.Windows.Forms.TabPage tabPagePatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxSozNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

