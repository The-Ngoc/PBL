using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    class Subject
    {
        [Key]
        [Column("MaMon")]
        public string idSubject { get; set; }

        [Column("TenMon")]
        public string nameSubject { get; set; }

        [Column("SoTC")]
        public int numberOfCredit { get; set; }

        Subject()
        {
            this.nameSubject = "";
            this.idSubject = "";
            this.numberOfCredit = 0;
        }
        Subject(string idSubject, string nameSubject, int numberOfCredit)
        {
            this.idSubject = idSubject;
            this.nameSubject = nameSubject;
            this.numberOfCredit = numberOfCredit;
        }
    }
}
