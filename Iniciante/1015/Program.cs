static void Main(string[] args) {
        
        string[] linha1 = Console.ReadLine().Split(' ');
        string[] linha2 = Console.ReadLine().Split(' ');
        
        double x1 = double.Parse(linha1[0]);
        double y1 = double.Parse(linha1[1]);
        
        double x2 = double.Parse(linha2[0]);
        double y2 = double.Parse(linha2[1]);
        
        double xtotal = x2 - x1;
        double ytotal = y2 - y1;
        
        double xquadrado = xtotal * xtotal;
        double yquadrado = ytotal * ytotal;
        
        double total = xquadrado + yquadrado;
        
        double distancia = Math.Sqrt(total);
        
        Console.WriteLine(distancia.ToString("F4"));
}