using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TeacherService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TeacherService.svc or TeacherService.svc.cs at the Solution Explorer and start debugging.
    public class TeacherService : ITeacherService
    {

        public Teacher GetTeachers()
        {
            using (wcfEntities entities = new wcfEntities())
            {
                return entities.Teachers.ToList().ElementAt(0);
            }
        }

        public List<Teacher> GetAllTeacher()
        {
            using (wcfEntities entities = new wcfEntities())
            {
                return entities.Teachers.ToList();
            }
        }


        public bool addTeacher(Teacher t)
        {
            try
            {
                using (wcfEntities entities = new wcfEntities())
                {
                    Teacher teacher = t;
                    entities.Teachers.Add(teacher);
                    entities.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
