using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    [Table("GiaoVien")]
    class Teacher
    {
        [Key]
        [Column("MaGV")]
        public string _idTeacher { get; set; }


        [Column("HoTen")]
        public string _nameTeacher { get; set; }


        [Column("email")]
        public string _email{get;set;}


        [Column("SDT")]
        public string _SDT{get;set;}


        [Column("DiaChi")]
        public string _address{get;set;}

        [Column("MaKhoa")]
        public string _idFaculty{get;set;}

        [ForeignKey("_idFaculty")]

        public virtual Faculty _faculty { get; set; }

        public Teacher()
        {
            this._idTeacher = "";
            this._nameTeacher = "";
            this._email = "";
            this._SDT = "";
            this._address = "";
            this._idFaculty = "";
        }

        public Teacher (string idTeacher, string nameTeacher, string email, string sDT, string address, string idFaculty)
        {
            this._idTeacher = idTeacher;
            this._nameTeacher = nameTeacher;
            this._email = email;
            this._SDT = sDT;
            this._address = address;
            this._idFaculty = idFaculty;
        }
    }
}
