static void Main(string[] args) { 

        string[] ABC = Console.ReadLine().Split(' ');
        
        double A = double.Parse(ABC[0]);
        double B = double.Parse(ABC[1]);
        double C = double.Parse(ABC[2]);
        
        if(A+B>C && B+C>A && A+C>B){
            double perimetro = A+B+C;
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
        }else{
            double area = ((A+B)*C)/2;
            Console.WriteLine("Area = " + area.ToString("F1"));
        }
        
}