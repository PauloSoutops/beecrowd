static void Main(string[] args) { 
        
        string[] linha1 = Console.ReadLine().Split(' ');
        string[] linha2 = Console.ReadLine().Split(' ');
        
        int peca1 = int.Parse(linha1[0]);
        int numeropeca1 = int.Parse(linha1[1]);
        double valorpeca1 = double.Parse(linha1[2]);

        int peca2 = int.Parse(linha2[0]);
        int numeropeca2 = int.Parse(linha2[1]);
        double valorpeca2 = double.Parse(linha2[2]);
        
        double valor1 = numeropeca1 * valorpeca1;
        double valor2 = numeropeca2 * valorpeca2;
        
        double total = valor1 + valor2;
        
        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);
}