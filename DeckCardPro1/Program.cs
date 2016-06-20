using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCardPro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Display();
            deck.Shaffule();
            deck.Display();
            Console.WriteLine();
            Card card = deck.Deal();

            Console.WriteLine("Card Delt: {0} of {1}",card.Face,card.Suit);
            deck.Display();
          
        }
    }
}
