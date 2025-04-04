using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    [Table("MonHoc")]
    class Subject
    {
        [Key]
        [Column("MaMH")]
        public string _idSubject { get; set; }

        [Column("TenMH")]
        public string _nameSubject { get; set; }

        [Column("SoTC")]
        public int _numberOfCredit { get; set; }

        [Column("MaKhoa")]
        
        public string _idFaculty { get; set; }

        [ForeignKey("_idFaculty")]
        public virtual Faculty faculty { get; set; }

        Subject() { }
        public Subject(string idSubject, string nameSubject, int numberOfCredit,Faculty faculty)
        {
            this._idSubject = idSubject;
            this._nameSubject = nameSubject;
            this._numberOfCredit = numberOfCredit;
            this.faculty = faculty;
        }

    }
}
