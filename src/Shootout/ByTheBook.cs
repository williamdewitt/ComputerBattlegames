public static class ByTheBook
{
  public static async Task RunGame()
  {
    Console.Clear();
    Console.WriteLine("COWBOY SHOOTOUT -");
    Console.WriteLine("YOU ARE BACK TO BACK");
    Console.WriteLine("TAKE 10 PACES...");

    for (int i = 1; i <= 10; i++)
    {
      Console.WriteLine(".." + i);
      await Task.Delay(1_000);
    }

    Console.WriteLine();
    
    var waitTime = Random.Shared.Next(1, 10);
    await Task.Delay(TimeSpan.FromSeconds(waitTime));

    Console.WriteLine("HE DRAWS.....");
    
    if (Console.KeyAvailable)
    {
      Console.WriteLine("AND SHOOTS.");
      Console.WriteLine("BANG! YOU'RE DEAD!");
      return;
    }    

    for (int i = 1; i <= 5; i++)
    {
      if(Console.KeyAvailable)
      {
        Console.WriteLine("BUT YOU SHOOT FIRST.");
        Console.WriteLine("YOU KILLED HIM.");
        return;
      }

      await Task.Delay(200);
    }
  }
}