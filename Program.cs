using System;

namespace carddeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            Player myPlayer = new Player("Daphnie");
            myDeck.shuffle();
            Console.WriteLine(myDeck);
            myPlayer.Draw(myDeck);
            myPlayer.Draw(myDeck);
            myPlayer.Draw(myDeck);
            myPlayer.Discard(1);
            Console.WriteLine(myPlayer.hand);
        }
    }
}
