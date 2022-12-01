using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BE
{
    public class EventBE
    {
        public EventBE()
        {
        }

        private int id;
        private string name;
        private DateTime? started_time;
        private DateTime? ended_time;
        private string frecuency;
        private char part_day;
        private decimal budget;
        private String address;
        private String postal_code;
        private int capacity;
        private DateTime created_at;
        private int created_by;
        private DateTime updated_at;
        private int updated_by;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime? Started_time { get => started_time; set => started_time = value; }
        public DateTime? Ended_time { get => ended_time; set => ended_time = value; }
        public string Frecuency { get => frecuency; set => frecuency = value; }
        public char Part_day { get => part_day; set => part_day = value; }
        public decimal Budget { get => budget; set => budget = value; }
        public string Address { get => address; set => address = value; }
        public string Postal_code { get => postal_code; set => postal_code = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Created_by { get => created_by; set => created_by = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
        public int Updated_by { get => updated_by; set => updated_by = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    
}
