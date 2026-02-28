static void Main(string[] args) { 
        
        string[] linha = Console.ReadLine().Split(' ');
        
        double a = double.Parse(linha[0]);
        double b = double.Parse(linha[1]);
        double c = double.Parse(linha[2]);
        double pi = 3.14159;
        
        double areatriangulo = a * c / 2;
        double areacirculo = pi * c * c;
        double areatrapezio = (((a + b) * c) / 2);
        double areaquadrado = b * b;
        double arearetangulo = a * b;
        
        Console.WriteLine("TRIANGULO: {0:F3}", areatriangulo);
        Console.WriteLine("CIRCULO: {0:F3}", areacirculo);
        Console.WriteLine("TRAPEZIO: {0:F3}", areatrapezio);
        Console.WriteLine("QUADRADO: {0:F3}", areaquadrado);
        Console.WriteLine("RETANGULO: {0:F3}", arearetangulo);
}