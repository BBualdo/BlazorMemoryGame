using Data.Enums;
using Data.Models;

namespace UI.Services;

public class GamesService
{
  public GameStep CurrentStep = GameStep.Username;
  public Game Game = new();

  public void SetUsername(string username)
  {
    Game.Username = username;
  }

  public void SetDifficulty(DifficultyLevels difficulty)
  {
    Game.Difficulty = difficulty;
  }
}