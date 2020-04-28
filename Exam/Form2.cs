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

namespace Exam
{
    public partial class Form2 : Form
    {
        PhoneContext db;
        public Form2()
        {
            
            InitializeComponent();
            db = new PhoneContext();

            db.Realizations.Load();

            dataGridView1.DataSource = db.Realizations.Local.ToBindingList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Realizations.SqlQuery($"SELECT * FROM Realizations Where RealizeTime BETWEEN {dateTimePicker1.Value.Date} AND {dateTimePicker2.Value.Date}").ToList();

            dataGridView1.Refresh();
        }
    }
}
