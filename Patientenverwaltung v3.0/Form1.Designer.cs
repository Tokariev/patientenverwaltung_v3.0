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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSuchen = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.panelLinks = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonw = new System.Windows.Forms.RadioButton();
            this.radioButtonm = new System.Windows.Forms.RadioButton();
            this.textBoxSozNr = new System.Windows.Forms.TextBox();
            this.labelID2 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonCloseDate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonNeuTermin = new System.Windows.Forms.Button();
            this.buttonTermineAendern = new System.Windows.Forms.Button();
            this.TimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.TimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBefund = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBetreff = new System.Windows.Forms.TextBox();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteDate = new System.Windows.Forms.Button();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewPatientTermine = new System.Windows.Forms.DataGridView();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabSuchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabTermine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermine)).BeginInit();
            this.tabPagePatient.SuspendLayout();
            this.panelLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientTermine)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(982, 574);
            this.tabControl.TabIndex = 0;
            // 
            // tabSuchen
            // 
            this.tabSuchen.Controls.Add(this.comboBox1);
            this.tabSuchen.Controls.Add(this.label4);
            this.tabSuchen.Controls.Add(this.textBoxSuche);
            this.tabSuchen.Controls.Add(this.buttonAddPatient);
            this.tabSuchen.Controls.Add(this.dataGridView1);
            this.tabSuchen.Location = new System.Drawing.Point(4, 29);
            this.tabSuchen.Name = "tabSuchen";
            this.tabSuchen.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuchen.Size = new System.Drawing.Size(974, 541);
            this.tabSuchen.TabIndex = 0;
            this.tabSuchen.Text = "Suchen";
            this.tabSuchen.UseVisualStyleBackColor = true;
            this.tabSuchen.Enter += new System.EventHandler(this.tabSuchen_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Vorname",
            "Adresse",
            "Geburtsdatum",
            "Sozialnr"});
            this.comboBox1.Location = new System.Drawing.Point(628, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Suche nach:";
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
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.tabTermine.Size = new System.Drawing.Size(974, 541);
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
            this.dataGridViewTermine.AllowUserToAddRows = false;
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
            this.tabPagePatient.Controls.Add(this.panelLinks);
            this.tabPagePatient.Controls.Add(this.buttonCloseDate);
            this.tabPagePatient.Controls.Add(this.label12);
            this.tabPagePatient.Controls.Add(this.buttonNeuTermin);
            this.tabPagePatient.Controls.Add(this.buttonTermineAendern);
            this.tabPagePatient.Controls.Add(this.TimePickerTo);
            this.tabPagePatient.Controls.Add(this.TimePickerFrom);
            this.tabPagePatient.Controls.Add(this.label13);
            this.tabPagePatient.Controls.Add(this.label8);
            this.tabPagePatient.Controls.Add(this.textBoxBefund);
            this.tabPagePatient.Controls.Add(this.label7);
            this.tabPagePatient.Controls.Add(this.textBoxBetreff);
            this.tabPagePatient.Controls.Add(this.dateTimePickerAppointment);
            this.tabPagePatient.Controls.Add(this.label6);
            this.tabPagePatient.Controls.Add(this.btnDeleteDate);
            this.tabPagePatient.Controls.Add(this.btnAddDate);
            this.tabPagePatient.Controls.Add(this.label5);
            this.tabPagePatient.Controls.Add(this.dataGridViewPatientTermine);
            this.tabPagePatient.Controls.Add(this.labelStatus);
            this.tabPagePatient.Location = new System.Drawing.Point(4, 29);
            this.tabPagePatient.Name = "tabPagePatient";
            this.tabPagePatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatient.Size = new System.Drawing.Size(974, 541);
            this.tabPagePatient.TabIndex = 2;
            this.tabPagePatient.Text = "Patient";
            this.tabPagePatient.Enter += new System.EventHandler(this.tabPagePatient_Enter);
            this.tabPagePatient.Leave += new System.EventHandler(this.tabPagePatient_Leave);
            // 
            // panelLinks
            // 
            this.panelLinks.Controls.Add(this.pictureBox);
            this.panelLinks.Controls.Add(this.label1);
            this.panelLinks.Controls.Add(this.label2);
            this.panelLinks.Controls.Add(this.buttonSpeichern);
            this.panelLinks.Controls.Add(this.textBoxName);
            this.panelLinks.Controls.Add(this.textBoxVorname);
            this.panelLinks.Controls.Add(this.label3);
            this.panelLinks.Controls.Add(this.panel1);
            this.panelLinks.Controls.Add(this.textBoxSozNr);
            this.panelLinks.Controls.Add(this.labelID2);
            this.panelLinks.Controls.Add(this.labelId);
            this.panelLinks.Controls.Add(this.btnEdit);
            this.panelLinks.Controls.Add(this.dateTimePickerBirthday);
            this.panelLinks.Controls.Add(this.btnDelete);
            this.panelLinks.Controls.Add(this.textBoxAdress);
            this.panelLinks.Controls.Add(this.label9);
            this.panelLinks.Controls.Add(this.label11);
            this.panelLinks.Controls.Add(this.label10);
            this.panelLinks.Location = new System.Drawing.Point(6, 3);
            this.panelLinks.Name = "panelLinks";
            this.panelLinks.Size = new System.Drawing.Size(364, 504);
            this.panelLinks.TabIndex = 45;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::Patientenverwaltung_v3._0.Properties.Resources.patient_2;
            this.pictureBox.Location = new System.Drawing.Point(225, 23);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(137, 122);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname: ";
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(250, 446);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(112, 58);
            this.buttonSpeichern.TabIndex = 2;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(130, 156);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(232, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(130, 194);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.ReadOnly = true;
            this.textBoxVorname.Size = new System.Drawing.Size(232, 26);
            this.textBoxVorname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "SozNr: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonw);
            this.panel1.Controls.Add(this.radioButtonm);
            this.panel1.Location = new System.Drawing.Point(132, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 43);
            this.panel1.TabIndex = 38;
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
            // textBoxSozNr
            // 
            this.textBoxSozNr.Location = new System.Drawing.Point(130, 55);
            this.textBoxSozNr.Name = "textBoxSozNr";
            this.textBoxSozNr.ReadOnly = true;
            this.textBoxSozNr.Size = new System.Drawing.Size(89, 26);
            this.textBoxSozNr.TabIndex = 7;
            // 
            // labelID2
            // 
            this.labelID2.AutoSize = true;
            this.labelID2.Location = new System.Drawing.Point(128, 24);
            this.labelID2.Name = "labelID2";
            this.labelID2.Size = new System.Drawing.Size(69, 20);
            this.labelID2.TabIndex = 37;
            this.labelID2.Text = "labelID2";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(62, 23);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(33, 20);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "ID: ";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(14, 446);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 58);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Patient ändern";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(132, 318);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(196, 26);
            this.dateTimePickerBirthday.TabIndex = 33;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(132, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 58);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Patient löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(130, 276);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.ReadOnly = true;
            this.textBoxAdress.Size = new System.Drawing.Size(232, 26);
            this.textBoxAdress.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Geschlecht: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Geburtsdatum: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Adresse: ";
            // 
            // buttonCloseDate
            // 
            this.buttonCloseDate.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseDate.Image")));
            this.buttonCloseDate.Location = new System.Drawing.Point(919, 210);
            this.buttonCloseDate.Name = "buttonCloseDate";
            this.buttonCloseDate.Size = new System.Drawing.Size(45, 45);
            this.buttonCloseDate.TabIndex = 44;
            this.buttonCloseDate.UseVisualStyleBackColor = true;
            this.buttonCloseDate.Visible = false;
            this.buttonCloseDate.Click += new System.EventHandler(this.buttonCloseDate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(399, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Betref: ";
            // 
            // buttonNeuTermin
            // 
            this.buttonNeuTermin.Image = ((System.Drawing.Image)(resources.GetObject("buttonNeuTermin.Image")));
            this.buttonNeuTermin.Location = new System.Drawing.Point(411, 44);
            this.buttonNeuTermin.Name = "buttonNeuTermin";
            this.buttonNeuTermin.Size = new System.Drawing.Size(49, 49);
            this.buttonNeuTermin.TabIndex = 42;
            this.buttonNeuTermin.UseVisualStyleBackColor = true;
            this.buttonNeuTermin.Click += new System.EventHandler(this.buttonNeuTermin_Click);
            // 
            // buttonTermineAendern
            // 
            this.buttonTermineAendern.Image = ((System.Drawing.Image)(resources.GetObject("buttonTermineAendern.Image")));
            this.buttonTermineAendern.Location = new System.Drawing.Point(411, 99);
            this.buttonTermineAendern.Name = "buttonTermineAendern";
            this.buttonTermineAendern.Size = new System.Drawing.Size(49, 49);
            this.buttonTermineAendern.TabIndex = 41;
            this.buttonTermineAendern.UseVisualStyleBackColor = true;
            this.buttonTermineAendern.Click += new System.EventHandler(this.buttonTermineAendern_Click);
            // 
            // TimePickerTo
            // 
            this.TimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerTo.Location = new System.Drawing.Point(768, 219);
            this.TimePickerTo.Name = "TimePickerTo";
            this.TimePickerTo.ShowUpDown = true;
            this.TimePickerTo.Size = new System.Drawing.Size(94, 26);
            this.TimePickerTo.TabIndex = 40;
            this.TimePickerTo.Visible = false;
            // 
            // TimePickerFrom
            // 
            this.TimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerFrom.Location = new System.Drawing.Point(654, 219);
            this.TimePickerFrom.Name = "TimePickerFrom";
            this.TimePickerFrom.ShowUpDown = true;
            this.TimePickerFrom.Size = new System.Drawing.Size(94, 26);
            this.TimePickerFrom.TabIndex = 39;
            this.TimePickerFrom.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(367, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 520);
            this.label13.TabIndex = 36;
            this.label13.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 25;
            // 
            // textBoxBefund
            // 
            this.textBoxBefund.Enabled = false;
            this.textBoxBefund.Location = new System.Drawing.Point(465, 382);
            this.textBoxBefund.Multiline = true;
            this.textBoxBefund.Name = "textBoxBefund";
            this.textBoxBefund.Size = new System.Drawing.Size(499, 125);
            this.textBoxBefund.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Befund: ";
            // 
            // textBoxBetreff
            // 
            this.textBoxBetreff.Enabled = false;
            this.textBoxBetreff.Location = new System.Drawing.Point(465, 262);
            this.textBoxBetreff.Multiline = true;
            this.textBoxBetreff.Name = "textBoxBetreff";
            this.textBoxBetreff.Size = new System.Drawing.Size(499, 114);
            this.textBoxBetreff.TabIndex = 22;
            this.textBoxBetreff.TextChanged += new System.EventHandler(this.textBoxBetreff_TextChanged);
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(465, 219);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(183, 26);
            this.dateTimePickerAppointment.TabIndex = 21;
            this.dateTimePickerAppointment.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(751, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "-";
            this.label6.Visible = false;
            // 
            // btnDeleteDate
            // 
            this.btnDeleteDate.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDate.Image")));
            this.btnDeleteDate.Location = new System.Drawing.Point(411, 154);
            this.btnDeleteDate.Name = "btnDeleteDate";
            this.btnDeleteDate.Size = new System.Drawing.Size(49, 49);
            this.btnDeleteDate.TabIndex = 16;
            this.btnDeleteDate.UseVisualStyleBackColor = true;
            this.btnDeleteDate.Click += new System.EventHandler(this.btnDeleteDate_Click);
            // 
            // btnAddDate
            // 
            this.btnAddDate.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDate.Image")));
            this.btnAddDate.Location = new System.Drawing.Point(868, 210);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(45, 45);
            this.btnAddDate.TabIndex = 15;
            this.btnAddDate.UseVisualStyleBackColor = true;
            this.btnAddDate.Visible = false;
            this.btnAddDate.Click += new System.EventHandler(this.btnAddDate_Click);
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
            this.dataGridViewPatientTermine.Size = new System.Drawing.Size(498, 197);
            this.dataGridViewPatientTermine.TabIndex = 11;
            this.dataGridViewPatientTermine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatientTermine_CellClick);
            this.dataGridViewPatientTermine.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatientTermine_CellDoubleClick);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(22, 514);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 18);
            this.labelStatus.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 611);
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
            this.panelLinks.ResumeLayout(false);
            this.panelLinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientTermine)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBetreff;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBefund;
        private Control DrawLine;
        private Label label13;
        private Label labelID2;
        private Panel panel1;
        private RadioButton radioButtonw;
        private RadioButton radioButtonm;
        private ComboBox comboBox1;
        private DateTimePicker TimePickerFrom;
        private DateTimePicker TimePickerTo;
        private Button buttonTermineAendern;
        private Label label12;
        private Button buttonNeuTermin;
        private Button buttonCloseDate;
        private Panel panelLinks;
    }
}

