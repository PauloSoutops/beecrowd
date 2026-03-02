static void Main(string[] args) { 
            string[] entrada = Console.ReadLine().Split(' ');

        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);
        int c = int.Parse(entrada[2]);

        int originalA = a;
        int originalB = b;
        int originalC = c;

        int temp;

        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }

        if (a > c)
        {
            temp = a;
            a = c;
            c = temp;
        }

        if (b > c)
        {
            temp = b;
            b = c;
            c = temp;
        }

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine();
        Console.WriteLine(originalA);
        Console.WriteLine(originalB);
        Console.WriteLine(originalC);
    

}