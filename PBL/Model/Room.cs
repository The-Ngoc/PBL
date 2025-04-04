using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.module
{
    [Table("Phong")]
    class Room
    {
        [Key]
        [Column("MaPhong")]
        public string _idRoom { get; set; }

        [Column("SLChoNgoi")]
        public int _numberOfSeats { get; set; }

        [Column("TrangThai")]
        public bool _status { get; set; } = true;
        public Room()
        {
            this._idRoom = "";
            this._numberOfSeats = 0;
        }

        public Room(string idRoom, int numberOfSeats)
        {
            this._idRoom = idRoom;
            this._numberOfSeats = numberOfSeats;
        }
    }
}
