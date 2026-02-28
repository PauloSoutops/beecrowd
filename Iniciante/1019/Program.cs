static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        
        int horas = n / 3600;
        n %= 3600;
        
        int minutos = n / 60;
        n %= 60;
        
        int segundo = n;
        
        Console.WriteLine($"{horas}:{minutos}:{segundo}");
}