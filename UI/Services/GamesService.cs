﻿using Data.Enums;
using Data.Models;

namespace UI.Services;

public class GamesService
{
  public GameStep CurrentStep = GameStep.Username;

  public Game Game = new()
  {
    Difficulty = DifficultyLevels.Medium,
    Date = DateOnly.FromDateTime(DateTime.Now)
  };

  public void SetUsername(string username)
  {
    Game.Username = username;
  }

  public void SetDifficulty(DifficultyLevels difficulty)
  {
    Game.Difficulty = difficulty;
  }

  public void ResetGame()
  {
    Game = new Game
    {
      Difficulty = DifficultyLevels.Medium,
      Date = DateOnly.FromDateTime(DateTime.Now)
    };
    CurrentStep = GameStep.Username;
  }
}