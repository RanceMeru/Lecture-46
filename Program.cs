class Program
{
    static void Main(string[] args)
    {
        //the method add is being called using values that we want but not set in the method
        Add(6,90);
        Add("Bobby","Luv");
        Add(50.5, 73.6);
        //They all have the same name but different parameters and this demonstrates method overloading

        Console.WriteLine();//can peak the definition (WriteLine)
    }
    public static void Add(int x , int y )
    {
        int sum = x + y ;
        Console.WriteLine(sum);

    }

    public static void Add(string x , string y)
    {
        string answer =  x +" "+ y;
        Console.WriteLine(answer);
    }
    public static void Add(double x , double y)
    {
        double sum = x + y;
        Console.WriteLine(sum);

    }
}