using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PBL.data;
using PBL.module;

namespace PBL.DAL
{
    class ScheduleDAL
    {
        private readonly AppDBContext _context;
        public ScheduleDAL() {
            _context = new AppDBContext();
        }

        public List<Schedule> selectAll()
        {
            List<Schedule> schedules = _context.listSchedule.ToList();
            return schedules;
        }

        public List<Schedule>? sellectT(string idteacher)
        {
            List<Schedule> schedules = _context.listSchedule
                .Include(s =>s.assign)
                .Where(s => s.assign._idTeacher == idteacher)
                .ToList();
            if (schedules != null)
            {
                return schedules;
            }
            return null;
        }

        public List<Schedule>? selectByIDTeacher(string id)
        {
            List<Schedule> schedules = _context.listSchedule
                .Include(s => s.classSession).ThenInclude(c => c.room)
                .Include(s => s.assign).ThenInclude(a => a.teacher)
                .Include(s => s.assign).ThenInclude(a => a.classs)
                .Include(s => s.assign).ThenInclude(a => a.subject)
                .Include(s => s.assign)
                .Where(s => s.assign._idTeacher == id).ToList();
            if (schedules != null)
            {
                return schedules;
            }
            return null;
        }
    }
}
