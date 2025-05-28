public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter width: ");
        int width = int.Parse(Console.ReadLine());  
        Console.Write("Enter height: ");
        int height = int.Parse(Console.ReadLine());
        int area = width * height;
        Console.WriteLine("area: "+ area);
    }
}