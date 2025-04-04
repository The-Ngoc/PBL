using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PBL.DAL;
using PBL.module;

namespace PBL3.fe
{
    public partial class FormXemThoiKhoaBieu : Form
    {
        public FormXemThoiKhoaBieu()
        {
            InitializeComponent();
            load_Teacher();
        }

        private void load_Teacher()
        {
            if (comboBox1 != null)
            {
                TeacherDAL teacherDAL = new TeacherDAL();
                List<Teacher> teachers = teacherDAL.selectAll();
                comboBox1.DataSource = teachers;
                comboBox1.DisplayMember = "_nameTeacher";
                comboBox1.ValueMember = "_idTeacher";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXemLich_Click(object sender, EventArgs e)
        {
            string idTeacherSelect = comboBox1.SelectedValue.ToString();
            ScheduleDAL scheduleDAL = new ScheduleDAL();
            List<Schedule> schedules = scheduleDAL.selectByIDTeacher(idTeacherSelect);
            if (schedules != null)
            {
                dataGridView1.DataSource = schedules;
            }
        }
    }
}
