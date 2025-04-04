using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.DAL;
using PBL.module;

namespace PBL3.fe
{
    public partial class FormXepThoiKhoaBieu : Form
    {
        public FormXepThoiKhoaBieu()
        {
            InitializeComponent();
            load_Faculty();
        }

        private void load_Faculty()
        {
            FacultyDAL facultyDAL = new FacultyDAL();
            List<Faculty> faculties = facultyDAL.sellectAll();
            cbbChonKhoa.DataSource = faculties;
            cbbChonKhoa.DisplayMember = "_nameFaculty";
            cbbChonKhoa.ValueMember = "_idFaculty";
        }

        private void cbbChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChonKhoa.SelectedValue != null)
            {
                load_Teacher();
                load_Subject();
                load_Class();
                load_Room();

            }
        }

        private void load_Teacher()
        {
            try
            {
                if (cbbChonKhoa.SelectedValue != null)
                {
                    string idFacultySelect = cbbChonKhoa.SelectedValue.ToString();
                    TeacherDAL teacherDAL = new TeacherDAL();
                    List<Teacher> teachers = teacherDAL.selectByIDFaculty(idFacultySelect);
                    cbbChonGiangVien.DataSource = teachers;
                    cbbChonGiangVien.DisplayMember = "_nameTeacher";
                    cbbChonGiangVien.ValueMember = "_idTeacher";
                }
            }
            catch
                (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void cbbChonGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void load_Subject()
        {
            try
            {
                if (cbbChonKhoa.SelectedValue != null)
                {
                    string idFacultySelect = cbbChonKhoa.SelectedValue.ToString();
                    SubjectDAL subjectDAL = new SubjectDAL();
                    List<Subject> subjects = subjectDAL.selectByIDFaculty(idFacultySelect);
                    cbbChonMonHoc.DataSource = subjects;
                    cbbChonMonHoc.DisplayMember = "_nameSubject";
                    cbbChonMonHoc.ValueMember = "_idSubject";
                }
            }
            catch
                (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void cbbChonMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void load_Room()
        {
            try
            {
                RoomDAL roomDAL = new RoomDAL();
                List<Room> rooms = roomDAL.selectRoomTrue();
                cbbChonPhongHoc.DataSource = rooms;
                cbbChonPhongHoc.DisplayMember = "_idRoom";
                cbbChonPhongHoc.ValueMember = "_idRoom";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbbChonPhongHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void load_Class()
        {
            try
            {
                if (cbbChonKhoa.SelectedValue != null)
                {
                    string idFacultySelect = cbbChonKhoa.SelectedValue.ToString();
                    ClassDAL classDAL = new ClassDAL();
                    List<Class> classes = classDAL.selectByIDFaculty(idFacultySelect);
                    cbbLopHocPhan.DataSource = classes;
                    cbbLopHocPhan.DisplayMember = "_name";
                    cbbLopHocPhan.ValueMember = "_idClass";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void cbbLopHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXepLich_Click(object sender, EventArgs e)
        {
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
