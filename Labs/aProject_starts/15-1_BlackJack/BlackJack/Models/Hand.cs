using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace BlackJack.Models
{
    public class Hand 
    {
        private List<Card> cards { get; set; }
        public Hand() => cards = new List<Card>();

        public List<Card> Cards => cards;
        public bool HideHoleCard { get; set; }

        public void Add(Card card) => cards.Add(card);

        // don't store read-only properties in session
        [JsonIgnore]
        public int Total {
            get {
                int total = cards.Sum(c => c.Value);
                int numberOfAces = cards.Where(c => c.IsAce).Count();

                // check aces - count as 1 instead of 11 as needed
                for (int i = 0; i < numberOfAces; i++) {
                    if (total > 21) {
                        total -= 10;
                    }
                }

                return total;
            }
        }
        [JsonIgnore]
        public int Count => cards.Count;
        [JsonIgnore]
        public bool HasCards => cards.Count > 0;
        [JsonIgnore]
        public bool HasAce => cards.FirstOrDefault(c => c.IsAce) != null;
        [JsonIgnore]
        public bool HasBlackJack => cards.Count == 2 && Total == 21;
        [JsonIgnore]
        public bool HasSoftSeventeen => cards.Count == 2 && Total == 17 && HasAce;
        [JsonIgnore]
        public bool IsBusted => Total > 21;
    }
}
