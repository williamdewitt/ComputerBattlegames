namespace RobotMissile;

public static class ByTheBook
{
  public static void RunGame()
  {
    Console.Clear();
    Console.WriteLine("ROBOT MISSILE");
    Console.WriteLine();
    Console.WriteLine("TYPE THE CORRECT CODE");
    Console.WriteLine("LETTER (A-Z) TO");
    Console.WriteLine("DEFUSE THE MISSILE.");
    Console.WriteLine("YOU HAVE 4 CHANCES");
    Console.WriteLine();

    // The start of the char values for A-Z and a-z
    // int CapitalLetterVal = 65;
    // int SmallLetterVal = 97;

    var c = (char)Random.Shared.Next(97, 123);

    for (int i = 0; i < 4; i++)
    {
      var g = Console.ReadKey(true).KeyChar;

      if (g == c)
      {
        Console.WriteLine("TICK...FZZZZ...CLICK...");
        Console.WriteLine("YOU DID IT!");

        if(i == 3)
        {
          Console.WriteLine("(JUST)");
        }

        return;
      }

      if (g < c)
      {
        Console.WriteLine("LATER");
      }

      if (g > c)
      {
        Console.WriteLine("EARLIER");
      }

      Console.WriteLine(" THAN " + g);
    }

    Console.WriteLine("BOOOOOOOOMM...");
    Console.WriteLine("YOU BLEW IT.");
    Console.WriteLine("THE CORRECT CODE WAS " + c);
  }
}