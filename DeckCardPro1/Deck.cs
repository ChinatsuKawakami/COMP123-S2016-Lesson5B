using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCardPro1
{
    class Deck:List<Card>
    {
      
        public Deck()
        {
           this._create();
        }

        private void  _create()
        {
            int suitIndex;
            string suit;
            for(suitIndex=0;suitIndex <4; suitIndex++)
            {
                 suit ="";
                switch(suitIndex)
                {
                    case 0:
                       suit = "Diamonds";
                        break;
                    case 1:
                        suit = "Clubs";
                        break;
                    case 2:
                        suit = "Hearts";
                        break;
                    case 3:
                        suit = "Spades";
                        break;


                }//close switch
             for(int face = 1; face< 14;face++)
            {
               

                this.Add(new Card(face,suit));


            }//close for 
         }//close loop for

        
     }//_create Method
           
        public void Display()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Current Card                                   +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach(Card card in this)
            {
                Console.WriteLine("{0} of {1}",card.Face,card.Suit);
            }
              Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine();

        }
        public void Shaffule()
        {

            Random ram = new Random();

            int currentCard;
            int numberCard = this.Count;

            for(currentCard = 0;currentCard<numberCard;currentCard++)
            {
             
                int randomIndex = ram.Next(0,numberCard);

                Card temp = this[currentCard];
                this[currentCard] = this[randomIndex];
                this[randomIndex] = temp;

             
               

            }
        }
           
             public Card Deal()
            {
                Card top = this[0];
                if(this.Count >0)
                {
                    this.RemoveAt(0);
                }
               return top;
                
            }
              
        }


        }
    

