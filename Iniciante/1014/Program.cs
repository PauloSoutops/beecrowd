static void Main(string[] args) { 
        
        int X = int.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        double consumo = X / Y;

        Console.WriteLine($"{consumo:F3} km/l");

}