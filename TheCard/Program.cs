CardColor[] colors = new CardColor[] { CardColor.Red, CardColor.Green, CardColor.Blue, CardColor.Yellow };
CardRank[] ranks = new CardRank[] {CardRank.One, CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Seven, CardRank.Eight, CardRank.Nine, CardRank.Ten, CardRank.DollarSign, CardRank.Percent, CardRank.Carot, CardRank.Ampersand };

foreach (CardColor color in colors)
{
    foreach (CardRank rank in ranks)
    {
        Card newCard = new Card(color, rank);
        Console.WriteLine($"The {newCard.CardColor} {newCard.CardRank}");
    }
}

public class Card
{
    public CardColor CardColor { get; set; }
    public CardRank CardRank { get; set; }

    public Card(CardColor cardColor, CardRank cardRank)
    {
        CardRank = cardRank;
        CardColor = cardColor;
    }

    public bool IsSymbol => CardRank == CardRank.DollarSign || CardRank == CardRank.Percent || CardRank == CardRank.Carot || CardRank == CardRank.Ampersand;
    public bool IsNumber => !IsSymbol;
}


public enum CardColor {Red, Green, Blue, Yellow }
public enum CardRank {One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Carot, Ampersand }