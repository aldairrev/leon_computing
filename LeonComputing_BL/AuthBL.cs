using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeonComputing_ADO;
using LeonComputing_BE;

namespace LeonComputing_BL
{
    public class AuthBL
    {
        private AuthADO ado = new AuthADO();

        public UserBE attempt(String username, String password)
        {
            return ado.attempt(username, password);
        }
    }
}
