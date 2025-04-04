using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    [Table("ThoiKhoaBieu")]
    class Schedule
    {
        [Key]
        [Column("MaTKB")]
        public int _idSchedule { get; set; }


        [Column("MaBuoiHoc")]
        public int _idClassSession { get; set; }
        [ForeignKey("_idClassSession")]
        public virtual ClassSession classSession { get; set; }

      
        [Column("MaPC")]
        public int _idAssign { get; set; }
        [ForeignKey("_idAssign")]
        public virtual Assign assign { get; set; }

        [Column("Tuan")]
        public int week { get; set; }

        public Schedule()
        {

        }

        public Schedule(ClassSession classSession, Assign assign, int week)
        {
            this.assign = assign;
            this.classSession = classSession;
            this.week = week;
        }

    }
}
