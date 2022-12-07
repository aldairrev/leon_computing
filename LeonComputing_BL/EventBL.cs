using LeonComputing_ADO;
using LeonComputing_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BL
{
    public class EventBL
    {
        private EventADO ado = new EventADO();

        public List<EventBE> getAll()
        {
            return ado.getAll();
        }
        public List<EventBE> Search(string search)
        {
            return ado.Search(search);
        }
        public EventBE FindById(int id)
        {
            return ado.FindById(id);
        }
        public EventBE Create(EventBE evt)
        {
            return ado.Create(evt);
        }
        public EventBE Update(EventBE evt)
        {
            if (evt.Id != 0)
            {
                return ado.Update(evt);
            } else
            {
                return null;
            }
        }
        public bool Delete(int id)
        {
            return ado.Delete(id);
        }

        public List<EventBE> getTenBestCapacity()
        {
            return ado.getTenBestCapacity();
        }
    }
}
