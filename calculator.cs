using System;

public class Program
{
  public static void Main(string[] args)
  {
    //setup
    double sideLength;
    double slantHeight;
    double altitude;
    double radius;
    
    //input
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Enter what operation you would like to do.\nType 'q' for Pyramid with slant height given.\nType 'w' for Pyramid without slant height given.\nType 'e' for Cone with slant height given.\nType 'r' for Cone without slant height given.");
    char funcIdentifyer = Convert.ToChar(Console.ReadLine());

    switch (funcIdentifyer)
    {
    case 'q':
      Console.WriteLine("Enter side length and slant height");
      sideLength = Convert.ToDouble(Console.ReadLine());
      slantHeight = Convert.ToDouble(Console.ReadLine());
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"The answer is: {PyramidWithSlant(sideLength, slantHeight)}");
      break;

    case 'w':
      Console.WriteLine("Enter side length and altitude");
      sideLength = Convert.ToDouble(Console.ReadLine());
      altitude = Convert.ToDouble(Console.ReadLine());
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"The answer is: {PyramidWithoutSlant(sideLength, altitude)}");
      break;

    case 'e':
      Console.WriteLine("Enter radius and slant height");
      radius = Convert.ToDouble(Console.ReadLine());
      slantHeight = Convert.ToDouble(Console.ReadLine());
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"The answer is: {ConeWithSlant(radius, slantHeight)}");
      break;

    case 'r':
      Console.WriteLine("Enter Radius and altitude");
      radius = Convert.ToDouble(Console.ReadLine());
      altitude = Convert.ToDouble(Console.ReadLine());
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"The answer is: {ConeWithoutSlant(radius, altitude)}");
      break;
      
    default:
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("Invalid command. Try again.");
      break;
    }
    Console.ForegroundColor = ConsoleColor.White;
  }

  public static double PyramidWithSlant(double sideLength, double slantHeight)
  {
    double result = (sideLength * 4 * slantHeight / 2) + sideLength * sideLength;
    return result;
  }

  public static double PyramidWithoutSlant(double sideLength, double altitude)
  {
    double slantHeight = Math.Sqrt(Math.Pow(sideLength / 2, 2) + Math.Pow(altitude, 2));
    double result = (sideLength * 4 * slantHeight / 2) + sideLength * sideLength;
    return result;
  }

  public static double ConeWithSlant(double radius, double slantHeight)
  {
    double result = (3.14 * radius * slantHeight) + 3.14 * Math.Pow(radius, 2);
    return result;
  }
//not done yet
  public static double ConeWithoutSlant(double radius, double altitude)
  {
    double slantHeight = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(altitude, 2));
    double result = 3.14 * radius * slantHeight + 3.14 * Math.Pow(radius, 2);
    return result;
  }
}
