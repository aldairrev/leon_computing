using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BE
{
    public class BusinessBE
    {
        public BusinessBE()
        {
        }

        private int id;
        private string name;
        private string url;
        private string type_id;
        private string code_id;
        private DateTime created_at;
        private int created_by;
        private DateTime updated_at;
        private int updated_by;
        private string ubigeo_code;
        private string address;
        private string phone;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Url { get => url; set => url = value; }
        public string Type_id { get => type_id; set => type_id = value; }
        public string Code_id { get => code_id; set => code_id = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Created_by { get => created_by; set => created_by = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
        public int Updated_by { get => updated_by; set => updated_by = value; }
        public string Ubigeo_code { get => ubigeo_code; set => ubigeo_code = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return $"BusinessBE; Id={id}, Name={name}, Url={url}, Type_id={type_id}, Code_id={code_id}, Created_at={Created_at.ToString() ?? "null"}, Created_by={created_by}, Updated_at={Updated_at.ToString() ?? "null"}, Ubigeo_code={ubigeo_code}, Address={address}, Phone={phone}, Email={email}";
        }

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
