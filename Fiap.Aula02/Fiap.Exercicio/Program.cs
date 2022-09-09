using Fiap.Exercicio.Models;

IList<Cliente> clientes = new List<Cliente>();
ContaCorrente cc = null ;
Random random = new Random();

Console.WriteLine("---------------------------------------------------------");
Console.Write("Informe a quantidade de clientes que deseja inserir >>> ");
var nroClientes = Console.ReadLine();
Console.WriteLine("---------------------------------------------------------\n");
Console.Clear();

for (int i=0; i < Convert.ToInt32(nroClientes); i++)
{
    Console.WriteLine("---------------------------------------------------------");
    Console.Write("Nome completo >>> ");
    var nome = Console.ReadLine();
    Console.Write("CPF >>> ");
    var cpf = Console.ReadLine();
    Console.Clear();

    clientes.Add(new Cliente(random.Next(), nome, cpf));  
}
Console.Clear();

Console.WriteLine("---------------------------------------------------------");
Console.Write("Informe o numero da Agencia >>> ");
var ag = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o numero da Conta >>> ");
var conta = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o tipo de conta (0 - Comum, 1 - Especial, 2 - Premium) >>> ");
TipoConta tpConta = (TipoConta) Convert.ToInt32(Console.ReadLine());

cc = new ContaCorrente(ag, conta, clientes, tpConta);
Console.WriteLine("\n"+cc);
Console.Clear();


var menu = "";
var continua = true;



while (continua) {


    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("Escolha uma das opções abaixo para a Conta Corrente:");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Exibir dados\n");
    Console.WriteLine("0 - SAIR");
    menu = Console.ReadLine();
    Decimal valor = 0;

    switch (menu)
    {
        case "1":
            
            Console.WriteLine("Informe o valor para depósito >>> R$ ");
            valor = Convert.ToDecimal(Console.Read());
            cc.Depositar(valor);
            break;

        case "2":
            
            Console.WriteLine("Informe o valor desejado para saque >>> R$ ");
            valor = Convert.ToDecimal(Console.Read());
            cc.Retirar(valor);
            break;

        case "3":
            
            Console.WriteLine(cc);
            break;

        case "0":
            Console.WriteLine("Encerrando programa");
            continua = false;
            break;

        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }

}





