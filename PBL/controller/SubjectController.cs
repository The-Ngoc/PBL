using PBL.data;
using PBL.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.controller
{
    class SubjectController
    {
        private readonly AppDBContext _context;

        public SubjectController()
        {
            _context = new AppDBContext();
        }

        public List<Subject> selectALl()
        {
            List<Subject> subjects = _context.listSubject.ToList();
            return subjects;
        }
    }
}
