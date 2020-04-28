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
    public partial class Form1 : Form
    {

        PhoneContext db;
        public Form1()
        {
            InitializeComponent();


            db = new PhoneContext();
            db.Phones.Load();
            db.Realizations.Load();
            dataGridView1.DataSource = db.Phones.Local.ToBindingList();

            comboBox1.DataSource = db.Phones.Local.ToBindingList();
            comboBox1.DisplayMember = "Model";
            comboBox1.ValueMember = "Id";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            using (PhoneContext db = new PhoneContext())
            {
                var ph = db.Phones.Find(comboBox1.SelectedValue);
                if(ph.Count <= 0 || ph.Count < (int)numericUpDown1.Value)
                {
                    MessageBox.Show("Товар отсутствует на складе", "Информация", MessageBoxButtons.OK);
                    return;
                }

                db.Realizations.Add(Realization.CreateRealization(textBox1.Text, (int)numericUpDown1.Value, DateTime.Now, (int)comboBox1.SelectedValue));
                
                ph.Count -= (int)numericUpDown1.Value;
                db.SaveChanges();

                

               
            }
            dataGridView1.Refresh();
            MessageBox.Show("Покупка оформлена успешно", "Информация", MessageBoxButtons.OK);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            DialogResult dialogResult = form2.ShowDialog(this);


        }
    }
}
