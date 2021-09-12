using System;

namespace TP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcao = "";
            ContaCorrente conta = null;
            Console.WriteLine("Digite uma das opções abaixo: \n 1 - Criar conta corrente \n 2 - Depositar \n 3 - Sacar \n 4 - Consultar saldo \n 5 - Sair");
            opcao = Console.ReadLine();
            while (opcao != "5")
            {

                switch (opcao)
                {
                    case "1":
                        if (conta != null)
                        {
                            Console.WriteLine("Já foi criada a conta corrente");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Digite seu nome: ");
                            var nome = Console.ReadLine();
                            conta = new ContaCorrente(nome, 0);
                            Console.WriteLine($"Conta criada. Nome: {conta.Nome} - Saldo: {conta.Saldo}");
                            opcao = "1";
                            break;
                        }
                    case "2":
						Console.WriteLine($"Digite o valor do depósito:");
                        var valorDeposito = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(conta.Depositar(valorDeposito));
                        opcao = "2";
                        break;
                    case "3":
                    //TODO: Criar fluxo/método sacar
                    case "4":
                        Console.WriteLine($"Saldo: {conta.ConsultarSaldo()}");
                        opcao = "4";
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Digite uma das opções abaixo: \n 1 - Criar conta corrente \n 2 - Depositar \n 3 - Sacar \n 4 - Consultar saldo \n 5 - Sair");
                opcao = Console.ReadLine();
            }
            Environment.Exit(0);
        }
    }

    class ContaCorrente
    {
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente(string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }
		
		public string Depositar(double valor) {
            try
            {
                if (valor < 0)
                    return "Não é possível fazer depósito com valor negativo";

                Saldo += valor;
                return "Valor depositado com sucesso";
            }
            catch (Exception)
            {
                throw ;
            } 
        }
        
        public double ConsultarSaldo()
        {
            return Saldo;
        }
    }

}
