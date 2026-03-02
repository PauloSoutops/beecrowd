static void Main(string[] args) { 

        string[] AB = Console.ReadLine().Split(' ');
        
        double A = double.Parse(AB[0]);
        double B = double.Parse(AB[1]);
        
        if(A % B == 0 || B % A == 0){
            Console.WriteLine("Sao Multiplos");
        }else{
            Console.WriteLine("Nao sao Multiplos");
        }
}