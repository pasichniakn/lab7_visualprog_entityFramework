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
    public partial class Form2 : Form
    {
        hospitalEntities hospitalEntities = new hospitalEntities();
        public Form2()
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
           // hospitalEntities.Doctors.Load();
            //hospitalEntities.Visitings.Load();
            hospitalEntities.WritingDisabilities.Load();

            patientBindingSource1.DataSource = hospitalEntities.Patients.Local.ToBindingList();
            //visitingsDataGridView1.DataSource = hospitalEntities.Visitings.Local.ToBindingList();
        }
    }
}



