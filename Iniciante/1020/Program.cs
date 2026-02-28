static void Main(string[] args) { 

        int valor = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{valor / 365} ano(s)");
        valor %= 365;
        
        Console.WriteLine($"{valor / 30} mes(es)");
        valor %= 30;
        
        Console.WriteLine($"{valor / 1} dia(s)");
        valor = valor;
}