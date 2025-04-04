using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    [Table("BuoiHoc")]
    class ClassSession
    {
        [Key]
        [Column("MaBuoiHoc")]
        public int _idClassSession { get; set; }

        [Column("Ngay")]
        public DateTime _day { get; set; }

        [Column("TietBatDau")]
        public int _startPeriod { get; set; }

        [Column("TietKetThuc")]
        public int _endPeriod { get; set; }

        [Column("Thu")]
        public int _dayOfWeek { get; set; }

        [Column("MaPhong")]
        public string _idRoom { get; set; }
        [ForeignKey("_idRoom")]
        public virtual Room room { get; set; }

        public ClassSession(DateTime day, int startPeriod, int endPeriod, int dayOfWeek, string idRoom)
        {
            this._idClassSession = 1;
            this._day = day;
            this._startPeriod = startPeriod;
            this._endPeriod = endPeriod;
            this._dayOfWeek = dayOfWeek;
            this._idRoom = idRoom;
        }
    }
}
