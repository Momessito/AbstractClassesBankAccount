using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarUsuario
{
    internal class Cliente : Usuario
    {



        private string cpf;
        private double rendaMensal;
        private double limiteCredito;

        public string Cpf { get => cpf; set => cpf = value; }
        public double RendaMensal { get => rendaMensal; set => rendaMensal = value; }
        public double LimiteCredito { get => limiteCredito; set => limiteCredito = value; }

        public Cliente(string nome, string login, string senha, bool ativo, string cpf, double rendaMensal, double limiteCredito)
        {
            Nome1 = nome;
            Login1 = login;
            Senha1 = senha;
            Ativo = ativo;
            Cpf = cpf;
            RendaMensal = rendaMensal;
            LimiteCredito = limiteCredito;
        }

        public void cadastrarCliente(string nome,string login,string senha,bool ativo,string cpf,double rendaMensal , double limiteCredito)
        {

            nome = base.Nome1;
            login = base.Login1;
            senha = base.Senha1;
            ativo = base.Ativo;
            cpf = Cpf;
            rendaMensal = RendaMensal;
            limiteCredito = LimiteCredito;
        }

        public string apresentarCliente()
        {
            return Nome1 + " , " + Login1 + " , " + Senha1 + " , " + Ativo + " , " + Cpf + " , " + RendaMensal + " , " + limiteCredito;
        }
    }
}
