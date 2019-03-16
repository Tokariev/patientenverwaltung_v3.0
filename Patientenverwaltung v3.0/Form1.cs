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

        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
            clearPatienElements();
            unBlockPatienElements();
            blockAppointment();
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
            //Update
            if (textBoxID.Text != "")
            {
                //string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";
                labelStatus.Text = database.Update(String.Format("UPDATE patienten SET sozialnr={0}, name='{1}', vorname='{2}' WHERE id_patient={3}",
                textBoxSozNr.Text, textBoxName.Text, textBoxVorname.Text, textBoxID.Text));
                blockPatienElements();
            }
            else if (textBoxSozNr.Text != "" && textBoxName.Text != "" && textBoxVorname.Text != "")
            {

                //Add new patient
                database.Insert(String.Format("INSERT INTO patienten (sozialnr, name, vorname) VALUES({0}, '{1}', '{2}')",
                textBoxSozNr.Text, textBoxName.Text, textBoxVorname.Text));

                tablePatienten = database.Select(String.Format("SELECT id_patient FROM patienten WHERE sozialnr={0}",
                    textBoxSozNr.Text));

                textBoxID.Text = tablePatienten.Rows[0][0].ToString();
                labelStatus.BackColor = Color.Transparent;
                MessageBox.Show("Der Patient wurde angelegt");
                blockPatienElements();

                unblockAppointment();
            }
            else {
                labelStatus.Text = "Bitte pflegen Sie alle notwendiege Felder des Panietens!";
                labelStatus.BackColor = Color.Red;
            } 
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxID.Text = ID;
            textBoxSozNr.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxVorname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            DataTable tablePatientTermine = database.Select("SELECT id_termin, datum, uhrzeit_von, uhrzeit_bis   FROM termine WHERE id_patient=" + ID);
            dataGridViewPatientTermine.DataSource = tablePatientTermine;
            tabControl.SelectedIndex = 2;
            blockPatienElements();
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
                DataTable tablePatienten = database.Select(String.Format("SELECT * FROM patienten WHERE name LIKE '{0}'", textBoxSuche.Text));
                dataGridView1.DataSource = tablePatienten;
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
            blockAppointment();
            if (textBoxID.Text != "")
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void tabSuchen_Enter(object sender, EventArgs e)
        {
            tablePatienten = database.Select("SELECT * FROM patienten");
            dataGridView1.DataSource = tablePatienten;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.Delete(String.Format("DELETE FROM termine WHERE id_patient={0}", textBoxID.Text));
            labelStatus.Text = database.Delete(String.Format("DELETE FROM patienten WHERE id_patient={0}", textBoxID.Text));

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
            if (textBoxTo.Text == "")
            {
                unblockAppointment();
            }
            else if (textBoxTo.Text != "")
            {
                labelStatus.Text = database.Insert(String.Format("INSERT INTO termine (id_patient, datum, uhrzeit_von , uhrzeit_bis, betreff) VALUES({0}, '{1}', '{2}', '{3}', '{4}')",
                textBoxID.Text, dateTimePickerAppointment.Value.ToString("yyyy/M/d"), textBoxFrom.Text, textBoxTo.Text, textBoxBetreff.Text));

                DataTable tablePatientTermine = database.Select(String.Format("SELECT id_termin, datum, uhrzeit_von, uhrzeit_bis FROM termine WHERE id_patient= {0}", textBoxID.Text));
                dataGridViewPatientTermine.DataSource = tablePatientTermine;

                textBoxBetreff.Clear();
                blockAppointment();
            }
            else {
                MessageBox.Show("Bitte pflegen alle Daten von Termin");
            }
            
        }

        private void blockPatienElements() {
            pictureBox.Enabled = false;
            textBoxID.ReadOnly = true;
            textBoxSozNr.ReadOnly = true;
            textBoxName.ReadOnly = true;
            textBoxVorname.ReadOnly = true;
            textBoxGender.ReadOnly = true;
            textBoxAdress.ReadOnly = true;
            dateTimePickerBirthday.Enabled = false;
           
        }
        private void unBlockPatienElements()
        {
            pictureBox.Enabled = true;
            textBoxID.ReadOnly = false;
            textBoxSozNr.ReadOnly = false;
            textBoxName.ReadOnly = false;
            textBoxVorname.ReadOnly = false;
            textBoxGender.ReadOnly = false;
            textBoxAdress.ReadOnly = false;
            dateTimePickerBirthday.Enabled = true;
        }
        private void clearPatienElements()
        {
            pictureBox.InitialImage = null;
            textBoxID.Text = null;
            textBoxSozNr.Text = null;
            textBoxName.Text = null;
            textBoxVorname.Text = null;
            textBoxGender.Text = null;
            textBoxAdress.Text = null;
            textBoxBefund.Text = null;
            textBoxBetreff.Text = null;
            this.dataGridViewPatientTermine.DataSource = null;
        }

        private void dataGridViewPatientTermine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (textBoxID.Text != "")
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

        private void btnDeleteDate_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                database.Delete(String.Format("DELETE FROM termine WHERE id_termin={0}",
                selected_id_termin));

                DataTable tablePatientTermine = database.Select(String.Format("SELECT id_termin, datum, uhrzeit_von, uhrzeit_bis FROM termine WHERE id_patient={0}",
                    textBoxID.Text));

                dataGridViewPatientTermine.DataSource = tablePatientTermine;
            }
        }

        private void dataGridViewPatientTermine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPatientTermine.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                selected_id_termin =  dataGridViewPatientTermine.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void blockAppointment() {
            dateTimePickerAppointment.Enabled = false;
            textBoxFrom.ReadOnly = true;
            textBoxTo.ReadOnly = true;
            textBoxBefund.ReadOnly = true;
            textBoxBetreff.ReadOnly = true;
        }

        private void unblockAppointment()
        {
            dateTimePickerAppointment.Enabled = true;
            textBoxFrom.ReadOnly = false;
            textBoxTo.ReadOnly = false;
            textBoxBetreff.ReadOnly = false;
        }

        private void dateTimePickerVon_ValueChanged(object sender, EventArgs e)
        {
            tableTermine = database.Select(String.Format("SELECT * FROM termine WHERE datum BETWEEN '{0}' AND '{1}' ORDER BY datum, uhrzeit_von", 
                dateTimePickerVon.Value.ToString("yyyy/M/d"), dateTimePickerBis.Value.ToString("yyyy/M/d")));
            dataGridViewTermine.DataSource = tableTermine;
        }

        private void dateTimePickerBis_ValueChanged(object sender, EventArgs e)
        {
            tableTermine = database.Select(String.Format("SELECT * FROM termine WHERE datum BETWEEN '{0}' AND '{1}' ORDER BY datum, uhrzeit_von",
                dateTimePickerVon.Value.ToString("yyyy/M/d"), dateTimePickerBis.Value.ToString("yyyy/M/d")));
            dataGridViewTermine.DataSource = tableTermine;
        }

        private void dataGridViewTermine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl.SelectedIndex = 2;
            string strDatum = dataGridViewTermine.Rows[e.RowIndex].Cells[2].Value.ToString();
            strDatum = strDatum.Split(' ').FirstOrDefault();

            string datum = strDatum.Substring(6, 4) + "." +
                strDatum.Substring(3, 2) + "." +
                strDatum.Substring(0, 2);

            string von = dataGridViewTermine.Rows[e.RowIndex].Cells[3].Value.ToString();
            string bis = dataGridViewTermine.Rows[e.RowIndex].Cells[4].Value.ToString();

            tablePatienten = database.Select(String.Format("SELECT * FROM patienten WHERE id_patient = " +
                "(SELECT id_patient FROM termine WHERE datum='{0}' AND uhrzeit_von='{1}' AND uhrzeit_bis='{2}');", datum, von, bis));

            string patientID = tablePatienten.Rows[0][0].ToString();
            textBoxID.Text = patientID;
            textBoxSozNr.Text = tablePatienten.Rows[0][1].ToString();
            textBoxName.Text = tablePatienten.Rows[0][2].ToString();
            textBoxVorname.Text = tablePatienten.Rows[0][3].ToString();
            textBoxGender.Text = tablePatienten.Rows[0][4].ToString();
            textBoxAdress.Text = tablePatienten.Rows[0][5].ToString();

            tablePatienten = database.Select(String.Format("SELECT id_termin, datum, uhrzeit_von, uhrzeit_bis FROM termine WHERE id_patient = {0}",
                patientID));
            dataGridViewPatientTermine.DataSource = tablePatienten;

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
    }
}
