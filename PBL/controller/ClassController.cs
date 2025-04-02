using PBL.data;
using PBL.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.controller
{
    class ClassController
    {
        private readonly AppDBContext _context;

        public ClassController()
        {
            _context = new AppDBContext();
        }

        public List<Class> selectAll()
        {
            List <Class> classes= _context.listClass.ToList();
            return classes;
        }
    }
}
