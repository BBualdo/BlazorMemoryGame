namespace UI.Models;

public class Card
{
  public int Id { get; set; }
  public string? ImagePath { get; set; }
  public bool IsRevealed { get; set; }

  public void Reveal()
  {
    IsRevealed = true;
  }
}