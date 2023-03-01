using PareAqui;


string opcao;
List<Carro> carros = new List<Carro>();

do{

    Console.WriteLine("Olá, bem vindo ao Estacionamento PARE AQUI!");
    Console.WriteLine("Selecione uma opção do menu:");
    Console.WriteLine("1 - Cadastrar Carro");
    Console.WriteLine("2 - Marcar Entrada");
    Console.WriteLine("3 - Marcar Saída");
    Console.WriteLine("4 - Consultar Histórico");
    Console.WriteLine("5 - Sair");
    opcao = Console.ReadLine();

    if(opcao == "1")
    {
        CadastrarCarro();
    }

}while (opcao != "5");


void CadastrarCarro()
{
    Carro carro = new Carro();
    Console.WriteLine("Digite a placa do carro:");
    carro.Placa = Console.ReadLine();
    Console.WriteLine("Digite o modelo do carro:");
    carro.Modelo = Console.ReadLine();
    Console.WriteLine("Digite qual cor do carro:");
    carro.Cor = Console.ReadLine();
    Console.WriteLine("Digite qual a Marca do carro:");
    carro.Marca = Console.ReadLine();
    carros.Add(carro);
}