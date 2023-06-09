using M2S5_Exercicios;

ClienteService clienteService = new ClienteService();
Console.WriteLine("Bem vindo ao banco, o que deseja fazer?\n" +
    "Física - Criar conta PF;\n" +
    "Jurídica - Criar conta PJ");
string op = Console.ReadLine().ToLower();
switch (op)
{
    case "juridica": clienteService.CriarConta(op);
        break;
    case "fisica": clienteService.CriarConta(op);
        break;
    default: break;
}