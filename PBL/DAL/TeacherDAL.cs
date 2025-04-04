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
    class TeacherDAL
    {
        private readonly AppDBContext _context;

        public TeacherDAL()
        {
            _context = new AppDBContext();
        }

        public List<Teacher> selectAll()
        {
            List<Teacher> teachers = _context.listTeacher.ToList();
            return teachers;
        }

        public List<Teacher> selectByIDFaculty(string idFaculty)
        {
            List<Teacher> teachers = _context.listTeacher.Where(x => x._idFaculty == idFaculty).ToList();
            return teachers;
        }
    }
}
