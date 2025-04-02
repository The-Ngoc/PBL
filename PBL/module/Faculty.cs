using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    class Faculty
    {
        [Key]
        [Column("MaKhoa")]
        public string idFaculty { get; set; }
        [Column("TenKhoa")]
        public string nameFaculty { get; set; }

        public Faculty()
        {
            this.idFaculty = "";
            this.nameFaculty = "";
        }

        public Faculty(string idFaculty, string nameFaculty)
        {
            this.idFaculty = idFaculty;
            this.nameFaculty = nameFaculty;
        }

    }
}
