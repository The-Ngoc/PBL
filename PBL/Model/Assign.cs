using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    [Table("PhanCong")]
    class Assign
    {
        [Key]
        [Column("MaPC")]
        public int _idAssign { get; set; }


        [Column("MaGV")]
        public string _idTeacher { get; set; }
        [ForeignKey("_idTeacher")]
        public virtual Teacher teacher { get; set; } 


        [Column("MaMH")]
        public string _idSubject { get; set; }
        [ForeignKey("_idSubject")]
        public virtual Subject subject { get; set; } 


        [Column("MaLop")]
        public string _idClass { get; set; }
        [ForeignKey("_idClass")]
        public virtual Class classs { get; set; } 

        [Column("HocKi")]
        public int _semester { get; set; }
        [Column("NamHoc")]
        public int _academicYear { get; set; }


        public Assign()
        {
            this._idTeacher = "";
            this._idSubject = "";
            this._idClass = "";
            this._semester = 0;
            this._academicYear = 0;
        }

        public Assign(string idTeacher, string idSubject, string idClass, int semester, int academicYear)
        {
            this._idAssign = 1;
            this._idTeacher = idTeacher;
            this._idSubject = idSubject;
            this._idClass = idClass;
            this._semester = semester;
            this._academicYear = academicYear;
        }
    }
}
