namespace TheVitalMessage;

public static class ByTheBook
{
  public static void RunGame()
  {
    Console.Clear();
    Console.WriteLine("VITAL MESSAGE");
    Console.WriteLine();
    Console.WriteLine("HOW DIFFICULT? (4-10)");
    
    var d = int.Parse(Console.ReadLine());

    while (d < 4 || d > 10)
    {
      Console.WriteLine("HOW DIFFICULT? (4-10)");
      d = int.Parse(Console.ReadLine());
    }

    var m = string.Empty;

    for (int i = 0; i < d; i++)
    {
      m += (char)Random.Shared.Next(97, 123);
    }

    Console.Clear();
    Console.WriteLine("SEND THIS MESSAGE:");
    Console.WriteLine();
    Console.WriteLine(m);

    for (int i = 1; i < d * 8; i++)
    {
      Thread.Sleep(30);
    }

    Console.Clear();
    var n = Console.ReadLine();

    if (n == m)
    {
      Console.WriteLine("MESSAGE CORRECT");
      Console.WriteLine("THE WAR IS OVER");
      return;
    }

    Console.WriteLine("YOU GOT IT WRONG");
    Console.WriteLine("YOU SHOULD HAVE SENT:");
    Console.WriteLine(m);
  }
}