using PBL.data;
using PBL.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.DAL
{
    class SubjectDAL
    {
        private readonly AppDBContext _context;

        public SubjectDAL()
        {
            _context = new AppDBContext();
        }

        public List<Subject> selectALl()
        {
            List<Subject> subjects = _context.listSubject.ToList();
            return subjects;
        }

       

        public List<Subject> selectByIDFaculty(string idFaculty)
        {
            List<Subject> subjects = _context.listSubject.Where(x => x._idFaculty == idFaculty ).ToList();
            return subjects;
        }
    }
}
