static void Main(string[] args) { 

    int numero = int.Parse(Console.ReadLine());
    double horas = int.Parse(Console.ReadLine());
    double salariohora = double.Parse(Console.ReadLine());
    
    double salario = salariohora * horas;
    
    Console.WriteLine("NUMBER = " + numero);
    Console.WriteLine("SALARY = U$ {0:F2}", salario);

}