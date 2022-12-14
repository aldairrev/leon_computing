using LeonComputing_ADO;
using LeonComputing_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BL
{
    public class UbigeoBL
    {

        UbigeoADO ado = new UbigeoADO();

        public DataTable Ubigeo_Departamentos()
        {
            return ado.Ubigeo_Departamentos();
        }
        public DataTable Ubigeo_ProvinciasDepartamento(String strIdDepartamento)
        {
            return ado.Ubigeo_ProvinciasDepartamento(strIdDepartamento);
        }
        public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento, String strIdProvincia)
        {
            return ado.Ubigeo_DistritosProvinciaDepartamento(strIdDepartamento, strIdProvincia);
        }
        
        public DataTable getUbigeoById(string ubigeo)
        {
            return ado.getUbigeoById(ubigeo);
        }
    }
}
