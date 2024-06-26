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
      var card1 = new Card
      {
        Id = i,
        // TODO: Add Images
        ImagePath = ""
      };
      var card2 = new Card
      {
        Id = i,
        ImagePath = card1.ImagePath
      };

      Cards.Add(card1);
      Cards.Add(card2);
    }

    // Randomly sorting cards
    Cards = Cards.OrderBy(c => Guid.NewGuid()).ToList();
  }

  public int Size { get; set; }
  public List<Card> Cards { get; set; } = [];
}