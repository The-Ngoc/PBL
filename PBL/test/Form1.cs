using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.data;
using PBL.DAL;

namespace PBL.test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combobox_Faculty();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void combobox_Faculty()
        {
            var list = new AppDBContext().listFaculty.ToList();
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "_nameFaculty";
            comboBox1.ValueMember = "_idFaculty";
        }
        
        private void ByFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedValue != null)
            {
                string idFaculty = (string)comboBox1.SelectedValue;
                var listSubject = new SubjectDAL().selectByIDFaculty(idFaculty.ToString());
                comboBox2.DataSource = listSubject;
                comboBox2.DisplayMember = "_nameSubject";
                comboBox2.ValueMember = "_idSubject";

                var listTeacher = new TeacherDAL().selectByIDFaculty(idFaculty.ToString());
                comboBox3.DataSource = listTeacher;
                comboBox3.DisplayMember = "_nameTeacher";
                comboBox3.ValueMember = "_idTeacher";

                var listClass = new ClassDAL().selectByIDFaculty(idFaculty.ToString());
                comboBox4.DataSource = listClass;
                comboBox4.DisplayMember = "_nameClass";
                comboBox4.ValueMember = "_idClass";


            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            Form2 test2 = new Form2(this);
            test2.Show();
            this.Hide();
        }
    }
}
