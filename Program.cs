using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarUsuario
{
    abstract internal class Usuario

    {


        private string Nome;
        private string Login;
        private string Senha;
        private bool ativo;
        public string Nome1 { get => Nome; set => Nome = value; }
        public string Login1 { get => Login; set => Login = value; }
        public string Senha1 { get => Senha; set => Senha = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}
