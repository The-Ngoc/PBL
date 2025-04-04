using PBL.data;
using PBL.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.DAL
{
    class FacultyDAL
    {
        private readonly AppDBContext _context;

        public FacultyDAL()
        {
            _context = new AppDBContext();
        }

        public List<Faculty> sellectAll()
        {
            List<Faculty> faculties = _context.listFaculty.ToList();
            return faculties;
        }
    }
}
