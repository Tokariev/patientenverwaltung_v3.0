using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patientenverwaltung_v3._0
{
    public partial class Form1 : Form
    {
        
        DBConnect database = new DBConnect();
        DataTable tablePatienten;
        DataTable tableTermine;

        string selected_id_termin;
        int NeuerPatient = 0;

        public Form1()
        {
            InitializeComponent();
            labelID2.Text = "";
            comboBox1.SelectedIndex = 0;
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
            clearPatienElements();
            unBlockPatienElements();
            blockAppointment();
            NeuerPatient = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // tablePatienten = database.Select("SELECT * FROM patienten");
            tableTermine = database.Select("SELECT datum, uhrzeit_von, uhrzeit_bis FROM termine");
            dataGridView1.DataSource = tablePatienten;
            dataGridViewTermine.DataSource = tableTermine;
        }

        private void buttonHeute_Click(object sender, EventArgs e)
        {
            dateTimePickerVon.Value = DateTime.Now;
            dateTimePickerBis.Value = DateTime.Now;
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            if (textBoxSozNr.Text != "" && textBoxName.Text != "" && textBoxVorname.Text != "") {
                if (NeuerPatient == 0) // Wenn ein bestehender Patient bearbeitet wird.
                {
                    labelStatus.Text = database.Update(String.Format("UPDATE patienten SET sozialnr={0}, name='{1}', vorname='{2}' WHERE id_patient={3}",
                    textBoxSozNr.Text, textBoxName.Text, textBoxVorname.Text, labelID2.Text));
                    blockPatienElements();
                }
                else if (NeuerPatient == 1 && textBoxSozNr.Text != "" && textBoxName.Text != "" && textBoxVorname.Text != "") // Wenn ein neuer Patient angelegt wird
                {
                    //Add new patient
                    database.Insert(String.Format("INSERT INTO patienten (sozialnr, name, vorname) VALUES({0}, '{1}', '{2}')",
                    textBoxSozNr.Text, textBoxName.Text, textBoxVorname.Text));

                    tablePatienten = database.Select(String.Format("SELECT id_patient FROM patienten WHERE sozialnr={0}",
                        textBoxSozNr.Text));

                    labelID2.Text = tablePatienten.Rows[0][0].ToString();
                    labelStatus.BackColor = Color.Transparent;
                    MessageBox.Show("Der Patient wurde angelegt");
                    blockPatienElements();

                    unblockAppointment();
                }
                else { // Wenn nicht alle Pflichtfelder ausgefüllt sind.
                    labelStatus.Text = "Bitte pflegen Sie alle notwendiege Felder des Panietens!";
                    labelStatus.BackColor = Color.Red;
                } }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "") //Hier wird geprüft, ob die angeklickte Spalte die Überschrift ist, oder keinen Inhalt hat.
            { 
            string ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelID2.Text = ID;
            textBoxSozNr.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxVorname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                if(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "m")
                {
                    radioButtonm.Checked = true;
                    radioButtonw.Checked = false;
                } else if(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "w")
                {
                    radioButtonw.Checked = true;
                    radioButtonm.Checked = false;
                } else
                {
                    radioButtonw.Checked = false;
                    radioButtonm.Checked = false;
                }
            textBoxAdress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            DataTable tablePatientTermine = database.Select("SELECT id_termin, datum, uhrzeit_von, uhrzeit_bis   FROM termine WHERE id_patient=" + ID);
            dataGridViewPatientTermine.DataSource = tablePatientTermine;
            tabControl.SelectedIndex = 2;
            //clearPatienElements();
            blockPatienElements();
                dataGridViewPatientTermine.ClearSelection();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                // Wrap the creation of the OpenFileDialog instance in a using statement,
                // rather than manually calling the Dispose method to ensure proper disposal
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pictureBox.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSuche.Text != "")
            {
                DataTable tablePatienten;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        tablePatienten = database.Select(String.Format("SELECT * FROM patienten WHERE name LIKE '{0}'", textBoxSuche.Text));
                        dataGridView1.DataSource = tablePatienten;
                        break;
                    case 1:
                        tablePatienten = database.Select(String.Format("SELECT * FROM patienten WHERE vorname LIKE '{0}'", textBoxSuche.Text));
                        dataGridView1.DataSource = tablePatienten;
                        break;
                    case 2:
                        tablePatienten = database.Select(String.Format("SELECT * FROM patienten WHERE adresse LIKE '{0}'", textBoxSuche.Text));
                        dataGridView1.DataSource = tablePatienten;
                        break;
                    case 3:
                        tablePatienten = database.Select(String.Format("SELECT * FROM patienten WHERE geburtsdatum LIKE '{0}'", textBoxSuche.Text));
                        dataGridView1.DataSource = tablePatienten;
                        break;
                    case 4:
                        tablePatienten = database.Select(String.Format("SELECT * FROM patienten WHERE sozialnr LIKE '{0}'", textBoxSuche.Text));
                        dataGridView1.DataSource = tablePatienten;
                        break;
                }
                
            }
            else {
                        DataTable tablePatienten = database.Select("SELECT * FROM patienten");
                        dataGridView1.DataSource = tablePatienten;
                 }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            unBlockPatienElements();
        }

        private void tabPagePatient_Enter(object sender, EventArgs e)
        {
            
            //blockAppointment();
            if (labelID2.Text != "")
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }

            dataGridViewPatientTermine.ClearSelection();
        }

        private void tabSuchen_Enter(object sender, EventArgs e)
        {
            tablePatienten = database.Select("SELECT * FROM patienten");
            dataGridView1.DataSource = tablePatienten;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.Delete(String.Format("DELETE FROM termine WHERE id_patient={0}", labelID2.Text));
            labelStatus.Text = database.Delete(String.Format("DELETE FROM patienten WHERE id_patient={0}", labelID2.Text));

            clearPatienElements();
        }

        private void tabTermine_Enter(object sender, EventArgs e)
        {
            tableTermine = database.Select("SELECT * FROM termine");
            dataGridView1.DataSource = tableTermine;
        }

        private void tabPagePatient_Leave(object sender, EventArgs e)
        {
            labelStatus.Text = "";
        }

        private void btnAddDate_Click(object sender, EventArgs e)
        {
            if (selected_id_termin == null) //Wenn kein Termin ausgewählt ist dann INSERT
            {
                labelStatus.Text = database.Insert(String.Format("INSERT INTO termine (id_patient, datum, uhrzeit_von , uhrzeit_bis, betreff) VALUES({0}, '{1}', '{2}', '{3}', '{4}')",
                labelID2.Text, dateTimePickerAppointment.Value.ToString("yyyy/M/d"), TimePickerFrom.Text, TimePickerTo.Text, textBoxBetreff.Text));

                DataTable tablePatientTermine = database.Select(String.Format("SELECT id_termin, datum, uhrzeit_von, uhrzeit_bis FROM termine WHERE id_patient= {0}", labelID2.Text));
                dataGridViewPatientTermine.DataSource = tablePatientTermine;

                clearTerminePanel();
                setTerminElementsUnvisible();
                textBoxBetreff.Enabled = false;
                dataGridViewPatientTermine.ClearSelection();
            }
            else { //Update
                labelStatus.Text = database.Update(String.Format("UPDATE termine SET datum='{0}', uhrzeit_von='{1}', uhrzeit_bis='{2}', betreff='{3}', befund='{4}' WHERE id_termin={5}",
                    dateTimePickerAppointment.Value.ToString("yyyy/M/d"), TimePickerFrom.Text, TimePickerTo.Text, textBoxBetreff.Text, textBoxBefund.Text, selected_id_termin));
                setTerminElementsUnvisible();

                buttonNeuTermin.Enabled = true;
                textBoxBetreff.Enabled = false;
                textBoxBefund.Enabled = false;
                panelLinks.Enabled = true;
            }
            dataGridViewPatientTermine.Enabled = true;
        }

        private void blockPatienElements() {
            pictureBox.Enabled = false;
            //labelID2.ReadOnly = true;
            textBoxSozNr.ReadOnly = true;
            textBoxName.ReadOnly = true;
            textBoxVorname.ReadOnly = true;
            if (! radioButtonm.Checked)
            {
                radioButtonm.Enabled = false;
            }
            else { radioButtonm.Enabled = true; }
            if (! radioButtonw.Checked)
            {
                radioButtonw.Enabled = false;
            }
            else { radioButtonw.Enabled = true; }
            textBoxAdress.ReadOnly = true;
            dateTimePickerBirthday.Enabled = false;
           
        }
        private void unBlockPatienElements()
        {
            pictureBox.Enabled = true;
            //labelID2.ReadOnly = false;
            textBoxSozNr.ReadOnly = false;
            textBoxName.ReadOnly = false;
            textBoxVorname.ReadOnly = false;
            radioButtonm.Enabled = true;
            radioButtonw.Enabled = true;
            textBoxAdress.ReadOnly = false;
            dateTimePickerBirthday.Enabled = true;
        }
        private void clearPatienElements()
        {
            pictureBox.InitialImage = null;
            labelID2.Text = null;
            textBoxSozNr.Text = null;
            textBoxName.Text = null;
            textBoxVorname.Text = null;
            radioButtonw.Checked = false;
            radioButtonm.Checked = false;
            textBoxAdress.Text = null;
            textBoxBefund.Text = null;
            textBoxBetreff.Text = null;
            this.dataGridViewPatientTermine.DataSource = null;
        }

        private void dataGridViewPatientTermine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "") //Hier wird geprüft, ob die angeklickte Spalte die Überschrift ist, oder keinen Inhalt hat.
            {
                if (labelID2.Text != "")
                {
                    string id_termin = dataGridViewPatientTermine.Rows[e.RowIndex].Cells[0].Value.ToString();

                    DataTable termine = database.Select(String.Format("SELECT betreff, befund FROM termine WHERE id_termin = {0} ",
                        id_termin));

                    string betreff = termine.Rows[0][0].ToString();
                    textBoxBetreff.Text = betreff;
                    string befund = termine.Rows[0][1].ToString();
                    textBoxBefund.Text = befund;
                }
            }
        }

        private void btnDeleteDate_Click(object sender, EventArgs e)
        {
            if (labelID2.Text != "")
            {
                database.Delete(String.Format("DELETE FROM termine WHERE id_termin={0}",
                selected_id_termin));

                DataTable tablePatientTermine = database.Select(String.Format("SELECT id_termin, datum, uhrzeit_von, uhrzeit_bis FROM termine WHERE id_patient={0}",
                    labelID2.Text));

                dataGridViewPatientTermine.DataSource = tablePatientTermine;
                clearTerminePanel();
            }
        }



        private void blockAppointment() {
            dateTimePickerAppointment.Enabled = false;
            TimePickerFrom.Enabled = false;
            TimePickerTo.Enabled = false;
            textBoxBefund.ReadOnly = true;
            textBoxBetreff.ReadOnly = true;
        }

        private void unblockAppointment()
        {
            dateTimePickerAppointment.Enabled = true;
            TimePickerFrom.Enabled = true;
            TimePickerTo.Enabled = true;
            textBoxBetreff.ReadOnly = false;
        }

        private void dateTimePickerVon_ValueChanged(object sender, EventArgs e)
        {
            tableTermine = database.Select(String.Format("SELECT datum, uhrzeit_von, uhrzeit_bis FROM termine WHERE datum BETWEEN '{0}' AND '{1}' ORDER BY datum, uhrzeit_von", 
                dateTimePickerVon.Value.ToString("yyyy/M/d"), dateTimePickerBis.Value.ToString("yyyy/M/d")));
            dataGridViewTermine.DataSource = tableTermine;
        }

        private void dateTimePickerBis_ValueChanged(object sender, EventArgs e)
        {
            tableTermine = database.Select(String.Format("SELECT datum, uhrzeit_von, uhrzeit_bis FROM termine WHERE datum BETWEEN '{0}' AND '{1}' ORDER BY datum, uhrzeit_von",
                dateTimePickerVon.Value.ToString("yyyy/M/d"), dateTimePickerBis.Value.ToString("yyyy/M/d")));
            dataGridViewTermine.DataSource = tableTermine;
        }

        private void dataGridViewTermine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null) //Hier wird geprüft, ob die angeklickte Spalte die Überschrift ist, oder keinen Inhalt hat.
            {
                tabControl.SelectedIndex = 2;
                string strDatum = dataGridViewTermine.Rows[e.RowIndex].Cells[0].Value.ToString();
                strDatum = strDatum.Split(' ').FirstOrDefault();

                string datum = strDatum.Substring(6, 4) + "." +
                    strDatum.Substring(3, 2) + "." +
                    strDatum.Substring(0, 2);

                string von = dataGridViewTermine.Rows[e.RowIndex].Cells[1].Value.ToString();
                string bis = dataGridViewTermine.Rows[e.RowIndex].Cells[2].Value.ToString();

                tablePatienten = database.Select(String.Format("SELECT * FROM patienten WHERE id_patient = " +
                    "(SELECT id_patient FROM termine WHERE datum='{0}' AND uhrzeit_von='{1}' AND uhrzeit_bis='{2}');", datum, von, bis));

                string patientID = tablePatienten.Rows[0][0].ToString();
                labelID2.Text = patientID;
                textBoxSozNr.Text = tablePatienten.Rows[0][1].ToString();
                textBoxName.Text = tablePatienten.Rows[0][2].ToString();
                textBoxVorname.Text = tablePatienten.Rows[0][3].ToString();
                if (tablePatienten.Rows[0][4].ToString() == "m")
                {
                    radioButtonm.Checked = true;
                    radioButtonw.Checked = false;
                }
                else if (tablePatienten.Rows[0][4].ToString() == "w")
                {
                    radioButtonw.Checked = true;
                    radioButtonm.Checked = false;
                }
                else
                {
                    radioButtonw.Checked = false;
                    radioButtonm.Checked = false;
                }
                textBoxAdress.Text = tablePatienten.Rows[0][5].ToString();

                tablePatienten = database.Select(String.Format("SELECT id_termin, datum, uhrzeit_von, uhrzeit_bis FROM termine WHERE id_patient = {0}", patientID));
                dataGridViewPatientTermine.DataSource = tablePatienten;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxBefund.Text == "")
            {
                textBoxBefund.ReadOnly = false;
            }
            if (textBoxBefund.Text != "" ){
                database.Update(String.Format("UPDATE termine SET befund='{0}' WHERE id_termin={1}",
                textBoxBefund.Text, selected_id_termin));
                textBoxBefund.ReadOnly = true;
            }
        }

        private void clearTerminePanel() {

            textBoxBetreff.Clear();
            textBoxBefund.Clear();
        }



        private void dataGridViewPatientTermine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "") //Hier wird geprüft, ob die angeklickte Spalte die Überschrift ist, oder keinen Inhalt hat.
            {
                if (labelID2.Text != "")
                {
                    string id_termin = dataGridViewPatientTermine.Rows[e.RowIndex].Cells[0].Value.ToString();
                    selected_id_termin = dataGridViewPatientTermine.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DataTable termine = database.Select(String.Format("SELECT betreff, befund, uhrzeit_von, uhrzeit_bis, datum FROM termine WHERE id_termin = {0} ",
                        id_termin));

                    TimePickerFrom.Text = termine.Rows[0][2].ToString();
                    TimePickerTo.Text = termine.Rows[0][3].ToString();

                    dateTimePickerAppointment.Text = termine.Rows[0][4].ToString();

                    string betreff = termine.Rows[0][0].ToString();
                    textBoxBetreff.Text = betreff;
                    string befund = termine.Rows[0][1].ToString();
                    textBoxBefund.Text = befund;

                }
            }
        }

        private void buttonNeuTermin_Click(object sender, EventArgs e)
        {
            selected_id_termin = null;
            dataGridViewPatientTermine.ClearSelection();
            setTerminElementsVisible();
            textBoxBetreff.Enabled = true;
            textBoxBetreff.Clear();
            if (textBoxBetreff.Text == "")
            {
                btnAddDate.Enabled = false;
            }
            else
            {
                btnAddDate.Enabled = true;
            }
        }

        public void setTerminElementsVisible() {
            dateTimePickerAppointment.Visible = true;
            TimePickerFrom.Visible = true;
            TimePickerTo.Visible = true;
            btnAddDate.Visible = true;
            buttonCloseDate.Visible = true;
            
        }

        private void buttonCloseDate_Click(object sender, EventArgs e)
        {
            setTerminElementsUnvisible();
            textBoxBetreff.Enabled = false;
            textBoxBefund.Enabled = false;
            clearTerminePanel();
        }

        public void setTerminElementsUnvisible()
        {
            dateTimePickerAppointment.Visible = false;
            TimePickerFrom.Visible = false;
            TimePickerTo.Visible = false;
            btnAddDate.Visible = false;
            buttonCloseDate.Visible = false;
        }

        private void textBoxBetreff_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBetreff.Text != "")
            {
                btnAddDate.Enabled = true;
            }
            else {
                btnAddDate.Enabled = false;
            }
        }

        private void buttonTerminAendern_Click(object sender, EventArgs e)
        {

        }

        private void buttonTermineAendern_Click(object sender, EventArgs e)
        {
            setTerminElementsVisible();
            panelLinks.Enabled = false;
            dataGridViewPatientTermine.Enabled = false;
            textBoxBetreff.Enabled = true;
            textBoxBefund.Enabled = true;
            buttonNeuTermin.Enabled = false;
        }

        private void tabControl_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}