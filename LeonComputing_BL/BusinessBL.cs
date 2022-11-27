using LeonComputing_ADO;
using LeonComputing_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BL
{
    public class BusinessBL
    {
        private BusinessADO ado = new BusinessADO();

        public List<BusinessBE> getAll()
        {
            return ado.getAll();
        }
        public List<BusinessBE> Search(string search)
        {
            return ado.Search(search);
        }
        public BusinessBE FindById(int id)
        {
            return ado.FindById(id);
        }
        public BusinessBE Create(BusinessBE business)
        {
            return ado.Create(business);
        }
        public BusinessBE Update(BusinessBE business)
        {
            if (business.Id != 0)
            {
                return ado.Update(business);
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
