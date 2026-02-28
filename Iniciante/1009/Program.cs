static void Main(string[] args) {
        
        string nome = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine());
        double vendas = double.Parse(Console.ReadLine());
        
        double salariofinal = (vendas * 0.15) + salario;
        
        Console.WriteLine("TOTAL = R$ {0:F2}", salariofinal);
}