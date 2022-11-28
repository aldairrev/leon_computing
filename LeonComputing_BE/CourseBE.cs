using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LeonComputing_BE
{
    public class CourseBE
    {
        private int id;
        private string name;
        private int hours_practice;
        private int hours_theory;
        private char level;
        private string description;
        private DateTime created_at;
        private int created_by;
        private DateTime updated_at;
        private int updated_by;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Hours_practice { get => hours_practice; set => hours_practice = value; }
        public int Hours_theory { get => hours_theory; set => hours_theory = value; }
        public char Level { get => level; set => level = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Created_by { get => created_by; set => created_by = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
        public int Updated_by { get => updated_by; set => updated_by = value; }
        public override string ToString()
        {
            return $"BusinessBE; Id={id}, Name={name}, Hours_practice={hours_practice}, Hours_theory ={hours_theory}, Level={level}, Description={description}, Created_at = {created_at}, Created_by = {created_by}, Updated_at = {updated_at}, Updated_by = {updated_by}";
        }

    }
}
