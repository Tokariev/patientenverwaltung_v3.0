using System.Windows.Forms;

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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSuche = new System.Windows.Forms.TextBox();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabTermine = new System.Windows.Forms.TabPage();
            this.dateTimePickerVon = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBis = new System.Windows.Forms.DateTimePicker();
            this.buttonHeute = new System.Windows.Forms.Button();
            this.dataGridViewTermine = new System.Windows.Forms.DataGridView();
            this.tabPagePatient = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBefund = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBetreff = new System.Windows.Forms.TextBox();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.btnDeleteDate = new System.Windows.Forms.Button();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewPatientTermine = new System.Windows.Forms.DataGridView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxSozNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonm = new System.Windows.Forms.RadioButton();
            this.radioButtonw = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.tabSuchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabTermine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermine)).BeginInit();
            this.tabPagePatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientTermine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSuchen);
            this.tabControl.Controls.Add(this.tabTermine);
            this.tabControl.Controls.Add(this.tabPagePatient);
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(41, 26);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(922, 565);
            this.tabControl.TabIndex = 0;
            // 
            // tabSuchen
            // 
            this.tabSuchen.Controls.Add(this.label4);
            this.tabSuchen.Controls.Add(this.textBoxSuche);
            this.tabSuchen.Controls.Add(this.buttonAddPatient);
            this.tabSuchen.Controls.Add(this.dataGridView1);
            this.tabSuchen.Location = new System.Drawing.Point(4, 29);
            this.tabSuchen.Name = "tabSuchen";
            this.tabSuchen.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuchen.Size = new System.Drawing.Size(914, 532);
            this.tabSuchen.TabIndex = 0;
            this.tabSuchen.Text = "Suchen";
            this.tabSuchen.UseVisualStyleBackColor = true;
            this.tabSuchen.Enter += new System.EventHandler(this.tabSuchen_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Suchen:";
            // 
            // textBoxSuche
            // 
            this.textBoxSuche.Location = new System.Drawing.Point(728, 60);
            this.textBoxSuche.Name = "textBoxSuche";
            this.textBoxSuche.Size = new System.Drawing.Size(180, 26);
            this.textBoxSuche.TabIndex = 2;
            this.textBoxSuche.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPatient.Location = new System.Drawing.Point(6, 445);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(83, 81);
            this.buttonAddPatient.TabIndex = 1;
            this.buttonAddPatient.Text = "+";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 92);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(902, 347);
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
            this.tabTermine.Enter += new System.EventHandler(this.tabTermine_Enter);
            // 
            // dateTimePickerVon
            // 
            this.dateTimePickerVon.Location = new System.Drawing.Point(440, 69);
            this.dateTimePickerVon.Name = "dateTimePickerVon";
            this.dateTimePickerVon.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerVon.TabIndex = 3;
            this.dateTimePickerVon.ValueChanged += new System.EventHandler(this.dateTimePickerVon_ValueChanged);
            // 
            // dateTimePickerBis
            // 
            this.dateTimePickerBis.Location = new System.Drawing.Point(708, 69);
            this.dateTimePickerBis.Name = "dateTimePickerBis";
            this.dateTimePickerBis.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerBis.TabIndex = 2;
            this.dateTimePickerBis.ValueChanged += new System.EventHandler(this.dateTimePickerBis_ValueChanged);
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
            this.dataGridViewTermine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTermine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTermine.Location = new System.Drawing.Point(3, 101);
            this.dataGridViewTermine.MultiSelect = false;
            this.dataGridViewTermine.Name = "dataGridViewTermine";
            this.dataGridViewTermine.ReadOnly = true;
            this.dataGridViewTermine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTermine.Size = new System.Drawing.Size(911, 351);
            this.dataGridViewTermine.TabIndex = 0;
            this.dataGridViewTermine.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTermine_CellDoubleClick);
            // 
            // tabPagePatient
            // 
            this.tabPagePatient.BackColor = System.Drawing.Color.Transparent;
            this.tabPagePatient.Controls.Add(this.panel1);
            this.tabPagePatient.Controls.Add(this.labelID2);
            this.tabPagePatient.Controls.Add(this.label13);
            this.tabPagePatient.Controls.Add(this.button1);
            this.tabPagePatient.Controls.Add(this.dateTimePickerBirthday);
            this.tabPagePatient.Controls.Add(this.textBoxAdress);
            this.tabPagePatient.Controls.Add(this.label11);
            this.tabPagePatient.Controls.Add(this.label10);
            this.tabPagePatient.Controls.Add(this.label9);
            this.tabPagePatient.Controls.Add(this.label8);
            this.tabPagePatient.Controls.Add(this.textBoxBefund);
            this.tabPagePatient.Controls.Add(this.label7);
            this.tabPagePatient.Controls.Add(this.textBoxBetreff);
            this.tabPagePatient.Controls.Add(this.dateTimePickerAppointment);
            this.tabPagePatient.Controls.Add(this.label6);
            this.tabPagePatient.Controls.Add(this.textBoxTo);
            this.tabPagePatient.Controls.Add(this.textBoxFrom);
            this.tabPagePatient.Controls.Add(this.btnDeleteDate);
            this.tabPagePatient.Controls.Add(this.btnAddDate);
            this.tabPagePatient.Controls.Add(this.btnDelete);
            this.tabPagePatient.Controls.Add(this.btnEdit);
            this.tabPagePatient.Controls.Add(this.label5);
            this.tabPagePatient.Controls.Add(this.dataGridViewPatientTermine);
            this.tabPagePatient.Controls.Add(this.pictureBox);
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
            this.tabPagePatient.Enter += new System.EventHandler(this.tabPagePatient_Enter);
            this.tabPagePatient.Leave += new System.EventHandler(this.tabPagePatient_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(367, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 520);
            this.label13.TabIndex = 36;
            this.label13.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 49);
            this.button1.TabIndex = 34;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(131, 301);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(196, 26);
            this.dateTimePickerBirthday.TabIndex = 33;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(129, 259);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.ReadOnly = true;
            this.textBoxAdress.Size = new System.Drawing.Size(232, 26);
            this.textBoxAdress.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Geburtsdatum: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Adresse: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Geschlecht: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Betreff: ";
            // 
            // textBoxBefund
            // 
            this.textBoxBefund.Location = new System.Drawing.Point(465, 333);
            this.textBoxBefund.Multiline = true;
            this.textBoxBefund.Name = "textBoxBefund";
            this.textBoxBefund.Size = new System.Drawing.Size(441, 168);
            this.textBoxBefund.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Befund: ";
            // 
            // textBoxBetreff
            // 
            this.textBoxBetreff.Location = new System.Drawing.Point(465, 207);
            this.textBoxBetreff.Multiline = true;
            this.textBoxBetreff.Name = "textBoxBetreff";
            this.textBoxBetreff.Size = new System.Drawing.Size(441, 120);
            this.textBoxBetreff.TabIndex = 22;
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(466, 160);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(258, 26);
            this.dateTimePickerAppointment.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(813, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "-";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(829, 160);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(77, 26);
            this.textBoxTo.TabIndex = 19;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(734, 160);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(77, 26);
            this.textBoxFrom.TabIndex = 18;
            // 
            // btnDeleteDate
            // 
            this.btnDeleteDate.Location = new System.Drawing.Point(407, 94);
            this.btnDeleteDate.Name = "btnDeleteDate";
            this.btnDeleteDate.Size = new System.Drawing.Size(49, 49);
            this.btnDeleteDate.TabIndex = 16;
            this.btnDeleteDate.Text = "-";
            this.btnDeleteDate.UseVisualStyleBackColor = true;
            this.btnDeleteDate.Click += new System.EventHandler(this.btnDeleteDate_Click);
            // 
            // btnAddDate
            // 
            this.btnAddDate.Location = new System.Drawing.Point(407, 29);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(49, 49);
            this.btnAddDate.TabIndex = 15;
            this.btnAddDate.Text = "+";
            this.btnAddDate.UseVisualStyleBackColor = true;
            this.btnAddDate.Click += new System.EventHandler(this.btnAddDate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(131, 443);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 58);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Patient löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(13, 443);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 58);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Patient ändern";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Termine: ";
            // 
            // dataGridViewPatientTermine
            // 
            this.dataGridViewPatientTermine.AllowUserToAddRows = false;
            this.dataGridViewPatientTermine.AllowUserToDeleteRows = false;
            this.dataGridViewPatientTermine.AllowUserToResizeColumns = false;
            this.dataGridViewPatientTermine.AllowUserToResizeRows = false;
            this.dataGridViewPatientTermine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatientTermine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientTermine.Location = new System.Drawing.Point(466, 6);
            this.dataGridViewPatientTermine.MultiSelect = false;
            this.dataGridViewPatientTermine.Name = "dataGridViewPatientTermine";
            this.dataGridViewPatientTermine.ReadOnly = true;
            this.dataGridViewPatientTermine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatientTermine.Size = new System.Drawing.Size(440, 137);
            this.dataGridViewPatientTermine.TabIndex = 11;
            this.dataGridViewPatientTermine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatientTermine_CellClick);
            this.dataGridViewPatientTermine.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatientTermine_CellDoubleClick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::Patientenverwaltung_v3._0.Properties.Resources.patient_2;
            this.pictureBox.Location = new System.Drawing.Point(224, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(137, 122);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(61, 6);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(33, 20);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "ID: ";
            // 
            // textBoxSozNr
            // 
            this.textBoxSozNr.Location = new System.Drawing.Point(129, 38);
            this.textBoxSozNr.Name = "textBoxSozNr";
            this.textBoxSozNr.ReadOnly = true;
            this.textBoxSozNr.Size = new System.Drawing.Size(89, 26);
            this.textBoxSozNr.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "SozNr: ";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(18, 507);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 20);
            this.labelStatus.TabIndex = 5;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(129, 177);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.ReadOnly = true;
            this.textBoxVorname.Size = new System.Drawing.Size(232, 26);
            this.textBoxVorname.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(129, 139);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(232, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(249, 443);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(112, 58);
            this.buttonSpeichern.TabIndex = 2;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // labelID2
            // 
            this.labelID2.AutoSize = true;
            this.labelID2.Location = new System.Drawing.Point(127, 7);
            this.labelID2.Name = "labelID2";
            this.labelID2.Size = new System.Drawing.Size(69, 20);
            this.labelID2.TabIndex = 37;
            this.labelID2.Text = "labelID2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonw);
            this.panel1.Controls.Add(this.radioButtonm);
            this.panel1.Location = new System.Drawing.Point(131, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 43);
            this.panel1.TabIndex = 38;
            // 
            // radioButtonm
            // 
            this.radioButtonm.AutoSize = true;
            this.radioButtonm.Location = new System.Drawing.Point(3, 9);
            this.radioButtonm.Name = "radioButtonm";
            this.radioButtonm.Size = new System.Drawing.Size(95, 24);
            this.radioButtonm.TabIndex = 0;
            this.radioButtonm.TabStop = true;
            this.radioButtonm.Text = "Männlich";
            this.radioButtonm.UseVisualStyleBackColor = true;
            // 
            // radioButtonw
            // 
            this.radioButtonw.AutoSize = true;
            this.radioButtonw.Location = new System.Drawing.Point(137, 9);
            this.radioButtonw.Name = "radioButtonw";
            this.radioButtonw.Size = new System.Drawing.Size(90, 24);
            this.radioButtonw.TabIndex = 1;
            this.radioButtonw.TabStop = true;
            this.radioButtonw.Text = "Weiblich";
            this.radioButtonw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 615);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Patientenverwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSuchen.ResumeLayout(false);
            this.tabSuchen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabTermine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermine)).EndInit();
            this.tabPagePatient.ResumeLayout(false);
            this.tabPagePatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientTermine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridViewPatientTermine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSuche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteDate;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBetreff;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBefund;
        private System.Windows.Forms.Button button1;
        private Control DrawLine;
        private Label label13;
        private Label labelID2;
        private Panel panel1;
        private RadioButton radioButtonw;
        private RadioButton radioButtonm;
    }
}

