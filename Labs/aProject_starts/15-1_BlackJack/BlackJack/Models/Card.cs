using System;
using Newtonsoft.Json;

namespace BlackJack.Models
{
    public class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }

        // don't store read-only properties in session
        [JsonIgnore]
        public bool IsAce => Rank == "A";
        [JsonIgnore]
        public bool IsFaceCard => Rank == "J" || Rank == "Q" || Rank == "K";
        [JsonIgnore]
        public string Name => $"{Rank}-{Suit}";
        [JsonIgnore]
        public int Value {
            get {
                if (IsAce)
                    return 11;
                else if (IsFaceCard)
                    return 10;
                else
                    return Convert.ToInt32(Rank);
            }
        }

    }
}
