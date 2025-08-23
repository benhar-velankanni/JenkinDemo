using System.IO;
namespace CalulatorAppwork {
public class CalulatorApp
{
   
    public int Add(int a, int b)
    {
       return a + b;
    }
    public int Multi(int a, int b) {  
        return a * b; 
    }
    
}
public class Program
{
    public static void Main(string[] args)
    {
        CalulatorApp calulatorApp = new CalulatorApp();
        Console.WriteLine(calulatorApp.Add(8, 2));
        Console.WriteLine(calulatorApp.Multi(5, 2));
        Console.ReadLine();
    }
}
}