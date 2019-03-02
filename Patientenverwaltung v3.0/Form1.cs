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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {

            tabControl.SelectedIndex = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable tablePatienten = database.Select("SELECT * FROM patienten");
            DataTable tableTermine = database.Select("SELECT * FROM termine");
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
            labelStatus.Text = database.Insert(String.Format("INSERT INTO patienten (sozialnr, name, vorname) VALUES('{0}', '{1}', '{2}')", 
                textBoxName.Text, textBoxVorname.Text, textBoxSozNr.Text));
            if (labelStatus.Text == "OK") {
                labelStatus.BackColor = Color.GreenYellow;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxSozNr.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxVorname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

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
    }
}
