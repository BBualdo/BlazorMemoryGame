using Data.Enums;
using Data.Models;

namespace UI.Services;

public class GamesService : IGamesService
{
  public GameStep CurrentStep { get; set; } = GameStep.Username;

  public Game Game { get; set; } = new()
  {
    Difficulty = DifficultyLevel.Medium,
    Date = DateOnly.FromDateTime(DateTime.Now)
  };

  public void SetUsername(string username)
  {
    Game.Username = username;
  }

  public void SetDifficulty(DifficultyLevel difficulty)
  {
    Game.Difficulty = difficulty;
  }

  public void ResetGame()
  {
    Game = new Game
    {
      Difficulty = DifficultyLevel.Medium,
      Date = DateOnly.FromDateTime(DateTime.Now)
    };
    CurrentStep = GameStep.Username;
  }

  public void TryAgain()
  {
    Game.Id = 0;
    Game.Moves = 0;
    Game.Matches = 0;
    Game.Fails = 0;
    Game.Date = DateOnly.FromDateTime(DateTime.Now);
    Game.Time = TimeSpan.Zero;
  }
}