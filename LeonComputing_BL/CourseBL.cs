using LeonComputing_ADO;
using LeonComputing_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BL
{
    public class CourseBL
    {
        private CourseADO ado = new CourseADO();

        public List<CourseBE> getAll()
        {
            return ado.getAll();
        }
        public List<CourseBE> Search(string search)
        {
            return ado.Search(search);
        }
        public CourseBE FindById(int id)
        {
            return ado.FindById(id);
        }
        public CourseBE Create(CourseBE Course)
        {
            return ado.Create(Course);
        }
        public CourseBE Update(CourseBE Course)
        {
            if (Course.Id != 0)
            {
                return ado.Update(Course);
            } else
            {
                return null;
            }
        }
        public bool Delete(int id)
        {
            return ado.Delete(id);
        }
    }
}
