static void Main(string[] args) {

        double[] v = Console.ReadLine().Split(' ')
                        .Select(double.Parse)
                        .OrderByDescending(x => x)
                        .ToArray();

        double A = v[0];
        double B = v[1];
        double C = v[2];

        double AQ = A * A;
        double BQ = B * B;
        double CQ = C * C;

        if (A >= B + C) {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else {
            if (AQ == BQ + CQ)
                Console.WriteLine("TRIANGULO RETANGULO");

            if (AQ > BQ + CQ)
                Console.WriteLine("TRIANGULO OBTUSANGULO");

            if (AQ < BQ + CQ)
                Console.WriteLine("TRIANGULO ACUTANGULO");

            if (A == B && B == C)
                Console.WriteLine("TRIANGULO EQUILATERO");

            else if (A == B || A == C || B == C)
                Console.WriteLine("TRIANGULO ISOSCELES");
        }
}