using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BE
{
    public class UserBE
    {
        private int id;
        private string username;
        private string password;
        private string firstname;
        private string middle_name;
        private string lastname;
        private string lastname_second;
        private DateTime birthday;
        private string email;
        private DateTime created_at;
        private int created_by;
        private DateTime updated_at;
        private int updated_by;

        public UserBE()
        {
        }

        public int MyProperty { get; set; }
        public int Id { get => id; set => id = value; }
        public int Updated_by { get => updated_by; set => updated_by = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Middle_name { get => middle_name; set => middle_name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Lastname_second { get => lastname_second; set => lastname_second = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Created_by { get => created_by; set => created_by = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }

        public override string ToString()
        {
            return base.ToString();
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
