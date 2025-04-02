using PBL.controller;
using PBL.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.test
{
    class testDB
    {
         public static void show()
        {
            FacultyController facultyController = new FacultyController();
            List<Faculty> list = facultyController.sellectALL();
            foreach(Faculty fa in list)
            {
                Console.WriteLine($"ID:{fa.idFaculty} -- {fa.nameFaculty}");
            }

            SubjectController subjectController = new SubjectController();
            List<Subject> listSubject = subjectController.selectALl();
            foreach(Subject sub in listSubject)
            {
                Console.WriteLine($"ID:{sub.idSubject} -- {sub.nameSubject}  -- {sub.numberOfCredit}");
            }

            ClassController classController = new ClassController();
            List<Class> listClass = classController.selectAll();
            foreach(Class cls in listClass)
            {
                Console.WriteLine($"ID:{cls.idClass} -- {cls.nameClass} -- {cls.numberOfStudent}");
            }
        }
    }
}
