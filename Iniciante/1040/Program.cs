static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');

        double N1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double N2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double N3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
        double N4 = double.Parse(valores[3], CultureInfo.InvariantCulture);

        double media = (N1 * 2 + N2 * 3 + N3 * 4 + N4) / 10.0;

        // TRUNCAR para 1 casa decimal (não arredondar!)
        media = Math.Floor(media * 10) / 10;

        Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");

            double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));

            double mediaFinal = (media + notaExame) / 2.0;

            // TRUNCAR novamente
            mediaFinal = Math.Floor(mediaFinal * 10) / 10;

            if (mediaFinal >= 5.0)
                Console.WriteLine("Aluno aprovado.");
            else
                Console.WriteLine("Aluno reprovado.");

            Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
        }
}