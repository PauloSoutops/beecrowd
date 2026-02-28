static void Main(string[] args) { 

        double n = double.Parse(Console.ReadLine());
        
        int n2 = (int) (n*100);
        
        Console.WriteLine("NOTAS:");
        
        Console.WriteLine($"{n2 / 10000} nota(s) de R$ 100.00");
        n2 %= 10000;
        
        Console.WriteLine($"{n2 / 5000} nota(s) de R$ 50.00");
        n2 %= 5000;
        
        Console.WriteLine($"{n2 / 2000} nota(s) de R$ 20.00");
        n2 %= 2000;
        
        Console.WriteLine($"{n2 / 1000} nota(s) de R$ 10.00");
        n2 %= 1000;
        
        Console.WriteLine($"{n2 / 500} nota(s) de R$ 5.00");
        n2 %= 500;
        
        Console.WriteLine($"{n2 / 200} nota(s) de R$ 2.00");
        n2 %= 200;
        
        Console.WriteLine("MOEDAS:");
        
        Console.WriteLine($"{n2 / 100} moeda(s) de R$ 1.00");
        n2 %= 100;

        Console.WriteLine($"{n2 / 50} moeda(s) de R$ 0.50");
        n2 %= 50;

        Console.WriteLine($"{n2 / 25} moeda(s) de R$ 0.25");
        n2 %= 25;

        Console.WriteLine($"{n2 / 10} moeda(s) de R$ 0.10");
        n2 %= 10;

        Console.WriteLine($"{n2 / 5} moeda(s) de R$ 0.05");
        n2 %= 5;

        Console.WriteLine($"{n2} moeda(s) de R$ 0.01");
}