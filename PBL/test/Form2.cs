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
using PBL.data;



namespace PBL.test
{

    public partial class Form2 : Form
    {
        Form1 old_Form;
        public Form2(Form1 form)
        {
            InitializeComponent();
            old_Form = form;
            load_Room();
            year_Load();
            HocKy_Load();
        }

        private void load_Room()
        {
            var list = new RoomDAL().selectRoomTrue();
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "_idRoom";
            comboBox1.ValueMember = "_idRoom";
        }

        private void Room_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            old_Form.Show();
        }


        private void year_Load()
        {
            for (int year = DateTime.Now.Year - 1; year <= DateTime.Now.Year + 5; year++)
            {
                comboBox2.Items.Add(year + " - " + (year + 1));
            }
        }
        private void YearAcademi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HocKy_Load()
        {
            comboBox3.Items.Add("HK1");
            comboBox3.Items.Add("HK2");
            comboBox3.Items.Add("He");
        }
        private void Hocky_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            this.Hide();
        }
    }
}
