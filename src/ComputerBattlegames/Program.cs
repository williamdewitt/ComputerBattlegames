using Spectre.Console;

var game = AnsiConsole.Prompt(
  new SelectionPrompt<string>()
    .Title("Choose a game")
    .PageSize(10)
    .AddChoices(
    [
      "Robot Missile"
    ])
);

switch (game)
{
  case "Robot Missile":
    RobotMissile.ByTheBook.RunGame();
    break;
}
