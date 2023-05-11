using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarUsuario
{
    internal class Operador : Funcionario
    {
        public Operador(string nome, string login, string senha, bool ativo, double salarioBase, string cargo, double valorComissao)
        {
            nome = this.Nome1;
            login = this.Login1;
            senha = this.Senha1;
            ativo = this.Ativo;
            cargo = this.Cargo;
            valorComissao = this.ValorComissao;
        }

        private string cargo;
        private double valorComissao;

        public string Cargo { get => cargo; set => cargo = value; }
        public double ValorComissao { get => valorComissao; set => valorComissao = value; }

        public void cadastrarOperador(string nome, string login, string senha, bool ativo, double salarioBase, string cargo, double valorComissao)
        {
            Nome1 = nome;
            Login1 = login;
            Senha1 = senha;
            Ativo = ativo;
            Cargo = cargo;
            ValorComissao = valorComissao;
            SalarioBase1 = salarioBase;
        }


        public string apresentarOperador()
        {
            return Nome1 + " , " + Login1 + " , " + Senha1 + " , " + Ativo + " , " + Cargo + " , " + ValorComissao;
        }

        public double calcularSalario()
        {
            return valorComissao + SalarioBase1;
        }
    }
}
