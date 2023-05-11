using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarUsuario
{
    internal class Validador
    {

        public string validarUsuario(string Usuario , string senha , string Nome)
        {
            if(senha != "001")
            {
                return "Erro de senha";

            }
            else
            {
                return "Logando usuario ... ";

            }
        }
    }
}
