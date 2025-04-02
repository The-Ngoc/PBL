using PBL.data;
using PBL.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.controller
{
    class FacultyController
    {
        private readonly AppDBContext _context;

        public FacultyController()
        {
            _context = new AppDBContext();
        }

        public List<Faculty> sellectALL()
        {
            List<Faculty> faculties = _context.lisFaculty.ToList();
            return faculties;
        }
    }
}
