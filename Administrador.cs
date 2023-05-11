using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarUsuario
{
    internal class Administrador:Funcionario
    {
        private int codigoLiberacao = 001;

        public int CodigoLiberacao { get => codigoLiberacao; set => codigoLiberacao = value; }

        public Administrador(string nome,string login,string senha,bool ativo,double salarioBase,int codigoLiberacao) {
            nome = this.Nome1;
            login = this.Login1;
            senha = this.Senha1;
            ativo = this.Ativo;
            salarioBase = this.SalarioBase1;
            codigoLiberacao = this.CodigoLiberacao;
        }
        public string autorizarUsuario(int codigo ,Usuario usu)
        {
            if(codigo == 001)
            {
                return "Usuario " + usu.Nome1 + " Com o codigo " + codigo + " Liberado com sucesso!";
            }else
            {
                return "Codigo de administrador Errado!";
            } 

        }

        public string calcularLimiteCredito(int codigo,Cliente cli)
        {
            if (codigo != CodigoLiberacao)
            {
                return "Você não tem permissão para realizar essa ação";

            }else
            {

                 return Convert.ToString(cli.RendaMensal * 0.4);
            }
        }



    }
}
