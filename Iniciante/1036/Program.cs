static void Main(string[] args) { 
        string line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line)) return;

        string[] valores = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (valores.Length < 3) return;

        // substitui vírgula por ponto para evitar problemas de cultura/local
        double A = double.Parse(valores[0].Replace(',', '.'));
        double B = double.Parse(valores[1].Replace(',', '.'));
        double C = double.Parse(valores[2].Replace(',', '.'));

        double delta = B * B - 4 * A * C;

        if (A == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            double R1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double R2 = (-B - Math.Sqrt(delta)) / (2 * A);

            // garante que o decimal impresso use ponto
            Console.WriteLine("R1 = " + R1.ToString("F5").Replace(',', '.'));
            Console.WriteLine("R2 = " + R2.ToString("F5").Replace(',', '.'));
        }

}