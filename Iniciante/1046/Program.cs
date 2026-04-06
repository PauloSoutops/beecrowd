using System; 

class URI {

    static void Main(string[] args) { 

        string[] horas = Console.ReadLine().Split(' ');

        int inicio = int.Parse(horas[0]);
        int fim = int.Parse(horas[1]);

        int duracao;

        if (fim > inicio)
        {
            duracao = fim - inicio;
        }
        else
        {
            duracao = 24 - inicio + fim;
        }

        Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
    }

}