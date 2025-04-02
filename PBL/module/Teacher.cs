using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    class Teacher
    {
        [Key]
        [Column("MaGV")]
        public string idTeacher;

        [Column("TenGV")]
        public string nameTeacher;

        [Column("email")]
        public string email;

        [Column("SDT")]
        public string SDT;

        [Column("DiaChi")]
        public string address;

        [Column("MaKhoa")]
        public string idFaculty;

        [Column("MaMon")]
        public string idSubject;

        public Teacher (string idTeacher, string nameTeacher, string email, string sDT, string address, string idFaculty, string idSubject)
        {
            this.idTeacher = idTeacher;
            this.nameTeacher = nameTeacher;
            this.email = email;
            SDT = sDT;
            this.address = address;
            this.idFaculty = idFaculty;
            this.idSubject = idSubject;
        }
    }
}
