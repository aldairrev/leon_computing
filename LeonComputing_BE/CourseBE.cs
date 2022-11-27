using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BE
{
    public class CourseBE
    {
        int id { get; set; }
        string name { get; set; }
        int hours_practice { get; set; }
        int hours_theory { get; set; }
        string level { get; set; }
        string description { get; set; }
        DateTime created_at { get; set; }
        int created_by { get; set; }
        DateTime updated_at { get; set; }
        int updated_by { get; set; }
    }
}
