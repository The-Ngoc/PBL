using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    class Class
    {
        [Key]
        [Column("MaLop")]
        public string idClass { get; set; }

        [Column("TenLop")]
        public string nameClass { get; set; }

        [Column("SoLuongSV")]
        public int numberOfStudent { get; set; }

        public Class()
        {
            this.nameClass = "";
            this.idClass = "";
            this.numberOfStudent = 0;
        }

        public Class(string idClass,string nameClass , int numberOfStudent)
        {
            this.idClass = idClass;
            this.nameClass = nameClass;
            this.numberOfStudent = numberOfStudent;
        }
    }
}
