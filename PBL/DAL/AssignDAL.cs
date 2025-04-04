using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.module;
using PBL.data;
using Microsoft.EntityFrameworkCore;

namespace PBL.DAL
{
    class AssignDAL
    {
        private readonly AppDBContext _context;
        public AssignDAL()
        {
            _context = new AppDBContext();
        }

        public List<Assign> selectAll()
        {
            List<Assign> assigns = _context.listAssign
                .Include(s => s.teacher)
                .Include(s => s.classs)
                .Include(s => s.subject)
                .ToList();
            return assigns;
        }
    }
}
