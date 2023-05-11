using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarUsuario
{
    abstract internal class Funcionario:Usuario
    {
        private double SalarioBase;

        public double SalarioBase1 { get => SalarioBase; set => SalarioBase = value; }
    }
}
