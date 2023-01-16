using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace lab7
{
    public partial class Form1 : Form
    {
        hospitalEntities  hospitalEntities = new hospitalEntities();
        public Form1()
        {
            InitializeComponent(); 
            Load += Form1_Load;
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            hospitalEntities.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hospitalEntities.Patients.Load();
            hospitalEntities.Doctors.Load();
            hospitalEntities.Visitings.Load();
            hospitalEntities.WritingDisabilities.Load();

            patientDataGridView.DataSource = hospitalEntities.Patients.Local.ToBindingList();
            doctorDataGridView.DataSource = hospitalEntities.Doctors.Local.ToBindingList();
            writingDisabilityDataGridView.DataSource = hospitalEntities.WritingDisabilities.Local.ToBindingList();
            visitingDataGridView.DataSource = hospitalEntities.Visitings.Local.ToBindingList();
        }

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            patientDataGridView.EndEdit();
            doctorDataGridView.EndEdit();
            writingDisabilityDataGridView.EndEdit();
            visitingDataGridView.EndEdit();

            hospitalEntities.SaveChanges();

        }

        private void patientDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormPatient FormPat= new FormPatient(patientBindingSource);
            FormPat.Owner = this;
            FormPat.ShowDialog();
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {

            patientDataGridView.EndEdit();
            hospitalEntities.SaveChanges();
            patientDataGridView.Refresh();
        }

        private void patientBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton_refr_Click(object sender, EventArgs e)
        {
            patientDataGridView.Refresh();
            doctorDataGridView.Refresh();
            writingDisabilityDataGridView.Refresh();
            visitingDataGridView.Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 form1= new Form2();
            form1.Show();
        }
    }
}
