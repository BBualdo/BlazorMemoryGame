using Data.Models;

namespace UI.Services;

public interface IScoresService
{
  Task<IEnumerable<Game>> GetGameScoresAsync();
  Task AddGameScoreAsync(Game game);
  Task DeleteGameScoreAsync(Game game);
  Task DeleteAllGameScoresAsync();
}