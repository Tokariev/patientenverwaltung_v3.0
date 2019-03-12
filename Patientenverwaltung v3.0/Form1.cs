using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            
            tabControl.SelectedIndex = 2;
            textBoxID.Text = null;
            textBoxSozNr.Text = null;
            textBoxSozNr.ReadOnly = false;
            textBoxName.Text = null;
            textBoxName.ReadOnly = false;
            textBoxVorname.Text = null;
            textBoxVorname.ReadOnly = false;

            this.dataGridViewPatientTermine.DataSource = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablePatienten = database.Select("SELECT * FROM patienten");
            tableTermine = database.Select("SELECT * FROM termine");
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
            }
            else {
                labelStatus.Text = database.Insert(String.Format("INSERT INTO patienten (sozialnr, name, vorname) VALUES('{0}', '{1}', '{2}')",
                textBoxName.Text, textBoxVorname.Text, textBoxSozNr.Text));
            }

            textBoxSozNr.ReadOnly = true;
            textBoxName.ReadOnly = true;
            textBoxVorname.ReadOnly = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxID.Text = ID;
            textBoxSozNr.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxVorname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            DataTable tablePatientTermine = database.Select("SELECT datum, uhrzeit_von, uhrzeit_bis   FROM termine WHERE id_patient=" + ID);
            dataGridViewPatientTermine.DataSource = tablePatientTermine;
            tabControl.SelectedIndex = 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSuche.Text != "")
            {
                DataTable tablePatienten = database.Select("SELECT * FROM patienten WHERE name='" + textBoxSuche.Text + "'");
                dataGridView1.DataSource = tablePatienten;
            }
            else {
                DataTable tablePatienten = database.Select("SELECT * FROM patienten");
                dataGridView1.DataSource = tablePatienten;
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            textBoxSozNr.ReadOnly = false;
            textBoxName.ReadOnly = false;
            textBoxVorname.ReadOnly = false; 
        }

        private void tabPagePatient_Enter(object sender, EventArgs e)
        {
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
            labelStatus.Text = database.Delete(String.Format("DELETE FROM termine WHERE id_patient={0}", textBoxID.Text));
            labelStatus.Text = database.Delete(String.Format("DELETE FROM patienten WHERE id_patient={0}", textBoxID.Text));

            dataGridView1.Rows.Clear();

            textBoxID.Text = null;
            textBoxSozNr.Text = null;
            textBoxName.Text = null;
            textBoxVorname.Text = null;
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

            labelStatus.Text = database.Insert(String.Format("INSERT INTO termine (id_patient, datum, uhrzeit_von , uhrzeit_bis) VALUES({0}, '{1}', '{2}', '{3}')",
                textBoxID.Text, dateTimePickerDate.Value.ToString("yyyy/M/d"), textBoxFrom.Text, textBoxTo.Text));

            DataTable tablePatientTermine = database.Select(String.Format("SELECT datum, uhrzeit_von, uhrzeit_bis   FROM termine WHERE id_patient= {0}", textBoxID.Text));
            dataGridViewPatientTermine.DataSource = tablePatientTermine;
        }
    }
}
