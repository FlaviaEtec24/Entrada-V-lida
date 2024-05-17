// Console.WriteLine("Começou!");

string opcao = "";
while (opcao != "s")
{
    Console.Clear();
    Console.Write("Deseja calcular a tabuada de qual número? ");
    int n = Convert.ToInt32(Console.ReadLine());

    int contador = 1;
    while (contador <= 10)
    {
        int produto = contador * n;
        Console.WriteLine($"{n} x {contador} = {produto}");
        contador++;
    }

    Console.Write("Deseja sair? ");
    opcao = Console.ReadLine()!;
}

Console.WriteLine("Acabou!");

