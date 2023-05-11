using System;

namespace ValidarUsuario
{
    internal class Principal
    {
        public int entrada = 0;
        public int entrada2 = 0;

        public Principal()
        {
            this.entrada = 0;
            this.entrada2 = 0;
        }

        static void Main(string[] args)
        {
            Administrador administrador = new Administrador("Alex", "alex123", "teucu", true, 300, 001);
            Operador operador = new Operador("Joao", "JoaozinhoGameplays", "EuReceboMal", false, 300, "Caixa", 900);
            Validador validador = new Validador();
            Principal prin = new Principal();
            Cliente cliente = new Cliente("Carlos", "Carlitos", "hahaha", false, "5646545651-5", 500, 0);


            while (prin.entrada == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Cliente \n2 - Operador \n3 - Administrador\n0 - Sair");
                Console.ForegroundColor = ConsoleColor.Magenta;
                switch (Console.ReadLine())
                {
                    case "1":

                        while (prin.entrada2 == 0)
                        {
                            Console.WriteLine("1 - Logar no Sistema\n2 - Cadastrar cliente\n3 - Visualizar Cliente\n0 - Sair\n");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    validador.validarUsuario("Carlos", "001", "Carlitos");
                                    Console.WriteLine(validador.validarUsuario("Carlos", "001", "Carlitos"));
                                    
                                    break;
                                case "2":
                                    cliente.cadastrarCliente("Carlos", "Carlitos", "hahaha", false, "5646545651-5", 500, 50);
                                    Console.WriteLine("Usuario Cadastrado!");
                                    break;
                                case "3":
                                    Console.WriteLine(cliente.apresentarCliente());
                                    break;
                                case "0":
                                    prin.entrada2 = 1;
                                    break;
                            }
                        }
                        break;

                    case "2":
                        while (prin.entrada2 == 0)
                        {
                            Console.WriteLine("1 - Logar no Sistema\n2 - Cadastrar Operador\n3 - Visualizar Operador\n4 - Calcular salário final do operador \n0 - Sair\n");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    validador.validarUsuario("Joao", "001", "JoaozinhoGameplays");
                                    Console.WriteLine(validador.validarUsuario("Joao", "001", "JoaozinhoGameplays"));

                                    break;
                                case "2":
                                    operador.cadastrarOperador("Joao", "JoaozinhoGameplays", "EuReceboMal", false, 900, "Caixa", 300);
                                    Console.WriteLine("Usuario Cadastrado!");
                                    break;
                                case "3":
                                    Console.WriteLine(operador.apresentarOperador());
                                    break;
                                case "4":
                                    Console.WriteLine(operador.calcularSalario());
                                    break;
                                case "0":
                                    prin.entrada2 = 1;
                                    break;
                            }
                        }
                        prin.entrada2 = 0;
                        break;

                    case "3":
                        while (prin.entrada2 == 0)
                        {
                            Console.WriteLine("1 - Logar no Sistema\n2 - Autorizar usuário\n3 - Calcular limite de crédito\n0 - Sair\n");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    validador.validarUsuario("Alex",  "001", "alex123");
                                    Console.WriteLine(validador.validarUsuario("Alex", "001", "alex123"));
                                    break;
                                case "2":
                                    Console.WriteLine(administrador.autorizarUsuario(001, cliente));
                                    break;
                                case "3":
                                    Console.WriteLine(administrador.calcularLimiteCredito(001,cliente));
                                    break;
                                case "0":
                                    prin.entrada2 = 1;
                                    break;
                            }
                        }
                        prin.entrada2 = 0;
                        break;

                    case "0":
                        prin.entrada = 1;
                        break;
                }

            }
        }
    }
}
