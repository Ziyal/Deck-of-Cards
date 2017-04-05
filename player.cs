using System;
using System.Collections.Generic;
 
 namespace carddeck {
    public class Player{ 
            public string name;
            public List<Card> hand = new List<Card>();

        public Player (string n) {
            name = n;
        }       
       

        Random rand = new Random();
        public void Draw(Deck cards) {
            hand.Add(cards.Deal());
        }
        
        public Card Discard(int indexNum) {
            Card temp = hand[indexNum];
            hand.RemoveAt(indexNum);
            return temp;
        }


    }
}