using Data.Enums;

namespace UI.Models;

public class Board
{
  public Board(DifficultyLevels difficultyLevel)
  {
    Size = difficultyLevel switch
    {
      DifficultyLevels.Testing => 2, // TODO: Remove this case
      DifficultyLevels.Easy => 4,
      DifficultyLevels.Hard => 16,
      _ => 8
    };

    for (var i = 0; i < Size; i++)
    {
      var card = new Card
      {
        Id = i,
        // TODO: Add Images
        ImagePath = ""
      };
      // Adding cards twice to create pairs
      Cards.Add(card);
      Cards.Add(card);
    }

    // Randomly sorting cards
    Cards = Cards.OrderBy(c => Guid.NewGuid()).ToList();
  }

  public int Size { get; set; }
  public List<Card> Cards { get; set; } = [];
}