using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.data;
using PBL.module;

namespace PBL.DAL
{
    class RoomDAL
    {
        private readonly AppDBContext _context;
        public RoomDAL()
        {
            _context = new AppDBContext();
        }
        public List<Room> selectAll()
        {
            List<Room> rooms = _context.listRoom.ToList();
            return rooms;
        }

        public List<Room> selectRoomTrue()
        {
            List<Room> rooms = _context.listRoom.Where(x => x._status == true).ToList();
            return rooms;
        }
    }
}
