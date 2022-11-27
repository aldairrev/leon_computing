using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BE
{
    public class PartnerBE
    {
        int id { get; set; }
        string firstname { get; set; }
        string middle_name { get; set; }
        string lastname { get; set; }
        string lastname_second { get; set; }
        DateTime admision_at { get; set; }
        DateTime birthday { get; set; }
        string code_id { get; set; }
        string type_id { get; set; }
        DateTime last_training_at { get; set; }
        DateTime created_at { get; set; }
        int created_by { get; set; }
        DateTime updated_at { get; set; }
        int updated_by { get; set; }
        string ubigeo_code { get; set; }
        string address { get; set; }
        string phone { get; set; }
        string email { get; set; }
    }
}
