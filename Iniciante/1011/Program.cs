static void Main(string[] args) { 

        float r = float.Parse(Console.ReadLine());
        double pi = 3.14159;
        
        double volume = (4/3.0) * pi * r * r * r;
        
        Console.WriteLine("VOLUME = {0:F3}", volume);
}