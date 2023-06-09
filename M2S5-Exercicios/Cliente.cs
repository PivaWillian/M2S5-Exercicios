namespace M2S5_Exercicios
{
    public abstract class Cliente
    {
        public int NumeroConta;
        public decimal Saldo = 0;
        public string Endereco;
        public string Nome;
        public void ResumirCliente()
        {
            Console.WriteLine($"Número da conta: {NumeroConta}\n" +
                $"Saldo: {Saldo}\n" +
                $"Endereço: {Endereco}\n" +
                $"Nome: {Nome}");

        }
    }

    public class PessoaJuridica : Cliente 
    {
        public string CNPJ;
        public void CriarConta()
        {
            Console.WriteLine("Favor informar o nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Favor informar o numero da conta: ");
            NumeroConta = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Favor informar o endereço: ");
            Endereco = Console.ReadLine();
            Console.WriteLine("Favor informar o CNPJ: ");
            CNPJ = Console.ReadLine();

        }
    }

    public class PessoaFisica: Cliente
    {
        public string CPF;

        public bool Maioridade(int idade)
        {
            if (idade > 18)
                return true;
            return false;
        }

        public void CriarConta()
        {
            Console.WriteLine("Favor informar o nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Favor informar o numero da conta: ");
            NumeroConta = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Favor informar o endereço: ");
            Endereco = Console.ReadLine();
            Console.WriteLine("Favor informar o CPF: ");
            CPF = Console.ReadLine();

        }
    }

    public class ClienteService : IClienteService
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public PessoaFisica pessoaFisica = new PessoaFisica();
        public PessoaJuridica pessoaJuridica = new PessoaJuridica();
        public void ExibirClientes()
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"{cliente.Nome}");
            }
        }

        public void BuscarClientePorConta(int numeroConta)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].NumeroConta == numeroConta)
                {
                    Console.WriteLine(clientes[i]);
                }
            }
        }

        public void CriarConta(string opcao)
        {
            if (opcao.ToLower() == "juridica")
            {
                pessoaJuridica.CriarConta();
            }
            else if (opcao.ToLower() == "fisica")
            {
                pessoaFisica.CriarConta();
            }
            else
                Console.WriteLine("Opção inválida");
        }
    }
}
