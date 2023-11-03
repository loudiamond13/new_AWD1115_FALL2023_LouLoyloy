namespace BlackJack.Models
{
    public class Player
    {
        public Player() => Hand = new Hand(); // initialize on load

        public Hand Hand { get; set; }
        public int TotalWinnings { get; set; }

        public void NewHand(Card card1, Card card2)
        {
            Hand = new Hand();
            Hand.Add(card1);
            Hand.Add(card2);
        }

        public void Hit(Card card)
        {
            Hand.Add(card);
        }
    }

}
