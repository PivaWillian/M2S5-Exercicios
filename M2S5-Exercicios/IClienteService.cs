namespace M2S5_Exercicios
{
    public interface IClienteService
    {
        void BuscarClientePorConta(int numeroConta);
        void CriarConta(string opcao);
        void ExibirClientes();
    }
}