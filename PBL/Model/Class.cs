using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    [Table("Lop")]
    class Class
    {
        [Key]
        [Column("MaLop")]
        public string _idClass { get; set; }

        [Column("TenLop")]
        public string _nameClass { get; set; }

        [Column("SoLuongSV")]
        public int _numberOfStudent { get; set; }

        [Column("MaKhoa")]
        public string _idFaculty { get; set; }
        [ForeignKey("_idFaculty")]
        public virtual Faculty _faculty { get; set; }

        public Class()
        {
            this._nameClass = "";
            this._idClass = "";
            this._numberOfStudent = 0;
            this._idFaculty = "";
        }

        public Class(string idClass,string nameClass , int numberOfStudent,string idFaculty)
        {
            this._idClass = idClass;
            this._nameClass = nameClass;
            this._numberOfStudent = numberOfStudent;
            this._idFaculty = idFaculty;
        }
    }
}
