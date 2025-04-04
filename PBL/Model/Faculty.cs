using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    [Table("Khoa")]
    class Faculty
    {
        [Key]
        [Column("MaKhoa")]
        public string _idFaculty { get; set; }

        [Column("TenKhoa")]
        public string _nameFaculty { get; set; }

        public List<Teacher> listClass { get; set; } = new List<Teacher>();
        public List<Subject> listSubject { get; set; } = new List<Subject>();

        public Faculty()
        {
            this._idFaculty = "";
            this._nameFaculty = "";
        }

        public Faculty(string idFaculty, string nameFaculty)
        {
            this._idFaculty = idFaculty;
            this._nameFaculty = nameFaculty;
        }

    }
}
