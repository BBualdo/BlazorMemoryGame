using Data.Enums;
using Data.Models;

namespace UI.Services;

public interface IGamesService
{
    GameStep CurrentStep { get; set; }
    Game Game { get; set; }
    
    void SetUsername(string username);
    
    void SetDifficulty(DifficultyLevel difficulty);
    
    void ResetGame();

    void TryAgain();
}