using PBL.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.data;

namespace PBL.DAL
{
    class ClassDAL
    {
        private readonly AppDBContext _context;

        public ClassDAL()
        {
            _context = new AppDBContext();
        }

        public List<Class> selectAll()
        {
            List<Class> classes = _context.listClass.ToList();
            return classes;
        }

        public List<Class> selectByIDFaculty(string idFaculty)
        {
            List<Class> classes = _context.listClass.Where(x => x._idFaculty == idFaculty).ToList();
            return classes;
        }
    }
}
