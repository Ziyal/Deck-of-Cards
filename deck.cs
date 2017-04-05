using System;
using System.Collections.Generic;

 namespace carddeck {
    public class Deck{
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            createDeck();
        }

        private void createDeck(){
            cards = new List<Card>();
            string[] allSuits = { "Clubs", "Spades", "Hearts", "Diamonds" };
            foreach (string suit in allSuits)
            {
                for (int i = 1; i < 14; i++)
                {
                    cards.Add(new Card(i, suit));

                }
            }
        }

        public Card Deal() {
            Card topCard = cards[0];
            cards.Remove(topCard);
            return topCard;
        }

        public void reset() {
            cards = new List<Card>();
            createDeck();
        }

        Random rand = new Random();
        public void shuffle() {
            for(int i = 0; i < cards.Count-1; i++){
                int randIdx = rand.Next(i, cards.Count);

                Card temp = cards[randIdx];
                cards[randIdx] = cards[i];
                cards[i] = temp;
            }
        }
    }
}


